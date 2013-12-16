namespace QLPT
{
    partial class FrmPhuongTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayVH = new System.Windows.Forms.DateTimePicker();
            this.cmbNguyenMau = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDVQL = new System.Windows.Forms.ComboBox();
            this.cmbDVTC = new System.Windows.Forms.ComboBox();
            this.txtLanDaiTu = new System.Windows.Forms.TextBox();
            this.txtLanTrungTu = new System.Windows.Forms.TextBox();
            this.txtLanTieuTu = new System.Windows.Forms.TextBox();
            this.txtLanBDTX = new System.Windows.Forms.TextBox();
            this.txtTongVH = new System.Windows.Forms.TextBox();
            this.txtBienDK = new System.Windows.Forms.TextBox();
            this.txtXuaXu = new System.Windows.Forms.TextBox();
            this.txtPhuongTienID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã PT: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayVH);
            this.groupBox1.Controls.Add(this.cmbNguyenMau);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbLoaiPT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbDVQL);
            this.groupBox1.Controls.Add(this.cmbDVTC);
            this.groupBox1.Controls.Add(this.txtLanDaiTu);
            this.groupBox1.Controls.Add(this.txtLanTrungTu);
            this.groupBox1.Controls.Add(this.txtLanTieuTu);
            this.groupBox1.Controls.Add(this.txtLanBDTX);
            this.groupBox1.Controls.Add(this.txtTongVH);
            this.groupBox1.Controls.Add(this.txtBienDK);
            this.groupBox1.Controls.Add(this.txtXuaXu);
            this.groupBox1.Controls.Add(this.txtPhuongTienID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 266);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpNgayVH
            // 
            this.dtpNgayVH.CustomFormat = "MM/dd/yyyy";
            this.dtpNgayVH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayVH.Location = new System.Drawing.Point(569, 200);
            this.dtpNgayVH.Name = "dtpNgayVH";
            this.dtpNgayVH.Size = new System.Drawing.Size(239, 20);
            this.dtpNgayVH.TabIndex = 36;
            // 
            // cmbNguyenMau
            // 
            this.cmbNguyenMau.FormattingEnabled = true;
            this.cmbNguyenMau.Location = new System.Drawing.Point(105, 92);
            this.cmbNguyenMau.Name = "cmbNguyenMau";
            this.cmbNguyenMau.Size = new System.Drawing.Size(250, 21);
            this.cmbNguyenMau.TabIndex = 35;
            this.cmbNguyenMau.SelectedIndexChanged += new System.EventHandler(this.cmbNguyenMau_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Loại nguyên mấu :";
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.FormattingEnabled = true;
            this.cmbLoaiPT.Location = new System.Drawing.Point(105, 58);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(250, 21);
            this.cmbLoaiPT.TabIndex = 33;
            this.cmbLoaiPT.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPT_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Loại  PT :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(477, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Ngày vận hành :";
            // 
            // cmbDVQL
            // 
            this.cmbDVQL.FormattingEnabled = true;
            this.cmbDVQL.Location = new System.Drawing.Point(105, 236);
            this.cmbDVQL.Name = "cmbDVQL";
            this.cmbDVQL.Size = new System.Drawing.Size(250, 21);
            this.cmbDVQL.TabIndex = 29;
            this.cmbDVQL.SelectedIndexChanged += new System.EventHandler(this.cmbDVQL_SelectedIndexChanged);
            // 
            // cmbDVTC
            // 
            this.cmbDVTC.FormattingEnabled = true;
            this.cmbDVTC.Location = new System.Drawing.Point(105, 198);
            this.cmbDVTC.Name = "cmbDVTC";
            this.cmbDVTC.Size = new System.Drawing.Size(250, 21);
            this.cmbDVTC.TabIndex = 28;
            this.cmbDVTC.SelectedIndexChanged += new System.EventHandler(this.cmbDVTC_SelectedIndexChanged);
            // 
            // txtLanDaiTu
            // 
            this.txtLanDaiTu.Location = new System.Drawing.Point(569, 162);
            this.txtLanDaiTu.Name = "txtLanDaiTu";
            this.txtLanDaiTu.Size = new System.Drawing.Size(250, 20);
            this.txtLanDaiTu.TabIndex = 27;
            // 
            // txtLanTrungTu
            // 
            this.txtLanTrungTu.Location = new System.Drawing.Point(569, 128);
            this.txtLanTrungTu.Name = "txtLanTrungTu";
            this.txtLanTrungTu.Size = new System.Drawing.Size(250, 20);
            this.txtLanTrungTu.TabIndex = 26;
            // 
            // txtLanTieuTu
            // 
            this.txtLanTieuTu.Location = new System.Drawing.Point(569, 97);
            this.txtLanTieuTu.Name = "txtLanTieuTu";
            this.txtLanTieuTu.Size = new System.Drawing.Size(250, 20);
            this.txtLanTieuTu.TabIndex = 25;
            // 
            // txtLanBDTX
            // 
            this.txtLanBDTX.Location = new System.Drawing.Point(569, 63);
            this.txtLanBDTX.Name = "txtLanBDTX";
            this.txtLanBDTX.Size = new System.Drawing.Size(250, 20);
            this.txtLanBDTX.TabIndex = 24;
            // 
            // txtTongVH
            // 
            this.txtTongVH.Location = new System.Drawing.Point(569, 27);
            this.txtTongVH.Name = "txtTongVH";
            this.txtTongVH.Size = new System.Drawing.Size(250, 20);
            this.txtTongVH.TabIndex = 23;
            // 
            // txtBienDK
            // 
            this.txtBienDK.Location = new System.Drawing.Point(105, 128);
            this.txtBienDK.Name = "txtBienDK";
            this.txtBienDK.Size = new System.Drawing.Size(250, 20);
            this.txtBienDK.TabIndex = 22;
            // 
            // txtXuaXu
            // 
            this.txtXuaXu.Location = new System.Drawing.Point(105, 162);
            this.txtXuaXu.Name = "txtXuaXu";
            this.txtXuaXu.Size = new System.Drawing.Size(250, 20);
            this.txtXuaXu.TabIndex = 17;
            // 
            // txtPhuongTienID
            // 
            this.txtPhuongTienID.Location = new System.Drawing.Point(105, 27);
            this.txtPhuongTienID.Name = "txtPhuongTienID";
            this.txtPhuongTienID.Size = new System.Drawing.Size(250, 20);
            this.txtPhuongTienID.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Số lần Trung tu :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(477, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Số lần Đại tu :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(474, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tổng vận hành :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(477, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Số lần BDTX :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(477, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Số lần Tiểu tu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Đơn vị QL :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Biển ĐK :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xuất xứ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đon vị TC :";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(15, 294);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(791, 294);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(317, 294);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 4;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(211, 294);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 5;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(110, 294);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 6;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1208, 265);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // FrmPhuongTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPhuongTien";
            this.Text = "Phương tiện ";
            this.Load += new System.EventHandler(this.FrmPhuongTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDVQL;
        private System.Windows.Forms.ComboBox cmbDVTC;
        private System.Windows.Forms.TextBox txtLanDaiTu;
        private System.Windows.Forms.TextBox txtLanTrungTu;
        private System.Windows.Forms.TextBox txtLanTieuTu;
        private System.Windows.Forms.TextBox txtLanBDTX;
        private System.Windows.Forms.TextBox txtTongVH;
        private System.Windows.Forms.TextBox txtBienDK;
        private System.Windows.Forms.TextBox txtXuaXu;
        private System.Windows.Forms.TextBox txtPhuongTienID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cmbNguyenMau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayVH;
    }
}