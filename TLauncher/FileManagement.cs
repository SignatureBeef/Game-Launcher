using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace TLauncher
{
    public struct HashedFiles 
    {
        public string AssemblyPath  { get; set; }
        public string Hash          { get; set; }
        public string Title         { get; set; }
        public string Description   { get; set; }
        public string Identifier    { get; set; }
        public string Author        { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator !=(HashedFiles f1, HashedFiles f2)
        {
            return
                f1.AssemblyPath != f2.AssemblyPath &&
                f1.Hash != f2.Hash &&
                f1.Title != f2.Title &&
                f1.Description != f2.Description &&
                f1.Identifier != f2.Identifier &&
                f1.Author != f2.Author;
        }

        public static bool operator ==(HashedFiles f1, HashedFiles f2)
        {
            return
                f1.AssemblyPath == f2.AssemblyPath &&
                f1.Hash == f2.Hash &&
                f1.Title == f2.Title &&
                f1.Description == f2.Description &&
                f1.Identifier == f2.Identifier &&
                f1.Author == f2.Author;
        }
    }

    public static class FileManagement
    {
        public static List<HashedFiles> Hashes { get; set; }

        public static bool IsHashedFileValid(HashedFiles hash)
        {
            return hash.Hash == HashBytes(ASCIIEncoding.ASCII.GetBytes(hash.AssemblyPath));
        }

        public static List<HashedFiles> GetHashes(string Folder)
        {
            string[] Files = Directory.GetFiles(Folder);
            List<HashedFiles> hashes = new List<HashedFiles>();

            Assembly assembly = null;

            foreach (string file in Files.Where(x => x.ToLower().EndsWith(".gli")))
            {
                try
                {
                    string[] lines = File.ReadAllLines(file);

                    if (lines.Length >= 2)
                    {
                        var _Identifier = lines[0].Trim();
                        var _Hash = lines[1].Trim();
                        var _Location = "";

                        if(lines.Length > 2)
                            _Location = lines[2].Trim();

                        if (_Hash.Length != 64)
                        {
                            Console.WriteLine("{0} has an incorrect Hash Length. != 64.", file);
                            continue;
                        }
                        
                        string FoundFile;

                        if (File.Exists(_Location) && _Hash == HashBytes(File.ReadAllBytes(_Location)))
                            FoundFile = _Location;
                        else
                        {
                            if (!TryFindFile(_Hash, Folder, out FoundFile))
                            {
                                Console.WriteLine("{0} has no matching Hashed file.", file);
                                continue;
                            }
                        }

                        assembly = AssemblyManagement.GetAssembly(FoundFile);

                        hashes.Add(new HashedFiles()
                        {
                            AssemblyPath = FoundFile,
                            Hash = _Hash,
                            Identifier = _Identifier,
                            Title = AssemblyManagement.GetTitle(assembly),
                            Description = AssemblyManagement.GetDescription(assembly),
                            Author = AssemblyManagement.GetAuthor(assembly)
                        });

                        assembly = null;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("It seems there was an application running, I cannot Checksum it.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            return hashes;
        }
        
        public static string HashBytes(byte[] Data)
        {
            return BitConverter.ToString((
                new SHA256Managed()).ComputeHash(Data)).Replace("-", "").ToUpper();
        }

        public static bool TryFindFile(string Hash, string CurrentFolder, out string FoundFile)
        {
            FoundFile = default(String);

            foreach (string file in Directory.GetFiles(CurrentFolder)
                .Where(x => HashBytes(File.ReadAllBytes(x)) == Hash))
            {
                FoundFile = file;
                return true;
            }

            return false;
        }

        public static bool TryGetHashedFile(string Hash, out HashedFiles HashedFile)
        {
            HashedFile = default(HashedFiles);

            foreach (HashedFiles fileInfo in Hashes.Where(x => x.Hash == Hash))
            {
                HashedFile = fileInfo;
                return true;
            }

            return false;
        }

        public static HashedFiles GetFileByHash(string Hash)
        {
            HashedFiles info;
            if (!FileManagement.TryGetHashedFile(Hash, out info))
            {
                Notify.Message("Launcher Error", "Why now, It seems there was an issue finding that Hash.");
                return default(HashedFiles);
            }

            if (!File.Exists(info.AssemblyPath))
            {
                Notify.Message("Launcher Error", "Why now, It seems the Assembly could not be found!");
                return default(HashedFiles);
            }

            return info;
        }

        public static string IncrementFile(string filename)
        {
            string fileName = filename;

            int i = 0;
            while (File.Exists(fileName))
            {
                fileName = i++ + filename;
                Thread.Sleep(100);
            }

            return fileName;
        }
    }
}
