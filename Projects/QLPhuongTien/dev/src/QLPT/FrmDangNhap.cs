using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Component;

namespace QLPT
{
    public partial class FrmDangNhap : Form
    {
        private Account m_account = new Account();
        public bool m_isLogin = false;
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLy_PT;Integrated Security=True");
        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
            AcceptButton = btDangNhap;
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            bool ok = validAccount();
            if (ok == false)
                return;
            bool isExistAccount = m_account.isExistAccount(txtUser.Text.Trim(), txtPass.Text.Trim());
            if (isExistAccount)
            {
                this.Close();
                m_isLogin = true;
            }
            else
            {
                resetControl();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }
        //internal void ShowDiaLog()
        //{
        //    throw new NotImplementedException();
        //}
        private bool validAccount()
        {
            if (this.txtUser.Text.Length == 0 || this.txtPass.Text.Length == 0)
            {
                this.lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Bạn chưa nhập User hoặc Pass";
                return false;
            }

            return true;
        }
        public void resetControl()
        {
            this.lbStatus.ForeColor = Color.Red;
            this.lbStatus.Text = "Tài khoản không tồn tại";
            this.txtUser.Text = "";
            this.txtPass.Text = "";
            this.txtUser.Focus();
        }
    }
}
