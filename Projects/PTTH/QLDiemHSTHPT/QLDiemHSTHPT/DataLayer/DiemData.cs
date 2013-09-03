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

           SqlCommand cmd = new SqlCommand(@"SELECT *
                                           FROM DIEM D, HOCSINH S, MONHOC H, LOAIDIEM O, LOP L 
                                           WHERE D.MaHocSinh = S.MaHocSinh AND 
                                           D.MaMonHoc = H.MaMonHoc AND 
                                           D.MaLoaiDiem = O.MaLoaiDiem AND 
                                           D.MaLop = L.MaLop AND 
                                           S.MaHocSinh = @maHocSinh AND 
                                           H.MaMonHoc = @maMonHoc AND 
                                           D.MaHocKy = @maHocKy AND 
                                           D.MaNamHoc = @maNamHoc AND
                                           L.MaLop = @maLop");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

           m_DData.Load(cmd);
           return m_DData;
       }

       public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, String diemSo)
       {
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand(@"

            DELETE FROM DIEM 
            WHERE maHocSinh = @maHocSinh 
            and maMonHoc = @maMonHoc
            and maHocKy = @maHocKy
            and maNamHoc = @maNamHoc
            and maLop = @maLop
            and maLoaiDiem = @maLoaiDiem
            ;
            INSERT INTO DIEM VALUES(@maHocSinh, @maMonHoc, @maHocKy, @maNamHoc, @maLop, @maLoaiDiem, @diemSo)");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maLoaiDiem", SqlDbType.VarChar).Value = maLoaiDiem;
           cmd.Parameters.Add("diemSo", SqlDbType.VarChar).Value = diemSo;

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

           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "sp_LayDsDiemHocSinh";
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;

           m_DData.Load(cmd);
           return m_DData;
       }
       public float getDiemTrungBinhMonHocKy(String maHS,
           String strMaMonHoc,
           String strMaHocKy,
           String strMaKhoaHoc,
           String strMaLop)
       {
           float diemDTBMonHocHocKy = 0;
           DataService m_DData = new DataService();

           SqlCommand cmd = new SqlCommand(@"SELECT DTBMonHocKy FROM KQ_HOC_KY_MON_HOC 
                                            WHERE    MaHocSinh = @MaHocSinh
                                                    and MaLop = @MaLop
                                                    and MaMonHoc = @MaMonHoc
                                                    and MaHocKy = @MaHocKy
                                                    and MaNamHoc = @MaNamHoc


                                            ");
           cmd.Parameters.Add("MaHocSinh", SqlDbType.VarChar).Value = maHS;
           cmd.Parameters.Add("MaLop", SqlDbType.VarChar).Value = strMaLop;
           cmd.Parameters.Add("MaMonHoc", SqlDbType.VarChar).Value = strMaMonHoc;
           cmd.Parameters.Add("MaHocKy", SqlDbType.VarChar).Value = strMaHocKy;
           cmd.Parameters.Add("MaNamHoc", SqlDbType.VarChar).Value = strMaKhoaHoc;

           m_DData.Load(cmd);
           int dong = m_DData.Rows.Count;
           if (dong > 0)
           {
               diemDTBMonHocHocKy = float.Parse(m_DData.Rows[dong - 1]["DTBMonHocKy"].ToString().Trim());
           }
           return diemDTBMonHocHocKy;
       }


    
     }
}
