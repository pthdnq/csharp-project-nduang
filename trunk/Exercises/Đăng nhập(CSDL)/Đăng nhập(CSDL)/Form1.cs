using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Đăng_nhập_CSDL_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("kết nối thất bại");
                return;
            }
            SqlDataAdapter ad= new SqlDataAdapter(@"select * from acount where ID=N'"+txtID.Text.Trim()+"' and Pass=N'"+txtPass.Text.Trim()+"'", connectionString);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            if (numberRow == 0)
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng");
                return;
            }
            else
            {
                MessageBox.Show("đăng nhập thành công");
                return;
            }
        }

    }
}
