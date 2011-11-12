namespace TLauncher.Forms
{
    partial class GenHash
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
            this.Tb_Location = new System.Windows.Forms.TextBox();
            this.Lbl_Notify = new System.Windows.Forms.Label();
            this.Btn_Find = new System.Windows.Forms.Button();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.Tb_Title = new System.Windows.Forms.TextBox();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tb_Location
            // 
            this.Tb_Location.Location = new System.Drawing.Point(12, 25);
            this.Tb_Location.Name = "Tb_Location";
            this.Tb_Location.Size = new System.Drawing.Size(403, 20);
            this.Tb_Location.TabIndex = 0;
            // 
            // Lbl_Notify
            // 
            this.Lbl_Notify.AutoSize = true;
            this.Lbl_Notify.Location = new System.Drawing.Point(9, 9);
            this.Lbl_Notify.Name = "Lbl_Notify";
            this.Lbl_Notify.Size = new System.Drawing.Size(103, 13);
            this.Lbl_Notify.TabIndex = 1;
            this.Lbl_Notify.Text = "Please Select a File.";
            // 
            // Btn_Find
            // 
            this.Btn_Find.Location = new System.Drawing.Point(421, 25);
            this.Btn_Find.Name = "Btn_Find";
            this.Btn_Find.Size = new System.Drawing.Size(40, 20);
            this.Btn_Find.TabIndex = 1;
            this.Btn_Find.Text = ". . .";
            this.Btn_Find.UseVisualStyleBackColor = true;
            this.Btn_Find.Click += new System.EventHandler(this.Btn_Find_Click);
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(389, 76);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(72, 20);
            this.Btn_Generate.TabIndex = 3;
            this.Btn_Generate.Text = "Generate";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // Tb_Title
            // 
            this.Tb_Title.Location = new System.Drawing.Point(12, 76);
            this.Tb_Title.Name = "Tb_Title";
            this.Tb_Title.Size = new System.Drawing.Size(371, 20);
            this.Tb_Title.TabIndex = 2;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.Location = new System.Drawing.Point(9, 60);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(30, 13);
            this.Lbl_Title.TabIndex = 1;
            this.Lbl_Title.Text = "Title:";
            // 
            // GenHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 108);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.Btn_Find);
            this.Controls.Add(this.Lbl_Title);
            this.Controls.Add(this.Lbl_Notify);
            this.Controls.Add(this.Tb_Title);
            this.Controls.Add(this.Tb_Location);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenHash";
            this.Text = "Generate Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_Location;
        private System.Windows.Forms.Label Lbl_Notify;
        private System.Windows.Forms.Button Btn_Find;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.TextBox Tb_Title;
        private System.Windows.Forms.Label Lbl_Title;
    }
}