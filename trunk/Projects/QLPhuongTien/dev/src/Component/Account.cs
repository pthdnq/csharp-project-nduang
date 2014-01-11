using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Component
{
    public class Account
    {
        public Account()
        { 
        }
        Connection conn = new Connection();
        public bool isExistAccount(string user, string pass)
        {
            string sql = " select * from DangNhap where UserName = '" + user + "' and Pass = '" + pass + "'";
            SqlConnection con = conn.getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt.Rows.Count>0;
        }
        public string getPhanQuyen(string user, string pass)
        {
            try
            {
                string sql = " select * from DangNhap where UserName = '" + user + "' and Pass = '" + pass + "'";
                SqlConnection con = conn.getConnect();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                return dt.Rows[0]["phanquyen"].ToString();
            }
            catch (System.Exception ex)
            {
                return "";
            }

        }

    }
}
