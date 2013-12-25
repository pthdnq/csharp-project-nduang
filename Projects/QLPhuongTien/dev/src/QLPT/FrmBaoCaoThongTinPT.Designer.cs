namespace QLPT
{
    partial class FrmBaoCaoThongTinPT
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
           
            this.View_Info_PhuongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
           
            ((System.ComponentModel.ISupportInitialize)(this.View_Info_PhuongTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet_Info_PhuongTien";
            reportDataSource2.Value = this.View_Info_PhuongTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.BaoCaoThongTinPT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_Info_PhuongTien_DataSet
            // 
          
            // 
            // View_Info_PhuongTienBindingSource
            // 
            // View_Info_PhuongTienTableAdapter
            // 
            // FrmBaoCaoThongTinPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaoCaoThongTinPT";
            this.Text = "FrmBaoCaoThongTinPT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBaoCaoThongTinPT_Load);
      
            ((System.ComponentModel.ISupportInitialize)(this.View_Info_PhuongTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Info_PhuongTienBindingSource;
        
    }
}