using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcess
{
    public class DangKyData
    {
        Data data = new Data();
        public bool insert(string  UserName, string Pass, string PhanQuyen)
        {
            int retval;
            SqlConnection con = data.getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DangKyTaiKhoan";
            cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
            cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = Pass;
            cmd.Parameters.Add("PhanQuyen", SqlDbType.NVarChar).Value = PhanQuyen;
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval > 0;
        }
    }
}
