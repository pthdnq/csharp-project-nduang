using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Server =Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=quang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
               
                conn.Open();
                Console.WriteLine("connectionString opened !");
                MessageBox.Show("kết nối thành công");
            }
            catch (SqlException sqle)
            {
                
                Console.WriteLine("Error: " + sqle.Message);
                MessageBox.Show("kết nối thất bại");
            }
            finally
            {
                
                conn.Close();
                Console.WriteLine("connectionString closed !");
        }
        }

      
    }
}



