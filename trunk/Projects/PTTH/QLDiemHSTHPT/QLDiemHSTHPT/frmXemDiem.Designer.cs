namespace QLDiemHSTHPT
{
    partial class frmXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDiem));
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmbMaHS = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cmbHocsinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHocsinh = new DevComponents.DotNetBar.LabelX();
            this.cmblop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocky = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbMonhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbmnamhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblnamHoc = new DevComponents.DotNetBar.LabelX();
            this.btnNhapdiemchung = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel3 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.lvdiem = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colSTT = new System.Windows.Forms.ColumnHeader();
            this.colMaHocSinh = new System.Windows.Forms.ColumnHeader();
            this.colTenHS = new System.Windows.Forms.ColumnHeader();
            this.colMonhoc = new System.Windows.Forms.ColumnHeader();
            this.colLoaiDiem = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.bdgNhapdiemrieng = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.nvgPanelGiaoVien.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupBoxDsgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNhapdiemrieng)).BeginInit();
            this.bdgNhapdiemrieng.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvgPanelGiaoVien
            // 
            this.nvgPanelGiaoVien.CanCollapse = true;
            this.nvgPanelGiaoVien.Controls.Add(this.navigationPanePanel1);
            this.nvgPanelGiaoVien.Controls.Add(this.navigationPanePanel2);
            this.nvgPanelGiaoVien.Controls.Add(this.navigationPanePanel3);
            this.nvgPanelGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvgPanelGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.ItemPaddingBottom = 2;
            this.nvgPanelGiaoVien.ItemPaddingTop = 2;
            this.nvgPanelGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNhapdiemchung,
            this.buttonItem1,
            this.buttonItem2});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.NavigationBarHeight = 67;
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(210, 443);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TabIndex = 10;
            // 
            // 
            // 
            this.nvgPanelGiaoVien.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nvgPanelGiaoVien.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.nvgPanelGiaoVien.TitlePanel.Name = "panelTitle";
            this.nvgPanelGiaoVien.TitlePanel.Size = new System.Drawing.Size(208, 24);
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nvgPanelGiaoVien.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.nvgPanelGiaoVien.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.nvgPanelGiaoVien.TitlePanel.Style.GradientAngle = 90;
            this.nvgPanelGiaoVien.TitlePanel.Style.MarginLeft = 4;
            this.nvgPanelGiaoVien.TitlePanel.TabIndex = 0;
            this.nvgPanelGiaoVien.TitlePanel.Text = "Nhập thông tin điểm";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.cmbMaHS);
            this.navigationPanePanel1.Controls.Add(this.labelX4);
            this.navigationPanePanel1.Controls.Add(this.buttonX1);
            this.navigationPanePanel1.Controls.Add(this.cmbHocsinh);
            this.navigationPanePanel1.Controls.Add(this.lblHocsinh);
            this.navigationPanePanel1.Controls.Add(this.cmblop);
            this.navigationPanePanel1.Controls.Add(this.labelX3);
            this.navigationPanePanel1.Controls.Add(this.cmbHocky);
            this.navigationPanePanel1.Controls.Add(this.labelX2);
            this.navigationPanePanel1.Controls.Add(this.cmbMonhoc);
            this.navigationPanePanel1.Controls.Add(this.labelX1);
            this.navigationPanePanel1.Controls.Add(this.cbmnamhoc);
            this.navigationPanePanel1.Controls.Add(this.lblnamHoc);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnNhapdiemchung;
            this.navigationPanePanel1.Size = new System.Drawing.Size(208, 350);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(19, 197);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 36;
            this.labelX4.Text = "Mã HS:";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonX1.Location = new System.Drawing.Point(28, 314);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(140, 23);
            this.buttonX1.TabIndex = 35;
            this.buttonX1.Text = "Hiển thị danh sách";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // cmbHocsinh
            // 
            this.cmbHocsinh.DisplayMember = "Text";
            this.cmbHocsinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocsinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocsinh.FormattingEnabled = true;
            this.cmbHocsinh.ItemHeight = 14;
            this.cmbHocsinh.Location = new System.Drawing.Point(19, 275);
            this.cmbHocsinh.Name = "cmbHocsinh";
            this.cmbHocsinh.Size = new System.Drawing.Size(149, 20);
            this.cmbHocsinh.TabIndex = 34;
            // 
            // lblHocsinh
            // 
            this.lblHocsinh.Location = new System.Drawing.Point(19, 246);
            this.lblHocsinh.Name = "lblHocsinh";
            this.lblHocsinh.Size = new System.Drawing.Size(75, 23);
            this.lblHocsinh.TabIndex = 33;
            this.lblHocsinh.Text = "Học sinh:";
            // 

            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(19, 62);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "Lớp:";
            // 
            // cmbHocky
            // 
            this.cmbHocky.DisplayMember = "Text";
            this.cmbHocky.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocky.FormattingEnabled = true;
            this.cmbHocky.ItemHeight = 14;
            this.cmbHocky.Location = new System.Drawing.Point(19, 126);
            this.cmbHocky.Name = "cmbHocky";
            this.cmbHocky.Size = new System.Drawing.Size(149, 20);
            this.cmbHocky.TabIndex = 27;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(19, 107);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 26;
            this.labelX2.Text = "Học kỳ:";
            // 
            // cmbMonhoc
            // 
            this.cmbMonhoc.DisplayMember = "Text";
            this.cmbMonhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonhoc.FormattingEnabled = true;
            this.cmbMonhoc.ItemHeight = 14;
            this.cmbMonhoc.Location = new System.Drawing.Point(19, 171);
            this.cmbMonhoc.Name = "cmbMonhoc";
            this.cmbMonhoc.Size = new System.Drawing.Size(149, 20);
            this.cmbMonhoc.TabIndex = 24;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(19, 152);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "Môn học:";
            // 
            // cbmnamhoc
            // 
            this.cbmnamhoc.DisplayMember = "Text";
            this.cbmnamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbmnamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmnamhoc.FormattingEnabled = true;
            this.cbmnamhoc.ItemHeight = 14;
            this.cbmnamhoc.Location = new System.Drawing.Point(19, 36);
            this.cbmnamhoc.Name = "cbmnamhoc";
            this.cbmnamhoc.Size = new System.Drawing.Size(149, 20);
            this.cbmnamhoc.TabIndex = 20;
            // 
            // lblnamHoc
            // 
            this.lblnamHoc.Location = new System.Drawing.Point(19, 17);
            this.lblnamHoc.Name = "lblnamHoc";
            this.lblnamHoc.Size = new System.Drawing.Size(75, 23);
            this.lblnamHoc.TabIndex = 19;
            this.lblnamHoc.Text = "Khóa Học:";
            // 
            // btnNhapdiemchung
            // 
            this.btnNhapdiemchung.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNhapdiemchung.Checked = true;
            this.btnNhapdiemchung.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnNhapdiemchung.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapdiemchung.Image")));
            this.btnNhapdiemchung.ImagePaddingHorizontal = 8;
            this.btnNhapdiemchung.Name = "btnNhapdiemchung";
            this.btnNhapdiemchung.OptionGroup = "navBar";
            this.btnNhapdiemchung.Text = "Nhập thông tin điểm";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.buttonItem1;
            this.navigationPanePanel2.Size = new System.Drawing.Size(208, 374);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // navigationPanePanel3
            // 
            this.navigationPanePanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel3.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel3.Name = "navigationPanePanel3";
            this.navigationPanePanel3.ParentItem = this.buttonItem2;
            this.navigationPanePanel3.Size = new System.Drawing.Size(208, 374);
            this.navigationPanePanel3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel3.Style.GradientAngle = 90;
            this.navigationPanePanel3.TabIndex = 4;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem2.Image")));
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.OptionGroup = "navBar";
            this.buttonItem2.Text = "buttonItem2";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.Controls.Add(this.lvdiem);
            this.groupBoxDsgv.Controls.Add(this.bdgNhapdiemrieng);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Location = new System.Drawing.Point(210, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(719, 443);
            this.groupBoxDsgv.TabIndex = 11;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Danh Sách Hiển Thị";
            // 
            // lvdiem
            // 
            // 
            // 
            // 
            this.lvdiem.Border.Class = "ListViewBorder";
            this.lvdiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMaHocSinh,
            this.colTenHS,
            this.colMonhoc,
            this.colLoaiDiem,
            this.colDiem});
            this.lvdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvdiem.FullRowSelect = true;
            this.lvdiem.Location = new System.Drawing.Point(3, 41);
            this.lvdiem.Name = "lvdiem";
            this.lvdiem.Size = new System.Drawing.Size(713, 399);
            this.lvdiem.TabIndex = 12;
            this.lvdiem.UseCompatibleStateImageBehavior = false;
            this.lvdiem.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            this.colSTT.Width = 0;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.Text = "Mã học sinh";
            this.colMaHocSinh.Width = 0;
            // 
            // colTenHS
            // 
            this.colTenHS.Text = "Tên Học Sinh";
            this.colTenHS.Width = 0;
            // 
            // colMonhoc
            // 
            this.colMonhoc.Text = "Môn học";
            this.colMonhoc.Width = 0;
            // 
            // colLoaiDiem
            // 
            this.colLoaiDiem.Text = "Loại điểm";
            this.colLoaiDiem.Width = 100;
            // 
            // colDiem
            // 
            this.colDiem.Text = "Điểm";
            this.colDiem.Width = 100;
            // 
            // bdgNhapdiemrieng
            // 
            this.bdgNhapdiemrieng.AddNewItem = null;
            this.bdgNhapdiemrieng.CountItem = null;
            this.bdgNhapdiemrieng.CountItemFormat = "của {0}";
            this.bdgNhapdiemrieng.DeleteItem = null;
            this.bdgNhapdiemrieng.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnxoa,
            this.bngthoat});
            this.bdgNhapdiemrieng.Location = new System.Drawing.Point(3, 16);
            this.bdgNhapdiemrieng.MoveFirstItem = null;
            this.bdgNhapdiemrieng.MoveLastItem = null;
            this.bdgNhapdiemrieng.MoveNextItem = null;
            this.bdgNhapdiemrieng.MovePreviousItem = null;
            this.bdgNhapdiemrieng.Name = "bdgNhapdiemrieng";
            this.bdgNhapdiemrieng.PositionItem = null;
            this.bdgNhapdiemrieng.Size = new System.Drawing.Size(713, 25);
            this.bdgNhapdiemrieng.TabIndex = 0;
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(124, 22);
            this.btnxoa.Text = "Xóa dòng đã chọn";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // bngthoat
            // 
            this.bngthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            this.bngthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngthoat.Name = "bngthoat";
            this.bngthoat.Size = new System.Drawing.Size(58, 22);
            this.bngthoat.Text = "Thoát";
            this.bngthoat.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 443);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXemDiem";
            this.Text = "Xem Điểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.nvgPanelGiaoVien.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupBoxDsgv.ResumeLayout(false);
            this.groupBoxDsgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNhapdiemrieng)).EndInit();
            this.bdgNhapdiemrieng.ResumeLayout(false);
            this.bdgNhapdiemrieng.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane nvgPanelGiaoVien;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmblop;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocky;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonhoc;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbmnamhoc;
        private DevComponents.DotNetBar.LabelX lblnamHoc;
        private DevComponents.DotNetBar.ButtonItem btnNhapdiemchung;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private System.Windows.Forms.BindingNavigator bdgNhapdiemrieng;
        public System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private DevComponents.DotNetBar.Controls.ListViewEx lvdiem;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMaHocSinh;
        private System.Windows.Forms.ColumnHeader colTenHS;
        private System.Windows.Forms.ColumnHeader colMonhoc;
        private System.Windows.Forms.ColumnHeader colLoaiDiem;
        private System.Windows.Forms.ColumnHeader colDiem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocsinh;
        private DevComponents.DotNetBar.LabelX lblHocsinh;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel3;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMaHS;
        private DevComponents.DotNetBar.LabelX labelX4;
    }
}