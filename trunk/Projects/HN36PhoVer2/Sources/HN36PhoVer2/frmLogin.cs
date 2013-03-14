using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataObject;
namespace HN36PhoVer2GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Nhap ten dang nhap");
                txtID.Focus();
                return;
            }
            if(txtPass.Text == "")
            {
                MessageBox.Show("Nhap pass");
                txtPass.Focus();
                return;
                

            }

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
            SqlDataAdapter ad = new SqlDataAdapter(@"select * from acount where ID=N'" + txtID.Text.Trim() + "' and Pass=N'" + txtPass.Text.Trim() + "'", connectionString);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            if (numberRow == 0)
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không đúng");
                return;
            }
            //else
            //{
            //    MessageBox.Show("đăng nhập thành công");
            //    return;
            //}

            //viet tiep vao doan nay de hien ra form main va an form dang nhap
            frmMain main = new frmMain();
            this.Hide();
            main.ShowDialog();
          


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void setConnectionAppStart()
        {
            string strAppStart = Application.StartupPath;


        }
    }
}
