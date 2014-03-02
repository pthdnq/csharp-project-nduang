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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.View_Info_PhuongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_View_Info_PhuongTien = new QLPT.DataSet_View_Info_PhuongTien();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_Info_PhuongTienTableAdapter = new QLPT.DataSet_View_Info_PhuongTienTableAdapters.View_Info_PhuongTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_Info_PhuongTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_View_Info_PhuongTien)).BeginInit();
            this.SuspendLayout();
            // 
            // View_Info_PhuongTienBindingSource
            // 
            this.View_Info_PhuongTienBindingSource.DataMember = "View_Info_PhuongTien";
            this.View_Info_PhuongTienBindingSource.DataSource = this.DataSet_View_Info_PhuongTien;
            // 
            // DataSet_View_Info_PhuongTien
            // 
            this.DataSet_View_Info_PhuongTien.DataSetName = "DataSet_View_Info_PhuongTien";
            this.DataSet_View_Info_PhuongTien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_ThongTin_PhuongTien";
            reportDataSource1.Value = this.View_Info_PhuongTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.BaoCaoThongTinPT.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(633, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_Info_PhuongTienTableAdapter
            // 
            this.View_Info_PhuongTienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaoCaoThongTinPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaoCaoThongTinPT";
            this.Text = "Danh sách chi tiết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBaoCaoThongTinPT_FormClosing);
            this.Load += new System.EventHandler(this.FrmBaoCaoThongTinPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_Info_PhuongTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_View_Info_PhuongTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_Info_PhuongTienBindingSource;
        private DataSet_View_Info_PhuongTien DataSet_View_Info_PhuongTien;
        private DataSet_View_Info_PhuongTienTableAdapters.View_Info_PhuongTienTableAdapter View_Info_PhuongTienTableAdapter;
        
    }
}