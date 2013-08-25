using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemHSTHPT.Component;
namespace QLDiemHSTHPT.Controller
{
    public class KQHKMonHocData
    {
        DataService m_KQHocKyMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc, float diemTBKT, float diemTBMonHK)
        {
            DataService m_KQHKMHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_HOC_KY_MON_HOC VALUES(@maHocSinh, @maLop, @maMonHoc, @maHocKy, @maNamHoc, @diemTBKT, @diemTBMonHK)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("diemTBKT", SqlDbType.Float).Value = Math.Round(diemTBKT, 2);
            cmd.Parameters.Add("diemTBMonHK", SqlDbType.Float).Value = Math.Round(diemTBMonHK, 2);

            m_KQHKMHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            DataService m_KQHKMHData = new DataService();
            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_HOC_KY_MON_HOC WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaMonHoc = @maMonHoc AND MaHocKy = @maHocKy AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            m_KQHKMHData.Load(cmd);
        }

        public DataTable LayDsKQHocKyMonHocForReport(String maLop, String maMonHoc, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LayDsKQHocKyMonHocForReport";
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQHocKyMonHocData.Load(cmd);
            return m_KQHocKyMonHocData;
        }
        public DataTable LayDsKQHocKyMonHocTheoBan(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_LayDsKQHocKyMonHocTheoBan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maHocKy", SqlDbType.VarChar).Value = maHocKy;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;


            m_KQHocKyMonHocData.Load(cmd);
            return m_KQHocKyMonHocData;
        }
    }
}

