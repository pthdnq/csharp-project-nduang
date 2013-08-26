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
       DataServiceIOExcel dsIOExcel = new DataServiceIOExcel();

       public DataTable LayDsHocSinh()
       {
           SqlCommand cmd = new SqlCommand("SELECT MaHocSinh ,HoTen , DanToc, GioiTinh, MaNamHoc, MaKhoiLop, MaLop FROM HOCSINH");
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

       public DataTable LayDsHocSinhTheoMa(String namHoc, String lop,String maHS)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen " +
                                           "FROM HOCSINH HS /*INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh*/ " +
                                           "/*INNER JOIN LOP L ON L.MaLop = PL.MaLop */" +
                                           "WHERE HS.MaLop = @lop AND HS.MaNamHoc = @khoaHoc AND HS.MaHocSinh=@maHS");
           cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = namHoc;
           cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value = maHS;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
       public DataTable LayDsHocSinhTheoMaOrHoTen(String namHoc, String lop, String maHSOrHoTen)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen " +
                                           "FROM HOCSINH HS /*INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh*/ " +
                                           "/*INNER JOIN LOP L ON L.MaLop = PL.MaLop */" +
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
       public DataTable LayDsHocSinhTheoLop(String lop)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen, L.TenLop " +
                                           "FROM HOCSINH HS /* INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh */" +
                                           "INNER JOIN LOP L ON L.MaLop = HS.MaLop " +
                                           "WHERE HS.MaLop = @lop");
           cmd.Parameters.Add("lop", SqlDbType.VarChar).Value = lop;
           return m_HocSinhData;
       }
       //nhap diem
       public DataTable LayDsHocSinhTheoNamHoc(String namHoc)
       {
           SqlCommand cmd = new SqlCommand("SELECT HS.MaHocSinh, HS.HoTen, L.TenLop " +
                                           "FROM HOCSINH HS /*INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh */" +
                                           "INNER JOIN LOP L ON L.MaLop = HS.MaLop " +
                                           "WHERE HS.MaNamHoc = @khoaHoc");
           cmd.Parameters.Add("khoaHoc", SqlDbType.VarChar).Value = namHoc;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public void LuuHSVaoBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
       {
           SqlCommand cmd = new SqlCommand("INSERT INTO PHANLOP VALUES(@maNamHoc, @maKhoiLop, @maLop, @maHS)");
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value = maHS;

           m_HocSinhData.Load(cmd);
       }

       public DataTable LayDSHocSinhExcel(string path)
       {
           OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]");
           return dsIOExcel.Load(cmd, path);
       }

       public void XoaHSKhoiBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
       {
           SqlCommand cmd = new SqlCommand("DELETE FROM PHANLOP WHERE MaNamHoc = @maNamHoc AND MaKhoiLop = @maKhoiLop AND MaLop = @maLop AND MaHocSinh = @maHS");
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value = maHS;

           m_HocSinhData.Load(cmd);
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

       public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe,String maNamHoc , String maKhoiLop , String malop)
       {
           SqlCommand cmd = new SqlCommand("INSERT INTO HOCSINH VALUES(@maHocSinh, @hoTen, @gioiTinh, @ngaySinh, @noiSinh, @maDanToc, @maTonGiao, @hoTenCha, @maNgheCha, @hoTenMe, @maNgheMe,@maNamHoc ,@maKhoiLop,@maLop)");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;
           cmd.Parameters.Add("gioiTinh", SqlDbType.Bit).Value = gioiTinh;
           cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value = ngaySinh;
           cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value = noiSinh;
           cmd.Parameters.Add("maDanToc", SqlDbType.VarChar).Value = maDanToc;
           cmd.Parameters.Add("maTonGiao", SqlDbType.VarChar).Value = maTonGiao;
           cmd.Parameters.Add("hoTenCha", SqlDbType.NVarChar).Value = hoTenCha;
           cmd.Parameters.Add("maNgheCha", SqlDbType.VarChar).Value = maNgheCha;
           cmd.Parameters.Add("hoTenMe", SqlDbType.NVarChar).Value = hoTenMe;
           cmd.Parameters.Add("maNgheMe", SqlDbType.VarChar).Value = maNgheMe;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value = maKhoiLop;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = malop;

           m_HocSinhData.Load(cmd);
       }

       public DataTable TimTheoMa(String ma)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE MaHocSinh LIKE '%' + @ma + '%'");
           cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataTable TimHSChuaPL()
       {
           SqlCommand cmd = new SqlCommand(@"SELECT * "+
                                               "FROM HOCSINH "+
                                               "WHERE NOT EXISTS(SELECT PHANLOP.MaHocSinh FROM PHANLOP"+
                                                                " WHERE PHANLOP.MaHocSinh=HOCSINH.MaHocSinh)");
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataTable TimTheoTen(String ten)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE HoTen LIKE '%' + @ten + '%'");
           cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
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

       public String TruyVan()
       {
           return "select MaHocSinh, HoTen from HOCSINH ";
       }
       

       public String TruyVanChung()
       {
           return "SELECT HS.MaHocSinh, HS.HoTen, HS.GioiTinh, HS.NgaySinh, HS.NoiSinh, HS.DanToc, HS.TonGiao FROM HOCSINH HS ";
       }

       public DataTable TimKiemHocSinh(String hoTen)
       {
           SqlCommand cmd = new SqlCommand();

           String sql = TruyVanChung() + " WHERE HS.HoTen LIKE '%' + @hoTen + '%' ";
           cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
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

      

     
   }
}
