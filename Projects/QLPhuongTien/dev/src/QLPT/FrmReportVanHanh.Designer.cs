﻿namespace QLPT
{
    partial class FrmReportVanHanh
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
            this.View_PhuongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLy_PTDataSet = new QLPT.QuanLy_PTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_PhuongTienTableAdapter = new QLPT.QuanLy_PTDataSetTableAdapters.View_PhuongTienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_PhuongTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_PTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // View_PhuongTienBindingSource
            // 
            this.View_PhuongTienBindingSource.DataMember = "View_PhuongTien";
            this.View_PhuongTienBindingSource.DataSource = this.QuanLy_PTDataSet;
            // 
            // QuanLy_PTDataSet
            // 
            this.QuanLy_PTDataSet.DataSetName = "QuanLy_PTDataSet";
            this.QuanLy_PTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_PhuongTienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(627, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_PhuongTienTableAdapter
            // 
            this.View_PhuongTienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportVanHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportVanHanh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmReportVanHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_PhuongTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLy_PTDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_PhuongTienBindingSource;
        private QuanLy_PTDataSet QuanLy_PTDataSet;
        private QuanLy_PTDataSetTableAdapters.View_PhuongTienTableAdapter View_PhuongTienTableAdapter;
    }
}