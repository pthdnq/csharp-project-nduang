namespace QLDiemHSTHPT
{
    partial class frptDanhSachHocSinh
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frptDanhSachHocSinh));
            this.reportViewerDSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsDanhSachHocSinh = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDanhSachHocSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDSHS
            // 
            this.reportViewerDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QLDiemHSTHPT_Bussiness_HocSinhInfo";
            reportDataSource1.Value = this.bsDanhSachHocSinh;
            this.reportViewerDSHS.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSHS.LocalReport.ReportEmbeddedResource = "QLDiemHSTHPT.rptDSHS.rdlc";
            this.reportViewerDSHS.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSHS.Name = "reportViewerDSHS";
            this.reportViewerDSHS.Size = new System.Drawing.Size(620, 355);
            this.reportViewerDSHS.TabIndex = 0;
            // 
            // bsDanhSachHocSinh
            // 
            this.bsDanhSachHocSinh.DataSource = typeof(QLDiemHSTHPT.Bussiness.HocSinhInfo);
            // 
            // frptDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 355);
            this.Controls.Add(this.reportViewerDSHS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frptDanhSachHocSinh";
            this.Text = "Danh Sách Học Sinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDanhSachHocSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDSHS;
        private System.Windows.Forms.BindingSource bsDanhSachHocSinh;
    }
}