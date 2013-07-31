namespace QLDiemHSTHPT
{
    partial class frmPhanLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanLop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnthoat = new DevComponents.DotNetBar.ButtonX();
            this.btnluu = new DevComponents.DotNetBar.ButtonX();
            this.btnxoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyenlop = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSMoi = new System.Windows.Forms.ColumnHeader();
            this.colHoTenMoi = new System.Windows.Forms.ColumnHeader();
            this.groupPanelTTLopmoi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopmoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoilopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblkhoilopmoi = new DevComponents.DotNetBar.LabelX();
            this.cmbnamhocmoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblNamhocmoi = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = new System.Windows.Forms.ColumnHeader();
            this.colHoTenCu = new System.Windows.Forms.ColumnHeader();
            this.groupPanelTTLopcu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnTimKiemMa = new DevComponents.DotNetBar.ButtonX();
            this.btnTimKiemTen = new DevComponents.DotNetBar.ButtonX();
            this.txtTimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbLopcu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblLopcu = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoilopcu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblKhoiLopcu = new DevComponents.DotNetBar.LabelX();
            this.cmbNamhoccu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblNamhoccu = new DevComponents.DotNetBar.LabelX();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupPanelTTLopmoi.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupPanelTTLopcu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnthoat);
            this.panel4.Controls.Add(this.btnluu);
            this.panel4.Controls.Add(this.btnxoa);
            this.panel4.Controls.Add(this.btnChuyenlop);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(406, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(84, 520);
            this.panel4.TabIndex = 2;
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit1;
            this.btnthoat.Location = new System.Drawing.Point(6, 329);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(70, 60);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnluu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnluu.Image = global::QLDiemHSTHPT.Properties.Resources.luu;
            this.btnluu.Location = new System.Drawing.Point(6, 267);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(70, 56);
            this.btnluu.TabIndex = 8;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete2;
            this.btnxoa.Location = new System.Drawing.Point(6, 200);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(70, 61);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnChuyenlop
            // 
            this.btnChuyenlop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyenlop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyenlop.Image = global::QLDiemHSTHPT.Properties.Resources.chuyen_lop;
            this.btnChuyenlop.Location = new System.Drawing.Point(6, 131);
            this.btnChuyenlop.Name = "btnChuyenlop";
            this.btnChuyenlop.Size = new System.Drawing.Size(70, 63);
            this.btnChuyenlop.TabIndex = 6;
            this.btnChuyenlop.Click += new System.EventHandler(this.btnChuyenlop_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvLopMoi);
            this.panel3.Controls.Add(this.groupPanelTTLopmoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(490, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(416, 520);
            this.panel3.TabIndex = 1;
            // 
            // lvLopMoi
            // 
            // 
            // 
            // 
            this.lvLopMoi.Border.Class = "ListViewBorder";
            this.lvLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSMoi,
            this.colHoTenMoi});
            this.lvLopMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLopMoi.FullRowSelect = true;
            this.lvLopMoi.Location = new System.Drawing.Point(0, 131);
            this.lvLopMoi.Name = "lvLopMoi";
            this.lvLopMoi.Size = new System.Drawing.Size(416, 389);
            this.lvLopMoi.TabIndex = 6;
            this.lvLopMoi.UseCompatibleStateImageBehavior = false;
            this.lvLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSMoi
            // 
            this.colMaHSMoi.Text = "Mã học sinh";
            this.colMaHSMoi.Width = 90;
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ và tên";
            this.colHoTenMoi.Width = 267;
            // 
            // groupPanelTTLopmoi
            // 
            this.groupPanelTTLopmoi.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelTTLopmoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelTTLopmoi.Controls.Add(this.cmbLopmoi);
            this.groupPanelTTLopmoi.Controls.Add(this.labelX1);
            this.groupPanelTTLopmoi.Controls.Add(this.cmbKhoilopMoi);
            this.groupPanelTTLopmoi.Controls.Add(this.lblkhoilopmoi);
            this.groupPanelTTLopmoi.Controls.Add(this.cmbnamhocmoi);
            this.groupPanelTTLopmoi.Controls.Add(this.lblNamhocmoi);
            this.groupPanelTTLopmoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelTTLopmoi.Location = new System.Drawing.Point(0, 0);
            this.groupPanelTTLopmoi.Name = "groupPanelTTLopmoi";
            this.groupPanelTTLopmoi.Size = new System.Drawing.Size(416, 131);
            // 
            // 
            // 
            this.groupPanelTTLopmoi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelTTLopmoi.Style.BackColorGradientAngle = 90;
            this.groupPanelTTLopmoi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelTTLopmoi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopmoi.Style.BorderBottomWidth = 1;
            this.groupPanelTTLopmoi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelTTLopmoi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopmoi.Style.BorderLeftWidth = 1;
            this.groupPanelTTLopmoi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopmoi.Style.BorderRightWidth = 1;
            this.groupPanelTTLopmoi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopmoi.Style.BorderTopWidth = 1;
            this.groupPanelTTLopmoi.Style.CornerDiameter = 4;
            this.groupPanelTTLopmoi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelTTLopmoi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelTTLopmoi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelTTLopmoi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelTTLopmoi.TabIndex = 0;
            this.groupPanelTTLopmoi.Text = "Thông tin lớp mới";
            // 
            // cmbLopmoi
            // 
            this.cmbLopmoi.DisplayMember = "Text";
            this.cmbLopmoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopmoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLopmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLopmoi.FormattingEnabled = true;
            this.cmbLopmoi.ItemHeight = 14;
            this.cmbLopmoi.Location = new System.Drawing.Point(119, 81);
            this.cmbLopmoi.Name = "cmbLopmoi";
            this.cmbLopmoi.Size = new System.Drawing.Size(121, 20);
            this.cmbLopmoi.TabIndex = 11;
            this.cmbLopmoi.SelectedIndexChanged += new System.EventHandler(this.cmbLopmoi_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(60, 78);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(53, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Lớp:";
            // 
            // cmbKhoilopMoi
            // 
            this.cmbKhoilopMoi.DisplayMember = "Text";
            this.cmbKhoilopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoilopMoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoilopMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoilopMoi.FormattingEnabled = true;
            this.cmbKhoilopMoi.ItemHeight = 14;
            this.cmbKhoilopMoi.Location = new System.Drawing.Point(119, 52);
            this.cmbKhoilopMoi.Name = "cmbKhoilopMoi";
            this.cmbKhoilopMoi.Size = new System.Drawing.Size(121, 20);
            this.cmbKhoilopMoi.TabIndex = 9;
            this.cmbKhoilopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbKhoilopMoi_SelectedIndexChanged);
            // 
            // lblkhoilopmoi
            // 
            this.lblkhoilopmoi.BackColor = System.Drawing.Color.Transparent;
            this.lblkhoilopmoi.Location = new System.Drawing.Point(60, 49);
            this.lblkhoilopmoi.Name = "lblkhoilopmoi";
            this.lblkhoilopmoi.Size = new System.Drawing.Size(53, 23);
            this.lblkhoilopmoi.TabIndex = 8;
            this.lblkhoilopmoi.Text = "Khối lớp:";
            // 
            // cmbnamhocmoi
            // 
            this.cmbnamhocmoi.DisplayMember = "Text";
            this.cmbnamhocmoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbnamhocmoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnamhocmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnamhocmoi.FormattingEnabled = true;
            this.cmbnamhocmoi.ItemHeight = 14;
            this.cmbnamhocmoi.Location = new System.Drawing.Point(119, 23);
            this.cmbnamhocmoi.Name = "cmbnamhocmoi";
            this.cmbnamhocmoi.Size = new System.Drawing.Size(121, 20);
            this.cmbnamhocmoi.TabIndex = 7;
            this.cmbnamhocmoi.SelectedIndexChanged += new System.EventHandler(this.cmbnamhocmoi_SelectedIndexChanged);
            // 
            // lblNamhocmoi
            // 
            this.lblNamhocmoi.BackColor = System.Drawing.Color.Transparent;
            this.lblNamhocmoi.Location = new System.Drawing.Point(60, 20);
            this.lblNamhocmoi.Name = "lblNamhocmoi";
            this.lblNamhocmoi.Size = new System.Drawing.Size(53, 23);
            this.lblNamhocmoi.TabIndex = 6;
            this.lblNamhocmoi.Text = "Năm học:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvLopCu);
            this.panel2.Controls.Add(this.groupPanelTTLopcu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 520);
            this.panel2.TabIndex = 0;
            // 
            // lvLopCu
            // 
            // 
            // 
            // 
            this.lvLopCu.Border.Class = "ListViewBorder";
            this.lvLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu});
            this.lvLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLopCu.FullRowSelect = true;
            this.lvLopCu.Location = new System.Drawing.Point(0, 131);
            this.lvLopCu.Name = "lvLopCu";
            this.lvLopCu.Size = new System.Drawing.Size(406, 389);
            this.lvLopCu.TabIndex = 3;
            this.lvLopCu.UseCompatibleStateImageBehavior = false;
            this.lvLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "Mã học sinh";
            this.colMaHSCu.Width = 90;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Họ và tên";
            this.colHoTenCu.Width = 267;
            // 
            // groupPanelTTLopcu
            // 
            this.groupPanelTTLopcu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelTTLopcu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelTTLopcu.Controls.Add(this.btnTimKiemMa);
            this.groupPanelTTLopcu.Controls.Add(this.btnTimKiemTen);
            this.groupPanelTTLopcu.Controls.Add(this.txtTimkiem);
            this.groupPanelTTLopcu.Controls.Add(this.cmbLopcu);
            this.groupPanelTTLopcu.Controls.Add(this.lblLopcu);
            this.groupPanelTTLopcu.Controls.Add(this.cmbKhoilopcu);
            this.groupPanelTTLopcu.Controls.Add(this.lblKhoiLopcu);
            this.groupPanelTTLopcu.Controls.Add(this.cmbNamhoccu);
            this.groupPanelTTLopcu.Controls.Add(this.lblNamhoccu);
            this.groupPanelTTLopcu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelTTLopcu.Location = new System.Drawing.Point(0, 0);
            this.groupPanelTTLopcu.Name = "groupPanelTTLopcu";
            this.groupPanelTTLopcu.Size = new System.Drawing.Size(406, 131);
            // 
            // 
            // 
            this.groupPanelTTLopcu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelTTLopcu.Style.BackColorGradientAngle = 90;
            this.groupPanelTTLopcu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelTTLopcu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderBottomWidth = 1;
            this.groupPanelTTLopcu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelTTLopcu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderLeftWidth = 1;
            this.groupPanelTTLopcu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderRightWidth = 1;
            this.groupPanelTTLopcu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderTopWidth = 1;
            this.groupPanelTTLopcu.Style.CornerDiameter = 4;
            this.groupPanelTTLopcu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelTTLopcu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelTTLopcu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelTTLopcu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelTTLopcu.TabIndex = 0;
            this.groupPanelTTLopcu.Text = "Thông tin lớp cũ";
            // 
            // btnTimKiemMa
            // 
            this.btnTimKiemMa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiemMa.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiemMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemMa.Location = new System.Drawing.Point(220, 49);
            this.btnTimKiemMa.Name = "btnTimKiemMa";
            this.btnTimKiemMa.Size = new System.Drawing.Size(157, 23);
            this.btnTimKiemMa.TabIndex = 8;
            this.btnTimKiemMa.Text = "Tìm kiếm theo mã học sinh";
            this.btnTimKiemMa.Click += new System.EventHandler(this.btnTimKiemMa_Click);
            // 
            // btnTimKiemTen
            // 
            this.btnTimKiemTen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiemTen.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnTimKiemTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemTen.Location = new System.Drawing.Point(220, 20);
            this.btnTimKiemTen.Name = "btnTimKiemTen";
            this.btnTimKiemTen.Size = new System.Drawing.Size(157, 23);
            this.btnTimKiemTen.TabIndex = 7;
            this.btnTimKiemTen.Text = "Tìm kiếm theo tên  học sinh ";
            this.btnTimKiemTen.Click += new System.EventHandler(this.btnTimKiemTen_Click);
            // 
            // txtTimkiem
            // 
            // 
            // 
            // 
            this.txtTimkiem.Border.Class = "TextBoxBorder";
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(220, 78);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(170, 20);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.WatermarkText = "Nhập tên hoặc mã học sinh";
            // 
            // cmbLopcu
            // 
            this.cmbLopcu.DisplayMember = "Text";
            this.cmbLopcu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopcu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLopcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLopcu.FormattingEnabled = true;
            this.cmbLopcu.ItemHeight = 14;
            this.cmbLopcu.Location = new System.Drawing.Point(68, 81);
            this.cmbLopcu.Name = "cmbLopcu";
            this.cmbLopcu.Size = new System.Drawing.Size(121, 20);
            this.cmbLopcu.TabIndex = 5;
            this.cmbLopcu.Click += new System.EventHandler(this.cmbLopcu_Click);
            // 
            // lblLopcu
            // 
            this.lblLopcu.BackColor = System.Drawing.Color.Transparent;
            this.lblLopcu.Location = new System.Drawing.Point(9, 78);
            this.lblLopcu.Name = "lblLopcu";
            this.lblLopcu.Size = new System.Drawing.Size(53, 23);
            this.lblLopcu.TabIndex = 4;
            this.lblLopcu.Text = "Lớp:";
            // 
            // cmbKhoilopcu
            // 
            this.cmbKhoilopcu.DisplayMember = "Text";
            this.cmbKhoilopcu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoilopcu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoilopcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoilopcu.FormattingEnabled = true;
            this.cmbKhoilopcu.ItemHeight = 14;
            this.cmbKhoilopcu.Location = new System.Drawing.Point(68, 52);
            this.cmbKhoilopcu.Name = "cmbKhoilopcu";
            this.cmbKhoilopcu.Size = new System.Drawing.Size(121, 20);
            this.cmbKhoilopcu.TabIndex = 3;
            this.cmbKhoilopcu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoilopcu_SelectedIndexChanged);
            this.cmbKhoilopcu.Click += new System.EventHandler(this.cmbKhoilopcu_Click);
            // 
            // lblKhoiLopcu
            // 
            this.lblKhoiLopcu.BackColor = System.Drawing.Color.Transparent;
            this.lblKhoiLopcu.Location = new System.Drawing.Point(9, 49);
            this.lblKhoiLopcu.Name = "lblKhoiLopcu";
            this.lblKhoiLopcu.Size = new System.Drawing.Size(53, 23);
            this.lblKhoiLopcu.TabIndex = 2;
            this.lblKhoiLopcu.Text = "Khối lớp:";
            // 
            // cmbNamhoccu
            // 
            this.cmbNamhoccu.DisplayMember = "Text";
            this.cmbNamhoccu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamhoccu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamhoccu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamhoccu.FormattingEnabled = true;
            this.cmbNamhoccu.ItemHeight = 14;
            this.cmbNamhoccu.Location = new System.Drawing.Point(68, 23);
            this.cmbNamhoccu.Name = "cmbNamhoccu";
            this.cmbNamhoccu.Size = new System.Drawing.Size(121, 20);
            this.cmbNamhoccu.TabIndex = 1;
            this.cmbNamhoccu.SelectedIndexChanged += new System.EventHandler(this.cmbNamhoccu_SelectedIndexChanged);
            this.cmbNamhoccu.Click += new System.EventHandler(this.cmbNamhoccu_Click);
            // 
            // lblNamhoccu
            // 
            this.lblNamhoccu.BackColor = System.Drawing.Color.Transparent;
            this.lblNamhoccu.Location = new System.Drawing.Point(9, 20);
            this.lblNamhoccu.Name = "lblNamhoccu";
            this.lblNamhoccu.Size = new System.Drawing.Size(53, 23);
            this.lblNamhoccu.TabIndex = 0;
            this.lblNamhoccu.Text = "Năm học:";
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 520);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhanLop";
            this.Text = "Phân lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupPanelTTLopmoi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupPanelTTLopcu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelTTLopcu;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelTTLopmoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopmoi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoilopMoi;
        private DevComponents.DotNetBar.LabelX lblkhoilopmoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbnamhocmoi;
        private DevComponents.DotNetBar.LabelX lblNamhocmoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopcu;
        private DevComponents.DotNetBar.LabelX lblLopcu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoilopcu;
        private DevComponents.DotNetBar.LabelX lblKhoiLopcu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamhoccu;
        private DevComponents.DotNetBar.LabelX lblNamhoccu;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.ButtonX btnthoat;
        private DevComponents.DotNetBar.ButtonX btnluu;
        private DevComponents.DotNetBar.ButtonX btnxoa;
        private DevComponents.DotNetBar.ButtonX btnChuyenlop;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopMoi;
        private System.Windows.Forms.ColumnHeader colMaHSMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopCu;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimkiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiemTen;
        private DevComponents.DotNetBar.ButtonX btnTimKiemMa;

    }
}