using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemHSTHPT.Bussiness;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.DataLayer;
using Microsoft.Reporting.WinForms;
namespace QLDiemHSTHPT
{
    public partial class frptDanhSachLop : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        public frptDanhSachLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmDanhSachLop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            this.reportViewerDSLop.LocalReport.SetParameters(param);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            IList<LopInfo> lop = LopCtrl.LayDsLop(cmbNamHoc.SelectedValue.ToString());          

            this.bdDanhSachLop.DataSource = lop;
            this.reportViewerDSLop.RefreshReport();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            IList<LopInfo> lop = LopCtrl.LayDsLop();
            this.bdDanhSachLop.DataSource = lop;
            this.reportViewerDSLop.RefreshReport();
        }
    }
}