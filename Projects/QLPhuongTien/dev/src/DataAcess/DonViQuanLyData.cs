using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
    public class DonViQuanLyData
    {
        Data data = new Data();
        private String tblDonViQuanLy       = "DonViQuanLy";
        private String fldDonViQLID         = "DonViQLID";
        private String fldDonViQLTen        = "DonViQLTen";
        private String fldDonViQLToTruong   = "DonViQLToTruong";
        private String fldSdt               = "Sdt";
        private String fldEmail             = "Email";
        public bool insert(string DonViQLID, string DonViQLTen, string DonViQLToTruong, string Sdt, string Email)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_DonViQuanLyData";
            cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
            cmd.Parameters.Add("DonViQLTen", SqlDbType.NVarChar).Value = DonViQLTen;
            cmd.Parameters.Add("DonViQLToTruong", SqlDbType.NVarChar).Value = DonViQLToTruong;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool update(string DonViQLID, string DonViQLTen, string DonViQLToTruong, string Sdt, string Email)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_update_DonViQuanLyData";
            cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
            cmd.Parameters.Add("DonViQLTen", SqlDbType.NVarChar).Value = DonViQLTen;
            cmd.Parameters.Add("DonViQLToTruong", SqlDbType.NVarChar).Value = DonViQLToTruong;
            cmd.Parameters.Add("Sdt", SqlDbType.NVarChar).Value = Sdt;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool delete1(string DonViQLID)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_delete_DonViQuanLyData";
            cmd.Parameters.Add("DonViQLID", SqlDbType.NVarChar).Value = DonViQLID;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
        public bool isExist()
        {
            return true;
        }
    }
}
