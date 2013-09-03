using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QLDiemHSTHPT.DataLayer
{
   public class HocSinhData
    {
       DataService m_HocSinhData = new DataService();
       public int isLopVaKhoiLop(String maKhoiLop, String malop)
       {
           SqlCommand cmd = new SqlCommand(@"SELECT * FROM  LOP 
                WHERE MaLop = @malop and makhoiLop = @makhoiLop");
           cmd.Parameters.Add("malop", SqlDbType.VarChar).Value = malop;
           cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData.Rows.Count;
       }
       public DataTable LayDsHocSinh()
       {
           SqlCommand cmd = new SqlCommand("SELECT MaHocSinh ,HoTen , DanToc, GioiTinh, MaNamHoc, MaKhoiLop, MaLop FROM HOCSINH");
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
       public DataTable LayDsHocSinhGomHoTenVaMaHS()
       {
           SqlCommand cmd = new SqlCommand("SELECT MaHocSinh ,HoTen  FROM HOCSINH");
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       //nhap diem
       public DataTable LayDsHocSinhTheoLop(String khoaHoc, String lop)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen " +
                                           "FROM HOCSINH HS /*FULL JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh */" +
                                           "/*INNER JOIN LOP L ON L.MaLop = PL.MaLop*/ " +
                                           "WHERE HS.MaLop = @lop AND HS.MaNamHoc = @khoaHoc");
           cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = khoaHoc;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataTable LayDsHocSinhTheoMaOrHoTen(String namHoc, String lop, String maHSOrHoTen)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen " +
                                           "FROM HOCSINH HS  " +
                                           "WHERE HS.MaLop = @lop AND HS.MaNamHoc = @khoaHoc AND (HS.HoTen LIKE '%' + @maHSOrHoTen + '%' or HS.MaHocSinh LIKE '%' + @maHSOrHoTen + '%')  ");
           cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = namHoc;
           cmd.Parameters.Add("maHSOrHoTen", SqlDbType.VarChar).Value = maHSOrHoTen;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
       //nhap diem
       public DataTable LayDsHocSinhTheoLop(String namHoc, String khoiLop, String lop)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen, L.TenLop " +
                                           "FROM HOCSINH HS /*INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh */ " +
                                           "INNER JOIN LOP L ON L.MaLop = HS.MaLop " +
                                           "INNER JOIN KHOILOP KL ON KL.MaKhoiLop = HS.MaKhoiLop " +
                                           "WHERE HS.MaLop = @lop AND HS.MaNamHoc = @khoaHoc AND HS.MaKhoiLop = @khoiLop");
           cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = namHoc;
           cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value = khoiLop;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataTable LayDsHocSinhForReport()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataRow ThemDongMoi()
       {
           return m_HocSinhData.NewRow();
       }

       public void ThemHocSinh(DataRow m_Row)
       {
           m_HocSinhData.Rows.Add(m_Row);
       }

       public bool LuuHocSinh()
       {
           return m_HocSinhData.ExecuteNoneQuery() > 0;
       }

       public DataTable TimTheoMaHoTenLopNamHoc(String maOrTenHS, String maLop, String maNamHoc)
       {
           SqlCommand cmd = new SqlCommand(@"
            SELECT * FROM HOCSINH 
            WHERE (MaHocSinh LIKE '%' + @maOrTenHS + '%' 
                  or HoTen LIKE '%' + @maOrTenHS + '%')
                  and maLop LIKE '%' + @maLop + '%' 
                  and maNamHoc   LIKE '%' + @maNamHoc + '%' 

            ");
           cmd.Parameters.Add("maOrTenHS", SqlDbType.NVarChar).Value = maOrTenHS;
           cmd.Parameters.Add("maLop", SqlDbType.NVarChar).Value = maLop;
           cmd.Parameters.Add("maNamHoc", SqlDbType.NVarChar).Value = maNamHoc;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public String TruyVanChung()
       {
           return "SELECT HS.MaHocSinh, HS.HoTen, HS.GioiTinh, HS.NgaySinh, HS.NoiSinh, HS.DanToc, HS.TonGiao FROM HOCSINH HS ";
       }

       public DataTable TimKiemHocSinh(String hoTen, String theoNSinh, String noiSinh, String theoDToc, String danToc, String theoTGiao, String tonGiao)
       {
           SqlCommand cmd = new SqlCommand();

           String sql = TruyVanChung() + " WHERE HS.HoTen LIKE '%' + @hoTen + '%' ";
           cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;

           if (theoNSinh != "NONE")
           {
               sql += theoNSinh + " HS.NoiSinh LIKE '%' + @noiSinh + '%' ";
               cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value = noiSinh;
           }

           if (theoDToc != "NONE")
           {
               sql += theoDToc + " HS.DanToc LIKE '%' + @danToc + '%' ";
               cmd.Parameters.Add("danToc", SqlDbType.NVarChar).Value = danToc;
           }

           if (theoTGiao != "NONE")
           {
               sql += theoTGiao + " HS.TonGiao LIKE '%' + @tonGiao + '%' ";
               cmd.Parameters.Add("tonGiao", SqlDbType.NVarChar).Value = tonGiao;
           }

           cmd.CommandText = sql;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
       public DataTable LayDsHocSinhTheoLopChoCapNhatHanhKiem(String maHSOrhoTenHS, String maNamHoc, String malop, String maHocKy)
       {
           SqlCommand cmd = new SqlCommand();
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_LayDsHocSinhTheoLopChoCapNhatHanhKiem";
           cmd.Parameters.Add("maHSOrhoTenHS", SqlDbType.NVarChar).Value = maHSOrhoTenHS;
           cmd.Parameters.Add("malop", SqlDbType.VarChar).Value = malop;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;


           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
      

     
   }
}
