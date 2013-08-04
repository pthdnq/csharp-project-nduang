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
           //SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH, PHANCONG PC WHERE MH.MaMonHoc = PC.MaMonHoc AND PC.MaNamHoc = @namHoc AND PC.MaLop = @lop ");
           //cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
           //cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;

           SqlCommand cmd = new SqlCommand("SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH");

           //SqlCommand cmd = new SqlCommand("SELECT PL.MaHocSinh, HS.HoTen, L.TenLop " +
           //                               "FROM HOCSINH HS INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh " +
           //                               "INNER JOIN LOP L ON L.MaLop = PL.MaLop " +
           //                               "WHERE PL.MaLop = @lop AND PC.MaNamHoc = @namHoc");
           //cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
           //cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           
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
