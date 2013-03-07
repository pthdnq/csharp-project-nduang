using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace đăng_nhập_CSDL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
             
                MessageBox.Show("kết nối thành công");
            }
            catch (SqlException sqle)
            {
                
                MessageBox.Show("kết nối thất bại");
            }
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter ad = new SqlDataAdapter(@"select * from acount where ID=ngocham and Pass=ham115", connectionString);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            if (numberRow == 0)
            {
                
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng");
                return;
            }
        }
    }
   
}
