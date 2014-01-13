using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using System.Data.SqlClient;
using Component;

namespace QLPT
{
    public partial class FrmXoaTaiKhoan : Form
    {
        XoaTaiKhoanBUS m_XoaTaiKhoanBUS = new XoaTaiKhoanBUS();
        Utils m_utils = new Utils();
        public FrmXoaTaiKhoan()
        {
            InitializeComponent();
        }

        private void FrmXoaTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dat = new DataTable();
            dat = m_XoaTaiKhoanBUS.selectTaiKhoan();
            dgvTaiKhoan.DataSource = dat;

        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvTaiKhoan.RowCount; i++)
            {
                dgvTaiKhoan.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }

        public void delTaiKhoan()
        {
            int count = dgvTaiKhoan.SelectedRows.Count;
            if(count <1)
            {
                MessageBox.Show("Bạn chưa chọn tài khoản cần xóa");
                return;
            }
            
            foreach (DataGridViewRow row in dgvTaiKhoan.SelectedRows)
            {
                string currentTaiKhoan="";
                
                try
                {
                    currentTaiKhoan = row.Cells["UserName"].Value.ToString();
                    //Không cho xóa tài khoản đang đăng nhập
                    if(FrmDangNhap.currenAccount == currentTaiKhoan)
                    {
                        MessageBox.Show("Không thể xóa tài khoản đang đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
                        return;
                    }
                    bool ok = m_XoaTaiKhoanBUS.deleteUserName(currentTaiKhoan);
                    if (ok == false)
                    {
                        MessageBox.Show("Xóa tài khoản[" + currentTaiKhoan + "] thất bại !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //MessageBox.Show("Xóa tài khoản " + currentTaiKhoan + " thất bại !!!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.ErrorCode == m_utils.ERR_MA_DANG_SU_DUNG)
                    {
                        MessageBox.Show("Mã [" + currentTaiKhoan + "] đang đươc sử dụng cho bảng nhân viên nên không thể xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delTaiKhoan();
            FrmXoaTaiKhoan_Load(sender,e);
        }

    }
}
