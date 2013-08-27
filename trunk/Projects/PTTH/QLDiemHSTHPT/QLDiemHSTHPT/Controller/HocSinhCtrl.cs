using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;
using QLDiemHSTHPT.Bussiness;
using DevComponents.Editors.DateTimeAdv;


namespace QLDiemHSTHPT.Controller
{
   public class HocSinhCtrl
    {
       HocSinhData m_HocSinhData = new HocSinhData();
       public bool isLopVaKhoiLop(String khoiLop, String lop)
       {
           int i = m_HocSinhData.isLopVaKhoiLop(khoiLop, lop);
           if (i <= 0)
               return false;
           return true;
       }
       public void HienThiComboBox(ComboBoxEx comboBox)
       {
           comboBox.DataSource = m_HocSinhData.LayDsHocSinh();
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       //nhap diem
       public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiComboBox(String namHoc, String lop,String maHS, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoMa(namHoc, lop,maHS);
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiComboBoxMaHS(String namHoc, String lop, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
           comboBox.DisplayMember = "MaHocSinh";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_HocSinhData.LayDsHocSinh();
           cmbColumn.DisplayMember = "HoTen";
           cmbColumn.ValueMember = "MaHocSinh";
           cmbColumn.DataPropertyName = "MaHocSinh";
           cmbColumn.HeaderText = "Học sinh";
       }



       public void HienThi(DataGridViewX dGV,BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_HocSinhData.LayDsHocSinh();

           //DataTable dT = m_HocSinhData.LayDsHocSinh();
           bN.BindingSource = bS;
           dGV.DataSource = bS;
           
       }

       //nhap diem
       public void HienThiDsHocSinhTheoLop(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop,String maHSOrhoTenHS)
       {
           BindingSource bS = new BindingSource();
           if (maHSOrhoTenHS == "")
                bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, lop);
           else
                bS.DataSource = m_HocSinhData.LayDsHocSinhTheoMaOrHoTen(namHoc, lop, maHSOrhoTenHS);
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }





       //phan lop
       public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
       {
           return m_HocSinhData.LayDsHocSinhTheoNamHoc(namHoc);
       }

       public DataTable HienThiDsHocSinhTheoLop(String lop)
       {
           return m_HocSinhData.LayDsHocSinhTheoLop(lop);
       }
       //report
       public static IList<HocSinhInfo> LayDsHocSinh()
       {
           HocSinhData m_HSData = new HocSinhData();
           DataTable m_DT = m_HSData.LayDsHocSinhForReport();

           IList<HocSinhInfo> dS = new List<HocSinhInfo>();

           foreach (DataRow Row in m_DT.Rows)
           {
               HocSinhInfo hs = new HocSinhInfo();
               hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
               hs.HoTen = Convert.ToString(Row["HoTen"]);
               hs.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
               hs.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
               hs.NoiSinh = Convert.ToString(Row["NoiSinh"]);
               hs.DanToc = Convert.ToString(Row["DanToc"]); ;
               hs.TonGiao = Convert.ToString(Row["TonGiao"]); 
               hs.HoTenCha = Convert.ToString(Row["HoTenCha"]);
               hs.NgheNghiepCha = Convert.ToString(Row["NgheNghiepCha"]);
               hs.HoTenMe = Convert.ToString(Row["HoTenMe"]);
               hs.NgheNghiepMe = Convert.ToString(Row["NgheNghiepMe"]); 

               dS.Add(hs);
           }
           return dS;
       }

       public DataRow ThemDongMoi()
       {
           return m_HocSinhData.ThemDongMoi();
       }

       public void ThemHocSinh(DataRow m_Row)
       {
           m_HocSinhData.ThemHocSinh(m_Row);
       }

       public bool LuuHocSinh()
       {
           return m_HocSinhData.LuuHocSinh();
       }

     
       public void TimTheoMa(String m_MaHocSinh)
       {
           m_HocSinhData.TimTheoMa(m_MaHocSinh);
       }

       public void TimTheoMaHoTenLopNamHoc(String maOrTenHocSinh, String maLop, String maNamHoc)
       {
           m_HocSinhData.TimTheoMaHoTenLopNamHoc(maOrTenHocSinh, maLop, maNamHoc);
       }

    }
         
}
