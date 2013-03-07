using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace thành_công_đi__nào
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
            conn.Open();
            try
            {
                //MessageBox.Show("kết nối thành công");
                SqlDataAdapter ad = new SqlDataAdapter(@"select * from account where ID='" + txtID.Text.Trim() + "' and Pass='" + txtPass.Text.Trim() + "'", connectionString);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                int numberRow = dt.Rows.Count;
                if (numberRow == 0)
                {
                    if (txtPass.Text == "")
                    {
                        MessageBox.Show("nhập pass");
                        txtPass.Focus();
                        return;
                    }
                    if (txtID.Text == "")
                    {
                        MessageBox.Show("nhập ID");
                        txtID.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("đăng nhập thành công");
                }

  
            }
            catch (SqlException sqle)
            {

                MessageBox.Show("kết nối thất bại");
            }
            
            
        }
    }
}
