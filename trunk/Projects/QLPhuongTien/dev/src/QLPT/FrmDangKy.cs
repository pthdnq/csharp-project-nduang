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
using Component;

namespace QLPT
{
    public partial class FrmDangKy : Form
    {
        Data dt = new Data();
        DangKyBUS m_DangKyBUS = new DangKyBUS();
        Utils utils = new Utils();
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
               // string insert = @"INSERT INTO DangNhap (UserName , Pass) VALUES ('" + txtTen.Text + "','" + txtMK.Text + "')";
               // dt.moketnoi();
               // SqlCommand cmd = new SqlCommand(insert, dt.sqlConn);
                try
                {
                    m_DangKyBUS.insert(txtTen.Text
                                            , txtMK.Text
                                            , cmbPhanQuyen.Text                                         
                                            );
                    MessageBox.Show("Đăng ký tài khoản: "+txtTen.Text+" thành công ");
                    //this.Close();
                    FrmDangKy_Load(sender, e);


                }
                catch (SqlException ex)
                {
                    if (ex.ErrorCode == utils.ERR_MA_DANG_SU_DUNG)
                    {
                          MessageBox.Show("Tên truy cập [" + txtTen.Text + "] đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void FrmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

    }
}
