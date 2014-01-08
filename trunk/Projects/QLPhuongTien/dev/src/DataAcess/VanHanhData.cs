using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace DataAcess
{
    public class VanHanhData
    {
        Data data = new Data();
        DonViTCData m_DonViTCData = new DonViTCData();
        NhanVienData m_NhanVienData = new NhanVienData();
        PhuongTienData m_PhuongTienData = new PhuongTienData();
        NguyenMauPTData m_NguyenMauPTData = new NguyenMauPTData();
        LoaiPTData m_LoaiPTData = new LoaiPTData();
        public bool insert(
            string VanHanhID,
            string PhuongTienID,
            string NgayVanHanh,
            string VanHanh,
            string VanHanhDV,
            string CaLamViec,
            string NhanVienID,
            string DonViTCID,
            string MoTa
       )
        {

            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_VanHanhData";
            cmd.Parameters.Add("VanHanhID", SqlDbType.NVarChar).Value = VanHanhID;
            cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            cmd.Parameters.Add("NgayVanHanh", SqlDbType.NVarChar).Value = NgayVanHanh;
            cmd.Parameters.Add("VanHanh", SqlDbType.Float).Value = float.Parse(VanHanh);
            cmd.Parameters.Add("VanHanhDV", SqlDbType.NVarChar).Value = VanHanhDV;
            cmd.Parameters.Add("CaLamViec", SqlDbType.Int).Value = int.Parse(CaLamViec);
            cmd.Parameters.Add("NhanVienID", SqlDbType.NVarChar).Value = NhanVienID;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = MoTa;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool update(
                 string VanHanhID,
                 string PhuongTienID,
                 string NgayVanHanh,
                 string VanHanh,
                 string VanHanhDV,
                 string CaLamViec,
                 string NhanVienID,
                 string DonViTCID,
                 string MoTa

            )
        {

            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_VanHanhData";
            cmd.Parameters.Add("VanHanhID", SqlDbType.NVarChar).Value = VanHanhID;
            cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            cmd.Parameters.Add("NgayVanHanh", SqlDbType.NVarChar).Value = NgayVanHanh;
            try
            {
                int iCaLamViec = (int)float.Parse(CaLamViec);
                cmd.Parameters.Add("CaLamViec", SqlDbType.Int).Value = iCaLamViec;
                cmd.Parameters.Add("VanHanh", SqlDbType.Float).Value = float.Parse(VanHanh);
            }
            catch (System.Exception ex)
            {

            }
            // cmd.Parameters.Add("VanHanh", SqlDbType.Float).Value = float.Parse(VanHanh);
            cmd.Parameters.Add("VanHanhDV", SqlDbType.NVarChar).Value = VanHanhDV;
            // cmd.Parameters.Add("CaLamViec", SqlDbType.Int).Value = int.Parse(CaLamViec);
            cmd.Parameters.Add("NhanVienID", SqlDbType.NVarChar).Value = NhanVienID;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("MoTa", SqlDbType.NVarChar).Value = MoTa;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool delete1(string VanHanhID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_VanHanhID";
            cmd.Parameters.Add("VanHanhID", SqlDbType.NVarChar).Value = VanHanhID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public DataTable select()
        {
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_VanHanhData";
            //retval = cmd.ExecuteNonQuery();
            DataTable dtb;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "VanHanh");
                dtb = ds.Tables["VanHanh"];
            }
            catch (System.Exception ex)
            {
                return null;
            }
            return dtb;
        }

        public DataTable selectDonViTC()
        {
            return m_DonViTCData.select();
        }
        public DataTable selectNhanVien()
        {
            return m_NhanVienData.select();
        }
        public DataTable selectPhuongTien()
        {
            return m_PhuongTienData.select();
        }
        public DataTable selectVanHanh_TenPhuongTien()
        {
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_VanHanh_TenPhuongTien";
            //retval = cmd.ExecuteNonQuery();
            DataTable dtb;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhuongTienTen");
                dtb = ds.Tables["PhuongTienTen"];
            }
            catch (System.Exception ex)
            {
                return null;
            }
            return dtb;

        }
        public DataTable getTongVanHanh()
        {
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_getTongVanHanh";
            DataTable dtb;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhuongTien");
                dtb = ds.Tables["PhuongTien"];
            }
            catch (System.Exception ex)
            {
                return null;
            }
            return dtb;
        }
        public DataTable update_TongVHToPhuongTien(string PhuongTienID, string TongVH)
        {
            return m_PhuongTienData.update_TongVHToPhuongTien(PhuongTienID, TongVH);
        }
        public DataTable getMocBaoTriForPhuongTien()
        {
            return m_NguyenMauPTData.getMocBaoTri();
        }
        public DataTable update_LanBaoTri(
           string PhuongTienID,
           string LanBDTX,
           string LanTieuTu,
           string LanTrungTu,
           string LanDaiTu)
        {

            return m_PhuongTienData.update_LanBaoTri(
                           PhuongTienID,
                           LanBDTX,
                           LanTieuTu,
                           LanTrungTu,
                           LanDaiTu
                );
        }

        public DataTable selectDonViTCbyNhanVien(string NhanVienID)
        {
            return m_DonViTCData.selectDonViTCbyNhanVien(NhanVienID);
        }
        public DataTable selectLoaiPT()
        {
            return m_LoaiPTData.select();
        }
        public DataTable selectTenPTbyLoaiPT(string LoaiPTMa)
        {
            return m_LoaiPTData.selectTenPTbyLoaiPT(LoaiPTMa);
        }
    }
}
