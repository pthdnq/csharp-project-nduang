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
    public partial class frptKetQuaHocKy_MonHoc : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();

        public frptKetQuaHocKy_MonHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frptKetQuaHocKy_MonHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));
            this.reportViewerKQHKMH.LocalReport.SetParameters(param);

            IList<KQHKMonHocInfo> ketqua = KQHKMonHocCtrl.LayDsKQHocKyMonHoc(cmbLop.SelectedValue.ToString(),
                                                                            cmbMonHoc.SelectedValue.ToString(),
                                                                                   cmbHocKy.SelectedValue.ToString(),
                                                                                   cmbNamHoc.SelectedValue.ToString());
            this.bdKQHKMH.DataSource = ketqua;
            this.reportViewerKQHKMH.RefreshReport();
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }
    }
}