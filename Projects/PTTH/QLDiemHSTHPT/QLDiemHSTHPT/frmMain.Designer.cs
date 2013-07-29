using System.Windows.Forms;
namespace QLDiemHSTHPT
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
            System.Windows.Forms.DialogResult A;
            A = DevComponents.DotNetBar.MessageBoxEx.Show("Bạn có muốn thoát khỏi chương trình không?", "Quản Lý Điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (disposing && (components != null))
                components.Dispose();
            if (A == System.Windows.Forms.DialogResult.Yes)
                base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.office2007StartButton2 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer5 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer6 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer7 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem15 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem16 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem17 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem18 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem19 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem20 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem14 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer2 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.galleryContainer3 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.bottomBar = new DevComponents.DotNetBar.Bar();
            this.lblND = new DevComponents.DotNetBar.LabelX();
            this.lbNguoidung = new DevComponents.DotNetBar.LabelX();
            this.lblTenNguoiDung = new DevComponents.DotNetBar.LabelX();
            this.office2007StartButton4 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer9 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer10 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer11 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem29 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem30 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem31 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem32 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem33 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.buttonItem8 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem11 = new DevComponents.DotNetBar.ButtonItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem12 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem13 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabGiupdo = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuydinh = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabTracuu = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabThongKe = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabQuanLy = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.btnDangnhap = new DevComponents.DotNetBar.ButtonItem();
            this.btnDangxuat = new DevComponents.DotNetBar.ButtonItem();
            this.btnDoimatkhau = new DevComponents.DotNetBar.ButtonItem();
            this.btnQlyND = new DevComponents.DotNetBar.ButtonItem();
            this.btnSaoluudl = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhuchoidl = new DevComponents.DotNetBar.ButtonItem();
            this.btnThoat = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton5 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer17 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer18 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer19 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem34 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem35 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem36 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem37 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem38 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem39 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem40 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabQuanLy1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.galleryContainer4 = new DevComponents.DotNetBar.GalleryContainer();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem59 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem63 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem64 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem65 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem66 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem67 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem68 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem69 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem70 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem71 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem72 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem73 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem77 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem78 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem79 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem80 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem81 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem83 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem84 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khốiLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nămHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcLựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hạnhKiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dânTộcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tônGiáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghềNghiệpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcKỳToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcKỳTheoMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcKỳTheoLớpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảCảNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảCảNămTheoMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảCảNămTheoLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuHọcSinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhVềĐộTuổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhVềThangĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quyĐịnhVềSỉSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTrườngHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiểnThịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhtacvu = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhCôngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cửaSổNgangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổDọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cửaSổBìnhThườngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnnamhoc = new System.Windows.Forms.ToolStripButton();
            this.btnhocky = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnphancong = new System.Windows.Forms.ToolStripButton();
            this.btnphanlop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKQHKMH = new System.Windows.Forms.ToolStripButton();
            this.btnKQHKLop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnKQCNMH = new System.Windows.Forms.ToolStripButton();
            this.btnKQCNLop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnhocsinh = new System.Windows.Forms.ToolStripButton();
            this.btngiaovien = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnTTTruong = new System.Windows.Forms.ToolStripButton();
            this.btnTTPM = new System.Windows.Forms.ToolStripButton();
            this.tbtnhocsinh = new System.Windows.Forms.ToolStripButton();
            this.tabStrip = new DevComponents.DotNetBar.TabStrip();
            this.panelTacvu = new DevComponents.DotNetBar.PanelEx();
            this.expelTracuu = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonTCGV = new DevComponents.DotNetBar.ButtonX();
            this.buttonTCHS = new DevComponents.DotNetBar.ButtonX();
            this.expelquanly = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonGV = new DevComponents.DotNetBar.ButtonX();
            this.buttonHocSinh = new DevComponents.DotNetBar.ButtonX();
            this.buttonPCong = new DevComponents.DotNetBar.ButtonX();
            this.buttonPLop = new DevComponents.DotNetBar.ButtonX();
            this.expanelHethong = new DevComponents.DotNetBar.ExpandablePanel();
            this.buttonthoat = new DevComponents.DotNetBar.ButtonX();
            this.buttondangnhap = new DevComponents.DotNetBar.ButtonX();
            this.buttondangxuat = new DevComponents.DotNetBar.ButtonX();
            this.backupDialog = new System.Windows.Forms.SaveFileDialog();
            this.restoreDialog = new System.Windows.Forms.OpenFileDialog();
            this.office2007StartButton3 = new DevComponents.DotNetBar.Office2007StartButton();
            this.itemContainer8 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer12 = new DevComponents.DotNetBar.ItemContainer();
            this.itemContainer13 = new DevComponents.DotNetBar.ItemContainer();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem21 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem22 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem23 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem24 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem25 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem26 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).BeginInit();
            this.bottomBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelTacvu.SuspendLayout();
            this.expelTracuu.SuspendLayout();
            this.expelquanly.SuspendLayout();
            this.expanelHethong.SuspendLayout();
            this.SuspendLayout();
            // 
            // office2007StartButton2
            // 
            this.office2007StartButton2.AutoExpandOnClick = true;
            this.office2007StartButton2.CanCustomize = false;
            this.office2007StartButton2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton2.ImagePaddingHorizontal = 2;
            this.office2007StartButton2.ImagePaddingVertical = 2;
            this.office2007StartButton2.Name = "office2007StartButton2";
            this.office2007StartButton2.ShowSubItems = false;
            this.office2007StartButton2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer5});
            this.office2007StartButton2.Text = "&File";
            // 
            // itemContainer5
            // 
            // 
            // 
            // 
            this.itemContainer5.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer5.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer5.Name = "itemContainer5";
            this.itemContainer5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer6});
            // 
            // itemContainer6
            // 
            // 
            // 
            // 
            this.itemContainer6.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer6.ItemSpacing = 0;
            this.itemContainer6.Name = "itemContainer6";
            this.itemContainer6.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer7});
            // 
            // itemContainer7
            // 
            // 
            // 
            // 
            this.itemContainer7.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer7.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer7.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer7.Name = "itemContainer7";
            this.itemContainer7.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem15,
            this.buttonItem16,
            this.buttonItem17,
            this.buttonItem18,
            this.buttonItem19,
            this.buttonItem20});
            // 
            // buttonItem15
            // 
            this.buttonItem15.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem15.ImagePaddingHorizontal = 8;
            this.buttonItem15.Name = "buttonItem15";
            this.buttonItem15.SubItemsExpandWidth = 24;
            this.buttonItem15.Text = "&New";
            // 
            // buttonItem16
            // 
            this.buttonItem16.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem16.ImagePaddingHorizontal = 8;
            this.buttonItem16.Name = "buttonItem16";
            this.buttonItem16.SubItemsExpandWidth = 24;
            this.buttonItem16.Text = "&Open...";
            // 
            // buttonItem17
            // 
            this.buttonItem17.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem17.ImagePaddingHorizontal = 8;
            this.buttonItem17.Name = "buttonItem17";
            this.buttonItem17.SubItemsExpandWidth = 24;
            this.buttonItem17.Text = "&Save...";
            // 
            // buttonItem18
            // 
            this.buttonItem18.BeginGroup = true;
            this.buttonItem18.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem18.ImagePaddingHorizontal = 8;
            this.buttonItem18.Name = "buttonItem18";
            this.buttonItem18.SubItemsExpandWidth = 24;
            this.buttonItem18.Text = "S&hare...";
            // 
            // buttonItem19
            // 
            this.buttonItem19.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem19.ImagePaddingHorizontal = 8;
            this.buttonItem19.Name = "buttonItem19";
            this.buttonItem19.SubItemsExpandWidth = 24;
            this.buttonItem19.Text = "&Print...";
            // 
            // buttonItem20
            // 
            this.buttonItem20.BeginGroup = true;
            this.buttonItem20.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem20.ImagePaddingHorizontal = 8;
            this.buttonItem20.Name = "buttonItem20";
            this.buttonItem20.SubItemsExpandWidth = 24;
            this.buttonItem20.Text = "&Close";
            // 
            // buttonItem14
            // 
            this.buttonItem14.ImagePaddingHorizontal = 8;
            this.buttonItem14.Name = "buttonItem14";
            this.buttonItem14.Text = "buttonItem14";
            // 
            // galleryContainer2
            // 
            // 
            // 
            // 
            this.galleryContainer2.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer2.EnableGalleryPopup = false;
            this.galleryContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer2.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer2.MultiLine = false;
            this.galleryContainer2.Name = "galleryContainer2";
            this.galleryContainer2.PopupUsesStandardScrollbars = false;
            // 
            // labelItem1
            // 
            this.labelItem1.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem1.CanCustomize = false;
            this.labelItem1.Name = "labelItem1";
            // 
            // galleryContainer3
            // 
            // 
            // 
            // 
            this.galleryContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer3.EnableGalleryPopup = false;
            this.galleryContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer3.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer3.MultiLine = false;
            this.galleryContainer3.Name = "galleryContainer3";
            this.galleryContainer3.PopupUsesStandardScrollbars = false;
            // 
            // labelItem2
            // 
            this.labelItem2.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem2.CanCustomize = false;
            this.labelItem2.Name = "labelItem2";
            // 
            // bottomBar
            // 
            this.bottomBar.AccessibleDescription = "DotNetBar Bar (bottomBar)";
            this.bottomBar.AccessibleName = "DotNetBar Bar";
            this.bottomBar.AccessibleRole = System.Windows.Forms.AccessibleRole.StatusBar;
            this.bottomBar.AlwaysDisplayDockTab = true;
            this.bottomBar.AntiAlias = true;
            this.bottomBar.BarType = DevComponents.DotNetBar.eBarType.StatusBar;
            this.bottomBar.Controls.Add(this.lblND);
            this.bottomBar.Controls.Add(this.lbNguoidung);
            this.bottomBar.Controls.Add(this.lblTenNguoiDung);
            this.bottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bottomBar.GrabHandleStyle = DevComponents.DotNetBar.eGrabHandleStyle.ResizeHandle;
            this.bottomBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton4});
            this.bottomBar.ItemSpacing = 2;
            this.bottomBar.Location = new System.Drawing.Point(0, 672);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(933, 49);
            this.bottomBar.Stretch = true;
            this.bottomBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.bottomBar.TabIndex = 8;
            this.bottomBar.TabStop = false;
            // 
            // lblND
            // 
            this.lblND.BackColor = System.Drawing.Color.Transparent;
            this.lblND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblND.Location = new System.Drawing.Point(199, 11);
            this.lblND.Name = "lblND";
            this.lblND.SingleLineColor = System.Drawing.Color.Empty;
            this.lblND.Size = new System.Drawing.Size(144, 26);
            this.lblND.TabIndex = 2;
            // 
            // lbNguoidung
            // 
            this.lbNguoidung.BackColor = System.Drawing.Color.Transparent;
            this.lbNguoidung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbNguoidung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNguoidung.Location = new System.Drawing.Point(49, 11);
            this.lbNguoidung.Name = "lbNguoidung";
            this.lbNguoidung.SingleLineColor = System.Drawing.Color.Empty;
            this.lbNguoidung.Size = new System.Drawing.Size(144, 26);
            this.lbNguoidung.TabIndex = 1;
            this.lbNguoidung.Text = "Người dùng đang đăng nhập:";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Red;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(145, 5);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(0, 0);
            this.lblTenNguoiDung.TabIndex = 0;
            // 
            // office2007StartButton4
            // 
            this.office2007StartButton4.AutoExpandOnClick = true;
            this.office2007StartButton4.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton4.Image = global::QLDiemHSTHPT.Properties.Resources.WVista_Home_Premium4;
            this.office2007StartButton4.ImagePaddingHorizontal = 2;
            this.office2007StartButton4.ImagePaddingVertical = 2;
            this.office2007StartButton4.Name = "office2007StartButton4";
            this.office2007StartButton4.ShowSubItems = false;
            this.office2007StartButton4.StopPulseOnMouseOver = false;
            this.office2007StartButton4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer9});
            this.office2007StartButton4.Text = "Start";
            this.office2007StartButton4.Tooltip = "Start";
            // 
            // itemContainer9
            // 
            // 
            // 
            // 
            this.itemContainer9.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer9.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer9.Name = "itemContainer9";
            this.itemContainer9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer10});
            // 
            // itemContainer10
            // 
            // 
            // 
            // 
            this.itemContainer10.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer10.ItemSpacing = 0;
            this.itemContainer10.Name = "itemContainer10";
            this.itemContainer10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer11});
            // 
            // itemContainer11
            // 
            // 
            // 
            // 
            this.itemContainer11.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer11.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer11.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer11.Name = "itemContainer11";
            this.itemContainer11.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem29,
            this.buttonItem30,
            this.buttonItem31,
            this.buttonItem32,
            this.buttonItem33});
            // 
            // buttonItem29
            // 
            this.buttonItem29.BeginGroup = true;
            this.buttonItem29.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem29.Image = global::QLDiemHSTHPT.Properties.Resources.doimatkhau;
            this.buttonItem29.ImagePaddingHorizontal = 8;
            this.buttonItem29.Name = "buttonItem29";
            this.buttonItem29.SubItemsExpandWidth = 24;
            this.buttonItem29.Text = "Đổi mật khẩu";
            this.buttonItem29.Tooltip = "Đổi mật khẩu";
            // 
            // buttonItem30
            // 
            this.buttonItem30.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem30.Image = global::QLDiemHSTHPT.Properties.Resources.quanlynguoidung;
            this.buttonItem30.ImagePaddingHorizontal = 8;
            this.buttonItem30.Name = "buttonItem30";
            this.buttonItem30.Text = "Quản lý người dùng";
            this.buttonItem30.Tooltip = "Quản lý người dùng";
            this.buttonItem30.Click += new System.EventHandler(this.buttonItem30_Click);
            // 
            // buttonItem31
            // 
            this.buttonItem31.BeginGroup = true;
            this.buttonItem31.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem31.Image = global::QLDiemHSTHPT.Properties.Resources.saoluudulieu;
            this.buttonItem31.ImagePaddingHorizontal = 8;
            this.buttonItem31.Name = "buttonItem31";
            this.buttonItem31.SubItemsExpandWidth = 24;
            this.buttonItem31.Text = "Sao lưu dữ liệu";
            this.buttonItem31.Tooltip = "Sao lưu dữ liệu";
            this.buttonItem31.Click += new System.EventHandler(this.buttonItem31_Click);
            // 
            // buttonItem32
            // 
            this.buttonItem32.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem32.Image = global::QLDiemHSTHPT.Properties.Resources.phuchoidulieu;
            this.buttonItem32.ImagePaddingHorizontal = 8;
            this.buttonItem32.Name = "buttonItem32";
            this.buttonItem32.SubItemsExpandWidth = 24;
            this.buttonItem32.Text = "Phục hồi dữ liệu";
            this.buttonItem32.Tooltip = "Phục hồi dữ liệu";
            this.buttonItem32.Click += new System.EventHandler(this.buttonItem32_Click);
            // 
            // buttonItem33
            // 
            this.buttonItem33.BeginGroup = true;
            this.buttonItem33.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem33.Image = global::QLDiemHSTHPT.Properties.Resources.thoat;
            this.buttonItem33.ImagePaddingHorizontal = 8;
            this.buttonItem33.Name = "buttonItem33";
            this.buttonItem33.SubItemsExpandWidth = 24;
            this.buttonItem33.Text = "Thoát";
            this.buttonItem33.Tooltip = "Thoát";
            this.buttonItem33.Click += new System.EventHandler(this.buttonItem33_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.SubItemsExpandWidth = 24;
            this.buttonItem2.Text = "&New";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.ImagePaddingHorizontal = 8;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItemsExpandWidth = 24;
            this.buttonItem3.Text = "&Open...";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.ImagePaddingHorizontal = 8;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.SubItemsExpandWidth = 24;
            this.buttonItem4.Text = "&Save...";
            // 
            // buttonItem5
            // 
            this.buttonItem5.BeginGroup = true;
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.ImagePaddingHorizontal = 8;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.SubItemsExpandWidth = 24;
            this.buttonItem5.Text = "S&hare...";
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.ImagePaddingHorizontal = 8;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.SubItemsExpandWidth = 24;
            this.buttonItem6.Text = "&Print...";
            // 
            // buttonItem7
            // 
            this.buttonItem7.BeginGroup = true;
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.ImagePaddingHorizontal = 8;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.SubItemsExpandWidth = 24;
            this.buttonItem7.Text = "&Close";
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem8,
            this.buttonItem8,
            this.buttonItem9,
            this.buttonItem10,
            this.buttonItem11});
            // 
            // labelItem8
            // 
            this.labelItem8.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem8.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem8.CanCustomize = false;
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.PaddingBottom = 2;
            this.labelItem8.PaddingTop = 2;
            this.labelItem8.Stretch = true;
            this.labelItem8.Text = "Recent Documents";
            // 
            // buttonItem8
            // 
            this.buttonItem8.ImagePaddingHorizontal = 8;
            this.buttonItem8.Name = "buttonItem8";
            this.buttonItem8.Text = "&1. Short News 5-7.rtf";
            // 
            // buttonItem9
            // 
            this.buttonItem9.ImagePaddingHorizontal = 8;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.Text = "&2. Prospect Email.rtf";
            // 
            // buttonItem10
            // 
            this.buttonItem10.ImagePaddingHorizontal = 8;
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.Text = "&3. Customer Email.rtf";
            // 
            // buttonItem11
            // 
            this.buttonItem11.ImagePaddingHorizontal = 8;
            this.buttonItem11.Name = "buttonItem11";
            this.buttonItem11.Text = "&4. example.rtf";
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer";
            this.itemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem12,
            this.buttonItem13});
            // 
            // buttonItem12
            // 
            this.buttonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem12.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem12.ImagePaddingHorizontal = 8;
            this.buttonItem12.Name = "buttonItem12";
            this.buttonItem12.SubItemsExpandWidth = 24;
            this.buttonItem12.Text = "Opt&ions";
            // 
            // buttonItem13
            // 
            this.buttonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem13.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonItem13.ImagePaddingHorizontal = 8;
            this.buttonItem13.Name = "buttonItem13";
            this.buttonItem13.SubItemsExpandWidth = 24;
            this.buttonItem13.Text = "E&xit";
            // 
            // ribbonTabGiupdo
            // 
            this.ribbonTabGiupdo.ImagePaddingHorizontal = 8;
            this.ribbonTabGiupdo.Name = "ribbonTabGiupdo";
            this.ribbonTabGiupdo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F6);
            this.ribbonTabGiupdo.Text = "Giúp Đỡ";
            this.ribbonTabGiupdo.Tooltip = "Giúp Đỡ(F6)";
            // 
            // ribbonTabQuydinh
            // 
            this.ribbonTabQuydinh.ImagePaddingHorizontal = 8;
            this.ribbonTabQuydinh.Name = "ribbonTabQuydinh";
            this.ribbonTabQuydinh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.ribbonTabQuydinh.Text = "Quy Định";
            this.ribbonTabQuydinh.Tooltip = "Quy Định(F5)";
            // 
            // ribbonTabTracuu
            // 
            this.ribbonTabTracuu.ImagePaddingHorizontal = 8;
            this.ribbonTabTracuu.Name = "ribbonTabTracuu";
            this.ribbonTabTracuu.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F4);
            this.ribbonTabTracuu.Text = "Tra Cứu";
            this.ribbonTabTracuu.Tooltip = "Tra Cứu(F4)";
            // 
            // ribbonTabThongKe
            // 
            this.ribbonTabThongKe.AutoCheckOnClick = true;
            this.ribbonTabThongKe.ImagePaddingHorizontal = 8;
            this.ribbonTabThongKe.Name = "ribbonTabThongKe";
            this.ribbonTabThongKe.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F3);
            this.ribbonTabThongKe.Text = "Thống Kê";
            this.ribbonTabThongKe.Tooltip = "Thống Kê (F3)";
            // 
            // ribbonTabQuanLy
            // 
            this.ribbonTabQuanLy.Checked = true;
            this.ribbonTabQuanLy.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy.Name = "ribbonTabQuanLy";
            this.ribbonTabQuanLy.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.ribbonTabQuanLy.Text = "&Quản Lý";
            this.ribbonTabQuanLy.Tooltip = "Quản Lý (F2)";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            this.qatCustomizeItem1.Tooltip = "Thanh công cụ truy xuất nhanh";
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.StopPulseOnMouseOver = false;
            this.office2007StartButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.office2007StartButton1.Text = "Start";
            this.office2007StartButton1.Tooltip = "Start";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer2.ItemSpacing = 0;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3});
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnDangnhap,
            this.btnDangxuat,
            this.btnDoimatkhau,
            this.btnQlyND,
            this.btnSaoluudl,
            this.btnPhuchoidl,
            this.btnThoat});
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BeginGroup = true;
            this.btnDangnhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangnhap.ImagePaddingHorizontal = 8;
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.PopupWidth = 100;
            this.btnDangnhap.Text = "Đăng Nhập";
            this.btnDangnhap.Tooltip = "Đăng nhập";
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.AutoCheckOnClick = true;
            this.btnDangxuat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangxuat.ImagePaddingHorizontal = 8;
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.SubItemsExpandWidth = 24;
            this.btnDangxuat.Text = "Đăng Xuất";
            this.btnDangxuat.Tooltip = "Đăng Xuất";
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.BeginGroup = true;
            this.btnDoimatkhau.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDoimatkhau.ImagePaddingHorizontal = 8;
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            this.btnDoimatkhau.SubItemsExpandWidth = 24;
            this.btnDoimatkhau.Text = "Đổi mật khẩu";
            this.btnDoimatkhau.Tooltip = "Đổi mật khẩu";
            // 
            // btnQlyND
            // 
            this.btnQlyND.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnQlyND.ImagePaddingHorizontal = 8;
            this.btnQlyND.Name = "btnQlyND";
            this.btnQlyND.Text = "Quản lý người dùng";
            this.btnQlyND.Tooltip = "Quản lý người dùng";
            // 
            // btnSaoluudl
            // 
            this.btnSaoluudl.BeginGroup = true;
            this.btnSaoluudl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaoluudl.ImagePaddingHorizontal = 8;
            this.btnSaoluudl.Name = "btnSaoluudl";
            this.btnSaoluudl.SubItemsExpandWidth = 24;
            this.btnSaoluudl.Text = "Sao lưu dữ liệu";
            this.btnSaoluudl.Tooltip = "Sao lưu dữ liệu";
            // 
            // btnPhuchoidl
            // 
            this.btnPhuchoidl.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnPhuchoidl.ImagePaddingHorizontal = 8;
            this.btnPhuchoidl.Name = "btnPhuchoidl";
            this.btnPhuchoidl.SubItemsExpandWidth = 24;
            this.btnPhuchoidl.Text = "Phục hồi dữ liệu";
            this.btnPhuchoidl.Tooltip = "Phục hồi dữ liệu";
            // 
            // btnThoat
            // 
            this.btnThoat.BeginGroup = true;
            this.btnThoat.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThoat.ImagePaddingHorizontal = 8;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.SubItemsExpandWidth = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Tooltip = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // office2007StartButton5
            // 
            this.office2007StartButton5.AutoExpandOnClick = true;
            this.office2007StartButton5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton5.ImagePaddingHorizontal = 2;
            this.office2007StartButton5.ImagePaddingVertical = 2;
            this.office2007StartButton5.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton5.Name = "office2007StartButton5";
            this.office2007StartButton5.ShowSubItems = false;
            this.office2007StartButton5.StopPulseOnMouseOver = false;
            this.office2007StartButton5.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer17});
            this.office2007StartButton5.Text = "Start";
            this.office2007StartButton5.Tooltip = "Start";
            // 
            // itemContainer17
            // 
            // 
            // 
            // 
            this.itemContainer17.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer17.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer17.Name = "itemContainer17";
            this.itemContainer17.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer18});
            // 
            // itemContainer18
            // 
            // 
            // 
            // 
            this.itemContainer18.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer18.ItemSpacing = 0;
            this.itemContainer18.Name = "itemContainer18";
            this.itemContainer18.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer19});
            // 
            // itemContainer19
            // 
            // 
            // 
            // 
            this.itemContainer19.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer19.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer19.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer19.Name = "itemContainer19";
            this.itemContainer19.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem34,
            this.buttonItem35,
            this.buttonItem36,
            this.buttonItem37,
            this.buttonItem38,
            this.buttonItem39,
            this.buttonItem40});
            // 
            // buttonItem34
            // 
            this.buttonItem34.BeginGroup = true;
            this.buttonItem34.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem34.ImagePaddingHorizontal = 8;
            this.buttonItem34.Name = "buttonItem34";
            this.buttonItem34.PopupWidth = 100;
            this.buttonItem34.Text = "Đăng Nhập";
            this.buttonItem34.Tooltip = "Đăng nhập";
            // 
            // buttonItem35
            // 
            this.buttonItem35.AutoCheckOnClick = true;
            this.buttonItem35.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem35.ImagePaddingHorizontal = 8;
            this.buttonItem35.Name = "buttonItem35";
            this.buttonItem35.SubItemsExpandWidth = 24;
            this.buttonItem35.Text = "Đăng Xuất";
            this.buttonItem35.Tooltip = "Đăng Xuất";
            // 
            // buttonItem36
            // 
            this.buttonItem36.BeginGroup = true;
            this.buttonItem36.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem36.ImagePaddingHorizontal = 8;
            this.buttonItem36.Name = "buttonItem36";
            this.buttonItem36.SubItemsExpandWidth = 24;
            this.buttonItem36.Text = "Đổi mật khẩu";
            this.buttonItem36.Tooltip = "Đổi mật khẩu";
            // 
            // buttonItem37
            // 
            this.buttonItem37.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem37.ImagePaddingHorizontal = 8;
            this.buttonItem37.Name = "buttonItem37";
            this.buttonItem37.Text = "Quản lý người dùng";
            this.buttonItem37.Tooltip = "Quản lý người dùng";
            // 
            // buttonItem38
            // 
            this.buttonItem38.BeginGroup = true;
            this.buttonItem38.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem38.ImagePaddingHorizontal = 8;
            this.buttonItem38.Name = "buttonItem38";
            this.buttonItem38.SubItemsExpandWidth = 24;
            this.buttonItem38.Text = "Sao lưu dữ liệu";
            this.buttonItem38.Tooltip = "Sao lưu dữ liệu";
            // 
            // buttonItem39
            // 
            this.buttonItem39.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem39.ImagePaddingHorizontal = 8;
            this.buttonItem39.Name = "buttonItem39";
            this.buttonItem39.SubItemsExpandWidth = 24;
            this.buttonItem39.Text = "Phục hồi dữ liệu";
            this.buttonItem39.Tooltip = "Phục hồi dữ liệu";
            // 
            // buttonItem40
            // 
            this.buttonItem40.BeginGroup = true;
            this.buttonItem40.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem40.ImagePaddingHorizontal = 8;
            this.buttonItem40.Name = "buttonItem40";
            this.buttonItem40.SubItemsExpandWidth = 24;
            this.buttonItem40.Text = "Thoát";
            this.buttonItem40.Tooltip = "Thoát";
            // 
            // ribbonTabQuanLy1
            // 
            this.ribbonTabQuanLy1.Checked = true;
            this.ribbonTabQuanLy1.ImagePaddingHorizontal = 8;
            this.ribbonTabQuanLy1.Name = "ribbonTabQuanLy1";
            this.ribbonTabQuanLy1.Text = "Năm Học";
            // 
            // galleryContainer4
            // 
            // 
            // 
            // 
            this.galleryContainer4.BackgroundStyle.Class = "RibbonFileMenuColumnTwoContainer";
            this.galleryContainer4.EnableGalleryPopup = false;
            this.galleryContainer4.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer4.MinimumSize = new System.Drawing.Size(180, 240);
            this.galleryContainer4.MultiLine = false;
            this.galleryContainer4.Name = "galleryContainer4";
            this.galleryContainer4.PopupUsesStandardScrollbars = false;
            // 
            // labelItem3
            // 
            this.labelItem3.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.labelItem3.BorderType = DevComponents.DotNetBar.eBorderType.Etched;
            this.labelItem3.CanCustomize = false;
            this.labelItem3.Name = "labelItem3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem46,
            this.toolStripMenuItem63,
            this.toolStripMenuItem77,
            this.toolStripMenuItem81});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem47,
            this.toolStripMenuItem48,
            this.toolStripMenuItem49,
            this.toolStripMenuItem50,
            this.toolStripMenuItem51,
            this.toolStripMenuItem52,
            this.toolStripMenuItem1,
            this.toolStripMenuItem53,
            this.toolStripMenuItem54,
            this.toolStripMenuItem55,
            this.toolStripMenuItem58,
            this.toolStripMenuItem59,
            this.toolStripMenuItem60});
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem46.Text = "Quản Lý";
            this.toolStripMenuItem46.Click += new System.EventHandler(this.toolStripMenuItem46_Click);
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.Image = global::QLDiemHSTHPT.Properties.Resources.khoilop;
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem47.Text = "Khối Lớp";
            this.toolStripMenuItem47.Click += new System.EventHandler(this.khốiLớpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.Image = global::QLDiemHSTHPT.Properties.Resources.lophoc;
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem48.Text = "Lớp Học";
            this.toolStripMenuItem48.Click += new System.EventHandler(this.toolStripMenuItem48_Click);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Image = global::QLDiemHSTHPT.Properties.Resources.hocky;
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem49.Text = "Học Kỳ";
            this.toolStripMenuItem49.Click += new System.EventHandler(this.họcKỳToolStripMenuItem_Click);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Image = global::QLDiemHSTHPT.Properties.Resources.namhoc;
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem50.Text = "Năm Học";
            this.toolStripMenuItem50.Click += new System.EventHandler(this.nămHọcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Image = global::QLDiemHSTHPT.Properties.Resources.monhoc;
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem51.Text = "Môn Học ";
            this.toolStripMenuItem51.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.Image = global::QLDiemHSTHPT.Properties.Resources.diem;
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem52.Text = "Nhập điểm chung";
            this.toolStripMenuItem52.Click += new System.EventHandler(this.toolStripMenuItem52_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::QLDiemHSTHPT.Properties.Resources.QDdotuoi;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "Nhập điểm riêng";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.Image = global::QLDiemHSTHPT.Properties.Resources.ketqua;
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem53.Text = "Kết Quả ";
            this.toolStripMenuItem53.Click += new System.EventHandler(this.kếtQuảToolStripMenuItem_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.Image = global::QLDiemHSTHPT.Properties.Resources.hocluc;
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem54.Text = "Học Lực";
            this.toolStripMenuItem54.Click += new System.EventHandler(this.họcLựcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.Image = global::QLDiemHSTHPT.Properties.Resources.hanhkiem;
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem55.Text = "Hạnh Kiểm";
            this.toolStripMenuItem55.Click += new System.EventHandler(this.hạnhKiểmToolStripMenuItem_Click);
            // 
            // toolStripMenuItem58
            // 
            this.toolStripMenuItem58.Image = global::QLDiemHSTHPT.Properties.Resources.dantoc1;
            this.toolStripMenuItem58.Name = "toolStripMenuItem58";
            this.toolStripMenuItem58.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem58.Text = "Dân Tộc";
            this.toolStripMenuItem58.Click += new System.EventHandler(this.dânTộcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem59
            // 
            this.toolStripMenuItem59.Image = global::QLDiemHSTHPT.Properties.Resources.tongiao;
            this.toolStripMenuItem59.Name = "toolStripMenuItem59";
            this.toolStripMenuItem59.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem59.Text = "Tôn Giáo";
            this.toolStripMenuItem59.Click += new System.EventHandler(this.tônGiáoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.Image = global::QLDiemHSTHPT.Properties.Resources.nghenghiep;
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem60.Text = "Nghề Nghiệp";
            this.toolStripMenuItem60.Click += new System.EventHandler(this.nghềNghiệpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem63
            // 
            this.toolStripMenuItem63.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem64,
            this.toolStripMenuItem67,
            this.toolStripMenuItem70});
            this.toolStripMenuItem63.Name = "toolStripMenuItem63";
            this.toolStripMenuItem63.Size = new System.Drawing.Size(70, 20);
            this.toolStripMenuItem63.Text = "Thống Kê";
            // 
            // toolStripMenuItem64
            // 
            this.toolStripMenuItem64.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem65,
            this.toolStripMenuItem66});
            this.toolStripMenuItem64.Name = "toolStripMenuItem64";
            this.toolStripMenuItem64.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem64.Text = "Kết quả học kỳ";
            // 
            // toolStripMenuItem65
            // 
            this.toolStripMenuItem65.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKMH;
            this.toolStripMenuItem65.Name = "toolStripMenuItem65";
            this.toolStripMenuItem65.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItem65.Text = "Kết quả học kỳ theo môn học";
            this.toolStripMenuItem65.Click += new System.EventHandler(this.toolStripMenuItem65_Click);
            // 
            // toolStripMenuItem66
            // 
            this.toolStripMenuItem66.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKLop;
            this.toolStripMenuItem66.Name = "toolStripMenuItem66";
            this.toolStripMenuItem66.Size = new System.Drawing.Size(230, 22);
            this.toolStripMenuItem66.Text = "Kết quả học kỳ theo lớp học";
            this.toolStripMenuItem66.Click += new System.EventHandler(this.toolStripMenuItem66_Click);
            // 
            // toolStripMenuItem67
            // 
            this.toolStripMenuItem67.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem68,
            this.toolStripMenuItem69});
            this.toolStripMenuItem67.Name = "toolStripMenuItem67";
            this.toolStripMenuItem67.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem67.Text = "Kết quả cả năm";
            // 
            // toolStripMenuItem68
            // 
            this.toolStripMenuItem68.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNMH;
            this.toolStripMenuItem68.Name = "toolStripMenuItem68";
            this.toolStripMenuItem68.Size = new System.Drawing.Size(234, 22);
            this.toolStripMenuItem68.Text = "Kết quả cả năm theo môn học";
            this.toolStripMenuItem68.Click += new System.EventHandler(this.toolStripMenuItem68_Click);
            // 
            // toolStripMenuItem69
            // 
            this.toolStripMenuItem69.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNLop;
            this.toolStripMenuItem69.Name = "toolStripMenuItem69";
            this.toolStripMenuItem69.Size = new System.Drawing.Size(234, 22);
            this.toolStripMenuItem69.Text = "Kết quả cả năm theo lớp học";
            this.toolStripMenuItem69.Click += new System.EventHandler(this.toolStripMenuItem69_Click);
            // 
            // toolStripMenuItem70
            // 
            this.toolStripMenuItem70.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem71,
            this.toolStripMenuItem72,
            this.toolStripMenuItem73});
            this.toolStripMenuItem70.Name = "toolStripMenuItem70";
            this.toolStripMenuItem70.Size = new System.Drawing.Size(156, 22);
            this.toolStripMenuItem70.Text = "Xuất danh sách";
            // 
            // toolStripMenuItem71
            // 
            this.toolStripMenuItem71.Image = global::QLDiemHSTHPT.Properties.Resources.DSGV;
            this.toolStripMenuItem71.Name = "toolStripMenuItem71";
            this.toolStripMenuItem71.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem71.Text = "Danh sách giáo viên";
            this.toolStripMenuItem71.Click += new System.EventHandler(this.toolStripMenuItem71_Click);
            // 
            // toolStripMenuItem72
            // 
            this.toolStripMenuItem72.Image = global::QLDiemHSTHPT.Properties.Resources.DSHS;
            this.toolStripMenuItem72.Name = "toolStripMenuItem72";
            this.toolStripMenuItem72.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem72.Text = "Danh sách học sinh";
            this.toolStripMenuItem72.Click += new System.EventHandler(this.toolStripMenuItem72_Click);
            // 
            // toolStripMenuItem73
            // 
            this.toolStripMenuItem73.Image = global::QLDiemHSTHPT.Properties.Resources.DSLop;
            this.toolStripMenuItem73.Name = "toolStripMenuItem73";
            this.toolStripMenuItem73.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem73.Text = "Danh sách lớp học";
            this.toolStripMenuItem73.Click += new System.EventHandler(this.toolStripMenuItem73_Click);
            // 
            // toolStripMenuItem77
            // 
            this.toolStripMenuItem77.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem78,
            this.toolStripMenuItem79,
            this.toolStripMenuItem80});
            this.toolStripMenuItem77.Name = "toolStripMenuItem77";
            this.toolStripMenuItem77.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem77.Text = "Quy Định";
            // 
            // toolStripMenuItem78
            // 
            this.toolStripMenuItem78.Image = global::QLDiemHSTHPT.Properties.Resources.QDdotuoi;
            this.toolStripMenuItem78.Name = "toolStripMenuItem78";
            this.toolStripMenuItem78.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem78.Text = "Quy định về độ tuổi ";
            this.toolStripMenuItem78.Click += new System.EventHandler(this.toolStripMenuItem78_Click);
            // 
            // toolStripMenuItem79
            // 
            this.toolStripMenuItem79.Image = global::QLDiemHSTHPT.Properties.Resources.QDthangdiem;
            this.toolStripMenuItem79.Name = "toolStripMenuItem79";
            this.toolStripMenuItem79.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem79.Text = "Quy định về thang điểm";
            this.toolStripMenuItem79.Click += new System.EventHandler(this.toolStripMenuItem79_Click);
            // 
            // toolStripMenuItem80
            // 
            this.toolStripMenuItem80.Image = global::QLDiemHSTHPT.Properties.Resources.QDSiSo;
            this.toolStripMenuItem80.Name = "toolStripMenuItem80";
            this.toolStripMenuItem80.Size = new System.Drawing.Size(202, 22);
            this.toolStripMenuItem80.Text = "Quy định về sỉ số";
            this.toolStripMenuItem80.Click += new System.EventHandler(this.toolStripMenuItem80_Click);
            // 
            // toolStripMenuItem81
            // 
            this.toolStripMenuItem81.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem83,
            this.toolStripMenuItem84});
            this.toolStripMenuItem81.Name = "toolStripMenuItem81";
            this.toolStripMenuItem81.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem81.Text = "Giúp Đỡ";
            // 
            // toolStripMenuItem83
            // 
            this.toolStripMenuItem83.Image = global::QLDiemHSTHPT.Properties.Resources.TTPM;
            this.toolStripMenuItem83.Name = "toolStripMenuItem83";
            this.toolStripMenuItem83.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem83.Text = "Thông tin phần mềm";
            this.toolStripMenuItem83.Click += new System.EventHandler(this.toolStripMenuItem83_Click);
            // 
            // toolStripMenuItem84
            // 
            this.toolStripMenuItem84.Image = global::QLDiemHSTHPT.Properties.Resources.HDSD;
            this.toolStripMenuItem84.Name = "toolStripMenuItem84";
            this.toolStripMenuItem84.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuItem84.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem84.Text = "Hướng dẫn sử dụng";
            this.toolStripMenuItem84.Click += new System.EventHandler(this.toolStripMenuItem84_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // khốiLớpToolStripMenuItem
            // 
            this.khốiLớpToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.khoilop;
            this.khốiLớpToolStripMenuItem.Name = "khốiLớpToolStripMenuItem";
            this.khốiLớpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khốiLớpToolStripMenuItem.Text = "Khối Lớp";
            this.khốiLớpToolStripMenuItem.Click += new System.EventHandler(this.khốiLớpToolStripMenuItem_Click);
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.lophoc;
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lớpHọcToolStripMenuItem.Text = "Lớp Học";
            // 
            // họcKỳToolStripMenuItem
            // 
            this.họcKỳToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.hocky;
            this.họcKỳToolStripMenuItem.Name = "họcKỳToolStripMenuItem";
            this.họcKỳToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.họcKỳToolStripMenuItem.Text = "Học Kỳ";
            this.họcKỳToolStripMenuItem.Click += new System.EventHandler(this.họcKỳToolStripMenuItem_Click);
            // 
            // nămHọcToolStripMenuItem
            // 
            this.nămHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.namhoc;
            this.nămHọcToolStripMenuItem.Name = "nămHọcToolStripMenuItem";
            this.nămHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nămHọcToolStripMenuItem.Text = "Năm Học";
            this.nămHọcToolStripMenuItem.Click += new System.EventHandler(this.nămHọcToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.monhoc;
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mônHọcToolStripMenuItem.Text = "Môn Học ";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.diem;
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.điểmToolStripMenuItem.Text = "Điểm";
            // 
            // kếtQuảToolStripMenuItem
            // 
            this.kếtQuảToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.ketqua;
            this.kếtQuảToolStripMenuItem.Name = "kếtQuảToolStripMenuItem";
            this.kếtQuảToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kếtQuảToolStripMenuItem.Text = "Kết Quả ";
            this.kếtQuảToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảToolStripMenuItem_Click);
            // 
            // họcLựcToolStripMenuItem
            // 
            this.họcLựcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.hocluc;
            this.họcLựcToolStripMenuItem.Name = "họcLựcToolStripMenuItem";
            this.họcLựcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.họcLựcToolStripMenuItem.Text = "Học Lực";
            this.họcLựcToolStripMenuItem.Click += new System.EventHandler(this.họcLựcToolStripMenuItem_Click);
            // 
            // hạnhKiểmToolStripMenuItem
            // 
            this.hạnhKiểmToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.hanhkiem;
            this.hạnhKiểmToolStripMenuItem.Name = "hạnhKiểmToolStripMenuItem";
            this.hạnhKiểmToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hạnhKiểmToolStripMenuItem.Text = "Hạnh Kiểm";
            this.hạnhKiểmToolStripMenuItem.Click += new System.EventHandler(this.hạnhKiểmToolStripMenuItem_Click);
            // 
            // họcSinhToolStripMenuItem
            // 
            this.họcSinhToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.hocsinh1;
            this.họcSinhToolStripMenuItem.Name = "họcSinhToolStripMenuItem";
            this.họcSinhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.họcSinhToolStripMenuItem.Text = "Học Sinh";
            // 
            // phânLớpToolStripMenuItem
            // 
            this.phânLớpToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.phanlop;
            this.phânLớpToolStripMenuItem.Name = "phânLớpToolStripMenuItem";
            this.phânLớpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phânLớpToolStripMenuItem.Text = "Phân Lớp";
            // 
            // dânTộcToolStripMenuItem
            // 
            this.dânTộcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.dantoc1;
            this.dânTộcToolStripMenuItem.Name = "dânTộcToolStripMenuItem";
            this.dânTộcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dânTộcToolStripMenuItem.Text = "Dân Tộc";
            this.dânTộcToolStripMenuItem.Click += new System.EventHandler(this.dânTộcToolStripMenuItem_Click);
            // 
            // tônGiáoToolStripMenuItem
            // 
            this.tônGiáoToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.tongiao;
            this.tônGiáoToolStripMenuItem.Name = "tônGiáoToolStripMenuItem";
            this.tônGiáoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tônGiáoToolStripMenuItem.Text = "Tôn Giáo";
            this.tônGiáoToolStripMenuItem.Click += new System.EventHandler(this.tônGiáoToolStripMenuItem_Click);
            // 
            // nghềNghiệpToolStripMenuItem
            // 
            this.nghềNghiệpToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.nghenghiep;
            this.nghềNghiệpToolStripMenuItem.Name = "nghềNghiệpToolStripMenuItem";
            this.nghềNghiệpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nghềNghiệpToolStripMenuItem.Text = "Nghề Nghiệp";
            this.nghềNghiệpToolStripMenuItem.Click += new System.EventHandler(this.nghềNghiệpToolStripMenuItem_Click);
            // 
            // giáoViênToolStripMenuItem
            // 
            this.giáoViênToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.giaovien;
            this.giáoViênToolStripMenuItem.Name = "giáoViênToolStripMenuItem";
            this.giáoViênToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.giáoViênToolStripMenuItem.Text = "Giáo Viên";
            // 
            // phânCôngToolStripMenuItem
            // 
            this.phânCôngToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.phancong;
            this.phânCôngToolStripMenuItem.Name = "phânCôngToolStripMenuItem";
            this.phânCôngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phânCôngToolStripMenuItem.Text = "Phân Công";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // kếtQuảHọcKỳToolStripMenuItem
            // 
            this.kếtQuảHọcKỳToolStripMenuItem.Name = "kếtQuảHọcKỳToolStripMenuItem";
            this.kếtQuảHọcKỳToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kếtQuảHọcKỳToolStripMenuItem.Text = "Kết quả học kỳ";
            // 
            // kếtQuảHọcKỳTheoMônHọcToolStripMenuItem
            // 
            this.kếtQuảHọcKỳTheoMônHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKMH;
            this.kếtQuảHọcKỳTheoMônHọcToolStripMenuItem.Name = "kếtQuảHọcKỳTheoMônHọcToolStripMenuItem";
            this.kếtQuảHọcKỳTheoMônHọcToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.kếtQuảHọcKỳTheoMônHọcToolStripMenuItem.Text = "Kết quả học kỳ theo môn học";
            // 
            // kếtQuảHọcKỳTheoLớpToolStripMenuItem
            // 
            this.kếtQuảHọcKỳTheoLớpToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKLop;
            this.kếtQuảHọcKỳTheoLớpToolStripMenuItem.Name = "kếtQuảHọcKỳTheoLớpToolStripMenuItem";
            this.kếtQuảHọcKỳTheoLớpToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.kếtQuảHọcKỳTheoLớpToolStripMenuItem.Text = "Kết quả học kỳ theo lớp học";
            // 
            // kếtQuảCảNămToolStripMenuItem
            // 
            this.kếtQuảCảNămToolStripMenuItem.Name = "kếtQuảCảNămToolStripMenuItem";
            this.kếtQuảCảNămToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kếtQuảCảNămToolStripMenuItem.Text = "Kết quả cả năm";
            // 
            // kếtQuảCảNămTheoMônHọcToolStripMenuItem
            // 
            this.kếtQuảCảNămTheoMônHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNMH;
            this.kếtQuảCảNămTheoMônHọcToolStripMenuItem.Name = "kếtQuảCảNămTheoMônHọcToolStripMenuItem";
            this.kếtQuảCảNămTheoMônHọcToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.kếtQuảCảNămTheoMônHọcToolStripMenuItem.Text = "Kết quả cả năm theo môn học";
            // 
            // kếtQuảCảNămTheoLớpHọcToolStripMenuItem
            // 
            this.kếtQuảCảNămTheoLớpHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNLop;
            this.kếtQuảCảNămTheoLớpHọcToolStripMenuItem.Name = "kếtQuảCảNămTheoLớpHọcToolStripMenuItem";
            this.kếtQuảCảNămTheoLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.kếtQuảCảNămTheoLớpHọcToolStripMenuItem.Text = "Kết quả cả năm theo lớp học";
            // 
            // xuấtDanhSáchToolStripMenuItem
            // 
            this.xuấtDanhSáchToolStripMenuItem.Name = "xuấtDanhSáchToolStripMenuItem";
            this.xuấtDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.xuấtDanhSáchToolStripMenuItem.Text = "Xuất danh sách";
            // 
            // danhSáchGiáoViênToolStripMenuItem
            // 
            this.danhSáchGiáoViênToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.DSGV;
            this.danhSáchGiáoViênToolStripMenuItem.Name = "danhSáchGiáoViênToolStripMenuItem";
            this.danhSáchGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchGiáoViênToolStripMenuItem.Text = "Danh sách giáo viên";
            // 
            // danhSáchHọcSinhToolStripMenuItem
            // 
            this.danhSáchHọcSinhToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.DSHS;
            this.danhSáchHọcSinhToolStripMenuItem.Name = "danhSáchHọcSinhToolStripMenuItem";
            this.danhSáchHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchHọcSinhToolStripMenuItem.Text = "Danh sách học sinh";
            // 
            // danhSáchLớpHọcToolStripMenuItem
            // 
            this.danhSáchLớpHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.DSLop;
            this.danhSáchLớpHọcToolStripMenuItem.Name = "danhSáchLớpHọcToolStripMenuItem";
            this.danhSáchLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.danhSáchLớpHọcToolStripMenuItem.Text = "Danh sách lớp học";
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.traCứuToolStripMenuItem.Text = "Tra Cứu ";
            // 
            // traCứuGiáoViênToolStripMenuItem
            // 
            this.traCứuGiáoViênToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.TCGV;
            this.traCứuGiáoViênToolStripMenuItem.Name = "traCứuGiáoViênToolStripMenuItem";
            this.traCứuGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.traCứuGiáoViênToolStripMenuItem.Text = "Tra cứu giáo viên";
            // 
            // traCứuHọcSinhToolStripMenuItem
            // 
            this.traCứuHọcSinhToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.TCHS;
            this.traCứuHọcSinhToolStripMenuItem.Name = "traCứuHọcSinhToolStripMenuItem";
            this.traCứuHọcSinhToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.traCứuHọcSinhToolStripMenuItem.Text = "Tra cứu học sinh";
            // 
            // quyĐịnhToolStripMenuItem
            // 
            this.quyĐịnhToolStripMenuItem.Name = "quyĐịnhToolStripMenuItem";
            this.quyĐịnhToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.quyĐịnhToolStripMenuItem.Text = "Quy Định";
            // 
            // quyĐịnhVềĐộTuổiToolStripMenuItem
            // 
            this.quyĐịnhVềĐộTuổiToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.QDdotuoi;
            this.quyĐịnhVềĐộTuổiToolStripMenuItem.Name = "quyĐịnhVềĐộTuổiToolStripMenuItem";
            this.quyĐịnhVềĐộTuổiToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quyĐịnhVềĐộTuổiToolStripMenuItem.Text = "Quy định về độ tuổi ";
            // 
            // quyĐịnhVềThangĐiểmToolStripMenuItem
            // 
            this.quyĐịnhVềThangĐiểmToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.QDthangdiem;
            this.quyĐịnhVềThangĐiểmToolStripMenuItem.Name = "quyĐịnhVềThangĐiểmToolStripMenuItem";
            this.quyĐịnhVềThangĐiểmToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quyĐịnhVềThangĐiểmToolStripMenuItem.Text = "Quy định về thang điểm";
            // 
            // quyĐịnhVềSỉSốToolStripMenuItem
            // 
            this.quyĐịnhVềSỉSốToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.QDSiSo;
            this.quyĐịnhVềSỉSốToolStripMenuItem.Name = "quyĐịnhVềSỉSốToolStripMenuItem";
            this.quyĐịnhVềSỉSốToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.quyĐịnhVềSỉSốToolStripMenuItem.Text = "Quy định về sỉ số";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp Đỡ";
            // 
            // thôngTinTrườngHọcToolStripMenuItem
            // 
            this.thôngTinTrườngHọcToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.TTTH;
            this.thôngTinTrườngHọcToolStripMenuItem.Name = "thôngTinTrườngHọcToolStripMenuItem";
            this.thôngTinTrườngHọcToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.thôngTinTrườngHọcToolStripMenuItem.Text = "Thông tin trường học";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.TTPM;
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::QLDiemHSTHPT.Properties.Resources.HDSD;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // hiểnThịToolStripMenuItem
            // 
            this.hiểnThịToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhtacvu,
            this.thanhCôngCụToolStripMenuItem,
            this.toolStripSeparator4,
            this.cửaSổNgangToolStripMenuItem,
            this.cửaSổDọcToolStripMenuItem,
            this.cửaSổBìnhThườngToolStripMenuItem});
            this.hiểnThịToolStripMenuItem.Name = "hiểnThịToolStripMenuItem";
            this.hiểnThịToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.hiểnThịToolStripMenuItem.Text = "Hiển Thị";
            // 
            // thanhtacvu
            // 
            this.thanhtacvu.Checked = true;
            this.thanhtacvu.CheckOnClick = true;
            this.thanhtacvu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhtacvu.Name = "thanhtacvu";
            this.thanhtacvu.Size = new System.Drawing.Size(183, 22);
            this.thanhtacvu.Text = "Thanh tác vụ";
            // 
            // thanhCôngCụToolStripMenuItem
            // 
            this.thanhCôngCụToolStripMenuItem.Checked = true;
            this.thanhCôngCụToolStripMenuItem.CheckOnClick = true;
            this.thanhCôngCụToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.thanhCôngCụToolStripMenuItem.Name = "thanhCôngCụToolStripMenuItem";
            this.thanhCôngCụToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thanhCôngCụToolStripMenuItem.Text = "Thanh công cụ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // cửaSổNgangToolStripMenuItem
            // 
            this.cửaSổNgangToolStripMenuItem.Name = "cửaSổNgangToolStripMenuItem";
            this.cửaSổNgangToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổNgangToolStripMenuItem.Text = "Cửa Sổ Ngang";
            // 
            // cửaSổDọcToolStripMenuItem
            // 
            this.cửaSổDọcToolStripMenuItem.Name = "cửaSổDọcToolStripMenuItem";
            this.cửaSổDọcToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổDọcToolStripMenuItem.Text = "Cửa Sổ Dọc";
            // 
            // cửaSổBìnhThườngToolStripMenuItem
            // 
            this.cửaSổBìnhThườngToolStripMenuItem.Name = "cửaSổBìnhThườngToolStripMenuItem";
            this.cửaSổBìnhThườngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cửaSổBìnhThườngToolStripMenuItem.Text = "Cửa Sổ Bình Thường";
            // 
            // btnnamhoc
            // 
            this.btnnamhoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnnamhoc.Image = global::QLDiemHSTHPT.Properties.Resources.namhoc;
            this.btnnamhoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnnamhoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnamhoc.Name = "btnnamhoc";
            this.btnnamhoc.Size = new System.Drawing.Size(52, 52);
            this.btnnamhoc.Text = "Năm Học";
            // 
            // btnhocky
            // 
            this.btnhocky.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhocky.Image = global::QLDiemHSTHPT.Properties.Resources.hocky;
            this.btnhocky.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnhocky.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhocky.Name = "btnhocky";
            this.btnhocky.Size = new System.Drawing.Size(52, 52);
            this.btnhocky.Text = "Học Kỳ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // btnphancong
            // 
            this.btnphancong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnphancong.Image = global::QLDiemHSTHPT.Properties.Resources.phancong;
            this.btnphancong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnphancong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnphancong.Name = "btnphancong";
            this.btnphancong.Size = new System.Drawing.Size(52, 52);
            this.btnphancong.Text = "Phân công";
            // 
            // btnphanlop
            // 
            this.btnphanlop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnphanlop.Image = global::QLDiemHSTHPT.Properties.Resources.phanlop;
            this.btnphanlop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnphanlop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnphanlop.Name = "btnphanlop";
            this.btnphanlop.Size = new System.Drawing.Size(52, 52);
            this.btnphanlop.Text = "Phân Lớp ";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // btnKQHKMH
            // 
            this.btnKQHKMH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKQHKMH.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKMH;
            this.btnKQHKMH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKQHKMH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKQHKMH.Name = "btnKQHKMH";
            this.btnKQHKMH.Size = new System.Drawing.Size(52, 52);
            this.btnKQHKMH.Text = "KQHKMH";
            // 
            // btnKQHKLop
            // 
            this.btnKQHKLop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKQHKLop.Image = global::QLDiemHSTHPT.Properties.Resources.KQHKLop;
            this.btnKQHKLop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKQHKLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKQHKLop.Name = "btnKQHKLop";
            this.btnKQHKLop.Size = new System.Drawing.Size(52, 52);
            this.btnKQHKLop.Text = "KQHKLop";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // btnKQCNMH
            // 
            this.btnKQCNMH.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKQCNMH.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNMH;
            this.btnKQCNMH.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKQCNMH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKQCNMH.Name = "btnKQCNMH";
            this.btnKQCNMH.Size = new System.Drawing.Size(52, 52);
            this.btnKQCNMH.Text = "KQCNMH";
            // 
            // btnKQCNLop
            // 
            this.btnKQCNLop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKQCNLop.Image = global::QLDiemHSTHPT.Properties.Resources.KQCNLop;
            this.btnKQCNLop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnKQCNLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKQCNLop.Name = "btnKQCNLop";
            this.btnKQCNLop.Size = new System.Drawing.Size(52, 52);
            this.btnKQCNLop.Text = "KQCNLop";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // btnhocsinh
            // 
            this.btnhocsinh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhocsinh.Image = global::QLDiemHSTHPT.Properties.Resources.hocsinh1;
            this.btnhocsinh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnhocsinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhocsinh.Name = "btnhocsinh";
            this.btnhocsinh.Size = new System.Drawing.Size(52, 52);
            this.btnhocsinh.Text = "Học sinh";
            // 
            // btngiaovien
            // 
            this.btngiaovien.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btngiaovien.Image = global::QLDiemHSTHPT.Properties.Resources.giaovien;
            this.btngiaovien.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btngiaovien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btngiaovien.Name = "btngiaovien";
            this.btngiaovien.Size = new System.Drawing.Size(52, 52);
            this.btngiaovien.Text = "Giáo Viên";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // btnTTTruong
            // 
            this.btnTTTruong.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTTTruong.Image = global::QLDiemHSTHPT.Properties.Resources.TTTH;
            this.btnTTTruong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTTTruong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTTTruong.Name = "btnTTTruong";
            this.btnTTTruong.Size = new System.Drawing.Size(52, 52);
            this.btnTTTruong.Text = "TT Trường";
            // 
            // btnTTPM
            // 
            this.btnTTPM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTTPM.Image = global::QLDiemHSTHPT.Properties.Resources.TTPM;
            this.btnTTPM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTTPM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTTPM.Name = "btnTTPM";
            this.btnTTPM.Size = new System.Drawing.Size(52, 52);
            this.btnTTPM.Text = "TT Phần Mềm";
            this.btnTTPM.Click += new System.EventHandler(this.btnTTPM_Click);
            // 
            // tbtnhocsinh
            // 
            this.tbtnhocsinh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnhocsinh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnhocsinh.Name = "tbtnhocsinh";
            this.tbtnhocsinh.Size = new System.Drawing.Size(23, 22);
            this.tbtnhocsinh.Text = "Học sinh";
            // 
            // tabStrip
            // 
            this.tabStrip.AutoSelectAttachedControl = true;
            this.tabStrip.CanReorderTabs = true;
            this.tabStrip.CloseButtonOnTabsVisible = true;
            this.tabStrip.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabStrip.CloseButtonVisible = false;
            this.tabStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabStrip.Location = new System.Drawing.Point(0, 24);
            this.tabStrip.MdiForm = this;
            this.tabStrip.MdiTabbedDocuments = true;
            this.tabStrip.Name = "tabStrip";
            this.tabStrip.SelectedTab = null;
            this.tabStrip.SelectedTabFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabStrip.Size = new System.Drawing.Size(933, 29);
            this.tabStrip.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabStrip.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Top;
            this.tabStrip.TabIndex = 22;
            this.tabStrip.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabStrip.Text = "tabStrip";
            // 
            // panelTacvu
            // 
            this.panelTacvu.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelTacvu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelTacvu.Controls.Add(this.expelTracuu);
            this.panelTacvu.Controls.Add(this.expelquanly);
            this.panelTacvu.Controls.Add(this.expanelHethong);
            this.panelTacvu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTacvu.Location = new System.Drawing.Point(0, 53);
            this.panelTacvu.Name = "panelTacvu";
            this.panelTacvu.Size = new System.Drawing.Size(226, 619);
            this.panelTacvu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelTacvu.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelTacvu.Style.GradientAngle = 90;
            this.panelTacvu.StyleMouseDown.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.Alignment = System.Drawing.StringAlignment.Center;
            this.panelTacvu.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.panelTacvu.StyleMouseOver.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemHotText;
            this.panelTacvu.TabIndex = 23;
            // 
            // expelTracuu
            // 
            this.expelTracuu.CanvasColor = System.Drawing.SystemColors.Control;
            this.expelTracuu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expelTracuu.Controls.Add(this.buttonTCGV);
            this.expelTracuu.Controls.Add(this.buttonTCHS);
            this.expelTracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expelTracuu.Location = new System.Drawing.Point(14, 397);
            this.expelTracuu.Name = "expelTracuu";
            this.expelTracuu.Size = new System.Drawing.Size(192, 133);
            this.expelTracuu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expelTracuu.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expelTracuu.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expelTracuu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelTracuu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expelTracuu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expelTracuu.Style.GradientAngle = 90;
            this.expelTracuu.TabIndex = 2;
            this.expelTracuu.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expelTracuu.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expelTracuu.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expelTracuu.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expelTracuu.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expelTracuu.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expelTracuu.TitleStyle.GradientAngle = 90;
            this.expelTracuu.TitleText = "Tra Cứu";
            // 
            // buttonTCGV
            // 
            this.buttonTCGV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTCGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTCGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTCGV.Location = new System.Drawing.Point(24, 86);
            this.buttonTCGV.Name = "buttonTCGV";
            this.buttonTCGV.Size = new System.Drawing.Size(142, 27);
            this.buttonTCGV.TabIndex = 13;
            this.buttonTCGV.Text = "Tra Cứu GV";
            this.buttonTCGV.Tooltip = "Tra Cứu GV";
            this.buttonTCGV.Click += new System.EventHandler(this.buttonTCGV_Click);
            // 
            // buttonTCHS
            // 
            this.buttonTCHS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTCHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTCHS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTCHS.Location = new System.Drawing.Point(22, 42);
            this.buttonTCHS.Name = "buttonTCHS";
            this.buttonTCHS.Size = new System.Drawing.Size(144, 27);
            this.buttonTCHS.TabIndex = 12;
            this.buttonTCHS.Text = "Tra Cứu HS";
            this.buttonTCHS.Tooltip = "Tra Cứu HS";
            this.buttonTCHS.Click += new System.EventHandler(this.buttonTCHS_Click);
            // 
            // expelquanly
            // 
            this.expelquanly.CanvasColor = System.Drawing.SystemColors.Control;
            this.expelquanly.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expelquanly.Controls.Add(this.buttonGV);
            this.expelquanly.Controls.Add(this.buttonHocSinh);
            this.expelquanly.Controls.Add(this.buttonPCong);
            this.expelquanly.Controls.Add(this.buttonPLop);
            this.expelquanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expelquanly.Location = new System.Drawing.Point(12, 183);
            this.expelquanly.Name = "expelquanly";
            this.expelquanly.Size = new System.Drawing.Size(192, 196);
            this.expelquanly.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expelquanly.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expelquanly.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expelquanly.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expelquanly.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expelquanly.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expelquanly.Style.GradientAngle = 90;
            this.expelquanly.TabIndex = 1;
            this.expelquanly.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expelquanly.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expelquanly.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expelquanly.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expelquanly.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expelquanly.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expelquanly.TitleStyle.GradientAngle = 90;
            this.expelquanly.TitleText = "Quản Lý";
            // 
            // buttonGV
            // 
            this.buttonGV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonGV.Location = new System.Drawing.Point(22, 77);
            this.buttonGV.Name = "buttonGV";
            this.buttonGV.Size = new System.Drawing.Size(144, 30);
            this.buttonGV.TabIndex = 9;
            this.buttonGV.Text = "Giáo Viên";
            this.buttonGV.Tooltip = "Giáo Viên";
            this.buttonGV.Click += new System.EventHandler(this.buttonGV_Click);
            // 
            // buttonHocSinh
            // 
            this.buttonHocSinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonHocSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHocSinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonHocSinh.Location = new System.Drawing.Point(22, 41);
            this.buttonHocSinh.Name = "buttonHocSinh";
            this.buttonHocSinh.Size = new System.Drawing.Size(144, 30);
            this.buttonHocSinh.TabIndex = 8;
            this.buttonHocSinh.Text = "Học Sinh";
            this.buttonHocSinh.Tooltip = "Học Sinh";
            this.buttonHocSinh.Click += new System.EventHandler(this.buttonHocSinh_Click);
            // 
            // buttonPCong
            // 
            this.buttonPCong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPCong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPCong.Location = new System.Drawing.Point(22, 112);
            this.buttonPCong.Name = "buttonPCong";
            this.buttonPCong.Size = new System.Drawing.Size(144, 30);
            this.buttonPCong.TabIndex = 5;
            this.buttonPCong.Text = "Phân Công";
            this.buttonPCong.Tooltip = "Phân Công";
            this.buttonPCong.Click += new System.EventHandler(this.buttonPCong_Click);
            // 
            // buttonPLop
            // 
            this.buttonPLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonPLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonPLop.Location = new System.Drawing.Point(22, 148);
            this.buttonPLop.Name = "buttonPLop";
            this.buttonPLop.Size = new System.Drawing.Size(144, 30);
            this.buttonPLop.TabIndex = 4;
            this.buttonPLop.Text = "Phân Lớp";
            this.buttonPLop.Tooltip = "Phân Lớp";
            this.buttonPLop.Click += new System.EventHandler(this.buttonPLop_Click);
            // 
            // expanelHethong
            // 
            this.expanelHethong.CanvasColor = System.Drawing.SystemColors.Control;
            this.expanelHethong.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expanelHethong.Controls.Add(this.buttonthoat);
            this.expanelHethong.Controls.Add(this.buttondangnhap);
            this.expanelHethong.Controls.Add(this.buttondangxuat);
            this.expanelHethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expanelHethong.Location = new System.Drawing.Point(12, 15);
            this.expanelHethong.Name = "expanelHethong";
            this.expanelHethong.Size = new System.Drawing.Size(194, 154);
            this.expanelHethong.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expanelHethong.Style.BackColor1.Color = System.Drawing.Color.White;
            this.expanelHethong.Style.BackColor2.Color = System.Drawing.SystemColors.ActiveCaption;
            this.expanelHethong.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expanelHethong.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expanelHethong.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expanelHethong.Style.GradientAngle = 90;
            this.expanelHethong.TabIndex = 0;
            this.expanelHethong.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expanelHethong.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expanelHethong.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expanelHethong.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expanelHethong.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expanelHethong.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expanelHethong.TitleStyle.GradientAngle = 90;
            this.expanelHethong.TitleText = "Hệ Thống";
            // 
            // buttonthoat
            // 
            this.buttonthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonthoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            this.buttonthoat.Location = new System.Drawing.Point(24, 111);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(144, 28);
            this.buttonthoat.TabIndex = 3;
            this.buttonthoat.Text = "Thoát";
            this.buttonthoat.Tooltip = "Thoát";
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // buttondangnhap
            // 
            this.buttondangnhap.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttondangnhap.Image = global::QLDiemHSTHPT.Properties.Resources.dangnhapcontext;
            this.buttondangnhap.Location = new System.Drawing.Point(24, 39);
            this.buttondangnhap.Name = "buttondangnhap";
            this.buttondangnhap.Size = new System.Drawing.Size(144, 30);
            this.buttondangnhap.TabIndex = 2;
            this.buttondangnhap.Text = "Đăng Nhập";
            this.buttondangnhap.Tooltip = "Đăng Xuất";
            this.buttondangnhap.Click += new System.EventHandler(this.buttondangnhap_Click);
            // 
            // buttondangxuat
            // 
            this.buttondangxuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttondangxuat.Image = global::QLDiemHSTHPT.Properties.Resources.dangxuatcontext;
            this.buttondangxuat.Location = new System.Drawing.Point(24, 75);
            this.buttondangxuat.Name = "buttondangxuat";
            this.buttondangxuat.Size = new System.Drawing.Size(144, 30);
            this.buttondangxuat.TabIndex = 1;
            this.buttondangxuat.Text = "Đăng Xuất";
            this.buttondangxuat.Tooltip = "Đăng Xuất";
            this.buttondangxuat.Click += new System.EventHandler(this.buttondangxuat_Click);
            // 
            // backupDialog
            // 
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLDiemHSTHPT.BAK";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "Sao Lưu Dữ Liệu";
            // 
            // restoreDialog
            // 
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLDiemHSTHPT.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";
            // 
            // office2007StartButton3
            // 
            this.office2007StartButton3.AutoExpandOnClick = true;
            this.office2007StartButton3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton3.ImagePaddingHorizontal = 2;
            this.office2007StartButton3.ImagePaddingVertical = 2;
            this.office2007StartButton3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleIfRecentlyUsed;
            this.office2007StartButton3.Name = "office2007StartButton3";
            this.office2007StartButton3.ShowSubItems = false;
            this.office2007StartButton3.StopPulseOnMouseOver = false;
            this.office2007StartButton3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer8});
            this.office2007StartButton3.Text = "Start";
            this.office2007StartButton3.Tooltip = "Start";
            // 
            // itemContainer8
            // 
            // 
            // 
            // 
            this.itemContainer8.BackgroundStyle.Class = "RibbonFileMenuContainer";
            this.itemContainer8.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer8.Name = "itemContainer8";
            this.itemContainer8.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer12});
            // 
            // itemContainer12
            // 
            // 
            // 
            // 
            this.itemContainer12.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer";
            this.itemContainer12.ItemSpacing = 0;
            this.itemContainer12.Name = "itemContainer12";
            this.itemContainer12.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer13});
            // 
            // itemContainer13
            // 
            // 
            // 
            // 
            this.itemContainer13.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer";
            this.itemContainer13.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer13.MinimumSize = new System.Drawing.Size(120, 0);
            this.itemContainer13.Name = "itemContainer13";
            this.itemContainer13.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem21,
            this.buttonItem22,
            this.buttonItem23,
            this.buttonItem24,
            this.buttonItem25,
            this.buttonItem26});
            // 
            // buttonItem1
            // 
            this.buttonItem1.BeginGroup = true;
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.PopupWidth = 100;
            this.buttonItem1.Text = "Đăng Nhập";
            this.buttonItem1.Tooltip = "Đăng nhập";
            // 
            // buttonItem21
            // 
            this.buttonItem21.AutoCheckOnClick = true;
            this.buttonItem21.BeginGroup = true;
            this.buttonItem21.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem21.ImagePaddingHorizontal = 8;
            this.buttonItem21.Name = "buttonItem21";
            this.buttonItem21.SubItemsExpandWidth = 24;
            this.buttonItem21.Text = "Đăng Xuất";
            this.buttonItem21.Tooltip = "Đăng Xuất";
            // 
            // buttonItem22
            // 
            this.buttonItem22.BeginGroup = true;
            this.buttonItem22.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem22.ImagePaddingHorizontal = 8;
            this.buttonItem22.Name = "buttonItem22";
            this.buttonItem22.SubItemsExpandWidth = 24;
            this.buttonItem22.Text = "Đổi mật khẩu";
            this.buttonItem22.Tooltip = "Đổi mật khẩu";
            // 
            // buttonItem23
            // 
            this.buttonItem23.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem23.ImagePaddingHorizontal = 8;
            this.buttonItem23.Name = "buttonItem23";
            this.buttonItem23.Text = "Quản lý người dùng";
            this.buttonItem23.Tooltip = "Quản lý người dùng";
            // 
            // buttonItem24
            // 
            this.buttonItem24.BeginGroup = true;
            this.buttonItem24.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem24.ImagePaddingHorizontal = 8;
            this.buttonItem24.Name = "buttonItem24";
            this.buttonItem24.SubItemsExpandWidth = 24;
            this.buttonItem24.Text = "Sao lưu dữ liệu";
            this.buttonItem24.Tooltip = "Sao lưu dữ liệu";
            // 
            // buttonItem25
            // 
            this.buttonItem25.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem25.ImagePaddingHorizontal = 8;
            this.buttonItem25.Name = "buttonItem25";
            this.buttonItem25.SubItemsExpandWidth = 24;
            this.buttonItem25.Text = "Phục hồi dữ liệu";
            this.buttonItem25.Tooltip = "Phục hồi dữ liệu";
            // 
            // buttonItem26
            // 
            this.buttonItem26.BeginGroup = true;
            this.buttonItem26.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem26.ImagePaddingHorizontal = 8;
            this.buttonItem26.Name = "buttonItem26";
            this.buttonItem26.SubItemsExpandWidth = 24;
            this.buttonItem26.Text = "Thoát";
            this.buttonItem26.Tooltip = "Thoát";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.BackgroundImage = global::QLDiemHSTHPT.Properties.Resources._5196225935_de5b6556cc_z;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 721);
            this.Controls.Add(this.panelTacvu);
            this.Controls.Add(this.tabStrip);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỂM HỌC SINH TRUNG HỌC PHỔ THÔNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bottomBar)).EndInit();
            this.bottomBar.ResumeLayout(false);
            this.bottomBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTacvu.ResumeLayout(false);
            this.expelTracuu.ResumeLayout(false);
            this.expelquanly.ResumeLayout(false);
            this.expanelHethong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton2;
        private DevComponents.DotNetBar.ItemContainer itemContainer5;
        private DevComponents.DotNetBar.ItemContainer itemContainer6;
        private DevComponents.DotNetBar.ItemContainer itemContainer7;
        private DevComponents.DotNetBar.ButtonItem buttonItem15;
        private DevComponents.DotNetBar.ButtonItem buttonItem16;
        private DevComponents.DotNetBar.ButtonItem buttonItem17;
        private DevComponents.DotNetBar.ButtonItem buttonItem18;
        private DevComponents.DotNetBar.ButtonItem buttonItem19;
        private DevComponents.DotNetBar.ButtonItem buttonItem20;
        private DevComponents.DotNetBar.ButtonItem buttonItem14;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer2;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer3;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.Bar bottomBar;
        private DevComponents.DotNetBar.LabelX lblTenNguoiDung;
        private DevComponents.DotNetBar.LabelX lbNguoidung;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem8;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem buttonItem11;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.ButtonItem buttonItem12;
        private DevComponents.DotNetBar.ButtonItem buttonItem13;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabGiupdo;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuydinh;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabTracuu;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabThongKe;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.ButtonItem btnDangnhap;
        private DevComponents.DotNetBar.ButtonItem btnDangxuat;
        private DevComponents.DotNetBar.ButtonItem btnDoimatkhau;
        private DevComponents.DotNetBar.ButtonItem btnQlyND;
        private DevComponents.DotNetBar.ButtonItem btnSaoluudl;
        private DevComponents.DotNetBar.ButtonItem btnPhuchoidl;
        private DevComponents.DotNetBar.ButtonItem btnThoat;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton5;
        private DevComponents.DotNetBar.ItemContainer itemContainer17;
        private DevComponents.DotNetBar.ItemContainer itemContainer18;
        private DevComponents.DotNetBar.ItemContainer itemContainer19;
        private DevComponents.DotNetBar.ButtonItem buttonItem34;
        private DevComponents.DotNetBar.ButtonItem buttonItem35;
        private DevComponents.DotNetBar.ButtonItem buttonItem36;
        private DevComponents.DotNetBar.ButtonItem buttonItem37;
        private DevComponents.DotNetBar.ButtonItem buttonItem38;
        private DevComponents.DotNetBar.ButtonItem buttonItem39;
        private DevComponents.DotNetBar.ButtonItem buttonItem40;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabQuanLy1;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer4;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýToolStripMenuItem;
        private ToolStripMenuItem thốngKêToolStripMenuItem;
        private ToolStripMenuItem traCứuToolStripMenuItem;
        private ToolStripMenuItem quyĐịnhToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripMenuItem khốiLớpToolStripMenuItem;
        private ToolStripMenuItem lớpHọcToolStripMenuItem;
        private ToolStripMenuItem họcKỳToolStripMenuItem;
        private ToolStripMenuItem nămHọcToolStripMenuItem;
        private ToolStripMenuItem mônHọcToolStripMenuItem;
        private ToolStripMenuItem điểmToolStripMenuItem;
        private ToolStripMenuItem kếtQuảToolStripMenuItem;
        private ToolStripMenuItem họcLựcToolStripMenuItem;
        private ToolStripMenuItem hạnhKiểmToolStripMenuItem;
        private ToolStripMenuItem họcSinhToolStripMenuItem;
        private ToolStripMenuItem phânLớpToolStripMenuItem;
        private ToolStripMenuItem dânTộcToolStripMenuItem;
        private ToolStripMenuItem tônGiáoToolStripMenuItem;
        private ToolStripMenuItem nghềNghiệpToolStripMenuItem;
        private ToolStripMenuItem giáoViênToolStripMenuItem;
        private ToolStripMenuItem phânCôngToolStripMenuItem;
        private ToolStripButton btnnamhoc;
        private ToolStripMenuItem kếtQuảHọcKỳToolStripMenuItem;
        private ToolStripMenuItem kếtQuảHọcKỳTheoMônHọcToolStripMenuItem;
        private ToolStripMenuItem kếtQuảHọcKỳTheoLớpToolStripMenuItem;
        private ToolStripMenuItem kếtQuảCảNămToolStripMenuItem;
        private ToolStripMenuItem kếtQuảCảNămTheoMônHọcToolStripMenuItem;
        private ToolStripMenuItem xuấtDanhSáchToolStripMenuItem;
        private ToolStripMenuItem kếtQuảCảNămTheoLớpHọcToolStripMenuItem;
        private ToolStripMenuItem danhSáchGiáoViênToolStripMenuItem;
        private ToolStripMenuItem danhSáchHọcSinhToolStripMenuItem;
        private ToolStripMenuItem danhSáchLớpHọcToolStripMenuItem;
        private ToolStripMenuItem traCứuGiáoViênToolStripMenuItem;
        private ToolStripMenuItem traCứuHọcSinhToolStripMenuItem;
        private ToolStripMenuItem quyĐịnhVềĐộTuổiToolStripMenuItem;
        private ToolStripMenuItem quyĐịnhVềThangĐiểmToolStripMenuItem;
        private ToolStripMenuItem quyĐịnhVềSỉSốToolStripMenuItem;
        private ToolStripMenuItem thôngTinTrườngHọcToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private ToolStripButton btnhocky;
        private ToolStripButton btnphancong;
        private ToolStripButton btnphanlop;
        private ToolStripButton btnKQHKMH;
        private ToolStripButton btnKQCNMH;
        private ToolStripButton btnKQCNLop;
        private ToolStripButton btnKQHKLop;
        private ToolStripButton tbtnhocsinh;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnhocsinh;
        private ToolStripButton btngiaovien;
        private ToolStripMenuItem hiểnThịToolStripMenuItem;
        private ToolStripMenuItem thanhtacvu;
        private ToolStripMenuItem thanhCôngCụToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem cửaSổNgangToolStripMenuItem;
        private ToolStripMenuItem cửaSổDọcToolStripMenuItem;
        private ToolStripMenuItem cửaSổBìnhThườngToolStripMenuItem;
        private DevComponents.DotNetBar.TabStrip tabStrip;
        private DevComponents.DotNetBar.PanelEx panelTacvu;
        private DevComponents.DotNetBar.ExpandablePanel expanelHethong;
        private DevComponents.DotNetBar.ExpandablePanel expelquanly;
        private DevComponents.DotNetBar.ButtonX buttondangxuat;
        private DevComponents.DotNetBar.ButtonX buttonthoat;
        private DevComponents.DotNetBar.ButtonX buttondangnhap;
        private DevComponents.DotNetBar.ButtonX buttonPCong;
        private DevComponents.DotNetBar.ButtonX buttonPLop;
        private DevComponents.DotNetBar.ButtonX buttonGV;
        private DevComponents.DotNetBar.ButtonX buttonHocSinh;
        private DevComponents.DotNetBar.ExpandablePanel expelTracuu;
        private DevComponents.DotNetBar.ButtonX buttonTCGV;
        private DevComponents.DotNetBar.ButtonX buttonTCHS;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton btnTTTruong;
        private ToolStripButton btnTTPM;
        private DevComponents.DotNetBar.LabelX lblND;
        private SaveFileDialog backupDialog;
        private OpenFileDialog restoreDialog;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton4;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton3;
        private DevComponents.DotNetBar.ItemContainer itemContainer8;
        private DevComponents.DotNetBar.ItemContainer itemContainer12;
        private DevComponents.DotNetBar.ItemContainer itemContainer13;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem21;
        private DevComponents.DotNetBar.ButtonItem buttonItem22;
        private DevComponents.DotNetBar.ButtonItem buttonItem23;
        private DevComponents.DotNetBar.ButtonItem buttonItem24;
        private DevComponents.DotNetBar.ButtonItem buttonItem25;
        private DevComponents.DotNetBar.ButtonItem buttonItem26;
        private DevComponents.DotNetBar.ItemContainer itemContainer9;
        private DevComponents.DotNetBar.ItemContainer itemContainer10;
        private DevComponents.DotNetBar.ItemContainer itemContainer11;
        private DevComponents.DotNetBar.ButtonItem buttonItem29;
        private DevComponents.DotNetBar.ButtonItem buttonItem30;
        private DevComponents.DotNetBar.ButtonItem buttonItem31;
        private DevComponents.DotNetBar.ButtonItem buttonItem32;
        private DevComponents.DotNetBar.ButtonItem buttonItem33;
        private ToolStripMenuItem toolStripMenuItem46;
        private ToolStripMenuItem toolStripMenuItem47;
        private ToolStripMenuItem toolStripMenuItem48;
        private ToolStripMenuItem toolStripMenuItem49;
        private ToolStripMenuItem toolStripMenuItem50;
        private ToolStripMenuItem toolStripMenuItem51;
        private ToolStripMenuItem toolStripMenuItem52;
        private ToolStripMenuItem toolStripMenuItem53;
        private ToolStripMenuItem toolStripMenuItem54;
        private ToolStripMenuItem toolStripMenuItem55;
        private ToolStripMenuItem toolStripMenuItem58;
        private ToolStripMenuItem toolStripMenuItem59;
        private ToolStripMenuItem toolStripMenuItem60;
        private ToolStripMenuItem toolStripMenuItem63;
        private ToolStripMenuItem toolStripMenuItem64;
        private ToolStripMenuItem toolStripMenuItem65;
        private ToolStripMenuItem toolStripMenuItem66;
        private ToolStripMenuItem toolStripMenuItem67;
        private ToolStripMenuItem toolStripMenuItem68;
        private ToolStripMenuItem toolStripMenuItem69;
        private ToolStripMenuItem toolStripMenuItem70;
        private ToolStripMenuItem toolStripMenuItem71;
        private ToolStripMenuItem toolStripMenuItem72;
        private ToolStripMenuItem toolStripMenuItem73;
        private ToolStripMenuItem toolStripMenuItem77;
        private ToolStripMenuItem toolStripMenuItem78;
        private ToolStripMenuItem toolStripMenuItem79;
        private ToolStripMenuItem toolStripMenuItem80;
        private ToolStripMenuItem toolStripMenuItem81;
        private ToolStripMenuItem toolStripMenuItem83;
        private ToolStripMenuItem toolStripMenuItem84;
        private ToolStripMenuItem toolStripMenuItem1;


    }
}