using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TLauncher
{
    public static class Notify
    {
        public static void Message(string Header, string Message)
        {
            if (Program.CLI)
                Console.WriteLine("[{0}] {1}", Header, Message);
            else
                MessageBox.Show(Message, Header);
        }
    }
}
