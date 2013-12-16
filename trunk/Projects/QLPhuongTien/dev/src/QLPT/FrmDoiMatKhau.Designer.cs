namespace QLPT
{
    partial class FrmDoiMatKhau
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
            this.btThoat = new System.Windows.Forms.Button();
            this.btDoiMatKhau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtReMKmoi = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtMKmoi = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.lbMatKhauMoi = new System.Windows.Forms.Label();
            this.lbNhapLaiMatKhau = new System.Windows.Forms.Label();
            this.lbTenDangNhap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(296, 208);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(77, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Hủy";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btDoiMatKhau
            // 
            this.btDoiMatKhau.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btDoiMatKhau.Location = new System.Drawing.Point(21, 208);
            this.btDoiMatKhau.Name = "btDoiMatKhau";
            this.btDoiMatKhau.Size = new System.Drawing.Size(109, 23);
            this.btDoiMatKhau.TabIndex = 5;
            this.btDoiMatKhau.Text = "Đổi mật khẩu";
            this.btDoiMatKhau.UseVisualStyleBackColor = true;
            this.btDoiMatKhau.Click += new System.EventHandler(this.btDoiMatKhau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtReMKmoi);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtMKmoi);
            this.groupBox1.Controls.Add(this.lbMatKhau);
            this.groupBox1.Controls.Add(this.lbMatKhauMoi);
            this.groupBox1.Controls.Add(this.lbNhapLaiMatKhau);
            this.groupBox1.Controls.Add(this.lbTenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(145, 22);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(187, 20);
            this.txtTen.TabIndex = 7;
            // 
            // txtReMKmoi
            // 
            this.txtReMKmoi.Location = new System.Drawing.Point(145, 129);
            this.txtReMKmoi.Name = "txtReMKmoi";
            this.txtReMKmoi.Size = new System.Drawing.Size(187, 20);
            this.txtReMKmoi.TabIndex = 6;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(145, 59);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(187, 20);
            this.txtMK.TabIndex = 5;
            // 
            // txtMKmoi
            // 
            this.txtMKmoi.Location = new System.Drawing.Point(145, 96);
            this.txtMKmoi.Name = "txtMKmoi";
            this.txtMKmoi.Size = new System.Drawing.Size(187, 20);
            this.txtMKmoi.TabIndex = 4;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Location = new System.Drawing.Point(6, 66);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(58, 13);
            this.lbMatKhau.TabIndex = 3;
            this.lbMatKhau.Text = "Mật khẩu :";
            // 
            // lbMatKhauMoi
            // 
            this.lbMatKhauMoi.AutoSize = true;
            this.lbMatKhauMoi.Location = new System.Drawing.Point(6, 103);
            this.lbMatKhauMoi.Name = "lbMatKhauMoi";
            this.lbMatKhauMoi.Size = new System.Drawing.Size(80, 13);
            this.lbMatKhauMoi.TabIndex = 2;
            this.lbMatKhauMoi.Text = "Mật khẩu mới  :";
            // 
            // lbNhapLaiMatKhau
            // 
            this.lbNhapLaiMatKhau.AutoSize = true;
            this.lbNhapLaiMatKhau.Location = new System.Drawing.Point(0, 136);
            this.lbNhapLaiMatKhau.Name = "lbNhapLaiMatKhau";
            this.lbNhapLaiMatKhau.Size = new System.Drawing.Size(118, 13);
            this.lbNhapLaiMatKhau.TabIndex = 1;
            this.lbNhapLaiMatKhau.Text = "Nhập lại mật khẩu mới :";
            // 
            // lbTenDangNhap
            // 
            this.lbTenDangNhap.AutoSize = true;
            this.lbTenDangNhap.Location = new System.Drawing.Point(6, 29);
            this.lbTenDangNhap.Name = "lbTenDangNhap";
            this.lbTenDangNhap.Size = new System.Drawing.Size(87, 13);
            this.lbTenDangNhap.TabIndex = 0;
            this.lbTenDangNhap.Text = "Tên đăng nhập :";
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 250);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDoiMatKhau);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btDoiMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtReMKmoi;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtMKmoi;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Label lbMatKhauMoi;
        private System.Windows.Forms.Label lbNhapLaiMatKhau;
        private System.Windows.Forms.Label lbTenDangNhap;
    }
}