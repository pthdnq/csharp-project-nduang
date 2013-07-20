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
    public partial class frptDanhSachGiaoVien : Office2007Form
    {
        public frptDanhSachGiaoVien()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frptDanhSachGiaoVien_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
             param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerDSGV.LocalReport.SetParameters(param);
            IList<GiaoVienInfo> GV = GiaoVienCtrl.LayDsGiaoVien();
            this.bdDanhSachGiaoVien.DataSource = GV;
            
            this.reportViewerDSGV.RefreshReport();
        }

       
    }
}