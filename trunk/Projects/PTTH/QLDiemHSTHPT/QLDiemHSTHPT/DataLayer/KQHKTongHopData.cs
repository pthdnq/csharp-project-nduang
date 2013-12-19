using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemHSTHPT.Component;

namespace QLDiemHSTHPT.DataLayer
{
   public class KQHKTongHopData
    {
        DataService m_KQHocKyTongHopData = new DataService();

        public void ThemKetQuaDiemTBCacMonVaHocLucHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc, String maHocLuc, float diemTBChungCacMonHK)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand(@"INSERT INTO KQ_HOC_KY_TONG_HOP 
                (maHocSinh,maLop,maHocKy,maNamHoc,maHocLuc,DTBMonHocKy)
                VALUES(@maHocSinh, @maLop, @maHocKy, @maNamHoc, @maHocLuc, @diemTBChungCacMonHK)"
                );
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value = maHocLuc;
            cmd.Parameters.Add("diemTBChungCacMonHK", SqlDbType.Float).Value = Math.Round(diemTBChungCacMonHK, 2);

            m_KQHKTHData.Load(cmd);
        }
       public void CapNhatKetQuaDiemTBCMvaHocLucHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc, String maHocLuc,  float diemTBChungCacMonHK)
       {
           DataService m_KQHKTHData = new DataService();

           SqlCommand cmd = new SqlCommand(@"UPDATE  KQ_HOC_KY_TONG_HOP 
                                             SET  MaHocLuc =   @maHocLuc,
                                                  DTBMonHocKy =@diemTBChungCacMonHK
                                            WHERE maHocSinh = @maHocSinh
                                            and   maLop = @maLop
                                            and   maNamHoc = @maNamHoc
                                            ");
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value = maHocLuc;
           cmd.Parameters.Add("diemTBChungCacMonHK", SqlDbType.Float).Value = Math.Round(diemTBChungCacMonHK, 2);

           m_KQHKTHData.Load(cmd);
       }
        public void XoaKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_HOC_KY_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaHocKy = @maHocKy AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHKTHData.Load(cmd);
        }

        public DataTable LayDsKQHocKyTongHopForReport(String maLop, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM HOCSINH HS INNER JOIN KQ_HOC_KY_TONG_HOP KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
                                            "INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy " +
                                            "INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
                                            "INNER JOIN HOCLUC HL ON KQ.MaHocLuc = HL.MaHocLuc " +
                                            "INNER JOIN HANHKIEM HKIEM ON KQ.MaHanhKiem = HKIEM.MaHanhKiem " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaHocKy = @maHocKy AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyTongHopData.Load(cmd);
            return m_KQHocKyTongHopData;
        }
       public void CapNhatHanhKiemHocKy(String maHocSinh, 
                                       String maLop, 
                                       String maHocKy, 
                                       String maNamHoc, 
                                       String maHanhKiem
                                        )
       {
           DataService m_KQHKTHData = new DataService();

           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = "sp_CapNhatHanhKiemHocKy";
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
           cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
           cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
           cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
           cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value = maHanhKiem;

           m_KQHKTHData.Load(cmd);
       }
       public bool isTonTaiKetQua(     String maHocSinh,
                                       String maLop,
                                       String maHocKy,
                                       String maNamHoc
                                    )
       { 
            DataService m_KQHKTHData = new DataService();

            SqlCommand cmd = new SqlCommand("SELECT * FROM KQ_HOC_KY_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaHocKy = @maHocKy AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHKTHData.Load(cmd);
            return m_KQHKTHData.Rows.Count > 0;
       }

    }
}