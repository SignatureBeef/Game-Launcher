namespace TLauncher.Forms
{
    partial class FileList
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
            this.Lv_Files = new System.Windows.Forms.ListView();
            this.Clm_File = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clm_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Lv_Files
            // 
            this.Lv_Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Clm_File,
            this.Clm_Extension,
            this.Clm_Path});
            this.Lv_Files.FullRowSelect = true;
            this.Lv_Files.GridLines = true;
            this.Lv_Files.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Lv_Files.HoverSelection = true;
            this.Lv_Files.Location = new System.Drawing.Point(12, 12);
            this.Lv_Files.Name = "Lv_Files";
            this.Lv_Files.Size = new System.Drawing.Size(401, 256);
            this.Lv_Files.TabIndex = 0;
            this.Lv_Files.UseCompatibleStateImageBehavior = false;
            this.Lv_Files.View = System.Windows.Forms.View.Details;
            this.Lv_Files.DoubleClick += new System.EventHandler(this.Lv_Files_DoubleClick);
            // 
            // Clm_File
            // 
            this.Clm_File.Text = "File Name";
            this.Clm_File.Width = 334;
            // 
            // Clm_Extension
            // 
            this.Clm_Extension.Text = "Ext.";
            // 
            // Clm_Path
            // 
            this.Clm_Path.Text = "";
            this.Clm_Path.Width = 0;
            // 
            // FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 280);
            this.Controls.Add(this.Lv_Files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileList";
            this.ShowInTaskbar = false;
            this.Text = "FileList";
            this.Load += new System.EventHandler(this.FileList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Lv_Files;
        private System.Windows.Forms.ColumnHeader Clm_File;
        private System.Windows.Forms.ColumnHeader Clm_Extension;
        private System.Windows.Forms.ColumnHeader Clm_Path;
    }
}