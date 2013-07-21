namespace QLDiemHSTHPT.Component
{
    partial class frmQuyDinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyDinh));
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanelSiSo = new DevComponents.DotNetBar.TabControlPanel();
            this.itiSStoida = new DevComponents.Editors.IntegerInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.itiSStoithieu = new DevComponents.Editors.IntegerInput();
            this.lblSisotoithieu = new DevComponents.DotNetBar.LabelX();
            this.tabSiSo = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelDoTuoi = new DevComponents.DotNetBar.TabControlPanel();
            this.itiDoTuoiCanTren = new DevComponents.Editors.IntegerInput();
            this.labelX04 = new DevComponents.DotNetBar.LabelX();
            this.itiDoTuoiCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelX03 = new DevComponents.DotNetBar.LabelX();
            this.tabDotuoi = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanelThangdiem = new DevComponents.DotNetBar.TabControlPanel();
            this.checkTD100 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.checkTD10 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.tabthangdiem = new DevComponents.DotNetBar.TabItem(this.components);
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnHuybo = new DevComponents.DotNetBar.ButtonX();
            this.btnDongy = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanelSiSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiSStoida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiSStoithieu)).BeginInit();
            this.tabControlPanelDoTuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itiDoTuoiCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiDoTuoiCanDuoi)).BeginInit();
            this.tabControlPanelThangdiem.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanelThangdiem);
            this.tabControl1.Controls.Add(this.tabControlPanelDoTuoi);
            this.tabControl1.Controls.Add(this.tabControlPanelSiSo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 3;
            this.tabControl1.Size = new System.Drawing.Size(369, 226);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabSiSo);
            this.tabControl1.Tabs.Add(this.tabthangdiem);
            this.tabControl1.Tabs.Add(this.tabDotuoi);
            // 
            // tabControlPanelSiSo
            // 
            this.tabControlPanelSiSo.Controls.Add(this.itiSStoida);
            this.tabControlPanelSiSo.Controls.Add(this.labelX1);
            this.tabControlPanelSiSo.Controls.Add(this.itiSStoithieu);
            this.tabControlPanelSiSo.Controls.Add(this.lblSisotoithieu);
            this.tabControlPanelSiSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPanelSiSo.Location = new System.Drawing.Point(0, 22);
            this.tabControlPanelSiSo.Name = "tabControlPanelSiSo";
            this.tabControlPanelSiSo.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelSiSo.Size = new System.Drawing.Size(369, 204);
            this.tabControlPanelSiSo.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelSiSo.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelSiSo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelSiSo.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelSiSo.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelSiSo.Style.GradientAngle = 90;
            this.tabControlPanelSiSo.TabIndex = 1;
            this.tabControlPanelSiSo.TabItem = this.tabSiSo;
            // 
            // itiSStoida
            // 
            // 
            // 
            // 
            this.itiSStoida.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiSStoida.Location = new System.Drawing.Point(203, 67);
            this.itiSStoida.MaxValue = 100;
            this.itiSStoida.MinValue = 10;
            this.itiSStoida.Name = "itiSStoida";
            this.itiSStoida.ShowUpDown = true;
            this.itiSStoida.Size = new System.Drawing.Size(80, 20);
            this.itiSStoida.TabIndex = 3;
            this.itiSStoida.Value = 10;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(52, 70);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(145, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Sỉ số tối đa trong một lớp:";
            // 
            // itiSStoithieu
            // 
            // 
            // 
            // 
            this.itiSStoithieu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiSStoithieu.Location = new System.Drawing.Point(203, 41);
            this.itiSStoithieu.MaxValue = 100;
            this.itiSStoithieu.MinValue = 10;
            this.itiSStoithieu.Name = "itiSStoithieu";
            this.itiSStoithieu.ShowUpDown = true;
            this.itiSStoithieu.Size = new System.Drawing.Size(80, 20);
            this.itiSStoithieu.TabIndex = 1;
            this.itiSStoithieu.Value = 10;
            // 
            // lblSisotoithieu
            // 
            this.lblSisotoithieu.BackColor = System.Drawing.Color.Transparent;
            this.lblSisotoithieu.Location = new System.Drawing.Point(52, 41);
            this.lblSisotoithieu.Name = "lblSisotoithieu";
            this.lblSisotoithieu.Size = new System.Drawing.Size(145, 23);
            this.lblSisotoithieu.TabIndex = 0;
            this.lblSisotoithieu.Text = "Sỉ số tối thiểu trong một lớp:";
            // 
            // tabSiSo
            // 
            this.tabSiSo.AttachedControl = this.tabControlPanelSiSo;
            this.tabSiSo.Name = "tabSiSo";
            this.tabSiSo.Text = "Sỉ Số";
            // 
            // tabControlPanelDoTuoi
            // 
            this.tabControlPanelDoTuoi.Controls.Add(this.itiDoTuoiCanTren);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX04);
            this.tabControlPanelDoTuoi.Controls.Add(this.itiDoTuoiCanDuoi);
            this.tabControlPanelDoTuoi.Controls.Add(this.labelX03);
            this.tabControlPanelDoTuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelDoTuoi.Location = new System.Drawing.Point(0, 22);
            this.tabControlPanelDoTuoi.Name = "tabControlPanelDoTuoi";
            this.tabControlPanelDoTuoi.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelDoTuoi.Size = new System.Drawing.Size(369, 204);
            this.tabControlPanelDoTuoi.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelDoTuoi.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelDoTuoi.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelDoTuoi.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelDoTuoi.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelDoTuoi.Style.GradientAngle = 90;
            this.tabControlPanelDoTuoi.TabIndex = 3;
            this.tabControlPanelDoTuoi.TabItem = this.tabDotuoi;
            // 
            // itiDoTuoiCanTren
            // 
            // 
            // 
            // 
            this.itiDoTuoiCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiDoTuoiCanTren.Location = new System.Drawing.Point(221, 78);
            this.itiDoTuoiCanTren.MaxValue = 50;
            this.itiDoTuoiCanTren.MinValue = 10;
            this.itiDoTuoiCanTren.Name = "itiDoTuoiCanTren";
            this.itiDoTuoiCanTren.ShowUpDown = true;
            this.itiDoTuoiCanTren.Size = new System.Drawing.Size(72, 20);
            this.itiDoTuoiCanTren.TabIndex = 6;
            this.itiDoTuoiCanTren.Value = 10;
            // 
            // labelX04
            // 
            this.labelX04.BackColor = System.Drawing.Color.Transparent;
            this.labelX04.Location = new System.Drawing.Point(61, 78);
            this.labelX04.Name = "labelX04";
            this.labelX04.Size = new System.Drawing.Size(154, 20);
            this.labelX04.TabIndex = 4;
            this.labelX04.Text = "Độ tuổi tối đa của học sinh:";
            // 
            // itiDoTuoiCanDuoi
            // 
            // 
            // 
            // 
            this.itiDoTuoiCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.itiDoTuoiCanDuoi.Location = new System.Drawing.Point(221, 38);
            this.itiDoTuoiCanDuoi.MaxValue = 50;
            this.itiDoTuoiCanDuoi.MinValue = 10;
            this.itiDoTuoiCanDuoi.Name = "itiDoTuoiCanDuoi";
            this.itiDoTuoiCanDuoi.ShowUpDown = true;
            this.itiDoTuoiCanDuoi.Size = new System.Drawing.Size(72, 20);
            this.itiDoTuoiCanDuoi.TabIndex = 5;
            this.itiDoTuoiCanDuoi.Value = 10;
            // 
            // labelX03
            // 
            this.labelX03.BackColor = System.Drawing.Color.Transparent;
            this.labelX03.Location = new System.Drawing.Point(61, 38);
            this.labelX03.Name = "labelX03";
            this.labelX03.Size = new System.Drawing.Size(154, 20);
            this.labelX03.TabIndex = 3;
            this.labelX03.Text = "Độ tuổi tối thiểu của học sinh:";
            // 
            // tabDotuoi
            // 
            this.tabDotuoi.AttachedControl = this.tabControlPanelDoTuoi;
            this.tabDotuoi.Name = "tabDotuoi";
            this.tabDotuoi.Text = "Độ Tuổi";
            // 
            // tabControlPanelThangdiem
            // 
            this.tabControlPanelThangdiem.Controls.Add(this.checkTD100);
            this.tabControlPanelThangdiem.Controls.Add(this.checkTD10);
            this.tabControlPanelThangdiem.Controls.Add(this.labelX2);
            this.tabControlPanelThangdiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanelThangdiem.Location = new System.Drawing.Point(0, 22);
            this.tabControlPanelThangdiem.Name = "tabControlPanelThangdiem";
            this.tabControlPanelThangdiem.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanelThangdiem.Size = new System.Drawing.Size(369, 204);
            this.tabControlPanelThangdiem.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanelThangdiem.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanelThangdiem.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanelThangdiem.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanelThangdiem.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanelThangdiem.Style.GradientAngle = 90;
            this.tabControlPanelThangdiem.TabIndex = 2;
            this.tabControlPanelThangdiem.TabItem = this.tabthangdiem;
            // 
            // checkTD100
            // 
            this.checkTD100.BackColor = System.Drawing.Color.Transparent;
            this.checkTD100.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkTD100.Location = new System.Drawing.Point(107, 69);
            this.checkTD100.Name = "checkTD100";
            this.checkTD100.Size = new System.Drawing.Size(154, 23);
            this.checkTD100.TabIndex = 2;
            this.checkTD100.Text = "Thang điểm 100";
            // 
            // checkTD10
            // 
            this.checkTD10.BackColor = System.Drawing.Color.Transparent;
            this.checkTD10.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkTD10.Location = new System.Drawing.Point(107, 40);
            this.checkTD10.Name = "checkTD10";
            this.checkTD10.Size = new System.Drawing.Size(154, 23);
            this.checkTD10.TabIndex = 1;
            this.checkTD10.Text = "Thang điểm 10";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(1, 1);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(367, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Thang điểm theo quy định khi đánh giá kết quả học tập";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tabthangdiem
            // 
            this.tabthangdiem.AttachedControl = this.tabControlPanelThangdiem;
            this.tabthangdiem.Name = "tabthangdiem";
            this.tabthangdiem.Text = "Thang Điểm";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.btnHuybo);
            this.panelEx1.Controls.Add(this.btnDongy);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 173);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(369, 53);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // btnHuybo
            // 
            this.btnHuybo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuybo.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnHuybo.Location = new System.Drawing.Point(190, 18);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 23);
            this.btnHuybo.TabIndex = 1;
            this.btnHuybo.Text = "Hủy Bỏ";
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnDongy
            // 
            this.btnDongy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongy.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.btnDongy.Location = new System.Drawing.Point(90, 18);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 0;
            this.btnDongy.Text = "Đồng Ý";
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 226);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUY ĐỊNH";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanelSiSo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itiSStoida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiSStoithieu)).EndInit();
            this.tabControlPanelDoTuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itiDoTuoiCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itiDoTuoiCanDuoi)).EndInit();
            this.tabControlPanelThangdiem.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelSiSo;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelThangdiem;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX btnHuybo;
        private DevComponents.DotNetBar.ButtonX btnDongy;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanelDoTuoi;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkTD10;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.Editors.IntegerInput itiSStoida;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkTD100;
        private DevComponents.Editors.IntegerInput itiDoTuoiCanTren;
        private DevComponents.DotNetBar.LabelX labelX04;
        private DevComponents.Editors.IntegerInput itiDoTuoiCanDuoi;
        private DevComponents.DotNetBar.LabelX labelX03;
        private DevComponents.Editors.IntegerInput itiSStoithieu;
        private DevComponents.DotNetBar.LabelX lblSisotoithieu;
        public DevComponents.DotNetBar.TabItem tabSiSo;
        public DevComponents.DotNetBar.TabItem tabthangdiem;
        public DevComponents.DotNetBar.TabItem tabDotuoi;
    }
}