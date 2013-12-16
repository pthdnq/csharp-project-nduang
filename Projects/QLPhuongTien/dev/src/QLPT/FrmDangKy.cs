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
    public partial class FrmDangKy : Form
    {
        Data dt = new Data();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void FrmDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btDK_Click(object sender, EventArgs e)
        {
            if ((txtTen.Text == "") || (txtMK.Text == "")|| (txtNhapLaiMK.Text==""))
            {
                MessageBox.Show("Điền Thiếu Thông Tin mật khẩu hoặc tên truy cập");
            }
            else if (txtMK.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật Khẩu Không Chính Xác");
            }
            else
            {
                string insert = @"INSERT INTO DangNhap (UserName , Pass) VALUES ('" + txtTen.Text + "','" + txtMK.Text + "')";
                dt.moketnoi();
                SqlCommand cmd = new SqlCommand(insert, dt.sqlConn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công tài khoản : " + txtTen.Text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dt.dongketnoi();
                    txtTen.Text = "";
                    txtMK.Text = "";
                    txtNhapLaiMK.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Xảy Ra : " + ex, "Lỗi");
                }


            }
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            this.txtTen.Text = "";
            this.txtMK.Text = "";
            this.txtNhapLaiMK.Text = "";
            this.txtTen.Focus();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
