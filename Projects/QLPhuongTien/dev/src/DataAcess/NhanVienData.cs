using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
  public  class NhanVienData
    {
        Data data = new Data();

        DonViTCData m_DonViTCData = new DonViTCData();
        public bool insert(string NhanVienID, string NhanVienTen, string Sdt, string Email, string DC,  string DonViTCID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_NhanVienData";
            cmd.Parameters.Add("NhanVienID", SqlDbType.NVarChar).Value = NhanVienID;
            cmd.Parameters.Add("NhanVienTen", SqlDbType.NVarChar).Value = NhanVienTen;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("DC", SqlDbType.NVarChar).Value = DC;
           // cmd.Parameters.Add("PhuongTienID", SqlDbType.NVarChar).Value = PhuongTienID;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool update(string NhanVienID, string NhanVienTen, string Sdt, string Email, string DC, string DonViTCID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_NhanVienData";
            cmd.Parameters.Add("NhanVienID", SqlDbType.NVarChar).Value = NhanVienID;
            cmd.Parameters.Add("NhanVienTen", SqlDbType.NVarChar).Value = NhanVienTen;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            cmd.Parameters.Add("DC", SqlDbType.NVarChar).Value = DC;
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool delete1(string NhanVienID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_NhanVienData";
            cmd.Parameters.Add("NhanVienID", SqlDbType.NVarChar).Value = NhanVienID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
      public DataTable selectDonViTC()
        {
            return m_DonViTCData.select();
        }
    

    }
}
