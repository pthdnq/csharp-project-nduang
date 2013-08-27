using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.Bussiness;
using QLDiemHSTHPT.DataLayer;
using System.Data.OleDb;

using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class GiaoVienCtrl
    {
       GiaoVienData m_GiaoVienData = new GiaoVienData();

       public void HienThiComboBox(ComboBox comboBox)
       {
           comboBox.DataSource = m_GiaoVienData.LayDsGiaoVien();
           comboBox.DisplayMember = "TenGiaoVien";
           comboBox.ValueMember = "MaGiaoVien";
       }

       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_GiaoVienData.LayDsGiaoVien();
           cmbColumn.DisplayMember = "TenGiaoVien";
           cmbColumn.ValueMember = "MaGiaoVien";
           cmbColumn.DataPropertyName = "MaGiaoVien";
           cmbColumn.HeaderText = "Giáo viên";
       }

      
       public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN
                            )
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_GiaoVienData.LayDsGiaoVien();
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }

       public DataRow ThemDongMoi()
       {
           return m_GiaoVienData.ThemDongMoi();
       }


       public void ThemGiaoVien(DataRow m_Row)
       {
           m_GiaoVienData.ThemGiaoVien(m_Row);
       }

       public bool LuuGiaoVien()
       {
           return m_GiaoVienData.LuuGiaoVien();
       }

       public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon,bool gioitinh)
       {
           m_GiaoVienData.LuuGiaoVien(maGiaoVien, tenGiaoVien, diaChi, dienThoai, chuyenMon ,gioitinh);
       }

       public static IList<GiaoVienInfo> LayDsGiaoVien()
       {
           GiaoVienData m_GVData = new GiaoVienData();
           DataTable m_DT = m_GVData.LayDsGiaoVienForReport();

           IList<GiaoVienInfo> dS = new List<GiaoVienInfo>();

           foreach (DataRow Row in m_DT.Rows)
           {
              
               MonHocInfo mh = new MonHocInfo();
               mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
               mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);
               mh.SoTiet = Convert.ToInt32(Row["SoTiet"]);
               //mh.HeSo = Convert.ToInt32(Row["HeSo"]);

               GiaoVienInfo gv = new GiaoVienInfo();
               gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
               gv.TenGiaoVien = Convert.ToString(Row["TenGiaoVien"]);
               gv.DiaChi = Convert.ToString(Row["DiaChi"]);
               gv.DienThoai = Convert.ToString(Row["DienThoai"]);
               gv.MonHoc = mh;
               dS.Add(gv);
           }
           return dS;
       }

       public void TimKiemGiaoVien(TextBoxX txtHoTen,
                                  ComboBoxEx cmbTheoDChi,
                                  TextBoxX txtDiaChi,
                                  ComboBoxEx cmbTheoCMon,
                                  ComboBoxEx cmbCMon,
                                  DataGridViewX dGV,
                                  BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(txtHoTen.Text, cmbTheoDChi.Text, txtDiaChi.Text, cmbTheoCMon.Text, cmbCMon.Text);
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }

        public void TimTheoMa(String m_MaGiaoVien)
        {
            m_GiaoVienData.TimTheoMa(m_MaGiaoVien);
        }
        
        public void TimTheoTen(String m_TenGiaoVien)
        {
            m_GiaoVienData.TimTheoTen(m_TenGiaoVien);
        }
    }
}
