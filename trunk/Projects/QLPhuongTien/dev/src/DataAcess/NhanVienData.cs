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
        private String tblNhanVien = "NhanVien";
        private String fldNhanVienID = "NhanVienID";
        private String fldNhanVienTen = "NhanVienTen";
        private String fldSdt = "Sdt";
        private String fldEmail = "Email";
        private String fldDC = "DC";
        private string fldPhuongTienID = "PhuongTienID";
        private String fldDonViTCID = "DonViTCID";

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
      //public bool combobox(string DonViTCID , string DonViTCTen , string )
      //  {
      //      int retval;
      //      SqlConnection con = data.getConnect();
      //      con.Open();
      //      SqlCommand cmd = new SqlCommand();
      //      cmd.Connection = con;
      //      cmd.CommandType = CommandType.StoredProcedure;
      //      cmd.CommandText = "sp_select_DonViTCData";
      //      cmd.Parameters.Add("DonViTCID", SqlDbType.NVarChar).Value = DonViTCID;
      //      cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;
      //      cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;
      //      cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;
      //      cmd.Parameters.Add("DonViTCTen", SqlDbType.NVarChar).Value = DonViTCTen;

      //      retval = cmd.ExecuteNonQuery();
      //      cmd.Dispose();
      //      con.Close();
      //      return retval > 0;
      //  }
     

    }
}
