namespace QLDiemHSTHPT
{
    partial class frptDanhSachGiaoVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frptDanhSachGiaoVien));
            this.reportViewerDSGV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bdDanhSachGiaoVien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdDanhSachGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerDSGV
            // 
            this.reportViewerDSGV.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "QLDiemHSTHPT_Bussiness_GiaoVienInfo";
            reportDataSource1.Value = this.bdDanhSachGiaoVien;
            this.reportViewerDSGV.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerDSGV.LocalReport.ReportEmbeddedResource = "QLDiemHSTHPT.rptDSGV.rdlc";
            this.reportViewerDSGV.Location = new System.Drawing.Point(0, 0);
            this.reportViewerDSGV.Name = "reportViewerDSGV";
            this.reportViewerDSGV.Size = new System.Drawing.Size(626, 442);
            this.reportViewerDSGV.TabIndex = 0;
            this.reportViewerDSGV.Load += new System.EventHandler(this.reportViewerDSGV_Load);
            // 
            // bdDanhSachGiaoVien
            // 
            this.bdDanhSachGiaoVien.DataSource = typeof(QLDiemHSTHPT.Bussiness.GiaoVienInfo);
            // 
            // frptDanhSachGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 442);
            this.Controls.Add(this.reportViewerDSGV);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frptDanhSachGiaoVien";
            this.Text = "Danh Sách Giáo Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frptDanhSachGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdDanhSachGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerDSGV;
        private System.Windows.Forms.BindingSource bdDanhSachGiaoVien;
    }
}