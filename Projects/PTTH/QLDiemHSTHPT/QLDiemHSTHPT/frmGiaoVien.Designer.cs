namespace QLDiemHSTHPT
{
    partial class frmGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMenuGiaoVien = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefreshMN = new DevComponents.DotNetBar.ButtonItem();
            this.nvgPanelGiaoVien = new DevComponents.DotNetBar.NavigationPane();
            this.ngvPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.buttonTKGV = new DevComponents.DotNetBar.ButtonX();
            this.ckboxtheoten = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckboxtheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTimKiemGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblTimKiem = new DevComponents.DotNetBar.LabelX();
            this.btnTimKiemGV = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDsgv = new System.Windows.Forms.GroupBox();
            this.dgvGiaoVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGiaoVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bdgGiaoVien = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bngThemmoi = new System.Windows.Forms.ToolStripButton();
            this.bngXoa = new System.Windows.Forms.ToolStripButton();
            this.bngluu = new System.Windows.Forms.ToolStripButton();
            this.bngthoat = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.nvgPanelGiaoVien.SuspendLayout();
            this.ngvPanelTimKiem.SuspendLayout();
            this.groupBoxDsgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgGiaoVien)).BeginInit();
            this.bdgGiaoVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuGiaoVien
            // 
            this.btnMenuGiaoVien.AutoExpandOnClick = true;
            this.btnMenuGiaoVien.ImagePaddingHorizontal = 8;
            this.btnMenuGiaoVien.Name = "btnMenuGiaoVien";
            this.btnMenuGiaoVien.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenuGiaoVien.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnClose,
            this.btnRefreshMN});
            this.btnMenuGiaoVien.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QLDiemHSTHPT.Properties.Resources.add;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // btnRefreshMN
            // 
            this.btnRefreshMN.Image = global::QLDiemHSTHPT.Properties.Resources.re;
            this.btnRefreshMN.ImagePaddingHorizontal = 8;
            this.btnRefreshMN.Name = "btnRefreshMN";
            this.btnRefreshMN.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefreshMN.Text = "Refresh";
            this.btnRefreshMN.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.btnTimKiemGV});
            this.nvgPanelGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.nvgPanelGiaoVien.Name = "nvgPanelGiaoVien";
            this.nvgPanelGiaoVien.NavigationBarHeight = 67;
            this.nvgPanelGiaoVien.Padding = new System.Windows.Forms.Padding(1);
            this.nvgPanelGiaoVien.Size = new System.Drawing.Size(192, 510);
            this.nvgPanelGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.nvgPanelGiaoVien.TabIndex = 4;
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
            this.nvgPanelGiaoVien.TitlePanel.Text = "Tìm kiếm giáo viên";
            // 
            // ngvPanelTimKiem
            // 
            this.ngvPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ngvPanelTimKiem.Controls.Add(this.buttonTKGV);
            this.ngvPanelTimKiem.Controls.Add(this.ckboxtheoten);
            this.ngvPanelTimKiem.Controls.Add(this.ckboxtheoMa);
            this.ngvPanelTimKiem.Controls.Add(this.txtTimKiemGV);
            this.ngvPanelTimKiem.Controls.Add(this.lblTimKiem);
            this.ngvPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngvPanelTimKiem.Location = new System.Drawing.Point(1, 25);
            this.ngvPanelTimKiem.Name = "ngvPanelTimKiem";
            this.ngvPanelTimKiem.ParentItem = this.btnTimKiemGV;
            this.ngvPanelTimKiem.Size = new System.Drawing.Size(190, 417);
            this.ngvPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.ngvPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ngvPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.ngvPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ngvPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ngvPanelTimKiem.Style.GradientAngle = 90;
            this.ngvPanelTimKiem.TabIndex = 3;
            // 
            // buttonTKGV
            // 
            this.buttonTKGV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTKGV.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.buttonTKGV.Location = new System.Drawing.Point(28, 118);
            this.buttonTKGV.Name = "buttonTKGV";
            this.buttonTKGV.Size = new System.Drawing.Size(133, 23);
            this.buttonTKGV.TabIndex = 4;
            this.buttonTKGV.Text = "Tìm Kiếm";
            this.buttonTKGV.Click += new System.EventHandler(this.btnTimKiemGV_Click);
            // 
            // ckboxtheoten
            // 
            this.ckboxtheoten.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckboxtheoten.Location = new System.Drawing.Point(22, 89);
            this.ckboxtheoten.Name = "ckboxtheoten";
            this.ckboxtheoten.Size = new System.Drawing.Size(157, 23);
            this.ckboxtheoten.TabIndex = 3;
            this.ckboxtheoten.Text = "Tìm theo tên giáo viên";
            // 
            // ckboxtheoMa
            // 
            this.ckboxtheoMa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckboxtheoMa.Checked = true;
            this.ckboxtheoMa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckboxtheoMa.CheckValue = "Y";
            this.ckboxtheoMa.Location = new System.Drawing.Point(22, 63);
            this.ckboxtheoMa.Name = "ckboxtheoMa";
            this.ckboxtheoMa.Size = new System.Drawing.Size(157, 23);
            this.ckboxtheoMa.TabIndex = 2;
            this.ckboxtheoMa.Text = "Tìm theo mã giáo viên";
            // 
            // txtTimKiemGV
            // 
            // 
            // 
            // 
            this.txtTimKiemGV.Border.Class = "TextBoxBorder";
            this.txtTimKiemGV.Location = new System.Drawing.Point(19, 36);
            this.txtTimKiemGV.Name = "txtTimKiemGV";
            this.txtTimKiemGV.Size = new System.Drawing.Size(155, 21);
            this.txtTimKiemGV.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Location = new System.Drawing.Point(19, 12);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(152, 23);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Nhập tên hoặc mã cần tìm:";
            // 
            // btnTimKiemGV
            // 
            this.btnTimKiemGV.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTimKiemGV.Checked = true;
            this.btnTimKiemGV.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiemGV.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemGV.Image")));
            this.btnTimKiemGV.ImagePaddingHorizontal = 8;
            this.btnTimKiemGV.Name = "btnTimKiemGV";
            this.btnTimKiemGV.OptionGroup = "navBar";
            this.btnTimKiemGV.Text = "Tìm kiếm giáo viên";
            // 
            // groupBoxDsgv
            // 
            this.groupBoxDsgv.Controls.Add(this.dgvGiaoVien);
            this.groupBoxDsgv.Controls.Add(this.bdgGiaoVien);
            this.groupBoxDsgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsgv.Location = new System.Drawing.Point(192, 0);
            this.groupBoxDsgv.Name = "groupBoxDsgv";
            this.groupBoxDsgv.Size = new System.Drawing.Size(711, 510);
            this.groupBoxDsgv.TabIndex = 5;
            this.groupBoxDsgv.TabStop = false;
            this.groupBoxDsgv.Text = "Danh Sách Giáo Viên";
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGiaoVien,
            this.TenGiaoVien,
            this.DiaChi,
            this.DienThoai,
            this.MaMonHoc,
            this.Gioitinh});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGiaoVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvGiaoVien.Location = new System.Drawing.Point(3, 41);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGiaoVien.Size = new System.Drawing.Size(705, 466);
            this.dgvGiaoVien.TabIndex = 6;
            this.dgvGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellClick);
            // 
            // MaGiaoVien
            // 
            this.MaGiaoVien.DataPropertyName = "MaGiaoVien";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaGiaoVien.DefaultCellStyle = dataGridViewCellStyle1;
            this.MaGiaoVien.HeaderText = "Mã Giáo Viên";
            this.MaGiaoVien.Name = "MaGiaoVien";
            this.MaGiaoVien.ReadOnly = true;
            this.MaGiaoVien.Width = 130;
            // 
            // TenGiaoVien
            // 
            this.TenGiaoVien.DataPropertyName = "TenGiaoVien";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenGiaoVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenGiaoVien.HeaderText = "Tên Giáo Viên";
            this.TenGiaoVien.Name = "TenGiaoVien";
            this.TenGiaoVien.Width = 150;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienThoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaMonHoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.MaMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaMonHoc.HeaderText = "Chuyên môn";
            this.MaMonHoc.Name = "MaMonHoc";
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới Tính Nữ";
            this.Gioitinh.Name = "Gioitinh";
            // 
            // bdgGiaoVien
            // 
            this.bdgGiaoVien.AddNewItem = null;
            this.bdgGiaoVien.CountItem = this.bindingNavigatorCountItem;
            this.bdgGiaoVien.CountItemFormat = "của {0}";
            this.bdgGiaoVien.DeleteItem = null;
            this.bdgGiaoVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bngThemmoi,
            this.bngXoa,
            this.bngluu,
            this.bngthoat,
            this.btnRefresh});
            this.bdgGiaoVien.Location = new System.Drawing.Point(3, 16);
            this.bdgGiaoVien.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgGiaoVien.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgGiaoVien.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgGiaoVien.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgGiaoVien.Name = "bdgGiaoVien";
            this.bdgGiaoVien.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgGiaoVien.Size = new System.Drawing.Size(705, 25);
            this.bdgGiaoVien.TabIndex = 0;
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
            // bngThemmoi
            // 
            this.bngThemmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngThemmoi.Image = global::QLDiemHSTHPT.Properties.Resources.add;
            this.bngThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngThemmoi.Name = "bngThemmoi";
            this.bngThemmoi.Size = new System.Drawing.Size(23, 22);
            this.bngThemmoi.Text = "Thêm ";
            this.bngThemmoi.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // bngXoa
            // 
            this.bngXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngXoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            this.bngXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngXoa.Name = "bngXoa";
            this.bngXoa.Size = new System.Drawing.Size(23, 22);
            this.bngXoa.Text = "Xóa";
            this.bngXoa.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // bngluu
            // 
            this.bngluu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngluu.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            this.bngluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngluu.Name = "bngluu";
            this.bngluu.Size = new System.Drawing.Size(23, 22);
            this.bngluu.Text = "Lưu";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // bngthoat
            // 
            this.bngthoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            this.bngthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngthoat.Name = "bngthoat";
            this.bngthoat.Size = new System.Drawing.Size(23, 22);
            this.bngthoat.Text = "Thoát";
            this.bngthoat.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::QLDiemHSTHPT.Properties.Resources.re;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 510);
            this.Controls.Add(this.groupBoxDsgv);
            this.Controls.Add(this.nvgPanelGiaoVien);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiaoVien";
            this.Text = "Giáo Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.nvgPanelGiaoVien.ResumeLayout(false);
            this.ngvPanelTimKiem.ResumeLayout(false);
            this.groupBoxDsgv.ResumeLayout(false);
            this.groupBoxDsgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgGiaoVien)).EndInit();
            this.bdgGiaoVien.ResumeLayout(false);
            this.bdgGiaoVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem btnMenuGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnRefreshMN;
        private DevComponents.DotNetBar.NavigationPane nvgPanelGiaoVien;
        private DevComponents.DotNetBar.NavigationPanePanel ngvPanelTimKiem;
        private DevComponents.DotNetBar.ButtonX buttonTKGV;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckboxtheoten;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckboxtheoMa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiemGV;
        private DevComponents.DotNetBar.LabelX lblTimKiem;
        private DevComponents.DotNetBar.ButtonItem btnTimKiemGV;
        private System.Windows.Forms.GroupBox groupBoxDsgv;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvGiaoVien;
        private System.Windows.Forms.BindingNavigator bdgGiaoVien;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bngThemmoi;
        private System.Windows.Forms.ToolStripButton bngXoa;
        private System.Windows.Forms.ToolStripButton bngluu;
        private System.Windows.Forms.ToolStripButton bngthoat;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGiaoVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Gioitinh;
    }
}