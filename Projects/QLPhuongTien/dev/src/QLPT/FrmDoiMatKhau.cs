using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using DataAcess;
using System.Data.SqlClient;


namespace QLPT
{
    public partial class FrmDoiMatKhau : Form
    {
        Data dt = new Data();
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
           
            txtTen.Focus();
            dt.moketnoi();
        }
        public Boolean Test_Database(string strChuoiDieuKien, string strTableName, SqlConnection sqlCNN)
        {
            dt.moketnoi();
            bool bolReturn = false;
            string strSQL = "SELECT * FROM " + strTableName.Trim() + " WHERE " + strChuoiDieuKien + "";
            SqlCommand sqlCmd = new SqlCommand(strSQL, sqlCNN);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            if ((sqlReader != null) && (!sqlReader.IsClosed)) sqlReader.Close();
            sqlReader = sqlCmd.ExecuteReader();
            if (sqlReader.HasRows)
                bolReturn = true;
            sqlReader.Dispose();
            sqlReader.Close();
            return bolReturn;
        }

        private void btDoiMatKhau_Click(object sender, EventArgs e)
        {
            string strDangNhap = txtTen.Text.Trim();
            string strMatKhau = txtMK.Text.Trim();
            string strChuoiDieuKien = "UserName='" + strDangNhap + "' and Pass='" + strMatKhau + "' ";
            string strTableName = "DangNhap";
            if (Test_Database(strChuoiDieuKien, strTableName,dt.sqlConn))
            {
                string sql = @"select * from DangNhap";
               dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql,dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DangNhap");
                DataTable dtb = ds.Tables["DangNhap"];
                foreach (DataRow dr in dtb.Rows)
                {

                    if ((dr["UserName"].ToString() == txtTen.Text) && (dr["Pass"].ToString() == txtMK.Text))
                    {
                        if (txtMKmoi.Text != txtReMKmoi.Text)
                        {
                            MessageBox.Show("Mật Khẩu Nhập Lại Không Chính Xác", "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtReMKmoi.Text = "";
                            this.txtReMKmoi.Focus();
                        }
                        else
                        {
                            string update = @"update DangNhap set pass = '" + txtMKmoi.Text + "' where UserName = '" + txtTen.Text + "' ";
                           dt.moketnoi();
                            SqlCommand cmd = new SqlCommand(update,dt.sqlConn);
                            try
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Đã đổi mật khẩu  Thành công tài khoản " + txtTen.Text, "thành công ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                               dt.dongketnoi();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật không đúng : " + ex, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                // MessageBox.Show("Tên Đăng nhập hoặc mật khẩu chưa đúng");
                            }

                        }

                    }



                }

            }
            else
            {

                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
                //this.ForeColor = Color.Red;
                this.txtTen.Text = "";
                this.txtMK.Text = "";
                this.txtTen.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn  không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void FrmDoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

    }
}
