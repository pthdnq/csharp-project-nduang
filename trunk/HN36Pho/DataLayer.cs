using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HN36Pho
{
    class DataLayer
    {
        public SqlConnection conn = new SqlConnection();
        public bool OpenConnection()
        {
            conn.ConnectionString=ModuleConfig.strConnection;
            conn.Open();
            if (conn==null)
            {
                return false;
            }
            return true;
        }
        public bool CloseConnection()
        {
            
            if (conn!=null)
            {
                conn.Close();
                return false;
            }
            return true;
        }
        public DataTable getData(string sqlQuery)
        {
            OpenConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            CloseConnection();
            return dt;
        }
        public bool updateData(string sqlQuery)
        {
            OpenConnection();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, conn);
            int Result=sqlCommand.ExecuteNonQuery();
            CloseConnection();
            if (Result==-1)
            {
                return false;
            }
            return true;
        }
        public int countRow(string sqlQuery)
        {
            OpenConnection();
            SqlDataAdapter ad = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            CloseConnection();
            return numberRow;
        }
    }
}
