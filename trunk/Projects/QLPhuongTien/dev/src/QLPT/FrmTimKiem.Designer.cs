namespace QLPT
{
    partial class FrmTimKiem
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
            this.lbLoaiPT = new System.Windows.Forms.Label();
            this.cmbLoaiPT = new System.Windows.Forms.ComboBox();
            this.cmbNhanHieu = new System.Windows.Forms.ComboBox();
            this.cmbNangLuc = new System.Windows.Forms.ComboBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.lbNhanHieu = new System.Windows.Forms.Label();
            this.lbNangLuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNangLuc);
            this.groupBox1.Controls.Add(this.lbNhanHieu);
            this.groupBox1.Controls.Add(this.cmbNangLuc);
            this.groupBox1.Controls.Add(this.cmbNhanHieu);
            this.groupBox1.Controls.Add(this.cmbLoaiPT);
            this.groupBox1.Controls.Add(this.lbLoaiPT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // lbLoaiPT
            // 
            this.lbLoaiPT.AutoSize = true;
            this.lbLoaiPT.Location = new System.Drawing.Point(15, 29);
            this.lbLoaiPT.Name = "lbLoaiPT";
            this.lbLoaiPT.Size = new System.Drawing.Size(50, 13);
            this.lbLoaiPT.TabIndex = 0;
            this.lbLoaiPT.Text = "Loại PT :";
            // 
            // cmbLoaiPT
            // 
            this.cmbLoaiPT.FormattingEnabled = true;
            this.cmbLoaiPT.Location = new System.Drawing.Point(104, 26);
            this.cmbLoaiPT.Name = "cmbLoaiPT";
            this.cmbLoaiPT.Size = new System.Drawing.Size(190, 21);
            this.cmbLoaiPT.TabIndex = 1;
            // 
            // cmbNhanHieu
            // 
            this.cmbNhanHieu.FormattingEnabled = true;
            this.cmbNhanHieu.Location = new System.Drawing.Point(104, 65);
            this.cmbNhanHieu.Name = "cmbNhanHieu";
            this.cmbNhanHieu.Size = new System.Drawing.Size(190, 21);
            this.cmbNhanHieu.TabIndex = 4;
            // 
            // cmbNangLuc
            // 
            this.cmbNangLuc.FormattingEnabled = true;
            this.cmbNangLuc.Location = new System.Drawing.Point(104, 101);
            this.cmbNangLuc.Name = "cmbNangLuc";
            this.cmbNangLuc.Size = new System.Drawing.Size(190, 21);
            this.cmbNangLuc.TabIndex = 5;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLPT.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(243, 168);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(85, 32);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết";
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimKiem.Location = new System.Drawing.Point(3, 16);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.Size = new System.Drawing.Size(516, 315);
            this.dgvTimKiem.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Image = global::QLPT.Properties.Resources.View;
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(12, 168);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(92, 32);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            // 
            // lbNhanHieu
            // 
            this.lbNhanHieu.AutoSize = true;
            this.lbNhanHieu.Location = new System.Drawing.Point(15, 73);
            this.lbNhanHieu.Name = "lbNhanHieu";
            this.lbNhanHieu.Size = new System.Drawing.Size(62, 13);
            this.lbNhanHieu.TabIndex = 6;
            this.lbNhanHieu.Text = "Nhãn hiệu :";
            // 
            // lbNangLuc
            // 
            this.lbNangLuc.AutoSize = true;
            this.lbNangLuc.Location = new System.Drawing.Point(15, 109);
            this.lbNangLuc.Name = "lbNangLuc";
            this.lbNangLuc.Size = new System.Drawing.Size(56, 13);
            this.lbNangLuc.TabIndex = 7;
            this.lbNangLuc.Text = "Năng lực :";
            // 
            // FrmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTimKiem";
            this.Text = "Tìm kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNangLuc;
        private System.Windows.Forms.ComboBox cmbNhanHieu;
        private System.Windows.Forms.ComboBox cmbLoaiPT;
        private System.Windows.Forms.Label lbLoaiPT;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label lbNangLuc;
        private System.Windows.Forms.Label lbNhanHieu;
    }
}