using System.Windows.Forms;
namespace QLDiemHSTHPT
{
    partial class frmHocLuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocLuc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDshocluc = new System.Windows.Forms.GroupBox();
            this.dgvhocluc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bdgHocluc = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.MaHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCanDuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemCanTren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemKhongChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDshocluc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhocluc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgHocluc)).BeginInit();
            this.bdgHocluc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDshocluc
            // 
            this.groupBoxDshocluc.Controls.Add(this.dgvhocluc);
            this.groupBoxDshocluc.Controls.Add(this.bdgHocluc);
            this.groupBoxDshocluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDshocluc.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDshocluc.Name = "groupBoxDshocluc";
            this.groupBoxDshocluc.Size = new System.Drawing.Size(699, 462);
            this.groupBoxDshocluc.TabIndex = 2;
            this.groupBoxDshocluc.TabStop = false;
            this.groupBoxDshocluc.Text = "Danh Sách Học Lực";
            // 
            // dgvhocluc
            // 
            this.dgvhocluc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvhocluc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhocluc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvhocluc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhocluc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHocLuc,
            this.TenHocLuc,
            this.DiemCanDuoi,
            this.DiemCanTren,
            this.DiemKhongChe});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvhocluc.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvhocluc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhocluc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvhocluc.Location = new System.Drawing.Point(3, 41);
            this.dgvhocluc.Name = "dgvhocluc";
            this.dgvhocluc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvhocluc.Size = new System.Drawing.Size(693, 418);
            this.dgvhocluc.TabIndex = 1;
            // 
            // bdgHocluc
            // 
            this.bdgHocluc.AddNewItem = null;
            this.bdgHocluc.CountItem = this.bindingNavigatorCountItem;
            this.bdgHocluc.CountItemFormat = "của {0}";
            this.bdgHocluc.DeleteItem = null;
            this.bdgHocluc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bngthoat});
            this.bdgHocluc.Location = new System.Drawing.Point(3, 16);
            this.bdgHocluc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgHocluc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgHocluc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgHocluc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgHocluc.Name = "bdgHocluc";
            this.bdgHocluc.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgHocluc.Size = new System.Drawing.Size(693, 25);
            this.bdgHocluc.TabIndex = 0;
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
            this.bngThemmoi.Enabled = false;
            this.bngThemmoi.Image = global::QLDiemHSTHPT.Properties.Resources.add;
            this.bngThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngThemmoi.Name = "bngThemmoi";
            this.bngThemmoi.Size = new System.Drawing.Size(61, 22);
            this.bngThemmoi.Text = "Thêm ";
            this.bngThemmoi.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // bngXoa
            // 
            this.bngXoa.Enabled = false;
            this.bngXoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            this.bngXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngXoa.Name = "bngXoa";
            this.bngXoa.Size = new System.Drawing.Size(47, 22);
            this.bngXoa.Text = "Xóa";
            this.bngXoa.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // bngluu
            // 
            this.bngluu.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            this.bngluu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngluu.Name = "bngluu";
            this.bngluu.Size = new System.Drawing.Size(47, 22);
            this.bngluu.Text = "Lưu";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // bngthoat
            // 
            this.bngthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            this.bngthoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bngthoat.Name = "bngthoat";
            this.bngthoat.Size = new System.Drawing.Size(58, 22);
            this.bngthoat.Text = "Thoát";
            this.bngthoat.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // MaHocLuc
            // 
            this.MaHocLuc.DataPropertyName = "MaHocLuc";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaHocLuc.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaHocLuc.HeaderText = "Mã Học Lực";
            this.MaHocLuc.Name = "MaHocLuc";
            this.MaHocLuc.ReadOnly = true;
            this.MaHocLuc.Width = 130;
            // 
            // TenHocLuc
            // 
            this.TenHocLuc.DataPropertyName = "TenHocLuc";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenHocLuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.TenHocLuc.HeaderText = "Tên Học Lực";
            this.TenHocLuc.Name = "TenHocLuc";
            this.TenHocLuc.ReadOnly = true;
            this.TenHocLuc.Width = 130;
            // 
            // DiemCanDuoi
            // 
            this.DiemCanDuoi.DataPropertyName = "DiemCanDuoi";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemCanDuoi.DefaultCellStyle = dataGridViewCellStyle4;
            this.DiemCanDuoi.HeaderText = "Điểm Cận Dưới";
            this.DiemCanDuoi.Name = "DiemCanDuoi";
            this.DiemCanDuoi.Width = 130;
            // 
            // DiemCanTren
            // 
            this.DiemCanTren.DataPropertyName = "DiemCanTren";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemCanTren.DefaultCellStyle = dataGridViewCellStyle5;
            this.DiemCanTren.HeaderText = "Điểm Cận Trên";
            this.DiemCanTren.Name = "DiemCanTren";
            this.DiemCanTren.Width = 130;
            // 
            // DiemKhongChe
            // 
            this.DiemKhongChe.DataPropertyName = "DiemKhongChe";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiemKhongChe.DefaultCellStyle = dataGridViewCellStyle6;
            this.DiemKhongChe.HeaderText = "Điểm Khống Chế";
            this.DiemKhongChe.Name = "DiemKhongChe";
            this.DiemKhongChe.Width = 130;
            // 
            // frmHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 462);
            this.Controls.Add(this.groupBoxDshocluc);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHocLuc";
            this.Text = "Học Lực";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocLuc_Load);
            this.groupBoxDshocluc.ResumeLayout(false);
            this.groupBoxDshocluc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhocluc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgHocluc)).EndInit();
            this.bdgHocluc.ResumeLayout(false);
            this.bdgHocluc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDshocluc;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvhocluc;
        private System.Windows.Forms.BindingNavigator bdgHocluc;
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
        private DataGridViewTextBoxColumn MaHocLuc;
        private DataGridViewTextBoxColumn TenHocLuc;
        private DataGridViewTextBoxColumn DiemCanDuoi;
        private DataGridViewTextBoxColumn DiemCanTren;
        private DataGridViewTextBoxColumn DiemKhongChe;
    }
}