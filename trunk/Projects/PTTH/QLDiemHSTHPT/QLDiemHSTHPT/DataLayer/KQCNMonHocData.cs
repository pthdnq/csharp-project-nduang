using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemHSTHPT.Component;

namespace QLDiemHSTHPT.Controller
{
    public class KQCNMonHocData
    {
        DataService m_KQCaNamMonHocData = new DataService();
        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai, float diemTBMonCN)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_MON_HOC VALUES(@maHocSinh, @maLop, @maMonHoc, @maNamHoc, @diemThiLai, @diemTBMonCN)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("diemThiLai", SqlDbType.Float).Value = Math.Round(diemThiLai, 2);
            cmd.Parameters.Add("diemTBMonCN", SqlDbType.Float).Value = Math.Round(diemTBMonCN, 2);

            m_KQCNMHData.Load(cmd);
        }

        public void UpdateKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai, float diemTBMonCN)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_UpdateKetQuaCNMonHoc";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;
            cmd.Parameters.Add("diemThiLai", SqlDbType.Float).Value = Math.Round(diemThiLai, 2);
            cmd.Parameters.Add("diemTBMonCN", SqlDbType.Float).Value = Math.Round(diemTBMonCN, 2);

            m_KQCNMHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_DEL_KQ_CA_NAM_MON_HOC";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCNMHData.Load(cmd);
        }

        public DataTable LayDsKQCaNamMonHocForReport(String maLop, String maMonHoc, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LayDsKQCaNamMonHocForReport";
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }
    }
}
