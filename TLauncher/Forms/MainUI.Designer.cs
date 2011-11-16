namespace TLauncher.Forms
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.lv_Items = new System.Windows.Forms.ListView();
            this.Clm_Identifier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Assembly = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cml_Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Launch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_GliFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessChecker = new System.Windows.Forms.Timer(this.components);
            this.tt_listB = new System.Windows.Forms.ToolTip(this.components);
            this.ts_Header = new System.Windows.Forms.ToolStrip();
            this.tsLbl_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.generateFileHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv_Items
            // 
            this.lv_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clm_Identifier,
            this.Clm_Assembly,
            this.Cml_Author,
            this.Clm_Desc,
            this.Clm_Launch,
            this.Clm_Hash,
            this.Clm_GliFile});
            this.lv_Items.FullRowSelect = true;
            this.lv_Items.GridLines = true;
            this.lv_Items.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_Items.HoverSelection = true;
            this.lv_Items.Location = new System.Drawing.Point(12, 28);
            this.lv_Items.Name = "lv_Items";
            this.lv_Items.Size = new System.Drawing.Size(576, 312);
            this.lv_Items.TabIndex = 0;
            this.tt_listB.SetToolTip(this.lv_Items, "Double Click to run!");
            this.lv_Items.UseCompatibleStateImageBehavior = false;
            this.lv_Items.View = System.Windows.Forms.View.Details;
            this.lv_Items.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.lv_Items.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lv_Items_KeyUp);
            // 
            // Clm_Identifier
            // 
            this.Clm_Identifier.Text = "Identifier";
            this.Clm_Identifier.Width = 76;
            // 
            // Clm_Assembly
            // 
            this.Clm_Assembly.Text = "Assembly";
            this.Clm_Assembly.Width = 95;
            // 
            // Cml_Author
            // 
            this.Cml_Author.Text = "Author";
            this.Cml_Author.Width = 85;
            // 
            // Clm_Desc
            // 
            this.Clm_Desc.Text = "Description";
            this.Clm_Desc.Width = 250;
            // 
            // Clm_Launch
            // 
            this.Clm_Launch.Text = "";
            // 
            // Clm_Hash
            // 
            this.Clm_Hash.Text = "Hash";
            this.Clm_Hash.Width = 0;
            // 
            // Clm_GliFile
            // 
            this.Clm_GliFile.Text = "";
            this.Clm_GliFile.Width = 0;
            // 
            // ProcessChecker
            // 
            this.ProcessChecker.Interval = 2000;
            this.ProcessChecker.Tick += new System.EventHandler(this.ProcessChecker_Tick);
            // 
            // ts_Header
            // 
            this.ts_Header.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLbl_File});
            this.ts_Header.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ts_Header.Location = new System.Drawing.Point(0, 0);
            this.ts_Header.Name = "ts_Header";
            this.ts_Header.Size = new System.Drawing.Size(600, 25);
            this.ts_Header.TabIndex = 1;
            this.ts_Header.Text = "toolStrip1";
            // 
            // tsLbl_File
            // 
            this.tsLbl_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsLbl_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateFileHashToolStripMenuItem,
            this.fileListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.tsLbl_File.Image = ((System.Drawing.Image)(resources.GetObject("tsLbl_File.Image")));
            this.tsLbl_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLbl_File.Name = "tsLbl_File";
            this.tsLbl_File.Size = new System.Drawing.Size(38, 22);
            this.tsLbl_File.Text = "File";
            // 
            // generateFileHashToolStripMenuItem
            // 
            this.generateFileHashToolStripMenuItem.Name = "generateFileHashToolStripMenuItem";
            this.generateFileHashToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.generateFileHashToolStripMenuItem.Text = "Generate File Hash";
            this.generateFileHashToolStripMenuItem.Click += new System.EventHandler(this.generateFileHashToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fileListToolStripMenuItem
            // 
            this.fileListToolStripMenuItem.Name = "fileListToolStripMenuItem";
            this.fileListToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fileListToolStripMenuItem.Text = "File List";
            this.fileListToolStripMenuItem.Click += new System.EventHandler(this.fileListToolStripMenuItem_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 352);
            this.Controls.Add(this.ts_Header);
            this.Controls.Add(this.lv_Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainUI";
            this.Text = "Terraria Launcher";
            this.ts_Header.ResumeLayout(false);
            this.ts_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lv_Items;
        private System.Windows.Forms.ColumnHeader Clm_Assembly;
        private System.Windows.Forms.ColumnHeader Clm_Desc;
        private System.Windows.Forms.ColumnHeader Cml_Author;
        private System.Windows.Forms.ColumnHeader Clm_Launch;
        private System.Windows.Forms.ColumnHeader Clm_Identifier;
        private System.Windows.Forms.ColumnHeader Clm_Hash;
        public System.Windows.Forms.Timer ProcessChecker;
        private System.Windows.Forms.ToolTip tt_listB;
        private System.Windows.Forms.ToolStrip ts_Header;
        private System.Windows.Forms.ToolStripDropDownButton tsLbl_File;
        private System.Windows.Forms.ToolStripMenuItem generateFileHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Clm_GliFile;
        private System.Windows.Forms.ToolStripMenuItem fileListToolStripMenuItem;

    }
}