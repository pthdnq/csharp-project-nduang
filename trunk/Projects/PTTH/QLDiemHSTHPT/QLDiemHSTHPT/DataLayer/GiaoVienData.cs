using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QLDiemHSTHPT.DataLayer
{
   public class GiaoVienData
    {
       DataService m_GiaoVienData = new DataService();
       DataServiceIOExcel dsIOExcel = new DataServiceIOExcel();

       public DataTable LayDsGiaoVien()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN");
           m_GiaoVienData.Load(cmd);
           return m_GiaoVienData;
       }
        
       public DataRow ThemDongMoi()
       {
           return m_GiaoVienData.NewRow();
       }

       public void ThemGiaoVien(DataRow m_Row)
       {
           m_GiaoVienData.Rows.Add(m_Row);
       }

       public bool LuuGiaoVien()
       {
           return m_GiaoVienData.ExecuteNoneQuery() > 0;
       }

       public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon,bool gioiTinh)
       {
           SqlCommand cmd = new SqlCommand("INSERT INTO GIAOVIEN VALUES(@maGiaoVien, @tenGiaoVien, @diaChi, @dienThoai, @chuyenMon, @gioitinh)");
           cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;
           cmd.Parameters.Add("tenGiaoVien", SqlDbType.NVarChar).Value = tenGiaoVien;
           cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
           cmd.Parameters.Add("dienThoai", SqlDbType.VarChar).Value = dienThoai;
           cmd.Parameters.Add("chuyenMon", SqlDbType.VarChar).Value = chuyenMon;
           cmd.Parameters.Add("gioiTinh", SqlDbType.Bit).Value = gioiTinh;
           m_GiaoVienData.Load(cmd);
       }

       public DataTable LayDsGiaoVienForReport()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC M INNER JOIN GIAOVIEN G ON G.MaMonHoc = M.MaMonHoc");
           m_GiaoVienData.Load(cmd);
           return m_GiaoVienData;
       }

       public DataTable TimTheoMa(String ma)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN WHERE MaGiaoVien LIKE '%' + @ma + '%'");
           cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;
           m_GiaoVienData.Load(cmd);
           return m_GiaoVienData;
       }

       public DataTable TimTheoTen(String ten)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN WHERE TenGiaoVien LIKE '%' + @ten + '%'");
           cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;
           m_GiaoVienData.Load(cmd);
           return m_GiaoVienData;
       }

       public String TruyVanChung()
       {
           return "SELECT G.MaGiaoVien, G.TenGiaoVien, G.DiaChi, G.DienThoai, H.TenMonHoc FROM GIAOVIEN G INNER JOIN MONHOC H ON G.MaMonHoc = H.MaMonHoc";
       }

       public DataTable LayDSGiaoVienExcel(string path)
       {
           OleDbCommand cmd = new OleDbCommand("select * from [Sheet1$]");
           return dsIOExcel.Load(cmd, path);
       }

       public DataTable TimKiemGiaoVien(String hoTen, String theoDChi, String diaChi, String theoCMon, String cMon)
       {
           SqlCommand cmd = new SqlCommand();

           String sql = TruyVanChung() + " WHERE G.TenGiaoVien LIKE '%' + @hoTen + '%' ";
           cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;

           if (theoDChi != "NONE")
           {
               sql += theoDChi + " G.DiaChi LIKE '%' + @diaChi + '%' ";
               cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
           }

           if (theoCMon != "NONE")
           {
               sql += theoCMon + " H.TenMonHoc = @cMon";
               cmd.Parameters.Add("cMon", SqlDbType.NVarChar).Value = cMon;
           }

           cmd.CommandText = sql;
           m_GiaoVienData.Load(cmd);
           return m_GiaoVienData;
       }
    }
}
