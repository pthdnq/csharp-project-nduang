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

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=account;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();

               // MessageBox.Show("kết nối thành công");
            }
            catch (SqlException)
            {

                MessageBox.Show("kết nối thất bại");
            }
           // SqlDataAdapter ad = new SqlDataAdapter(@"select * from acount where ID=N'"+txtID.Text.Trim()+"' and Pass=N'"+txtPass.Text.Trim()+"'", connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.StoredProcedure;//dùng store SQL
            command.CommandText = "sp_login";
            SqlParameter param = new SqlParameter();
            // 2. define parameters used in command object
            SqlParameter param1 = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            param1.ParameterName = "@ID";
            param1.Value = txtID.Text.Trim();
            // 3. add new parameter to command object
            command.Parameters.Add(param1);
            param2.ParameterName = "@pass";
            param2.Value = txtPass.Text.Trim();
            // 3. add new parameter to command object
            command.Parameters.Add(param2);

            SqlDataAdapter ad = new SqlDataAdapter(command);
           // int i = command.ExecuteNonQuery();
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
 
            }
        }
    }
   
}
