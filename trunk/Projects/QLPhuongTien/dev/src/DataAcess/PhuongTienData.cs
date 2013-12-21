using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
   public class PhuongTienData
    {
        Data data = new Data();

        DonViTCData m_DonViTCData = new DonViTCData();
        NguyenMauPTData m_NguyenMauPTData = new NguyenMauPTData();
        LoaiPTData m_LoaiPTData = new LoaiPTData();
        DonViQuanLyData m_DonViQuanLyData = new DonViQuanLyData();
        public bool insert(
           string AutoNum,
           string LoaiPTMa,
           string PhuongTienID,
           string NguyenMauID,
           string DonViQLID,
           string DonViTCID,
           string BienDK,
           string NgayVH,
           string LanBDTX,
           string LanTieuTu,
           string LanTrungTu,
           string LanDaiTu,
           string XuatXu,
           string TongVH
            )
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_PhuongTienData";
            cmd.Parameters.Add("AutoNum", SqlDbType.NVarChar).Value = AutoNum;
            cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
            cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            cmd.Parameters.Add("NguyenMauID", SqlDbType.NVarChar).Value = NguyenMauID;
            cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("BienDK", SqlDbType.NVarChar).Value = BienDK;
            cmd.Parameters.Add("NgayVH", SqlDbType.NVarChar).Value = NgayVH;
            cmd.Parameters.Add("LanBDTX", SqlDbType.NVarChar).Value = LanBDTX;
            cmd.Parameters.Add("LanTieuTu", SqlDbType.NVarChar).Value = LanTieuTu;
            cmd.Parameters.Add("LanTrungTu", SqlDbType.NVarChar).Value = LanTrungTu;
            cmd.Parameters.Add("LanDaiTu", SqlDbType.NVarChar).Value = LanDaiTu;
            cmd.Parameters.Add("XuatXu", SqlDbType.NVarChar).Value = XuatXu;
            cmd.Parameters.Add("TongVH", SqlDbType.NVarChar).Value = TongVH;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool update(
         string AutoNum,
         string LoaiPTMa,
         string PhuongTienID,
         string NguyenMauID,
         string DonViQLID,
         string DonViTCID,
         string BienDK,
         string NgayVH,
         string LanBDTX , 
         string LanTieuTu,
         string LanTrungTu,
         string LanDaiTu,
         string XuatXu,
         string TongVH
          )
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_PhuongTienData";
            cmd.Parameters.Add("AutoNum", SqlDbType.NVarChar).Value = AutoNum;
            cmd.Parameters.Add("LoaiPTMa", SqlDbType.NVarChar).Value = LoaiPTMa;
            cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            cmd.Parameters.Add("NguyenMauID", SqlDbType.NVarChar).Value = NguyenMauID;
            cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("BienDK", SqlDbType.NVarChar).Value = BienDK;
            cmd.Parameters.Add("NgayVH", SqlDbType.NVarChar).Value = NgayVH;
            cmd.Parameters.Add("LanBDTX", SqlDbType.NVarChar).Value = LanBDTX;
            cmd.Parameters.Add("LanTieuTu", SqlDbType.NVarChar).Value = LanTieuTu;
            cmd.Parameters.Add("LanTrungTu", SqlDbType.NVarChar).Value = LanTrungTu;
            cmd.Parameters.Add("LanDaiTu", SqlDbType.NVarChar).Value = LanDaiTu;
            cmd.Parameters.Add("XuatXu", SqlDbType.NVarChar).Value = XuatXu;
            cmd.Parameters.Add("TongVH", SqlDbType.NVarChar).Value = TongVH;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool delete1(string PhuongTienID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_PhuongTienData";
            cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        //public DataTable select()
        //{
        //    return m_DonViTCData.select();
        //}

        public DataTable select()
        {
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_PhuongTienData";
            //retval = cmd.ExecuteNonQuery();
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
       public DataTable selectNguyeMau()
        {
            return m_NguyenMauPTData.select();
        }
       public DataTable selectLoaiPT()
       {
           return m_LoaiPTData.select();
       }
       public DataTable selectDonViTC()
       {
           return m_DonViTCData.select();
       }
       public DataTable selectDonViQL()
       {
           return m_DonViQuanLyData.select();
       }
    }
}
