namespace QLPT
{
    partial class FrmCongTrinh
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenCT = new System.Windows.Forms.TextBox();
            this.txtNguoiGiamSat = new System.Windows.Forms.TextBox();
            this.txtMaCT = new System.Windows.Forms.TextBox();
            this.lbTenDV = new System.Windows.Forms.Label();
            this.lbToTruongDV = new System.Windows.Forms.Label();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbMaDV = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtThoiGianDuTinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(356, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 368);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThoiGianDuTinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtTenCT);
            this.groupBox1.Controls.Add(this.txtNguoiGiamSat);
            this.groupBox1.Controls.Add(this.txtMaCT);
            this.groupBox1.Controls.Add(this.lbTenDV);
            this.groupBox1.Controls.Add(this.lbToTruongDV);
            this.groupBox1.Controls.Add(this.lbGhiChu);
            this.groupBox1.Controls.Add(this.lbMaDV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị thi công";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(145, 180);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(164, 20);
            this.txtGhiChu.TabIndex = 7;
            // 
            // txtTenCT
            // 
            this.txtTenCT.Location = new System.Drawing.Point(145, 65);
            this.txtTenCT.Name = "txtTenCT";
            this.txtTenCT.Size = new System.Drawing.Size(164, 20);
            this.txtTenCT.TabIndex = 6;
            // 
            // txtNguoiGiamSat
            // 
            this.txtNguoiGiamSat.Location = new System.Drawing.Point(145, 97);
            this.txtNguoiGiamSat.Name = "txtNguoiGiamSat";
            this.txtNguoiGiamSat.Size = new System.Drawing.Size(164, 20);
            this.txtNguoiGiamSat.TabIndex = 5;
            // 
            // txtMaCT
            // 
            this.txtMaCT.Location = new System.Drawing.Point(145, 29);
            this.txtMaCT.Name = "txtMaCT";
            this.txtMaCT.Size = new System.Drawing.Size(164, 20);
            this.txtMaCT.TabIndex = 4;
            // 
            // lbTenDV
            // 
            this.lbTenDV.AutoSize = true;
            this.lbTenDV.Location = new System.Drawing.Point(6, 72);
            this.lbTenDV.Name = "lbTenDV";
            this.lbTenDV.Size = new System.Drawing.Size(82, 13);
            this.lbTenDV.TabIndex = 3;
            this.lbTenDV.Text = "Tên công trình :";
            // 
            // lbToTruongDV
            // 
            this.lbToTruongDV.AutoSize = true;
            this.lbToTruongDV.Location = new System.Drawing.Point(6, 104);
            this.lbToTruongDV.Name = "lbToTruongDV";
            this.lbToTruongDV.Size = new System.Drawing.Size(83, 13);
            this.lbToTruongDV.TabIndex = 2;
            this.lbToTruongDV.Text = "Người giám sát :";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(6, 187);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(50, 13);
            this.lbGhiChu.TabIndex = 1;
            this.lbGhiChu.Text = "Ghi chú :";
            // 
            // lbMaDV
            // 
            this.lbMaDV.AutoSize = true;
            this.lbMaDV.Location = new System.Drawing.Point(6, 36);
            this.lbMaDV.Name = "lbMaDV";
            this.lbMaDV.Size = new System.Drawing.Size(78, 13);
            this.lbMaDV.TabIndex = 0;
            this.lbMaDV.Text = "Mã công trình :";
            // 
            // btSua
            // 
            this.btSua.Image = global::QLPT.Properties.Resources.application_edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(26, 305);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 28);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Image = global::QLPT.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(26, 348);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 27);
            this.btXoa.TabIndex = 19;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Image = global::QLPT.Properties.Resources.Save;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(137, 256);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 31);
            this.btLuu.TabIndex = 18;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLPT.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(137, 305);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 28);
            this.btThoat.TabIndex = 17;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Image = global::QLPT.Properties.Resources.plus_16;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(26, 256);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 31);
            this.btThem.TabIndex = 16;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // txtThoiGianDuTinh
            // 
            this.txtThoiGianDuTinh.Location = new System.Drawing.Point(145, 138);
            this.txtThoiGianDuTinh.Name = "txtThoiGianDuTinh";
            this.txtThoiGianDuTinh.Size = new System.Drawing.Size(164, 20);
            this.txtThoiGianDuTinh.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thời gian dự tính (Tháng):";
            // 
            // FrmCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 399);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCongTrinh";
            this.Text = "Hạng mục công trình";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenCT;
        private System.Windows.Forms.TextBox txtNguoiGiamSat;
        private System.Windows.Forms.TextBox txtMaCT;
        private System.Windows.Forms.Label lbTenDV;
        private System.Windows.Forms.Label lbToTruongDV;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbMaDV;
        private System.Windows.Forms.TextBox txtThoiGianDuTinh;
        private System.Windows.Forms.Label label1;
    }
}