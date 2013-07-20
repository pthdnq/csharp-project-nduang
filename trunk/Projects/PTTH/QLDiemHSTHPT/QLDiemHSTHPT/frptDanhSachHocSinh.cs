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
    public partial class frptDanhSachHocSinh : Office2007Form
    {
        public frptDanhSachHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frptDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerDSHS.LocalReport.SetParameters(param);

            IList<GiaoVienInfo> giaovien = GiaoVienCtrl.LayDsGiaoVien();
            IList<HocSinhInfo> HS = HocSinhCtrl.LayDsHocSinh();
            this.bsDanhSachHocSinh.DataSource = HS;
            this.reportViewerDSHS.RefreshReport();
        }
    }
}