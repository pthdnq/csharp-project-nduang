﻿namespace QLPT
{
    partial class FrmBaoCaoVanHanh
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_VanHanh_DataSet = new QLPT.View_VanHanh_DataSet();
            this.View_VanHanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_VanHanhTableAdapter = new QLPT.View_VanHanh_DataSetTableAdapters.View_VanHanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_VanHanh_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_VanHanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVanHanh";
            reportDataSource1.Value = this.View_VanHanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLPT.BaoCaoVanHanh.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1133, 597);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_VanHanh_DataSet
            // 
            this.View_VanHanh_DataSet.DataSetName = "View_VanHanh_DataSet";
            this.View_VanHanh_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_VanHanhBindingSource
            // 
            this.View_VanHanhBindingSource.DataMember = "View_VanHanh";
            this.View_VanHanhBindingSource.DataSource = this.View_VanHanh_DataSet;
            // 
            // View_VanHanhTableAdapter
            // 
            this.View_VanHanhTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBaoCaoVanHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 597);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBaoCaoVanHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo vận hành chi tiết";
            this.Load += new System.EventHandler(this.FrmBaoCaoVanHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_VanHanh_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_VanHanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_VanHanhBindingSource;
        private View_VanHanh_DataSet View_VanHanh_DataSet;
        private View_VanHanh_DataSetTableAdapters.View_VanHanhTableAdapter View_VanHanhTableAdapter;
    }
}