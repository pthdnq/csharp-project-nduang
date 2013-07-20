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
    public partial class frptKetQuaHocKy_TongHop : Office2007Form
    {
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();

        public frptKetQuaHocKy_TongHop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frptKetQuaHocKy_Lop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }

        private void reportViewerKQCNTH_Load(object sender, EventArgs e)
        {

        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            
        }

        private void bdKQHKLop_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));
            this.reportViewerKQHKLop.LocalReport.SetParameters(param);

            IList<KQHKTongHopInfo> ketqua = KQHKTongHopCtrl.LayDsKQHocKyTongHop(cmbLop.SelectedValue.ToString(),
                                                                                    cmbHocKy.SelectedValue.ToString(),
                                                                                    cmbNamHoc.SelectedValue.ToString());
            this.bdKQHKLop.DataSource = ketqua;
            this.reportViewerKQHKLop.RefreshReport();
        }

        private void groupPanelDS_Click(object sender, EventArgs e)
        {

        }
        }
    }
