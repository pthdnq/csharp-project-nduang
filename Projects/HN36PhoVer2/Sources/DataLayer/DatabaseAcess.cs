using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace DataLayer
{
    public class DatabaseAcess
    {
        SqlConnection conn = new SqlConnection();
        public string strStarPath;
        public void setStartUpPath(string strStartPath_)
        {
            strStarPath = strStartPath_;
        }
        public string getStartUpPath()
        {
            return strStarPath;
        }
        public string getStringConnection()
        {
            //string strAppStart = Application.StartupPath

            string strAppStart = getStartUpPath();
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\QLSV.mdf;Integrated Security=True;Connect Timeout=10;User Instance=True";
            return connectionString;
        }
        public void openConnection()
        {
            string connectionString = getStringConnection();
            //SqlConnection conn = new SqlConnection(connectionString);
            if (conn.ConnectionString == "")
            {
                conn.ConnectionString = connectionString;
            }

            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
             //   MessageBox.Show("kết nối thất bại");
                return;
            }
        }
        public void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException sqle)
            {
               // MessageBox.Show("kết nối thất bại");
                return;
            }
        }
    }
}
