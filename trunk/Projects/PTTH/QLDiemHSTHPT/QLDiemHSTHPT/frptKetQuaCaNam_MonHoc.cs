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
    public partial class frptKetQuaCaNam_MonHoc : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        public frptKetQuaCaNam_MonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frptKetQuaCaNam_MonHoc_Load(object sender, EventArgs e)
        {
                 m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
                cmbMonHoc.DataBindings.Clear();
            cmbLop.DataBindings.Clear();
        }

        //private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
        //        m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
        //    cmbMonHoc.DataBindings.Clear();
        //}

        private void buttonX1_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.Text));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));
            this.reportViewerKQCNMH.LocalReport.SetParameters(param);

            IList<KQCNMonHocInfo> ketqua = KQCNMonHocCtrl.LayDsKQCaNamMonHoc(cmbLop.SelectedValue.ToString(),
                                                                                  cmbMonHoc.SelectedValue.ToString(),
                                                                                 cmbNamHoc.SelectedValue.ToString());

            this.bdKQCNMH.DataSource = ketqua;
            this.reportViewerKQCNMH.RefreshReport();

            
        }
    }
}