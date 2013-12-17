using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAcess
{
    public class Data
    {
        string ketnoi = @"Data Source=(local);Initial Catalog=QuanLy_PT;Integrated Security=True";
        public SqlCommand sqlCom = null;
        public SqlConnection sqlConn = null;
        public SqlDataAdapter da = null;
        public SqlDataReader dr = null;
        public DataSet ds = new DataSet();
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLy_PT;Integrated Security=True");
        }
        public DataTable getTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;

        }
        //không trả về kết quả 
        public int ExcuteNonQuery(string sql)
        {
            int retval;
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            retval = cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return retval;

        }
        public String getIDNumberAuto(string tblName, string fldID)
        {
            try
            {
                string sql = @"set rowcount 1 select " + fldID + " from " + tblName + " order by " + fldID + " Desc ";
                SqlConnection con = getConnect();
                SqlDataAdapter ad = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                string strMaxIDAuto = dt.Rows[0][0].ToString();
                return strMaxIDAuto;
            }
            catch(Exception)
            {
                return "0";
            }
        }
        public void moketnoi()
        {
            sqlConn = new SqlConnection(ketnoi);
            if ((sqlConn != null) && (sqlConn.State == ConnectionState.Closed))
            {
                sqlConn.Open();
            }
        }
        public void dongketnoi()
        {
            sqlConn.Close();
        }

        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";

        }
    }

}
