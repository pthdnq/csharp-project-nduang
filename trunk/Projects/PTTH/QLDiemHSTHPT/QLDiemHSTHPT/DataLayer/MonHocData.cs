using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class MonHocData
    {
        DataService m_MonHocData = new DataService();
        public DataTable LayDsMonHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC");
            m_MonHocData.Load(cmd);
            return m_MonHocData;
        }

       //hien thi form diem 
       public DataTable LayDsMonHoc(String namHoc, String lop)
       {
           //SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH, PHANCONG PC WHERE MH.MaMonHoc = PC.MaMonHoc AND PC.MaNamHoc = @khoaHoc AND PC.MaLop = @lop ");
           //cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = khoaHoc;
           //cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;

           SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSoBanCoBan, MH.HeSoBanKHTN, MH.HeSoBanKHXHNV FROM MONHOC MH");
           m_MonHocData.Load(cmd);
           return m_MonHocData;
       }

       public DataRow ThemDongMoi()
       {
           return m_MonHocData.NewRow();
       }
       public void ThemMonHoc(DataRow m_Row)
       {
           m_MonHocData.Rows.Add(m_Row);
       }

       public bool LuuMonHoc()
       {
           return m_MonHocData.ExecuteNoneQuery() > 0;
       }
    }
}
