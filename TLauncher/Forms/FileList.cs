using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TLauncher.Forms
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }

        private void FileList_Load(object sender, EventArgs e)
        {
            Lv_Files.Items.Clear();

            string Path = Directory.GetParent(Process.GetCurrentProcess().MainModule.FileName).FullName;
            foreach (string file in Directory.GetFiles(Path))
            {
                Lv_Files.Items.Add(
                    GetListViewItem(file)
                );
            }
        }

        public ListViewItem GetListViewItem(string File)
        {
            string file = (new FileInfo(File)).Name;
            string name =  file.Substring(0, file.LastIndexOf("."));
            string ext = file.Remove(0, name.Length + 1).ToUpper();
            ListViewItem item = new ListViewItem()
            {
                Text = name
            };
            foreach (string sItem in new string[] { ext, File })
            {
                item.SubItems.Add(new ListViewItem.ListViewSubItem()
                {
                    Text = sItem
                });
            }
            return item;
        }

        private void Lv_Files_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            ListViewItem item = lv.SelectedItems[0];
            string path = item.SubItems[2].Text;
            Process.Start(path);
        }
    }
}
