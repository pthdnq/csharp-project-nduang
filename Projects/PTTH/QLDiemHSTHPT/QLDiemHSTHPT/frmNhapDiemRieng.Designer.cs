namespace QLDiemHSTHPT
{
    partial class frmNhapDiemRieng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapDiemRieng));
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtdiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocsinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblHocsinh = new DevComponents.DotNetBar.LabelX();
            this.cmbloaidiem = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmblop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocky = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbMonhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnHienthiDS = new DevComponents.DotNetBar.ButtonX();
            this.cbmnamhoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblnamHoc = new DevComponents.DotNetBar.LabelX();
            this.btnNhapdiemchung = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.lvdiem = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHocSinh = new System.Windows.Forms.ColumnHeader();
            this.colTenHocSinh = new System.Windows.Forms.ColumnHeader();
            this.colHocky = new System.Windows.Forms.ColumnHeader();
            this.colMonhoc = new System.Windows.Forms.ColumnHeader();
            this.colLoaiDiem = new System.Windows.Forms.ColumnHeader();
            this.colDiem = new System.Windows.Forms.ColumnHeader();
            this.bdgNhapdiemrieng = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnxoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.btnXemdiem = new System.Windows.Forms.ToolStripButton();
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
            this.nvgPanelGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvgPanelGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.ItemPaddingBottom = 2;
            this.nvgPanelGiaoVien.ItemPaddingTop = 2;
            this.nvgPanelGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNhapdiemchung});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.NavigationBarHeight = 67;
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(192, 493);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TabIndex = 9;
            // 
            // 
            // 
            this.nvgPanelGiaoVien.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nvgPanelGiaoVien.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.nvgPanelGiaoVien.TitlePanel.Name = "panelTitle";
            this.nvgPanelGiaoVien.TitlePanel.Size = new System.Drawing.Size(190, 24);
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.nvgPanelGiaoVien.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.nvgPanelGiaoVien.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.nvgPanelGiaoVien.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.nvgPanelGiaoVien.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.nvgPanelGiaoVien.TitlePanel.Style.GradientAngle = 90;
            this.nvgPanelGiaoVien.TitlePanel.Style.MarginLeft = 4;
            this.nvgPanelGiaoVien.TitlePanel.TabIndex = 0;
            this.nvgPanelGiaoVien.TitlePanel.Text = "Nhập thông tin";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.txtdiem);
            this.navigationPanePanel1.Controls.Add(this.labelX4);
            this.navigationPanePanel1.Controls.Add(this.cmbHocsinh);
            this.navigationPanePanel1.Controls.Add(this.lblHocsinh);
            this.navigationPanePanel1.Controls.Add(this.cmbloaidiem);
            this.navigationPanePanel1.Controls.Add(this.labelX5);
            this.navigationPanePanel1.Controls.Add(this.cmblop);
            this.navigationPanePanel1.Controls.Add(this.labelX3);
            this.navigationPanePanel1.Controls.Add(this.cmbHocky);
            this.navigationPanePanel1.Controls.Add(this.labelX2);
            this.navigationPanePanel1.Controls.Add(this.cmbMonhoc);
            this.navigationPanePanel1.Controls.Add(this.labelX1);
            this.navigationPanePanel1.Controls.Add(this.btnHienthiDS);
            this.navigationPanePanel1.Controls.Add(this.cbmnamhoc);
            this.navigationPanePanel1.Controls.Add(this.lblnamHoc);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnNhapdiemchung;
            this.navigationPanePanel1.Size = new System.Drawing.Size(190, 400);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navigationPanePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // txtdiem
            // 
            // 
            // 
            // 
            this.txtdiem.Border.Class = "TextBoxBorder";
            this.txtdiem.Location = new System.Drawing.Point(19, 306);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(149, 20);
            this.txtdiem.TabIndex = 36;
            this.txtdiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdiem_KeyDown);
            this.txtdiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiem_KeyPress);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(19, 287);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 35;
            this.labelX4.Text = "Điểm:";
            // 
            // cmbHocsinh
            // 
            this.cmbHocsinh.DisplayMember = "Text";
            this.cmbHocsinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocsinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocsinh.FormattingEnabled = true;
            this.cmbHocsinh.ItemHeight = 14;
            this.cmbHocsinh.Location = new System.Drawing.Point(19, 216);
            this.cmbHocsinh.Name = "cmbHocsinh";
            this.cmbHocsinh.Size = new System.Drawing.Size(149, 20);
            this.cmbHocsinh.TabIndex = 34;
            // 
            // lblHocsinh
            // 
            this.lblHocsinh.Location = new System.Drawing.Point(19, 197);
            this.lblHocsinh.Name = "lblHocsinh";
            this.lblHocsinh.Size = new System.Drawing.Size(75, 23);
            this.lblHocsinh.TabIndex = 33;
            this.lblHocsinh.Text = "Học sinh:";
            // 
            // cmbloaidiem
            // 
            this.cmbloaidiem.DisplayMember = "Text";
            this.cmbloaidiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbloaidiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloaidiem.FormattingEnabled = true;
            this.cmbloaidiem.ItemHeight = 14;
            this.cmbloaidiem.Location = new System.Drawing.Point(19, 261);
            this.cmbloaidiem.Name = "cmbloaidiem";
            this.cmbloaidiem.Size = new System.Drawing.Size(149, 20);
            this.cmbloaidiem.TabIndex = 32;
            this.cmbloaidiem.SelectedIndexChanged += new System.EventHandler(this.cmbloaidiem_SelectedIndexChanged);
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(19, 242);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 31;
            this.labelX5.Text = "Loại điểm:";
            // 
            // cmblop
            // 
            this.cmblop.DisplayMember = "Text";
            this.cmblop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmblop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblop.FormattingEnabled = true;
            this.cmblop.ItemHeight = 14;
            this.cmblop.Location = new System.Drawing.Point(19, 81);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(149, 20);
            this.cmblop.TabIndex = 30;
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
            // btnHienthiDS
            // 
            this.btnHienthiDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienthiDS.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnHienthiDS.Location = new System.Drawing.Point(19, 341);
            this.btnHienthiDS.Name = "btnHienthiDS";
            this.btnHienthiDS.Size = new System.Drawing.Size(140, 23);
            this.btnHienthiDS.TabIndex = 22;
            this.btnHienthiDS.Text = "Thêm vào danh sách";
            this.btnHienthiDS.Click += new System.EventHandler(this.btnHienthiDS_Click);
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
            this.btnNhapdiemchung.Text = "Nhập thông tin";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.Controls.Add(this.lvdiem);
            this.groupBoxDsgv.Controls.Add(this.bdgNhapdiemrieng);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(732, 493);
            this.groupBoxDsgv.TabIndex = 10;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Danh Sách Nhập Điểm";
            // 
            // lvdiem
            // 
            // 
            // 
            // 
            this.lvdiem.Border.Class = "ListViewBorder";
            this.lvdiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinh,
            this.colTenHocSinh,
            this.colHocky,
            this.colMonhoc,
            this.colLoaiDiem,
            this.colDiem});
            this.lvdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvdiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvdiem.FullRowSelect = true;
            this.lvdiem.Location = new System.Drawing.Point(3, 41);
            this.lvdiem.Name = "lvdiem";
            this.lvdiem.Size = new System.Drawing.Size(726, 449);
            this.lvdiem.TabIndex = 9;
            this.lvdiem.UseCompatibleStateImageBehavior = false;
            this.lvdiem.View = System.Windows.Forms.View.Details;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.Text = "Mã học sinh";
            this.colMaHocSinh.Width = 150;
            // 
            // colTenHocSinh
            // 
            this.colTenHocSinh.Text = "Tên học sinh";
            this.colTenHocSinh.Width = 150;
            // 
            // colHocky
            // 
            this.colHocky.Text = "Học kỳ";
            this.colHocky.Width = 100;
            // 
            // colMonhoc
            // 
            this.colMonhoc.Text = "Môn học";
            this.colMonhoc.Width = 100;
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
            this.bngluu,
            this.btnXemdiem,
            this.bngthoat});
            this.bdgNhapdiemrieng.Location = new System.Drawing.Point(3, 16);
            this.bdgNhapdiemrieng.MoveFirstItem = null;
            this.bdgNhapdiemrieng.MoveLastItem = null;
            this.bdgNhapdiemrieng.MoveNextItem = null;
            this.bdgNhapdiemrieng.MovePreviousItem = null;
            this.bdgNhapdiemrieng.Name = "bdgNhapdiemrieng";
            this.bdgNhapdiemrieng.PositionItem = null;
            this.bdgNhapdiemrieng.Size = new System.Drawing.Size(726, 25);
            this.bdgNhapdiemrieng.TabIndex = 0;
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            this.btnxoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(47, 22);
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // bngluu
            // 
            this.bngluu.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            this.bngluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngluu.Name = "bngluu";
            this.bngluu.Size = new System.Drawing.Size(77, 22);
            this.bngluu.Text = "Lưu điểm";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // btnXemdiem
            // 
            this.btnXemdiem.Image = global::QLDiemHSTHPT.Properties.Resources.TCHS;
            this.btnXemdiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXemdiem.Name = "btnXemdiem";
            this.btnXemdiem.Size = new System.Drawing.Size(81, 22);
            this.btnXemdiem.Text = "Xem điểm";
            this.btnXemdiem.Click += new System.EventHandler(this.btnXemdiem_Click);
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
            // frmNhapDiemRieng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 493);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapDiemRieng";
            this.Text = "Nhập điểm riêng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDiemRieng_Load);
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
        private DevComponents.DotNetBar.ButtonX btnHienthiDS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbmnamhoc;
        private DevComponents.DotNetBar.LabelX lblnamHoc;
        private DevComponents.DotNetBar.ButtonItem btnNhapdiemchung;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private System.Windows.Forms.BindingNavigator bdgNhapdiemrieng;
        private System.Windows.Forms.ToolStripButton btnxoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton btnXemdiem;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdiem;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocsinh;
        private DevComponents.DotNetBar.LabelX lblHocsinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbloaidiem;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ListViewEx lvdiem;
        private System.Windows.Forms.ColumnHeader colMaHocSinh;
        private System.Windows.Forms.ColumnHeader colTenHocSinh;
        private System.Windows.Forms.ColumnHeader colHocky;
        private System.Windows.Forms.ColumnHeader colMonhoc;
        private System.Windows.Forms.ColumnHeader colLoaiDiem;
        private System.Windows.Forms.ColumnHeader colDiem;
    }
}