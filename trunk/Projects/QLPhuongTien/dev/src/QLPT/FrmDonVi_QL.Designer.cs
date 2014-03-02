namespace QLPT
{
    partial class frmDonVi_QL
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
            this.lbTenDV = new System.Windows.Forms.Label();
            this.lbToTruong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDonViQL_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSdt = new System.Windows.Forms.Label();
            this.txtDonViQL_ToTruong = new System.Windows.Forms.TextBox();
            this.txtDonViQL_ten = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViQLID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViQLTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTenDV
            // 
            this.lbTenDV.AutoSize = true;
            this.lbTenDV.Location = new System.Drawing.Point(6, 80);
            this.lbTenDV.Name = "lbTenDV";
            this.lbTenDV.Size = new System.Drawing.Size(65, 13);
            this.lbTenDV.TabIndex = 1;
            this.lbTenDV.Text = "Tên đơn vị :";
            // 
            // lbToTruong
            // 
            this.lbToTruong.AutoSize = true;
            this.lbToTruong.Location = new System.Drawing.Point(5, 118);
            this.lbToTruong.Name = "lbToTruong";
            this.lbToTruong.Size = new System.Drawing.Size(77, 13);
            this.lbToTruong.TabIndex = 2;
            this.lbToTruong.Text = "Người Quản lý:";
            this.lbToTruong.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDonViQL_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.lbSdt);
            this.groupBox1.Controls.Add(this.txtDonViQL_ToTruong);
            this.groupBox1.Controls.Add(this.txtDonViQL_ten);
            this.groupBox1.Controls.Add(this.lbTenDV);
            this.groupBox1.Controls.Add(this.lbToTruong);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn vị quản lý";
            // 
            // txtDonViQL_ID
            // 
            this.txtDonViQL_ID.Enabled = false;
            this.txtDonViQL_ID.Location = new System.Drawing.Point(84, 34);
            this.txtDonViQL_ID.Name = "txtDonViQL_ID";
            this.txtDonViQL_ID.Size = new System.Drawing.Size(207, 20);
            this.txtDonViQL_ID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã DV :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(464, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(464, 34);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(207, 20);
            this.txtSdt.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(385, 83);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email :";
            // 
            // lbSdt
            // 
            this.lbSdt.AutoSize = true;
            this.lbSdt.Location = new System.Drawing.Point(385, 41);
            this.lbSdt.Name = "lbSdt";
            this.lbSdt.Size = new System.Drawing.Size(76, 13);
            this.lbSdt.TabIndex = 6;
            this.lbSdt.Text = "Số điện thoại :";
            // 
            // txtDonViQL_ToTruong
            // 
            this.txtDonViQL_ToTruong.Location = new System.Drawing.Point(84, 111);
            this.txtDonViQL_ToTruong.Name = "txtDonViQL_ToTruong";
            this.txtDonViQL_ToTruong.Size = new System.Drawing.Size(207, 20);
            this.txtDonViQL_ToTruong.TabIndex = 5;
            this.txtDonViQL_ToTruong.Visible = false;
            // 
            // txtDonViQL_ten
            // 
            this.txtDonViQL_ten.Location = new System.Drawing.Point(84, 73);
            this.txtDonViQL_ten.Name = "txtDonViQL_ten";
            this.txtDonViQL_ten.Size = new System.Drawing.Size(207, 20);
            this.txtDonViQL_ten.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 170);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.DonViQLID,
            this.DonViQLTen,
            this.Sdt,
            this.Email});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btSua
            // 
            this.btSua.Enabled = false;
            this.btSua.Image = global::QLPT.Properties.Resources.application_edit;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(122, 185);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 28);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.Enabled = false;
            this.btXoa.Image = global::QLPT.Properties.Resources.Delete;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(241, 186);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 27);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Image = global::QLPT.Properties.Resources.Save;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(367, 186);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 31);
            this.btLuu.TabIndex = 6;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLPT.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(680, 186);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 28);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::QLPT.Properties.Resources.plus_16;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(12, 182);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 31);
            this.btThem.TabIndex = 4;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STT";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 30;
            // 
            // DonViQLID
            // 
            this.DonViQLID.DataPropertyName = "DonViQLID";
            this.DonViQLID.HeaderText = "Mã DV";
            this.DonViQLID.Name = "DonViQLID";
            this.DonViQLID.ReadOnly = true;
            this.DonViQLID.Width = 60;
            // 
            // DonViQLTen
            // 
            this.DonViQLTen.DataPropertyName = "DonViQLTen";
            this.DonViQLTen.HeaderText = "Tên đơn vị ";
            this.DonViQLTen.Name = "DonViQLTen";
            this.DonViQLTen.ReadOnly = true;
            this.DonViQLTen.Width = 170;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số điện thoại";
            this.Sdt.Name = "Sdt";
            this.Sdt.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 180;
            // 
            // frmDonVi_QL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(770, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDonVi_QL";
            this.Text = "Đơn vị quản lý phương tiện";
            this.Load += new System.EventHandler(this.FrmDonVi_QL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTenDV;
        private System.Windows.Forms.Label lbToTruong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDonViQL_ToTruong;
        private System.Windows.Forms.TextBox txtDonViQL_ten;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSdt;
        private System.Windows.Forms.TextBox txtDonViQL_ID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btThem;
        public System.Windows.Forms.Button btLuu;
        public System.Windows.Forms.Button btXoa;
        public System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViQLID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViQLTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}