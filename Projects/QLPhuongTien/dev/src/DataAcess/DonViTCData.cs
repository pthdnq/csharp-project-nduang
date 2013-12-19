using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
   public class DonViTCData
    {
        Data data = new Data();
        public bool insert(string DonViTCID, string DonViTCTen, string DonViTCToTruong, string Sdt, string Email)
        {

            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_DonViTCData";
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;
            cmd.Parameters.Add("DonViTCToTruong", SqlDbType.NVarChar).Value = DonViTCToTruong;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval >0;
        }
        public bool update(string DonViTCID, string DonViTCTen, string DonViTCToTruong, string Sdt, string Email)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_DonViTCData";
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
            cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;
            cmd.Parameters.Add("DonViTCToTruong", SqlDbType.NVarChar).Value = DonViTCToTruong;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool delete1(string DonViTCID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_DonViTCData";
            cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;       
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
            cmd.CommandText = "sp_select_DonViTCData";        
            //retval = cmd.ExecuteNonQuery();
            DataTable dtb;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "DonViTC");
                dtb = ds.Tables["DonViTC"];
            }
            catch (System.Exception ex)
            {  
                return null;
            }
            return dtb;
            
        }
        public bool isExist()
        {
            return true;
        }
    }
}
