namespace QLDiemHSTHPT
{
    partial class frmLoaiDiem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiDiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDsLD = new System.Windows.Forms.GroupBox();
            this.dgvLD = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaLoaiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgLoaiDiem = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupBoxDsLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLoaiDiem)).BeginInit();
            this.bdgLoaiDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDsLD
            // 
            this.groupBoxDsLD.Controls.Add(this.dgvLD);
            this.groupBoxDsLD.Controls.Add(this.bdgLoaiDiem);
            resources.ApplyResources(this.groupBoxDsLD, "groupBoxDsLD");
            this.groupBoxDsLD.Name = "groupBoxDsLD";
            this.groupBoxDsLD.TabStop = false;
            // 
            // dgvLD
            // 
            this.dgvLD.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiDiem,
            this.TenLoaiDiem,
            this.HeSo});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLD.DefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.dgvLD, "dgvLD");
            this.dgvLD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLD.Name = "dgvLD";
            // 
            // MaLoaiDiem
            // 
            this.MaLoaiDiem.DataPropertyName = "MaLoaiDiem";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLoaiDiem.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.MaLoaiDiem, "MaLoaiDiem");
            this.MaLoaiDiem.Name = "MaLoaiDiem";
            // 
            // TenLoaiDiem
            // 
            this.TenLoaiDiem.DataPropertyName = "TenLoaiDiem";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoaiDiem.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.TenLoaiDiem, "TenLoaiDiem");
            this.TenLoaiDiem.Name = "TenLoaiDiem";
            // 
            // HeSo
            // 
            this.HeSo.DataPropertyName = "HeSo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeSo.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.HeSo, "HeSo");
            this.HeSo.Name = "HeSo";
            // 
            // bdgLoaiDiem
            // 
            this.bdgLoaiDiem.AddNewItem = null;
            this.bdgLoaiDiem.CountItem = this.bindingNavigatorCountItem;
            this.bdgLoaiDiem.CountItemFormat = "của {0}";
            this.bdgLoaiDiem.DeleteItem = null;
            this.bdgLoaiDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            resources.ApplyResources(this.bdgLoaiDiem, "bdgLoaiDiem");
            this.bdgLoaiDiem.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgLoaiDiem.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgLoaiDiem.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgLoaiDiem.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgLoaiDiem.Name = "bdgLoaiDiem";
            this.bdgLoaiDiem.PositionItem = this.bindingNavigatorPositionItem;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            resources.ApplyResources(this.bindingNavigatorCountItem, "bindingNavigatorCountItem");
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveFirstItem, "bindingNavigatorMoveFirstItem");
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMovePreviousItem, "bindingNavigatorMovePreviousItem");
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            resources.ApplyResources(this.bindingNavigatorSeparator, "bindingNavigatorSeparator");
            // 
            // bindingNavigatorPositionItem
            // 
            resources.ApplyResources(this.bindingNavigatorPositionItem, "bindingNavigatorPositionItem");
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            resources.ApplyResources(this.bindingNavigatorSeparator1, "bindingNavigatorSeparator1");
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveNextItem, "bindingNavigatorMoveNextItem");
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.bindingNavigatorMoveLastItem, "bindingNavigatorMoveLastItem");
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            resources.ApplyResources(this.bindingNavigatorSeparator2, "bindingNavigatorSeparator2");
            // 
            // bngThemmoi
            // 
            this.bngThemmoi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngThemmoi.Image = global::QLDiemHSTHPT.Properties.Resources.add;
            resources.ApplyResources(this.bngThemmoi, "bngThemmoi");
            this.bngThemmoi.Name = "bngThemmoi";
            this.bngThemmoi.Click += new System.EventHandler(this.bngThemmoi_Click);
            // 
            // bngXoa
            // 
            this.bngXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngXoa.Image = global::QLDiemHSTHPT.Properties.Resources.delete;
            resources.ApplyResources(this.bngXoa, "bngXoa");
            this.bngXoa.Name = "bngXoa";
            this.bngXoa.Click += new System.EventHandler(this.bngXoa_Click);
            // 
            // bngluu
            // 
            this.bngluu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngluu.Image = global::QLDiemHSTHPT.Properties.Resources.save;
            resources.ApplyResources(this.bngluu, "bngluu");
            this.bngluu.Name = "bngluu";
            this.bngluu.Click += new System.EventHandler(this.bngluu_Click);
            // 
            // bngthoat
            // 
            this.bngthoat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bngthoat.Image = global::QLDiemHSTHPT.Properties.Resources.exit;
            resources.ApplyResources(this.bngthoat, "bngthoat");
            this.bngthoat.Name = "bngthoat";
            this.bngthoat.Click += new System.EventHandler(this.bngthoat_Click);
            // 
            // frmLoaiDiem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxDsLD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoaiDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiDiem_Load);
            this.groupBoxDsLD.ResumeLayout(false);
            this.groupBoxDsLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgLoaiDiem)).EndInit();
            this.bdgLoaiDiem.ResumeLayout(false);
            this.bdgLoaiDiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDsLD;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLD;
        private System.Windows.Forms.BindingNavigator bdgLoaiDiem;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
    }
}