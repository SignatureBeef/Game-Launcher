using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using TLauncher.Forms;
using System.Runtime.InteropServices;

namespace TLauncher
{
    static class Program
    {
        public static bool CLI, DEBUG;
        static MainUI MainUI { get; set; }

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        
        [STAThreadAttribute]
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            ParseInput(args);

            Console.WriteLine("Reading data...");
            FileManagement.Hashes = FileManagement.GetHashes(Path.GetDirectoryName(Application.ExecutablePath));

            if (CLI)
            {
                int Max = FileManagement.Hashes.Count;
                Console.WriteLine("{0} GLI's Found.\n", Max);

                if (Max == 0)
                {
                    Console.WriteLine("Press any key to exit...");
                    Console.ReadKey(true);
                    return;
                }
                
            LOOP:
                Console.WriteLine("Please enter in one of the following:");


                if (FileManagement.Hashes.Count > 0)
                {
                    int i = 0;
                    foreach (HashedFiles hFile in FileManagement.Hashes)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t[{0}] ", i++);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("~ {0} [{1}]", hFile.Identifier, hFile.Title);
                    }
                }

                READ:
                    string Input = ReadLine();

                    int hash;
                    if (Int32.TryParse(Input, out hash) && hash < Max && hash > -1)
                    {
                        HashedFiles file = FileManagement.Hashes[hash];
                        Console.WriteLine("Starting {0}", file.Title);
                        Process.Start(file.AssemblyPath);
                        Console.Clear();
                        goto LOOP;
                    }
                    else if(Input.Trim().ToLower() == "exit")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input, Try again: ");
                        goto READ;
                    }
            }
            else
            {
                ShowWindow(FindWindow(null, Console.Title), 0); //Hide Console
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainUI = new MainUI();

                foreach (HashedFiles file in FileManagement.Hashes)
                    AddItem(file.Identifier, file.Title, file.Author, file.Description, file.Hash);

                MainUI.ProcessChecker.Enabled = true;
                MainUI.ProcessChecker.Start();
                
                Application.Run(MainUI);
            }
        }

        public static void AddItem(string Identifier, string Title, string Author, string Description, string Hash)
        {
            ListViewItem item = new ListViewItem()
            {
                Text = Identifier
            };

            foreach (string nItem in new string[] { Title, Author, Description, "", Hash })
            {
                item.SubItems.Add(nItem);
            }
            MainUI.lv_Items.Items.Add(item);
        }

        static void ParseInput(string[] args)
        {
            if (args.Contains("-console"))
                CLI = true;

            if (args.Contains("-debug"))
                DEBUG = true;
        }

        static string ReadLine(bool pass = false)
        {
            string line = "";

            Console.ForegroundColor = ConsoleColor.Red;

            while (true)
            {
                bool write = true;
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                    break;
                else if (key.Key == ConsoleKey.Escape || key.Key == ConsoleKey.Tab)
                {
                    write = false;
                    Console.Write("\b \b");
                }
                else if (key.Key == ConsoleKey.Backspace)
                    write = false;

                if (write)
                    line += key.KeyChar.ToString();
                else if (key.Key != ConsoleKey.Escape && key.Key != ConsoleKey.Tab)
                {
                    if (line.Length > 0)
                    {
                        line = line.Remove(line.Length - 1, 1);
                        Console.Write(" \b");
                    }
                    else
                        Console.Write(" ");
                }

                if (pass && write)
                    Console.Write("\b*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return line;
        }
    }
}
