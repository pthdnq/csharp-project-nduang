namespace QLDiemHSTHPT
{
    partial class frmDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDictionary));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbWord = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lvLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanelTTLopcu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtTimkiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupPanelTTLopcu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtMeaning);
            this.panel3.Controls.Add(this.groupPanel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 520);
            this.panel3.TabIndex = 1;
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.txtMeaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeaning.ForeColor = System.Drawing.Color.Red;
            this.txtMeaning.Location = new System.Drawing.Point(134, 58);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(772, 462);
            this.txtMeaning.TabIndex = 14;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lbWord);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(134, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(772, 58);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 13;
            this.groupPanel1.Text = "Meaning";
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Location = new System.Drawing.Point(35, 10);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(30, 13);
            this.lbWord.TabIndex = 0;
            this.lbWord.Text = "word";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lvLopCu);
            this.panel4.Controls.Add(this.groupPanelTTLopcu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(134, 520);
            this.panel4.TabIndex = 0;
            // 
            // lvLopCu
            // 
            // 
            // 
            // 
            this.lvLopCu.Border.Class = "ListViewBorder";
            this.lvLopCu.Border.PaddingLeft = 5;
            this.lvLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu,
            this.colNgaySinh});
            this.lvLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLopCu.FullRowSelect = true;
            this.lvLopCu.Location = new System.Drawing.Point(0, 58);
            this.lvLopCu.Name = "lvLopCu";
            this.lvLopCu.Size = new System.Drawing.Size(134, 462);
            this.lvLopCu.TabIndex = 15;
            this.lvLopCu.UseCompatibleStateImageBehavior = false;
            this.lvLopCu.View = System.Windows.Forms.View.Details;
            this.lvLopCu.SelectedIndexChanged += new System.EventHandler(this.lvLopCu_SelectedIndexChanged_1);
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "ID_Word";
            this.colMaHSCu.Width = 5;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Word";
            this.colHoTenCu.Width = 150;
            // 
            // groupPanelTTLopcu
            // 
            this.groupPanelTTLopcu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelTTLopcu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelTTLopcu.Controls.Add(this.txtTimkiem);
            this.groupPanelTTLopcu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelTTLopcu.Location = new System.Drawing.Point(0, 0);
            this.groupPanelTTLopcu.Name = "groupPanelTTLopcu";
            this.groupPanelTTLopcu.Size = new System.Drawing.Size(134, 58);
            // 
            // 
            // 
            this.groupPanelTTLopcu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelTTLopcu.Style.BackColorGradientAngle = 90;
            this.groupPanelTTLopcu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelTTLopcu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderBottomWidth = 1;
            this.groupPanelTTLopcu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelTTLopcu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderLeftWidth = 1;
            this.groupPanelTTLopcu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderRightWidth = 1;
            this.groupPanelTTLopcu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelTTLopcu.Style.BorderTopWidth = 1;
            this.groupPanelTTLopcu.Style.CornerDiameter = 4;
            this.groupPanelTTLopcu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelTTLopcu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelTTLopcu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelTTLopcu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelTTLopcu.TabIndex = 14;
            this.groupPanelTTLopcu.Text = "Word";
            // 
            // txtTimkiem
            // 
            // 
            // 
            // 
            this.txtTimkiem.Border.Class = "TextBoxBorder";
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(0, 3);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(125, 20);
            this.txtTimkiem.TabIndex = 6;
            this.txtTimkiem.WatermarkText = "Enter word";
            this.txtTimkiem.ButtonCustomClick += new System.EventHandler(this.frmDictionary_MouseHover);
            this.txtTimkiem.ButtonCustom2Click += new System.EventHandler(this.frmMain_Activated);
            this.txtTimkiem.SizeChanged += new System.EventHandler(this.txtTimkiem_SizeChanged);
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            this.txtTimkiem.Enter += new System.EventHandler(this.txtTimkiem_Enter);
            this.txtTimkiem.Leave += new System.EventHandler(this.txtTimkiem_Leave);
            this.txtTimkiem.MouseHover += new System.EventHandler(this.txtTimkiem_MouseHover);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 96);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(906, 96);
            this.panel5.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::QLDiemHSTHPT.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(715, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Dictionary";
            // 
            // frmDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 520);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDictionary";
            this.Text = "Dictionary";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmPhanLop_Activated);
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmDictionary_MdiChildActivate);
            this.SizeChanged += new System.EventHandler(this.frmDictionary_SizeChanged);
            this.Enter += new System.EventHandler(this.frmDictionary_Enter);
            this.MouseHover += new System.EventHandler(this.frmDictionary_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupPanelTTLopcu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.TextBox txtMeaning;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopCu;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelTTLopcu;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}