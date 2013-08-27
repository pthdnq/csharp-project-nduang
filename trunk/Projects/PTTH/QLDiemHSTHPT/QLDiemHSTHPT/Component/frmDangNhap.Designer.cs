namespace QLDiemHSTHPT.Component
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.labelDANGNHAP = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.labelTenDN = new DevComponents.DotNetBar.LabelX();
            this.labelMK = new DevComponents.DotNetBar.LabelX();
            this.txtDangNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtmatkhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnhuybo = new DevComponents.DotNetBar.ButtonX();
            this.gpanelDangNhap = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnDangNhap = new DevComponents.DotNetBar.ButtonX();
            this.lblMatKhauLoi = new System.Windows.Forms.Label();
            this.lblDangNhapLoi = new System.Windows.Forms.Label();
            this.gpanelDangNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDANGNHAP
            // 
            this.labelDANGNHAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDANGNHAP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDANGNHAP.Location = new System.Drawing.Point(0, 0);
            this.labelDANGNHAP.Name = "labelDANGNHAP";
            this.labelDANGNHAP.Size = new System.Drawing.Size(394, 38);
            this.labelDANGNHAP.TabIndex = 3;
            this.labelDANGNHAP.Text = "QUẢN LÝ ĐIỂM HỌC SINH THPT";
            this.labelDANGNHAP.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.BackColor = System.Drawing.Color.Transparent;
            this.reflectionImage1.Image = global::QLDiemHSTHPT.Properties.Resources.DN;
            this.reflectionImage1.Location = new System.Drawing.Point(9, 12);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(67, 126);
            this.reflectionImage1.TabIndex = 0;
            // 
            // labelTenDN
            // 
            this.labelTenDN.BackColor = System.Drawing.Color.Transparent;
            this.labelTenDN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenDN.Location = new System.Drawing.Point(82, 26);
            this.labelTenDN.Name = "labelTenDN";
            this.labelTenDN.Size = new System.Drawing.Size(102, 23);
            this.labelTenDN.TabIndex = 1;
            this.labelTenDN.Text = "Tên Đăng Nhập:";
            this.labelTenDN.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelMK
            // 
            this.labelMK.BackColor = System.Drawing.Color.Transparent;
            this.labelMK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMK.Location = new System.Drawing.Point(82, 70);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(102, 23);
            this.labelMK.TabIndex = 2;
            this.labelMK.Text = "Mật Khẩu:";
            this.labelMK.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDangNhap
            // 
            // 
            // 
            // 
            this.txtDangNhap.Border.Class = "TextBoxBorder";
            this.txtDangNhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(190, 26);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(168, 22);
            this.txtDangNhap.TabIndex = 3;
            this.txtDangNhap.WatermarkText = "Tên đăng nhập";
            // 
            // txtmatkhau
            // 
            // 
            // 
            // 
            this.txtmatkhau.Border.Class = "TextBoxBorder";
            this.txtmatkhau.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(190, 70);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(168, 22);
            this.txtmatkhau.TabIndex = 5;
            this.txtmatkhau.WatermarkText = "Mật khẩu";
            this.txtmatkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmatkhau_KeyDown);
            // 
            // btnhuybo
            // 
            this.btnhuybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnhuybo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnhuybo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo.Location = new System.Drawing.Point(283, 115);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 23);
            this.btnhuybo.TabIndex = 8;
            this.btnhuybo.Text = "Hủy Bỏ";
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // gpanelDangNhap
            // 
            this.gpanelDangNhap.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpanelDangNhap.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpanelDangNhap.Controls.Add(this.btnDangNhap);
            this.gpanelDangNhap.Controls.Add(this.lblMatKhauLoi);
            this.gpanelDangNhap.Controls.Add(this.lblDangNhapLoi);
            this.gpanelDangNhap.Controls.Add(this.btnhuybo);
            this.gpanelDangNhap.Controls.Add(this.txtmatkhau);
            this.gpanelDangNhap.Controls.Add(this.txtDangNhap);
            this.gpanelDangNhap.Controls.Add(this.labelMK);
            this.gpanelDangNhap.Controls.Add(this.labelTenDN);
            this.gpanelDangNhap.Controls.Add(this.reflectionImage1);
            this.gpanelDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpanelDangNhap.Location = new System.Drawing.Point(0, 46);
            this.gpanelDangNhap.Name = "gpanelDangNhap";
            this.gpanelDangNhap.Size = new System.Drawing.Size(394, 173);
            // 
            // 
            // 
            this.gpanelDangNhap.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpanelDangNhap.Style.BackColorGradientAngle = 90;
            this.gpanelDangNhap.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpanelDangNhap.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpanelDangNhap.Style.BorderBottomWidth = 1;
            this.gpanelDangNhap.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpanelDangNhap.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpanelDangNhap.Style.BorderLeftWidth = 1;
            this.gpanelDangNhap.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpanelDangNhap.Style.BorderRightWidth = 1;
            this.gpanelDangNhap.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpanelDangNhap.Style.BorderTopWidth = 1;
            this.gpanelDangNhap.Style.CornerDiameter = 4;
            this.gpanelDangNhap.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpanelDangNhap.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpanelDangNhap.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpanelDangNhap.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.gpanelDangNhap.TabIndex = 1;
            this.gpanelDangNhap.Text = "Thông Tin Đăng Nhập";
            this.gpanelDangNhap.TitleImagePosition = DevComponents.DotNetBar.eTitleImagePosition.Center;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDangNhap.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(190, 115);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // lblMatKhauLoi
            // 
            this.lblMatKhauLoi.AutoSize = true;
            this.lblMatKhauLoi.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhauLoi.ForeColor = System.Drawing.Color.Red;
            this.lblMatKhauLoi.Location = new System.Drawing.Point(189, 94);
            this.lblMatKhauLoi.Name = "lblMatKhauLoi";
            this.lblMatKhauLoi.Size = new System.Drawing.Size(0, 16);
            this.lblMatKhauLoi.TabIndex = 6;
            // 
            // lblDangNhapLoi
            // 
            this.lblDangNhapLoi.AutoSize = true;
            this.lblDangNhapLoi.BackColor = System.Drawing.Color.Transparent;
            this.lblDangNhapLoi.ForeColor = System.Drawing.Color.Red;
            this.lblDangNhapLoi.Location = new System.Drawing.Point(187, 51);
            this.lblDangNhapLoi.Name = "lblDangNhapLoi";
            this.lblDangNhapLoi.Size = new System.Drawing.Size(0, 16);
            this.lblDangNhapLoi.TabIndex = 4;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 220);
            this.Controls.Add(this.labelDANGNHAP);
            this.Controls.Add(this.gpanelDangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.gpanelDangNhap.ResumeLayout(false);
            this.gpanelDangNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelDANGNHAP;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.LabelX labelTenDN;
        private DevComponents.DotNetBar.LabelX labelMK;
        public DevComponents.DotNetBar.Controls.TextBoxX txtDangNhap;
        public DevComponents.DotNetBar.Controls.TextBoxX txtmatkhau;
        private DevComponents.DotNetBar.ButtonX btnhuybo;
        private DevComponents.DotNetBar.Controls.GroupPanel gpanelDangNhap;
        //private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblMatKhauLoi;
        public System.Windows.Forms.Label lblDangNhapLoi;
        private DevComponents.DotNetBar.ButtonX btnDangNhap;

    }
}