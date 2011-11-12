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
    public partial class MainUI : Form
    {
        Dictionary<Int32, Int32> ProcessIDs = new Dictionary<Int32, Int32>();
        GenHash GenHashForm { get; set; }

        public MainUI()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView lView = sender as ListView;
            lView.UseWaitCursor = true;
            ListViewItem item = lView.SelectedItems[0];
            string Hash = item.SubItems[5].Text;
            RunHash(Hash);
            lView.UseWaitCursor = false;
        }

        void RunHash(string Hash)
        {
            HashedFiles info = FileManagement.GetFileByHash(Hash);

            if (!Program.CLI && info != default(HashedFiles)) {
                Process proc = Process.Start(info.AssemblyPath);
                ProcessIDs.Add(proc.Id, lv_Items.SelectedItems[0].Index);
                proc.EnableRaisingEvents = true;
                proc.Exited += new EventHandler(proc_Exited);
            }
        }

        void proc_Exited(object sender, EventArgs e)
        {
            Process proc = sender as Process;
            if (ProcessIDs.ContainsKey(proc.Id))
                ProcessIDs.Remove(proc.Id);
        }

        private void ProcessChecker_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < lv_Items.Items.Count; i++)
                lv_Items.Items[i].SubItems[4].Text = (ProcessIDs.ContainsValue(i)) ? "Running" : "Ready";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateFileHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GenHashForm == null)
                GenHashForm = new GenHash();

            GenHashForm.ShowDialog();
        }
    }
}
