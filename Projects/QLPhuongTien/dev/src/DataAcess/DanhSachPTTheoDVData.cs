using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
    public class DanhSachPTTheoDVData
    {
        Data data = new Data();
        DonViTCData m_DonViTCData = new DonViTCData();
        DonViQuanLyData m_DonViQuanLyData = new DonViQuanLyData();
        PhuongTienData m_PhuongTienData = new PhuongTienData();
        public DataTable selectDVTC()
        {
            return m_DonViTCData.select();
        }

        public DataTable selectDVQL()
        {
            return m_DonViQuanLyData.select();
        }
         public DataTable selectPTForDonViTC(string DonViTCID)
        {
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_select_PhuongTienDataForDonViTC";
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
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

         public DataTable selectPTForDonViQL(string DonViQLID)
         {
             SqlConnection con = data.getConnect();
             con.Open();
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.CommandText = "sp_select_PhuongTienDataForDonViQL";
             cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
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

        public DataTable selectAllPT()
         {
             return m_PhuongTienData.select();
         }
        public DataTable selectLoaiPTandTenNguyenMauForComboboxDgv()
        {
            return m_PhuongTienData.select();
         }
        public DataTable selectLoaiPT()
        {
            return m_PhuongTienData.select();
        }
        public DataTable selectNguyenMau()
        {
            return m_PhuongTienData.selectPhuongTienData_LoaiPT();
        }
    }

}
