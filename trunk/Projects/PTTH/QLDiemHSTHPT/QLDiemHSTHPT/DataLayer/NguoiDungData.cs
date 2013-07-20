using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class NguoiDungData
    {
        DataService m_NguoiDungData = new DataService();

        public DataTable LayDsNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG");
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }
       public DataTable LayDsNguoiDung(String m_Username)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM NGUOIDUNG WHERE TenDangNhap = @ten");
           cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = m_Username;
           m_NguoiDungData.Load(cmd);
           return m_NguoiDungData;
       }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.Rows.Add(m_Row);
        }
       
        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.ExecuteNoneQuery() > 0;
        }

       public void DoiMatKhau(String userName, String newPassword)
       {
           m_NguoiDungData.DoiMatKhau(userName, newPassword);
       }
    }
}
