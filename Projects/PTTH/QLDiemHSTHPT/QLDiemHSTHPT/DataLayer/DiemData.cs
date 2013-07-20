using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class DiemData
    {
       DataService m_DiemData = new DataService();

       public DataTable LayDsDiem()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DIEM");
           m_DiemData.Load(cmd);
           return m_DiemData;
       }

       public DataTable LayDsDiemHocSinhTL(String maHocSinh, String maMonHoc, String maNamHoc, String maLop)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand("SELECT * " +
                                           "FROM DIEM D, LOAIDIEM L " +
                                           "WHERE D.MaLoaiDiem = L.MaLoaiDiem AND " +
                                           "D.MaHocSinh = @maHocSinh AND " +
                                           "D.MaMonHoc = @maMonHoc AND " +
                                           "D.MaNamHoc = @maNamHoc AND " +
                                           "D.MaLop = @maLop");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

           m_DData.Load(cmd);
           return m_DData;
       }
       public DataTable LayDsDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand("SELECT * " +
                                           "FROM DIEM D, HOCSINH S, MONHOC H, LOAIDIEM O, LOP L " +
                                           "WHERE D.MaHocSinh = S.MaHocSinh AND " +
                                           "D.MaMonHoc = H.MaMonHoc AND " +
                                           "D.MaLoaiDiem = O.MaLoaiDiem AND " +
                                           "D.MaLop = L.MaLop AND " +
                                           "S.MaHocSinh = @maHocSinh AND " +
                                           "H.MaMonHoc = @maMonHoc AND " +
                                           "D.MaHocKy = @maHocKy AND " +
                                           "D.MaNamHoc = @maNamHoc AND " +
                                           "L.MaLop = @maLop");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

           m_DData.Load(cmd);
           return m_DData;
       }

       public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand("INSERT INTO DIEM VALUES(@maHocSinh, @maMonHoc, @maHocKy, @maNamHoc, @maLop, @maLoaiDiem, @diemSo)");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maLoaiDiem", SqlDbType.VarChar).Value = maLoaiDiem;
           cmd.Parameters.Add("diemSo", SqlDbType.Float).Value = Math.Round(diemSo, 2);

           m_DData.Load(cmd);
       }

       public void XoaDiem(int stt)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand("DELETE FROM DIEM WHERE STT = @stt");
           cmd.Parameters.Add("stt", SqlDbType.Int).Value = stt;

           m_DData.Load(cmd);
       }

       public DataTable LayDsDiemHocSinh(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand("SELECT * " +
                                           "FROM DIEM D, LOAIDIEM L " +
                                           "WHERE D.MaLoaiDiem = L.MaLoaiDiem AND " +
                                           "D.MaHocSinh = @maHocSinh AND " +
                                           "D.MaMonHoc = @maMonHoc AND " +
                                           "D.MaHocKy = @maHocKy AND " +
                                           "D.MaNamHoc = @maNamHoc AND " +
                                           "D.MaLop = @maLop");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

           m_DData.Load(cmd);
           return m_DData;
       }

    
     }
}
