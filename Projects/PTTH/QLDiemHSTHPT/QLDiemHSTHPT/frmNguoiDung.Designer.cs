namespace QLDiemHSTHPT
{
    partial class frmNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguoiDung));
            this.groupBoxDsND = new System.Windows.Forms.GroupBox();
            this.dgvND = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoaiND = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgND = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.groupBoxDsND.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgND)).BeginInit();
            this.bdgND.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDsND
            // 
            this.groupBoxDsND.Controls.Add(this.dgvND);
            this.groupBoxDsND.Controls.Add(this.bdgND);
            this.groupBoxDsND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDsND.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDsND.Name = "groupBoxDsND";
            this.groupBoxDsND.Size = new System.Drawing.Size(710, 426);
            this.groupBoxDsND.TabIndex = 1;
            this.groupBoxDsND.TabStop = false;
            this.groupBoxDsND.Text = "Danh Sách Người Dùng";
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvND.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.MaLoaiND,
            this.TenND,
            this.TenDangNhap,
            this.MatKhau});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvND.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvND.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvND.Location = new System.Drawing.Point(3, 41);
            this.dgvND.Name = "dgvND";
            this.dgvND.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvND.Size = new System.Drawing.Size(704, 382);
            this.dgvND.TabIndex = 1;
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "MaND";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaND.DefaultCellStyle = dataGridViewCellStyle9;
            this.MaND.HeaderText = "Mã Người Dùng";
            this.MaND.Name = "MaND";
            this.MaND.Width = 150;
            // 
            // MaLoaiND
            // 
            this.MaLoaiND.DataPropertyName = "MaLoaiND";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiND.DefaultCellStyle = dataGridViewCellStyle10;
            this.MaLoaiND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaLoaiND.HeaderText = "Loại Người Dùng";
            this.MaLoaiND.Name = "MaLoaiND";
            this.MaLoaiND.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaLoaiND.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaLoaiND.Width = 150;
            // 
            // TenND
            // 
            this.TenND.DataPropertyName = "TenND";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenND.DefaultCellStyle = dataGridViewCellStyle11;
            this.TenND.HeaderText = "Tên Người Dùng";
            this.TenND.Name = "TenND";
            this.TenND.Width = 130;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenDangNhap.DefaultCellStyle = dataGridViewCellStyle12;
            this.TenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Width = 130;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.DefaultCellStyle = dataGridViewCellStyle13;
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // bdgND
            // 
            this.bdgND.AddNewItem = null;
            this.bdgND.CountItem = this.bindingNavigatorCountItem;
            this.bdgND.CountItemFormat = "của {0}";
            this.bdgND.DeleteItem = null;
            this.bdgND.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolStripLabel1});
            this.bdgND.Location = new System.Drawing.Point(3, 16);
            this.bdgND.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgND.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgND.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgND.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgND.Name = "bdgND";
            this.bdgND.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgND.Size = new System.Drawing.Size(704, 25);
            this.bdgND.TabIndex = 0;
            this.bdgND.Text = "Chú ý tài loại người dùng là giáo viên thì tên đăng nhập phải là mã giáo viên";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(385, 15);
            this.toolStripLabel1.Text = "Chú ý đối với tài khoản GV thì tên đăng nhập phải là mã giáo viên!!!!!";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 426);
            this.Controls.Add(this.groupBoxDsND);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNguoiDung";
            this.Text = "Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.groupBoxDsND.ResumeLayout(false);
            this.groupBoxDsND.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgND)).EndInit();
            this.bdgND.ResumeLayout(false);
            this.bdgND.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDsND;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvND;
        private System.Windows.Forms.BindingNavigator bdgND;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaLoaiND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}