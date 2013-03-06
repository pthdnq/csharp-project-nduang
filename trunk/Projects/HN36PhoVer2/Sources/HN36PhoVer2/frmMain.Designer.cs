namespace HN36PhoVer2GUI
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHeThong = new System.Windows.Forms.TabPage();
            this.tabChucnang = new System.Windows.Forms.TabPage();
            this.tabTroGiup = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHeThong);
            this.tabControl1.Controls.Add(this.tabChucnang);
            this.tabControl1.Controls.Add(this.tabTroGiup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHeThong
            // 
            this.tabHeThong.Location = new System.Drawing.Point(4, 22);
            this.tabHeThong.Name = "tabHeThong";
            this.tabHeThong.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeThong.Size = new System.Drawing.Size(653, 236);
            this.tabHeThong.TabIndex = 0;
            this.tabHeThong.Text = "Quản Trị Hệ Thống";
            this.tabHeThong.UseVisualStyleBackColor = true;
            // 
            // tabChucnang
            // 
            this.tabChucnang.Location = new System.Drawing.Point(4, 22);
            this.tabChucnang.Name = "tabChucnang";
            this.tabChucnang.Padding = new System.Windows.Forms.Padding(3);
            this.tabChucnang.Size = new System.Drawing.Size(653, 236);
            this.tabChucnang.TabIndex = 1;
            this.tabChucnang.Text = "Chức Năng";
            this.tabChucnang.UseVisualStyleBackColor = true;
            // 
            // tabTroGiup
            // 
            this.tabTroGiup.Location = new System.Drawing.Point(4, 22);
            this.tabTroGiup.Name = "tabTroGiup";
            this.tabTroGiup.Padding = new System.Windows.Forms.Padding(3);
            this.tabTroGiup.Size = new System.Drawing.Size(653, 236);
            this.tabTroGiup.TabIndex = 2;
            this.tabTroGiup.Text = "Trợ Giúp";
            this.tabTroGiup.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHeThong;
        private System.Windows.Forms.TabPage tabChucnang;
        private System.Windows.Forms.TabPage tabTroGiup;
    }
}