using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace TLauncher
{
    public static class AssemblyManagement
    {
        public static string GetTitle(Assembly assembly)
        {
            return ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly,
                    typeof(AssemblyTitleAttribute))).Title;
        }

        public static string GetDescription(Assembly assembly)
        {
            return ((AssemblyDescriptionAttribute)Attribute.GetCustomAttribute(assembly,
                    typeof(AssemblyDescriptionAttribute))).Description;
        }

        public static string GetAuthor(Assembly assembly)
        {
            return ((AssemblyCompanyAttribute)Attribute.GetCustomAttribute(assembly,
                    typeof(AssemblyCompanyAttribute))).Company;
        }

        public static Assembly GetAssembly(string file)
        {
            Assembly assembly;
            using (FileStream fs = File.Open(file, FileMode.Open))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] buffer = new byte[1024];

                    int read = 0;

                    while ((read = fs.Read(buffer, 0, 1024)) > 0)
                        ms.Write(buffer, 0, read);

                    assembly = Assembly.Load(ms.ToArray());
                }
            }
            return assembly;
        }

        public static bool IsValidAssembly(string file)
        {
            try
            {
                if (File.Exists(file))
                {
                    Assembly asm = GetAssembly(file);
                    asm = null;
                    return true;
                }
            }
            catch { }

            return false;
        }
    }
}
