namespace QLPT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênMẫuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchCácPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐơnVịThiCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnVịThiCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýVậnHànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoTri = new System.Windows.Forms.ToolStripMenuItem();
            this.tìnhTrạngBảoTrìToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmPhươngTiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnQuanLy,
            this.mnBaoTri,
            this.mnTimKiem,
            this.mnTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangNhap,
            this.mnDangXuat,
            this.mnDangKy,
            this.mnDoiMatKhau,
            this.mnThoat});
            this.mnHeThong.Image = global::QLPT.Properties.Resources.TRITANIUM_SQUARED_HD_UTILITIES;
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(85, 20);
            this.mnHeThong.Text = "Hệ thống";
            // 
            // mnDangNhap
            // 
            this.mnDangNhap.Image = global::QLPT.Properties.Resources.lock_and_key_icon_thumb355812;
            this.mnDangNhap.Name = "mnDangNhap";
            this.mnDangNhap.Size = new System.Drawing.Size(145, 22);
            this.mnDangNhap.Text = "Đăng nhập";
            this.mnDangNhap.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // mnDangXuat
            // 
            this.mnDangXuat.Image = global::QLPT.Properties.Resources.thoat;
            this.mnDangXuat.Name = "mnDangXuat";
            this.mnDangXuat.Size = new System.Drawing.Size(145, 22);
            this.mnDangXuat.Text = "Đăng Xuất";
            this.mnDangXuat.Click += new System.EventHandler(this.mnDangXuat_Click);
            // 
            // mnDangKy
            // 
            this.mnDangKy.Image = global::QLPT.Properties.Resources.user_add;
            this.mnDangKy.Name = "mnDangKy";
            this.mnDangKy.Size = new System.Drawing.Size(145, 22);
            this.mnDangKy.Text = "Đăng ký";
            this.mnDangKy.Click += new System.EventHandler(this.đăngToolStripMenuItem_Click);
            // 
            // mnDoiMatKhau
            // 
            this.mnDoiMatKhau.Image = global::QLPT.Properties.Resources.Key;
            this.mnDoiMatKhau.Name = "mnDoiMatKhau";
            this.mnDoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.mnDoiMatKhau.Text = "Đổi mật khẩu";
            this.mnDoiMatKhau.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Image = global::QLPT.Properties.Resources._500px_Crystal_Clear_action_exit_svg;
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(145, 22);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // mnQuanLy
            // 
            this.mnQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhươngTiệnToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýĐơnVịThiCôngToolStripMenuItem,
            this.đơnVịThiCôngToolStripMenuItem,
            this.quảnLýVậnHànhToolStripMenuItem});
            this.mnQuanLy.Image = global::QLPT.Properties.Resources.Book_31;
            this.mnQuanLy.Name = "mnQuanLy";
            this.mnQuanLy.Size = new System.Drawing.Size(133, 20);
            this.mnQuanLy.Text = "Quản lý danh mục";
            // 
            // quảnLýPhươngTiệnToolStripMenuItem
            // 
            this.quảnLýPhươngTiệnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyênMẫuToolStripMenuItem,
            this.danhSáchCácPhươngTiệnToolStripMenuItem,
            this.loạiPhươngTiệnToolStripMenuItem});
            this.quảnLýPhươngTiệnToolStripMenuItem.Image = global::QLPT.Properties.Resources.Taxi;
            this.quảnLýPhươngTiệnToolStripMenuItem.Name = "quảnLýPhươngTiệnToolStripMenuItem";
            this.quảnLýPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýPhươngTiệnToolStripMenuItem.Text = "Quản lý phương tiện";
            // 
            // nguyênMẫuToolStripMenuItem
            // 
            this.nguyênMẫuToolStripMenuItem.Image = global::QLPT.Properties.Resources.List;
            this.nguyênMẫuToolStripMenuItem.Name = "nguyênMẫuToolStripMenuItem";
            this.nguyênMẫuToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nguyênMẫuToolStripMenuItem.Text = "Quản lý phương tiện";
            this.nguyênMẫuToolStripMenuItem.Click += new System.EventHandler(this.nguyênMẫuToolStripMenuItem_Click);
            // 
            // danhSáchCácPhươngTiệnToolStripMenuItem
            // 
            this.danhSáchCácPhươngTiệnToolStripMenuItem.Image = global::QLPT.Properties.Resources.Taxi1;
            this.danhSáchCácPhươngTiệnToolStripMenuItem.Name = "danhSáchCácPhươngTiệnToolStripMenuItem";
            this.danhSáchCácPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.danhSáchCácPhươngTiệnToolStripMenuItem.Text = "Nguyên mẫu";
            this.danhSáchCácPhươngTiệnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchCácPhươngTiệnToolStripMenuItem_Click);
            // 
            // loạiPhươngTiệnToolStripMenuItem
            // 
            this.loạiPhươngTiệnToolStripMenuItem.Image = global::QLPT.Properties.Resources.Delivery;
            this.loạiPhươngTiệnToolStripMenuItem.Name = "loạiPhươngTiệnToolStripMenuItem";
            this.loạiPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.loạiPhươngTiệnToolStripMenuItem.Text = "Loại phương tiện ";
            this.loạiPhươngTiệnToolStripMenuItem.Click += new System.EventHandler(this.loạiPhươngTiệnToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Image = global::QLPT.Properties.Resources.user_icon;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýĐơnVịThiCôngToolStripMenuItem
            // 
            this.quảnLýĐơnVịThiCôngToolStripMenuItem.Image = global::QLPT.Properties.Resources.Home;
            this.quảnLýĐơnVịThiCôngToolStripMenuItem.Name = "quảnLýĐơnVịThiCôngToolStripMenuItem";
            this.quảnLýĐơnVịThiCôngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýĐơnVịThiCôngToolStripMenuItem.Text = "Đơn vị quản lý";
            this.quảnLýĐơnVịThiCôngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýĐơnVịThiCôngToolStripMenuItem_Click);
            // 
            // đơnVịThiCôngToolStripMenuItem
            // 
            this.đơnVịThiCôngToolStripMenuItem.Image = global::QLPT.Properties.Resources.Company;
            this.đơnVịThiCôngToolStripMenuItem.Name = "đơnVịThiCôngToolStripMenuItem";
            this.đơnVịThiCôngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.đơnVịThiCôngToolStripMenuItem.Text = "Đơn vị thi công";
            this.đơnVịThiCôngToolStripMenuItem.Click += new System.EventHandler(this.đơnVịThiCôngToolStripMenuItem_Click);
            // 
            // quảnLýVậnHànhToolStripMenuItem
            // 
            this.quảnLýVậnHànhToolStripMenuItem.Image = global::QLPT.Properties.Resources.logo;
            this.quảnLýVậnHànhToolStripMenuItem.Name = "quảnLýVậnHànhToolStripMenuItem";
            this.quảnLýVậnHànhToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýVậnHànhToolStripMenuItem.Text = "Quản lý vận hành";
            this.quảnLýVậnHànhToolStripMenuItem.Click += new System.EventHandler(this.quảnLýVậnHànhToolStripMenuItem_Click);
            // 
            // mnBaoTri
            // 
            this.mnBaoTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìnhTrạngBảoTrìToolStripMenuItem,
            this.danhSáchNhânViênToolStripMenuItem,
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem});
            this.mnBaoTri.Image = global::QLPT.Properties.Resources.book_notebook;
            this.mnBaoTri.Name = "mnBaoTri";
            this.mnBaoTri.Size = new System.Drawing.Size(104, 20);
            this.mnBaoTri.Text = "Xuất báo cáo";
            // 
            // tìnhTrạngBảoTrìToolStripMenuItem
            // 
            this.tìnhTrạngBảoTrìToolStripMenuItem.Image = global::QLPT.Properties.Resources.Report;
            this.tìnhTrạngBảoTrìToolStripMenuItem.Name = "tìnhTrạngBảoTrìToolStripMenuItem";
            this.tìnhTrạngBảoTrìToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.tìnhTrạngBảoTrìToolStripMenuItem.Text = "Danh sách các phương tiện";
            this.tìnhTrạngBảoTrìToolStripMenuItem.Click += new System.EventHandler(this.tìnhTrạngBảoTrìToolStripMenuItem_Click);
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Image = global::QLPT.Properties.Resources.People;
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh sách nhân viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // báoCáoVậnHànhPhươngTiệnToolStripMenuItem
            // 
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem.Image = global::QLPT.Properties.Resources.Address_book;
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem.Name = "báoCáoVậnHànhPhươngTiệnToolStripMenuItem";
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem.Text = "Vận hành phương tiện";
            this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem.Click += new System.EventHandler(this.báoCáoVậnHànhPhươngTiệnToolStripMenuItem_Click);
            // 
            // mnTimKiem
            // 
            this.mnTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmPhươngTiệnToolStripMenuItem});
            this.mnTimKiem.Image = global::QLPT.Properties.Resources.Search;
            this.mnTimKiem.Name = "mnTimKiem";
            this.mnTimKiem.Size = new System.Drawing.Size(85, 20);
            this.mnTimKiem.Text = "Tìm kiếm";
            // 
            // tìmKiếmPhươngTiệnToolStripMenuItem
            // 
            this.tìmKiếmPhươngTiệnToolStripMenuItem.Image = global::QLPT.Properties.Resources.Search2;
            this.tìmKiếmPhươngTiệnToolStripMenuItem.Name = "tìmKiếmPhươngTiệnToolStripMenuItem";
            this.tìmKiếmPhươngTiệnToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.tìmKiếmPhươngTiệnToolStripMenuItem.Text = "Tìm kiếm phương tiện";
            this.tìmKiếmPhươngTiệnToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmPhươngTiệnToolStripMenuItem_Click);
            // 
            // mnTroGiup
            // 
            this.mnTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.thôngTinChươngTrìnhToolStripMenuItem});
            this.mnTroGiup.Image = global::QLPT.Properties.Resources.Help;
            this.mnTroGiup.Name = "mnTroGiup";
            this.mnTroGiup.Size = new System.Drawing.Size(80, 20);
            this.mnTroGiup.Text = "Trợ giúp";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::QLPT.Properties.Resources.Question;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // thôngTinChươngTrìnhToolStripMenuItem
            // 
            this.thôngTinChươngTrìnhToolStripMenuItem.Image = global::QLPT.Properties.Resources._600px_information_iconsvg;
            this.thôngTinChươngTrìnhToolStripMenuItem.Name = "thôngTinChươngTrìnhToolStripMenuItem";
            this.thôngTinChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.thôngTinChươngTrìnhToolStripMenuItem.Text = "Thông tin chương trình";
            this.thôngTinChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChươngTrìnhToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLPT.Properties.Resources._12102013_khu_xay_dung_tram_thu_phi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 247);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý phương tiện thi công cơ giới đường bộ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnDangKy;
        private System.Windows.Forms.ToolStripMenuItem mnDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnQuanLy;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐơnVịThiCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnVịThiCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnBaoTri;
        private System.Windows.Forms.ToolStripMenuItem mnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnTroGiup;
        private System.Windows.Forms.ToolStripMenuItem nguyênMẫuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchCácPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìnhTrạngBảoTrìToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loạiPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýVậnHànhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoVậnHànhPhươngTiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChươngTrìnhToolStripMenuItem;
    }
}

