namespace QLPT
{
    partial class FrmNguyenMau_PT
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
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaPT = new System.Windows.Forms.Label();
            this.lbTenPT = new System.Windows.Forms.Label();
            this.lbChiTiet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNangLuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhanHieu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBDTX = new System.Windows.Forms.TextBox();
            this.txtTrungTu = new System.Windows.Forms.TextBox();
            this.txtTieuTu = new System.Windows.Forms.TextBox();
            this.txtNguyenMau_ID = new System.Windows.Forms.TextBox();
            this.lbNguyenMau_ID = new System.Windows.Forms.Label();
            this.txtNguyenMau_ChiTiet = new System.Windows.Forms.TextBox();
            this.txtDaiTu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNguyenMau = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenMau)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Location = new System.Drawing.Point(489, 29);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(82, 13);
            this.lbDonViTinh.TabIndex = 0;
            this.lbDonViTinh.Text = "Bảo dưỡng TX :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lbMaPT
            // 
            this.lbMaPT.AutoSize = true;
            this.lbMaPT.Location = new System.Drawing.Point(8, 66);
            this.lbMaPT.Name = "lbMaPT";
            this.lbMaPT.Size = new System.Drawing.Size(50, 13);
            this.lbMaPT.TabIndex = 2;
            this.lbMaPT.Text = "Loại PT :";
            // 
            // lbTenPT
            // 
            this.lbTenPT.AutoSize = true;
            this.lbTenPT.Location = new System.Drawing.Point(489, 150);
            this.lbTenPT.Name = "lbTenPT";
            this.lbTenPT.Size = new System.Drawing.Size(41, 13);
            this.lbTenPT.TabIndex = 3;
            this.lbTenPT.Text = "Đại tu :";
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.AutoSize = true;
            this.lbChiTiet.Location = new System.Drawing.Point(488, 192);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(45, 13);
            this.lbChiTiet.TabIndex = 4;
            this.lbChiTiet.Text = "Chi tiết :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbLoaiPT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDonVi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNangLuc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNhanHieu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBDTX);
            this.groupBox1.Controls.Add(this.txtTrungTu);
            this.groupBox1.Controls.Add(this.txtTieuTu);
            this.groupBox1.Controls.Add(this.txtNguyenMau_ID);
            this.groupBox1.Controls.Add(this.lbNguyenMau_ID);
            this.groupBox1.Controls.Add(this.txtNguyenMau_ChiTiet);
            this.groupBox1.Controls.Add(this.lbChiTiet);
            this.groupBox1.Controls.Add(this.txtDaiTu);
            this.groupBox1.Controls.Add(this.lbMaPT);
            this.groupBox1.Controls.Add(this.lbDonViTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbTenPT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(867, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.FormattingEnabled = true;
            this.cmbLoaiPT.Location = new System.Drawing.Point(107, 63);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(261, 21);
            this.cmbLoaiPT.TabIndex = 24;
            this.cmbLoaiPT.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiPT_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đơn vị :";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(105, 182);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(263, 20);
            this.txtDonVi.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Năng lực :";
            // 
            // txtNangLuc
            // 
            this.txtNangLuc.Location = new System.Drawing.Point(104, 143);
            this.txtNangLuc.Name = "txtNangLuc";
            this.txtNangLuc.Size = new System.Drawing.Size(264, 20);
            this.txtNangLuc.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nhãn hiệu";
            // 
            // txtNhanHieu
            // 
            this.txtNhanHieu.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNhanHieu.Location = new System.Drawing.Point(105, 100);
            this.txtNhanHieu.Name = "txtNhanHieu";
            this.txtNhanHieu.Size = new System.Drawing.Size(264, 20);
            this.txtNhanHieu.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tiểu tu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Trung tu :";
            // 
            // txtBDTX
            // 
            this.txtBDTX.Location = new System.Drawing.Point(585, 22);
            this.txtBDTX.Name = "txtBDTX";
            this.txtBDTX.Size = new System.Drawing.Size(257, 20);
            this.txtBDTX.TabIndex = 15;
            // 
            // txtTrungTu
            // 
            this.txtTrungTu.Location = new System.Drawing.Point(585, 107);
            this.txtTrungTu.Name = "txtTrungTu";
            this.txtTrungTu.Size = new System.Drawing.Size(257, 20);
            this.txtTrungTu.TabIndex = 14;
            this.txtTrungTu.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTieuTu
            // 
            this.txtTieuTu.Location = new System.Drawing.Point(585, 59);
            this.txtTieuTu.Name = "txtTieuTu";
            this.txtTieuTu.Size = new System.Drawing.Size(257, 20);
            this.txtTieuTu.TabIndex = 13;
            // 
            // txtNguyenMau_ID
            // 
            this.txtNguyenMau_ID.Location = new System.Drawing.Point(105, 25);
            this.txtNguyenMau_ID.Name = "txtNguyenMau_ID";
            this.txtNguyenMau_ID.Size = new System.Drawing.Size(263, 20);
            this.txtNguyenMau_ID.TabIndex = 12;
            // 
            // lbNguyenMau_ID
            // 
            this.lbNguyenMau_ID.AutoSize = true;
            this.lbNguyenMau_ID.Location = new System.Drawing.Point(8, 29);
            this.lbNguyenMau_ID.Name = "lbNguyenMau_ID";
            this.lbNguyenMau_ID.Size = new System.Drawing.Size(89, 13);
            this.lbNguyenMau_ID.TabIndex = 11;
            this.lbNguyenMau_ID.Text = "Mã nguyên mấu :";
            // 
            // txtNguyenMau_ChiTiet
            // 
            this.txtNguyenMau_ChiTiet.Location = new System.Drawing.Point(585, 185);
            this.txtNguyenMau_ChiTiet.Name = "txtNguyenMau_ChiTiet";
            this.txtNguyenMau_ChiTiet.Size = new System.Drawing.Size(256, 20);
            this.txtNguyenMau_ChiTiet.TabIndex = 5;
            // 
            // txtDaiTu
            // 
            this.txtDaiTu.Location = new System.Drawing.Point(585, 146);
            this.txtDaiTu.Name = "txtDaiTu";
            this.txtDaiTu.Size = new System.Drawing.Size(257, 20);
            this.txtDaiTu.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNguyenMau);
            this.groupBox2.Location = new System.Drawing.Point(21, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // dgvNguyenMau
            // 
            this.dgvNguyenMau.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNguyenMau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenMau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt});
            this.dgvNguyenMau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguyenMau.Location = new System.Drawing.Point(3, 16);
            this.dgvNguyenMau.Name = "dgvNguyenMau";
            this.dgvNguyenMau.ReadOnly = true;
            this.dgvNguyenMau.Size = new System.Drawing.Size(852, 161);
            this.dgvNguyenMau.TabIndex = 0;
            this.dgvNguyenMau.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dgvNguyenMau.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 30;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(16, 241);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(338, 241);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(231, 241);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Enabled = false;
            this.btSua.Location = new System.Drawing.Point(117, 241);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(801, 241);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // FrmNguyenMau_PT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 483);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNguyenMau_PT";
            this.Text = "Nguyên mẫu  - Phương tiện";
            this.Load += new System.EventHandler(this.FrmNguyenMau_PT_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenMau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaPT;
        private System.Windows.Forms.Label lbTenPT;
        private System.Windows.Forms.Label lbChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDaiTu;
        private System.Windows.Forms.TextBox txtNguyenMau_ChiTiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNguyenMau;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbNguyenMau_ID;
        private System.Windows.Forms.TextBox txtNguyenMau_ID;
        private System.Windows.Forms.TextBox txtBDTX;
        private System.Windows.Forms.TextBox txtTrungTu;
        private System.Windows.Forms.TextBox txtTieuTu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNangLuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhanHieu;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
    }
}