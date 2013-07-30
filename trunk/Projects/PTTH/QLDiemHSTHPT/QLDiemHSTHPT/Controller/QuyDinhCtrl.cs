using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using QLDiemHSTHPT.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class QuyDinhCtrl
    {
        QuyDinhData m_QuyDinhData = new QuyDinhData();
        public void HienThi(IntegerInput itiSiSoCanDuoi,
                            IntegerInput itiSiSoCanTren,
                            IntegerInput itiDoTuoiCanDuoi,
                            IntegerInput itiDoTuoiCanTren,
                            CheckBoxX ckbThang10,
                            CheckBoxX ckbThang100)
        {
            BindingSource bS = new BindingSource();
            bS.DataSource = m_QuyDinhData.LayDsQuyDinh();

            DataTable DT = m_QuyDinhData.LayDsQuyDinh();
            int thangDiem =10;
            try
            {
                thangDiem = Convert.ToInt32(DT.Rows[0]["ThangDiem"]);
            }
            catch (System.Exception)
            {
                thangDiem = 10;
            }
             

            if (thangDiem == 10)
                ckbThang10.Checked = true;
            else
                ckbThang100.Checked = true;

            itiSiSoCanDuoi.DataBindings.Clear();
            itiSiSoCanDuoi.DataBindings.Add("Value", bS, "SiSoCanDuoi");

           itiSiSoCanTren.DataBindings.Clear();
            itiSiSoCanTren.DataBindings.Add("Value", bS, "SiSoCanTren");

            itiDoTuoiCanDuoi.DataBindings.Clear();
            itiDoTuoiCanDuoi.DataBindings.Add("Value", bS, "TuoiCanDuoi");

            itiDoTuoiCanTren.DataBindings.Clear();
            itiDoTuoiCanTren.DataBindings.Add("Value", bS, "TuoiCanTren");
           
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            m_QuyDinhData.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            m_QuyDinhData.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatQuyDinhThangDiem(int thangDiem)
        {
            m_QuyDinhData.CapNhatQuyDinhThangDiem(thangDiem);
        }
    }
}
