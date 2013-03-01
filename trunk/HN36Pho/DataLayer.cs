using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace HN36Pho
{
    class DataLayer
    {
        public SqlConnection conn = new SqlConnection();
        public bool OpenConnection()
        {
            try
            {
                conn.ConnectionString = getConnectionString();
                conn.Open();
                if (conn == null)
                {
                    return false;
                }
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Không thể kết nối cơ sở dữ liệu!!!!");
                Application.Exit();
                return false;
            }

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
            bool ok = OpenConnection();
            if (!ok)
            {
                return null;
            }
            SqlDataAdapter ad = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            CloseConnection();
            return dt;
        }
        public bool updateData(string sqlQuery)
        {
            bool ok=OpenConnection();
            if(!ok)
            {
                return false;
            }
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
            bool ok = OpenConnection();
            if (!ok)
            {
                return 0;
            }
            SqlDataAdapter ad = new SqlDataAdapter(sqlQuery, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            CloseConnection();
            return numberRow;
        }
        public string getConnectionString()
        {
            string conn = "";
            string strAppStart = Application.StartupPath;
            conn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\HN36Pho.mdf;Integrated Security=True;Connect Timeout=3;User Instance=True";
            return conn;
        }

    }
}
