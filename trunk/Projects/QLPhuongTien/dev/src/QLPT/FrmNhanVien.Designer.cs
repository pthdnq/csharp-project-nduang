namespace QLPT
{
    partial class FrmNhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDVTC = new System.Windows.Forms.ComboBox();
            this.txtNhanVien_Ten = new System.Windows.Forms.TextBox();
            this.txtNhanVien_Sdt = new System.Windows.Forms.TextBox();
            this.txtNhanVien_Email = new System.Windows.Forms.TextBox();
            this.txtNhanVien_DC = new System.Windows.Forms.TextBox();
            this.txtNhanVien_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btTroVe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDVTC);
            this.groupBox1.Controls.Add(this.txtNhanVien_Ten);
            this.groupBox1.Controls.Add(this.txtNhanVien_Sdt);
            this.groupBox1.Controls.Add(this.txtNhanVien_Email);
            this.groupBox1.Controls.Add(this.txtNhanVien_DC);
            this.groupBox1.Controls.Add(this.txtNhanVien_ID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // cmbDVTC
            // 
            this.cmbDVTC.FormattingEnabled = true;
            this.cmbDVTC.Location = new System.Drawing.Point(419, 102);
            this.cmbDVTC.Name = "cmbDVTC";
            this.cmbDVTC.Size = new System.Drawing.Size(192, 21);
            this.cmbDVTC.TabIndex = 12;
            this.cmbDVTC.SelectedIndexChanged += new System.EventHandler(this.cmbDVTC_SelectedIndexChanged);
            // 
            // txtNhanVien_Ten
            // 
            this.txtNhanVien_Ten.Location = new System.Drawing.Point(106, 62);
            this.txtNhanVien_Ten.Name = "txtNhanVien_Ten";
            this.txtNhanVien_Ten.Size = new System.Drawing.Size(196, 20);
            this.txtNhanVien_Ten.TabIndex = 11;
            // 
            // txtNhanVien_Sdt
            // 
            this.txtNhanVien_Sdt.Location = new System.Drawing.Point(106, 98);
            this.txtNhanVien_Sdt.Name = "txtNhanVien_Sdt";
            this.txtNhanVien_Sdt.Size = new System.Drawing.Size(196, 20);
            this.txtNhanVien_Sdt.TabIndex = 10;
            // 
            // txtNhanVien_Email
            // 
            this.txtNhanVien_Email.Location = new System.Drawing.Point(419, 24);
            this.txtNhanVien_Email.Name = "txtNhanVien_Email";
            this.txtNhanVien_Email.Size = new System.Drawing.Size(192, 20);
            this.txtNhanVien_Email.TabIndex = 9;
            // 
            // txtNhanVien_DC
            // 
            this.txtNhanVien_DC.Location = new System.Drawing.Point(419, 62);
            this.txtNhanVien_DC.Name = "txtNhanVien_DC";
            this.txtNhanVien_DC.Size = new System.Drawing.Size(192, 20);
            this.txtNhanVien_DC.TabIndex = 8;
            // 
            // txtNhanVien_ID
            // 
            this.txtNhanVien_ID.Location = new System.Drawing.Point(106, 28);
            this.txtNhanVien_ID.Name = "txtNhanVien_ID";
            this.txtNhanVien_ID.Size = new System.Drawing.Size(196, 20);
            this.txtNhanVien_ID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên NV :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NV :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 239);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.Size = new System.Drawing.Size(982, 220);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dgvNhanVien.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(690, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 20);
            this.txtTimKiem.TabIndex = 13;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(696, 78);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "Status";
            // 
            // btTroVe
            // 
            this.btTroVe.Image = global::QLPT.Properties.Resources.Back;
            this.btTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTroVe.Location = new System.Drawing.Point(909, 98);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(88, 32);
            this.btTroVe.TabIndex = 15;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::QLPT.Properties.Resources.View;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(909, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Image = global::QLPT.Properties.Resources.application_edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(118, 179);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 30);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::QLPT.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(228, 179);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 30);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::QLPT.Properties.Resources.Save;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(334, 179);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 30);
            this.btLuu.TabIndex = 3;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLPT.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(567, 179);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::QLPT.Properties.Resources.plus_16;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(12, 179);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 30);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 485);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDVTC;
        private System.Windows.Forms.TextBox txtNhanVien_Ten;
        private System.Windows.Forms.TextBox txtNhanVien_Sdt;
        private System.Windows.Forms.TextBox txtNhanVien_Email;
        private System.Windows.Forms.TextBox txtNhanVien_DC;
        private System.Windows.Forms.TextBox txtNhanVien_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Label lbStatus;
    }
}