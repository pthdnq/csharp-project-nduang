namespace QLPT
{
    partial class FrmDanhSachPTTheoDonVi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachPTTheoDonVi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDonViQL = new System.Windows.Forms.ComboBox();
            this.cmbDonViTC = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPT = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuongTienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPTMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenMauID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BienDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatXu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongVH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanBDTX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTieuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanTrungTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LanDaiTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HienTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.btDSTheoDVTC = new System.Windows.Forms.Button();
            this.btDSTheoDVQL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btDSTheoDVTC);
            this.groupBox1.Controls.Add(this.btDSTheoDVQL);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDonViQL);
            this.groupBox1.Controls.Add(this.cmbDonViTC);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 337);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn vị thi công";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đơn vị quản lý";
            // 
            // cmbDonViQL
            // 
            this.cmbDonViQL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonViQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDonViQL.FormattingEnabled = true;
            this.cmbDonViQL.Location = new System.Drawing.Point(95, 34);
            this.cmbDonViQL.Name = "cmbDonViQL";
            this.cmbDonViQL.Size = new System.Drawing.Size(185, 21);
            this.cmbDonViQL.TabIndex = 0;
            this.cmbDonViQL.SelectedIndexChanged += new System.EventHandler(this.cmbDonViQL_SelectedIndexChanged);
            // 
            // cmbDonViTC
            // 
            this.cmbDonViTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonViTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDonViTC.FormattingEnabled = true;
            this.cmbDonViTC.Location = new System.Drawing.Point(95, 83);
            this.cmbDonViTC.Name = "cmbDonViTC";
            this.cmbDonViTC.Size = new System.Drawing.Size(185, 21);
            this.cmbDonViTC.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDanhSachPT);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(428, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 337);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phương tiện";
            // 
            // dgvDanhSachPT
            // 
            this.dgvDanhSachPT.AllowUserToAddRows = false;
            this.dgvDanhSachPT.AllowUserToDeleteRows = false;
            this.dgvDanhSachPT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhSachPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.AutoNum,
            this.PhuongTienID,
            this.LoaiPTMa,
            this.NguyenMauID,
            this.BienDK,
            this.XuatXu,
            this.TongVH,
            this.LanBDTX,
            this.LanTieuTu,
            this.LanTrungTu,
            this.LanDaiTu,
            this.NgayVH,
            this.HienTrang});
            this.dgvDanhSachPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPT.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachPT.Name = "dgvDanhSachPT";
            this.dgvDanhSachPT.ReadOnly = true;
            this.dgvDanhSachPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPT.Size = new System.Drawing.Size(298, 318);
            this.dgvDanhSachPT.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // AutoNum
            // 
            this.AutoNum.DataPropertyName = "AutoNum";
            this.AutoNum.HeaderText = "AutoNum";
            this.AutoNum.Name = "AutoNum";
            this.AutoNum.ReadOnly = true;
            // 
            // PhuongTienID
            // 
            this.PhuongTienID.DataPropertyName = "PhuongTienID";
            this.PhuongTienID.HeaderText = "Mã PT ";
            this.PhuongTienID.Name = "PhuongTienID";
            this.PhuongTienID.ReadOnly = true;
            this.PhuongTienID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // LoaiPTMa
            // 
            this.LoaiPTMa.DataPropertyName = "LoaiPTMa";
            this.LoaiPTMa.HeaderText = "Loại PT ";
            this.LoaiPTMa.Name = "LoaiPTMa";
            this.LoaiPTMa.ReadOnly = true;
            this.LoaiPTMa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiPTMa.Visible = false;
            // 
            // NguyenMauID
            // 
            this.NguyenMauID.DataPropertyName = "NguyenMauID";
            this.NguyenMauID.HeaderText = "Loại nguyên mấu";
            this.NguyenMauID.Name = "NguyenMauID";
            this.NguyenMauID.ReadOnly = true;
            this.NguyenMauID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NguyenMauID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NguyenMauID.Width = 200;
            // 
            // BienDK
            // 
            this.BienDK.DataPropertyName = "BienDK";
            this.BienDK.HeaderText = "Biển ĐK";
            this.BienDK.Name = "BienDK";
            this.BienDK.ReadOnly = true;
            this.BienDK.Width = 70;
            // 
            // XuatXu
            // 
            this.XuatXu.DataPropertyName = "XuatXu";
            this.XuatXu.HeaderText = "Xuất xứ";
            this.XuatXu.Name = "XuatXu";
            this.XuatXu.ReadOnly = true;
            this.XuatXu.Width = 66;
            // 
            // TongVH
            // 
            this.TongVH.DataPropertyName = "TongVH";
            this.TongVH.HeaderText = "Tổng vận hành";
            this.TongVH.Name = "TongVH";
            this.TongVH.ReadOnly = true;
            // 
            // LanBDTX
            // 
            this.LanBDTX.DataPropertyName = "LanBDTX";
            this.LanBDTX.HeaderText = "số lần BDTX";
            this.LanBDTX.Name = "LanBDTX";
            this.LanBDTX.ReadOnly = true;
            this.LanBDTX.Width = 40;
            // 
            // LanTieuTu
            // 
            this.LanTieuTu.DataPropertyName = "LanTieuTu";
            this.LanTieuTu.HeaderText = "Số lần tiểu tu";
            this.LanTieuTu.Name = "LanTieuTu";
            this.LanTieuTu.ReadOnly = true;
            this.LanTieuTu.Width = 40;
            // 
            // LanTrungTu
            // 
            this.LanTrungTu.DataPropertyName = "LanTrungTu";
            this.LanTrungTu.HeaderText = "Số lần trung tu";
            this.LanTrungTu.Name = "LanTrungTu";
            this.LanTrungTu.ReadOnly = true;
            this.LanTrungTu.Width = 40;
            // 
            // LanDaiTu
            // 
            this.LanDaiTu.DataPropertyName = "LanDaiTu";
            this.LanDaiTu.HeaderText = "Số lần đại tu";
            this.LanDaiTu.Name = "LanDaiTu";
            this.LanDaiTu.ReadOnly = true;
            this.LanDaiTu.Width = 40;
            // 
            // NgayVH
            // 
            this.NgayVH.DataPropertyName = "NgayVH";
            this.NgayVH.HeaderText = "Ngày vận hành";
            this.NgayVH.Name = "NgayVH";
            this.NgayVH.ReadOnly = true;
            // 
            // HienTrang
            // 
            this.HienTrang.DataPropertyName = "HienTrang";
            this.HienTrang.HeaderText = "Hiện trạng";
            this.HienTrang.Name = "HienTrang";
            this.HienTrang.ReadOnly = true;
            this.HienTrang.Width = 30;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLPT.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(306, 128);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "   Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btDSTheoDVTC
            // 
            this.btDSTheoDVTC.Image = ((System.Drawing.Image)(resources.GetObject("btDSTheoDVTC.Image")));
            this.btDSTheoDVTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDSTheoDVTC.Location = new System.Drawing.Point(296, 76);
            this.btDSTheoDVTC.Name = "btDSTheoDVTC";
            this.btDSTheoDVTC.Size = new System.Drawing.Size(111, 23);
            this.btDSTheoDVTC.TabIndex = 5;
            this.btDSTheoDVTC.Text = "     Xem danh sách";
            this.btDSTheoDVTC.UseVisualStyleBackColor = true;
            this.btDSTheoDVTC.Click += new System.EventHandler(this.btDSTheoDVTC_Click);
            // 
            // btDSTheoDVQL
            // 
            this.btDSTheoDVQL.Image = ((System.Drawing.Image)(resources.GetObject("btDSTheoDVQL.Image")));
            this.btDSTheoDVQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDSTheoDVQL.Location = new System.Drawing.Point(296, 32);
            this.btDSTheoDVQL.Name = "btDSTheoDVQL";
            this.btDSTheoDVQL.Size = new System.Drawing.Size(111, 23);
            this.btDSTheoDVQL.TabIndex = 4;
            this.btDSTheoDVQL.Text = "     Xem danh sách";
            this.btDSTheoDVQL.UseVisualStyleBackColor = true;
            this.btDSTheoDVQL.Click += new System.EventHandler(this.btDSTheoDVQL_Click);
            // 
            // FrmDanhSachPTTheoDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 337);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDanhSachPTTheoDonVi";
            this.Text = "Tìm kiếm phương tiện theo các đơn vị";
            this.Load += new System.EventHandler(this.FrmDanhSachPTTheoDonVi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDSTheoDVTC;
        private System.Windows.Forms.Button btDSTheoDVQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDonViQL;
        private System.Windows.Forms.ComboBox cmbDonViTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDanhSachPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuongTienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPTMa;
        private System.Windows.Forms.DataGridViewComboBoxColumn NguyenMauID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatXu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongVH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanBDTX;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanTieuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanTrungTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LanDaiTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HienTrang;
        private System.Windows.Forms.Button btThoat;
    }
}