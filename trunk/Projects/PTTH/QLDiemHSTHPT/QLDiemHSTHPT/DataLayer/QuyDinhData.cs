using System;
using System.Data;
using System.Data.SqlClient;
using QLDiemHSTHPT.Component;


namespace QLDiemHSTHPT.DataLayer
{
   public class QuyDinhData
    {
        DataService m_QuyDinhData = new DataService();

        public DataTable LayDsQuyDinh()
        {
            SqlCommand cmdSelect = new SqlCommand("SELECT * FROM QUYDINH");
            m_QuyDinhData.Load(cmdSelect);
            if(m_QuyDinhData.Rows.Count==0)
            {
                int siSoCanDuoi=10;
                int siSoCanTren = 30;
                int tuoiCanDuoi = 10;
                int tuoiCanTren = 50;
                int thangDiem = 10;
                SqlCommand cmd = new SqlCommand(@"INSERT INTO QUYDINH VALUES(" +
                    "@tuoiCanDuoi, " +
                    "@tuoiCanTren," +
                    "@siSoCanDuoi," +
                    "@siSoCanTren," +
                    "@thangDiem)");
                cmd.Parameters.Add("siSoCanDuoi", SqlDbType.Int).Value = siSoCanDuoi;
                cmd.Parameters.Add("siSoCanTren", SqlDbType.Int).Value = siSoCanTren;
                cmd.Parameters.Add("tuoiCanDuoi", SqlDbType.Int).Value = tuoiCanDuoi;
                cmd.Parameters.Add("tuoiCanTren", SqlDbType.Int).Value = tuoiCanTren;
                cmd.Parameters.Add("thangDiem", SqlDbType.Int).Value = thangDiem;
                int i=m_QuyDinhData.ExecuteNoneQuery(cmd);
                m_QuyDinhData.Load(cmdSelect);
            }
            return m_QuyDinhData;
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren");
            cmd.Parameters.Add("siSoCanDuoi", SqlDbType.Int).Value = siSoCanDuoi;
            cmd.Parameters.Add("siSoCanTren", SqlDbType.Int).Value = siSoCanTren;
            m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren");
            cmd.Parameters.Add("tuoiCanDuoi", SqlDbType.Int).Value = tuoiCanDuoi;
            cmd.Parameters.Add("tuoiCanTren", SqlDbType.Int).Value = tuoiCanTren;
            m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhTruong(String tenTruong, String diaChiTruong)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET TenTruong = @tenTruong, DiaChiTruong = @diaChiTruong");
            cmd.Parameters.Add("tenTruong", SqlDbType.NVarChar).Value = tenTruong;
            cmd.Parameters.Add("diaChiTruong", SqlDbType.NVarChar).Value = diaChiTruong;
            m_QuyDinhData.Load(cmd);
        }

        public void CapNhatQuyDinhThangDiem(int thangDiem)
        {
            SqlCommand cmd = new SqlCommand("UPDATE QUYDINH SET ThangDiem = @thangDiem");
            cmd.Parameters.Add("thangDiem", SqlDbType.Int).Value = thangDiem;
            m_QuyDinhData.Load(cmd);
        }
    }
}