namespace QLDiemHSTHPT
{
    partial class frmXepLoaiHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXepLoaiHS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.ngvPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtMaHS_Or_hoTenHS = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocky = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnHienthiDS = new DevComponents.DotNetBar.ButtonX();
            this.cmbKhoaHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnCNdiem = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsHanhKiem = new System.Windows.Forms.GroupBox();
            this.dgvXepLoaiHanhKiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bdgXepHanhKiemHS = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.btnCapnhatdiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnNhapdiem = new DevComponents.DotNetBar.ButtonItem();
            this.MaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocLuc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaHanhKiem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nvgPanelGiaoVien.SuspendLayout();
            this.ngvPanelTimKiem.SuspendLayout();
            this.groupBoxDsHanhKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepLoaiHanhKiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgXepHanhKiemHS)).BeginInit();
            this.bdgXepHanhKiemHS.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvgPanelGiaoVien
            // 
            this.nvgPanelGiaoVien.CanCollapse = true;
            this.nvgPanelGiaoVien.Controls.Add(this.ngvPanelTimKiem);
            this.nvgPanelGiaoVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvgPanelGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvgPanelGiaoVien.ItemPaddingBottom = 2;
            this.nvgPanelGiaoVien.ItemPaddingTop = 2;
            this.nvgPanelGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnCNdiem});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.NavigationBarHeight = 67;
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(192, 448);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TabIndex = 8;
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
            this.nvgPanelGiaoVien.TitlePanel.Text = "Cập nhật hạnh kiểm";
            // 
            // ngvPanelTimKiem
            // 
            this.ngvPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ngvPanelTimKiem.Controls.Add(this.txtMaHS_Or_hoTenHS);
            this.ngvPanelTimKiem.Controls.Add(this.cmbLop);
            this.ngvPanelTimKiem.Controls.Add(this.labelX4);
            this.ngvPanelTimKiem.Controls.Add(this.cmbHocky);
            this.ngvPanelTimKiem.Controls.Add(this.labelX5);
            this.ngvPanelTimKiem.Controls.Add(this.labelX1);
            this.ngvPanelTimKiem.Controls.Add(this.btnHienthiDS);
            this.ngvPanelTimKiem.Controls.Add(this.cmbKhoaHoc);
            this.ngvPanelTimKiem.Controls.Add(this.labelX7);
            this.ngvPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngvPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.ngvPanelTimKiem.Name = "ngvPanelTimKiem";
            this.ngvPanelTimKiem.ParentItem = this.btnCNdiem;
            this.ngvPanelTimKiem.Size = new System.Drawing.Size(190, 355);
            this.ngvPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ngvPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ngvPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ngvPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ngvPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ngvPanelTimKiem.Style.GradientAngle = 90;
            this.ngvPanelTimKiem.TabIndex = 3;
            // 
            // txtMaHS_Or_hoTenHS
            // 
            // 
            // 
            // 
            this.txtMaHS_Or_hoTenHS.Border.Class = "TextBoxBorder";
            this.txtMaHS_Or_hoTenHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHS_Or_hoTenHS.Location = new System.Drawing.Point(26, 195);
            this.txtMaHS_Or_hoTenHS.Name = "txtMaHS_Or_hoTenHS";
            this.txtMaHS_Or_hoTenHS.Size = new System.Drawing.Size(140, 20);
            this.txtMaHS_Or_hoTenHS.TabIndex = 44;
            this.txtMaHS_Or_hoTenHS.WatermarkText = "Nhập thông tin cần tìm";
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 15;
            this.cmbLop.Location = new System.Drawing.Point(26, 86);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(121, 21);
            this.cmbLop.TabIndex = 43;
            this.cmbLop.SelectedIndexChanged += new System.EventHandler(this.cmbLopCN_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(26, 62);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 42;
            this.labelX4.Text = "Lớp:";
            // 
            // cmbHocky
            // 
            this.cmbHocky.DisplayMember = "Text";
            this.cmbHocky.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHocky.FormattingEnabled = true;
            this.cmbHocky.ItemHeight = 15;
            this.cmbHocky.Location = new System.Drawing.Point(26, 132);
            this.cmbHocky.Name = "cmbHocky";
            this.cmbHocky.Size = new System.Drawing.Size(121, 21);
            this.cmbHocky.TabIndex = 40;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(26, 107);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 39;
            this.labelX5.Text = "Học kỳ:";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(26, 167);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(105, 23);
            this.labelX1.TabIndex = 36;
            this.labelX1.Text = "Mã hoặc Họ tên";
            // 
            // btnHienthiDS
            // 
            this.btnHienthiDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienthiDS.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnHienthiDS.Location = new System.Drawing.Point(26, 232);
            this.btnHienthiDS.Name = "btnHienthiDS";
            this.btnHienthiDS.Size = new System.Drawing.Size(140, 23);
            this.btnHienthiDS.TabIndex = 35;
            this.btnHienthiDS.Text = "Hiển thị danh sách";
            this.btnHienthiDS.Click += new System.EventHandler(this.btnHienthiDS_Click);
            // 
            // cmbKhoaHoc
            // 
            this.cmbKhoaHoc.DisplayMember = "Text";
            this.cmbKhoaHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoaHoc.FormattingEnabled = true;
            this.cmbKhoaHoc.ItemHeight = 15;
            this.cmbKhoaHoc.Location = new System.Drawing.Point(26, 35);
            this.cmbKhoaHoc.Name = "cmbKhoaHoc";
            this.cmbKhoaHoc.Size = new System.Drawing.Size(121, 21);
            this.cmbKhoaHoc.TabIndex = 33;
            this.cmbKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNanhocCN_SelectedIndexChanged);
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(26, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 32;
            this.labelX7.Text = "Khóa Học:";
            // 
            // btnCNdiem
            // 
            this.btnCNdiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCNdiem.Checked = true;
            this.btnCNdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCNdiem.Image = ((System.Drawing.Image)(resources.GetObject("btnCNdiem.Image")));
            this.btnCNdiem.ImagePaddingHorizontal = 8;
            this.btnCNdiem.Name = "btnCNdiem";
            this.btnCNdiem.OptionGroup = "navBar";
            this.btnCNdiem.Text = "Cập nhật hạnh kiểm";
            // 
            // groupBoxDsHanhKiem
            // 
            this.groupBoxDsHanhKiem.Controls.Add(this.dgvXepLoaiHanhKiem);
            this.groupBoxDsHanhKiem.Controls.Add(this.bdgXepHanhKiemHS);
            this.groupBoxDsHanhKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsHanhKiem.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsHanhKiem.Name = "groupBoxDsHanhKiem";
            this.groupBoxDsHanhKiem.Size = new System.Drawing.Size(810, 448);
            this.groupBoxDsHanhKiem.TabIndex = 9;
            this.groupBoxDsHanhKiem.TabStop = false;
            this.groupBoxDsHanhKiem.Text = "Danh Sách Nhập Hạnh Kiểm";
            // 
            // dgvXepLoaiHanhKiem
            // 
            this.dgvXepLoaiHanhKiem.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXepLoaiHanhKiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXepLoaiHanhKiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXepLoaiHanhKiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXepLoaiHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvXepLoaiHanhKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocSinh,
            this.HoTen,
            this.MaHocLuc,
            this.MaHanhKiem});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXepLoaiHanhKiem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvXepLoaiHanhKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXepLoaiHanhKiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvXepLoaiHanhKiem.Location = new System.Drawing.Point(3, 41);
            this.dgvXepLoaiHanhKiem.Name = "dgvXepLoaiHanhKiem";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXepLoaiHanhKiem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvXepLoaiHanhKiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvXepLoaiHanhKiem.Size = new System.Drawing.Size(804, 404);
            this.dgvXepLoaiHanhKiem.TabIndex = 6;
            this.dgvXepLoaiHanhKiem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvNhapdiemchung_CellBeginEdit);
            this.dgvXepLoaiHanhKiem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvXepLoaiHanhKiem_DataError);
            this.dgvXepLoaiHanhKiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhapdiemchung_CellContentClick);
            // 
            // bdgXepHanhKiemHS
            // 
            this.bdgXepHanhKiemHS.AddNewItem = null;
            this.bdgXepHanhKiemHS.CountItem = this.bindingNavigatorCountItem;
            this.bdgXepHanhKiemHS.CountItemFormat = "của {0}";
            this.bdgXepHanhKiemHS.DeleteItem = null;
            this.bdgXepHanhKiemHS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bngluu,
            this.btnRefresh,
            this.bngthoat});
            this.bdgXepHanhKiemHS.Location = new System.Drawing.Point(3, 16);
            this.bdgXepHanhKiemHS.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgXepHanhKiemHS.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgXepHanhKiemHS.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgXepHanhKiemHS.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgXepHanhKiemHS.Name = "bdgXepHanhKiemHS";
            this.bdgXepHanhKiemHS.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgXepHanhKiemHS.Size = new System.Drawing.Size(804, 25);
            this.bdgXepHanhKiemHS.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bngluu
            // 
            this.bngluu.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            this.bngluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngluu.Name = "bngluu";
            this.bngluu.Size = new System.Drawing.Size(47, 22);
            this.bngluu.Text = "Lưu";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::QLDiemHSTHPT.Properties.Resources.re;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // btnCapnhatdiem
            // 
            this.btnCapnhatdiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnCapnhatdiem.Checked = true;
            this.btnCapnhatdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnCapnhatdiem.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhatdiem.Image")));
            this.btnCapnhatdiem.ImagePaddingHorizontal = 8;
            this.btnCapnhatdiem.Name = "btnCapnhatdiem";
            this.btnCapnhatdiem.OptionGroup = "navBar";
            this.btnCapnhatdiem.Text = "Cập nhật điểm";
            // 
            // btnNhapdiem
            // 
            this.btnNhapdiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNhapdiem.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnNhapdiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapdiem.Image")));
            this.btnNhapdiem.ImagePaddingHorizontal = 8;
            this.btnNhapdiem.Name = "btnNhapdiem";
            this.btnNhapdiem.OptionGroup = "navBar";
            this.btnNhapdiem.Text = "Nhập điểm học sinh";
            // 
            // MaHocSinh
            // 
            this.MaHocSinh.DataPropertyName = "MaHocSinh";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHocSinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.MaHocSinh.HeaderText = "Mã Học Sinh";
            this.MaHocSinh.Name = "MaHocSinh";
            this.MaHocSinh.ReadOnly = true;
            this.MaHocSinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHocSinh.Width = 130;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoTen.HeaderText = "Học Sinh";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoTen.Width = 150;
            // 
            // MaHocLuc
            // 
            this.MaHocLuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaHocLuc.HeaderText = "Học Lực";
            this.MaHocLuc.Name = "MaHocLuc";
            this.MaHocLuc.ReadOnly = true;
            this.MaHocLuc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHocLuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaHanhKiem
            // 
            this.MaHanhKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaHanhKiem.HeaderText = "Hạnh Kiểm";
            this.MaHanhKiem.Name = "MaHanhKiem";
            // 
            // frmXepLoaiHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 448);
            this.Controls.Add(this.groupBoxDsHanhKiem);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXepLoaiHS";
            this.Text = "Xếp loại học sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNhapDiemChung_Load);
            this.nvgPanelGiaoVien.ResumeLayout(false);
            this.ngvPanelTimKiem.ResumeLayout(false);
            this.groupBoxDsHanhKiem.ResumeLayout(false);
            this.groupBoxDsHanhKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepLoaiHanhKiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgXepHanhKiemHS)).EndInit();
            this.bdgXepHanhKiemHS.ResumeLayout(false);
            this.bdgXepHanhKiemHS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnCapnhatdiem;
        private DevComponents.DotNetBar.ButtonItem btnNhapdiem;
        private DevComponents.DotNetBar.NavigationPane nvgPanelGiaoVien;
        private DevComponents.DotNetBar.NavigationPanePanel ngvPanelTimKiem;
        private DevComponents.DotNetBar.ButtonItem btnCNdiem;
        private System.Windows.Forms.GroupBox groupBoxDsHanhKiem;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvXepLoaiHanhKiem;
        private System.Windows.Forms.BindingNavigator bdgXepHanhKiemHS;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocky;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnHienthiDS;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoaHoc;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHS_Or_hoTenHS;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHocLuc;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHanhKiem;

    }
}