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
    public partial class FrmDangNhap : Form
    {
        private Account m_account = new Account();
        private Utils m_utils = new Utils();
        public bool m_isLogin = false;
        public string m_PhanQuyen = "";
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
                m_PhanQuyen = m_account.getPhanQuyen(txtUser.Text.Trim(), txtPass.Text.Trim());
            }
            else 
            {
                //checkExistUser();
                resetControl();
                m_PhanQuyen = "";
            }
            
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            m_isLogin = false;
           
            this.Close();
           
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

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }


    }
}
