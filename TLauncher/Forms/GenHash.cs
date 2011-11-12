using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace TLauncher.Forms
{
    public partial class GenHash : Form
    {
        OpenFileDialog FB_Dialog { get; set; }

        public GenHash()
        {
            InitializeComponent();
        }
        
        private void Btn_Find_Click(object sender, EventArgs e)
        {
            if (FB_Dialog == null)
            {
                FB_Dialog = new OpenFileDialog();
                FB_Dialog.Title = "Find Executable";
                FB_Dialog.Multiselect = false;
                FB_Dialog.Filter = "*.exe | *.exe";
            }

            if (FB_Dialog.ShowDialog() == DialogResult.OK)
            {
                string File = FB_Dialog.FileName;
                if (IsValidAssembly(File))
                    Tb_Location.Text = File;             
            }
        }

        private void Btn_Generate_Click(object sender, EventArgs args)
        {
            try
            {
                string file = Tb_Location.Text;
                if (File.Exists(file) && IsValidAssembly(file))
                {
                    string Title = Tb_Title.Text;
                    if (String.IsNullOrWhiteSpace(Title) || String.IsNullOrEmpty(Title))
                    {
                        Title = "Game1";
                        if (MessageBox.Show("It seems you have incorrectly specified a title so a default was created, \n\n" +
                            "Is this Ok?", "Title Missing", MessageBoxButtons.YesNo) == DialogResult.No)
                            return;

                        Tb_Title.Text = Title;
                    }

                    Assembly assembly = AssemblyManagement.GetAssembly(file);
                    string _Hash = FileManagement.HashBytes(File.ReadAllBytes(file));

                    HashedFiles hashFile = new HashedFiles()
                    {
                        AssemblyPath = file,
                        Hash = _Hash,
                        Identifier = Title,
                        Title = AssemblyManagement.GetTitle(assembly),
                        Description = AssemblyManagement.GetDescription(assembly),
                        Author = AssemblyManagement.GetAuthor(assembly)
                    };
                    FileManagement.Hashes.Add(hashFile);
                    assembly = null;

                    string fileName = FileManagement.IncrementFile(Title + ".gli");
                    string[] Content =  { 
                                        Title,
                                        _Hash,
                                        file
                                    };
                    File.WriteAllLines(fileName, Content);

                    Program.AddItem(Title, hashFile.Title, hashFile.Author, hashFile.Description, _Hash);
                }
                else
                    Notify.Message("File Error", "Please select a existing file!");

                Close();
            }
            catch (Exception e)
            {
                Notify.Message("Generate Issue",
                    String.Format("It seems an error occured:\n\n{0}", e.Message)
                );
            }
        }

        static bool IsValidAssembly(string file)
        {
            if (AssemblyManagement.IsValidAssembly(file))
                return true;
            else
                Notify.Message("Generate Issue", "Please select a Valid Assembly.\n\n(Also make sute it is not in use.)");

            return false;
        }
    }
}
