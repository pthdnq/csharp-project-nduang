using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlTypes;

namespace DataGreadView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void btnok_Click(object sender, EventArgs e)
        {
            //    SqlConnection cnn = new SqlConnection();
            //    string strAppStart = Application.StartupPath;
            //    cnn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\QLSV.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            //    try
            //    {
            //        cnn.Open();
            //        //MessageBox.Show("thanh cong");//thanh cong ko hien ra, neu loi thi hien thi cho nguoi ta biet
            //    }
            //    catch (SqlException)
            //    {
            //        MessageBox.Show("that bai");
            //        return;
            //    }

            //     string sql = " select * from account";
            //     SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            //     DataTable t = new DataTable();
            //     ad.Fill(t);
            //     dtgv.DataSource = t;
            //     cnn.Close();

            openConnection();
            showData();
            closeConnection();
        }
        SqlConnection conn = new SqlConnection();
        private string getStringConnection()
        {
            string strAppStart = Application.StartupPath;
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\QLSV.mdf;Integrated Security=True;Connect Timeout=10;User Instance=True";
            return connectionString;
        }
        private void openConnection()
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
            catch (SqlException )
            {
                MessageBox.Show("kết nối thất bại");
                return;
            }
        }
        private void closeConnection()
        {
            try
            {
                conn.Close();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("kết nối thất bại");
                return;
            }
        }
        private void showData()
        {
            string sql = " select * from account";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable t = new DataTable();
            ad.Fill(t);
            dtgv.DataSource = t;
        }
        private void themDl()
        {
            string them = "INSERT INTO account(username, password) VALUES(@username,@pass)";//thêm dl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = them;
            // 2. define parameters used in command object
            SqlParameter param1 = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            param1.ParameterName = "@username";
            param1.Value = txtUsername.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param1);
            param2.ParameterName = "@pass";
            param2.Value = txtPass.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param2);
            int i = sqlCommand.ExecuteNonQuery();
            // MessageBox.Show("Đã insert [" + i.ToString() + "] dữ liệu");
            if (i == 0)
            {
                MessageBox.Show("insert that bai");
                return;
            }
            showData();
        }
        private void SuaDl()
        {
            string them = "UPDATE account SET Password =@pass Where Username=@username";//sửa dữ liệu
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = them;
            // 2. define parameters used in command object
            SqlParameter param1 = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            param1.ParameterName = "@username";
            param1.Value = txtUsername.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param1);
            param2.ParameterName = "@pass";
            param2.Value = txtPass.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param2);
            int i = sqlCommand.ExecuteNonQuery();
            // MessageBox.Show("Đã insert [" + i.ToString() + "] dữ liệu");
            if (i == 0)
            {
                MessageBox.Show("update that bai");
                return;
            }
            showData();
        }
        private void AnHien(bool status)
        {
            txtPass.Enabled = status;
            txtUsername.Enabled = status;

        }
        private void dltdatatextbox()//xóa nd textbox
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }
        private void xoaDl()
        {
            string them = @"DELETE FROM account WHERE username=@username AND Password=@pass";//xóa dl
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;
            sqlCommand.CommandText = them;
            // 2. define parameters used in command object
            SqlParameter param1 = new SqlParameter();
            SqlParameter param2 = new SqlParameter();
            param1.ParameterName = "@username";
            param1.Value = txtUsername.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param1);
            param2.ParameterName = "@pass";
            param2.Value = txtPass.Text.Trim();
            // 3. add new parameter to command object
            sqlCommand.Parameters.Add(param2);
            int i = sqlCommand.ExecuteNonQuery();
            // MessageBox.Show("Đã insert [" + i.ToString() + "] dữ liệu");
            if (i == 0)
            {
                MessageBox.Show("xoa that bai");
                return;
            }
            showData();

        }
        private bool isExistAccount()
        {
            string connectionString = getStringConnection();
            SqlDataAdapter ad = new SqlDataAdapter(@"select * from account where Username=N'" + txtUsername.Text.Trim() + "' and Password=N'" + txtPass.Text.Trim() + "'", connectionString);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            int numberRow = dt.Rows.Count;
            if (numberRow == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool kiemtratext()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("chưa nhập username");
                txtUsername.Focus();
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("chưa nhập pass");
                txtPass.Focus();
                return false;
            }
            return true;

        }
        private void btnok_Click_1(object sender, EventArgs e)
        {
            openConnection();
            showData();
            closeConnection();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            //dltdatatextbox();
            AnHien(true);
            bool no = kiemtratext();
            if (no == false)
            {
                return;
            }
            openConnection();
            bool ok = isExistAccount();
            if (ok == true)
            {
                MessageBox.Show("account đã tồn tại");
                closeConnection();
                return;
            }
            themDl();
            closeConnection();
        }
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AnHien(false);
            int dong = e.RowIndex;
            txtUsername.Text = dtgv.Rows[dong].Cells[1].Value.ToString();
            txtPass.Text = dtgv.Rows[dong].Cells[2].Value.ToString();
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            openConnection();
            SuaDl();
            closeConnection();
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            openConnection();
            xoaDl();
            dltdatatextbox();
            closeConnection();
        }
    }
}




