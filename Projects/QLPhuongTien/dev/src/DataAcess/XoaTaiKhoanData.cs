using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
   public class XoaTaiKhoanData
    {
       Data data = new Data();
       public bool deleteUserName(string UserName)
       {
       
          int retval;
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_delete_UserName";
           cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
           retval = cmd.ExecuteNonQuery();
           cmd.Dispose();
           con.Close();
           return retval > 0;

       }

       public DataTable selectTaiKhoan()
       {
           SqlConnection con = data.getConnect();
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = con;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = "sp_select_TaiKhoan";
           //retval = cmd.ExecuteNonQuery();
           DataTable dtb;
           try
           {
               SqlDataAdapter da = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               da.Fill(ds, "DangNhap");
               dtb = ds.Tables["DangNhap"];
           }
           catch (System.Exception ex)
           {
               return null;
           }
           return dtb;
       }
    }
}
