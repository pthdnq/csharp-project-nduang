using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.Bussiness;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class NguoiDungCtrl
    {
       NguoiDungData m_NguoiDungData = new NguoiDungData();
       NguoiDungInfo m_NguoiDungInfo = new NguoiDungInfo();
       LoaiNguoiDungInfo m_LoaiNguoiDungInfo = new LoaiNguoiDungInfo();

       public void HienThiComboBox(ComboBoxEx comboBox)
       {
           comboBox.DataSource = m_NguoiDungData.LayDsNguoiDung();
           comboBox.DisplayMember = "TenND";
           comboBox.ValueMember = "MaND";
       }
       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_NguoiDungData.LayDsNguoiDung();
           cmbColumn.DisplayMember = "TenND";
           cmbColumn.ValueMember = "MaND";
           cmbColumn.DataPropertyName = "MaND";
           cmbColumn.HeaderText = "Người dùng";
       }
       public void HienThi(DataGridViewX dGV, BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();

           bS.DataSource = m_NguoiDungData.LayDsNguoiDung();
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }
       public DataRow ThemDongMoi()
       {
           return m_NguoiDungData.ThemDongMoi();
       }
       public void ThemNguoiDung(DataRow m_Row)
       {
           m_NguoiDungData.ThemNguoiDung(m_Row);
       }
       public bool LuuNguoiDung()
       {
           return m_NguoiDungData.LuuNguoiDung();
       }

       public int DangNhap(string m_Username, string m_Password)
       {
           DataTable m_DT = m_NguoiDungData.LayDsNguoiDung(m_Username);

           if (m_DT.Rows.Count == 0)
               return 0;
           String m_SysPass = m_DT.Rows[0]["MatKhau"].ToString();
           if (m_SysPass != m_Password)
               return 1;
           else
           {
               m_NguoiDungInfo.TenND = m_DT.Rows[0]["TenND"].ToString();
               m_LoaiNguoiDungInfo.MaLoaiND = m_DT.Rows[0]["MaLoaiND"].ToString();
               m_LoaiNguoiDungInfo.TenLoaiND = m_DT.Rows[0]["TenLoaiND"].ToString();
               m_NguoiDungInfo.LoaiND = m_LoaiNguoiDungInfo;
               Utilities.NguoiDung = m_NguoiDungInfo;
               return 2;
           }
       }
       public void DoiMatKhau(String userName, String newPassword)
       {
           m_NguoiDungData.DoiMatKhau(userName, newPassword);
       }
    }
}
