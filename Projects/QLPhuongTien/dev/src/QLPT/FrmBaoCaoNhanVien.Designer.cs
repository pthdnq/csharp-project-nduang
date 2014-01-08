namespace QLPT
{
    partial class FrmBaoCaoNhanVien
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
            this.View_NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_View_NhanVien = new QLPT.DataSet_View_NhanVien();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_NhanVienTableAdapter = new QLPT.DataSet_View_NhanVienTableAdapters.View_NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_View_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // View_NhanVienBindingSource
            // 
            this.View_NhanVienBindingSource.DataMember = "View_NhanVien";
            this.View_NhanVienBindingSource.DataSource = this.DataSet_View_NhanVien;
            // 
            // DataSet_View_NhanVien
            // 
            this.DataSet_View_NhanVien.DataSetName = "DataSet_View_NhanVien";
            this.DataSet_View_NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_NhanVien";
            reportDataSource1.Value = this.View_NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.BaoCaoNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1000, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_NhanVienTableAdapter
            // 
            this.View_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaoCaoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 539);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaoCaoNhanVien";
            this.Text = "Danh sách thông tin chi tiết nhân viên";
            this.Load += new System.EventHandler(this.FrmBaoCaoNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_View_NhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_NhanVienBindingSource;
        private DataSet_View_NhanVien DataSet_View_NhanVien;
        private DataSet_View_NhanVienTableAdapters.View_NhanVienTableAdapter View_NhanVienTableAdapter;
    }
}