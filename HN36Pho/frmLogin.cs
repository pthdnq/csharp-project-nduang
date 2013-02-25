using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HN36Pho
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOKLogin_Click(object sender, EventArgs e)
        {
            checkLogin();
        }
        private bool checkLogin()
        {
            DataLayer DL = new DataLayer();
            string sqlQuery = "update account set online=0 ";
            DL.updateData(sqlQuery);
            if (txtUserLogin.Text.Trim()=="")
            {
                MessageBox.Show("Chưa nhập tài khoản");
                txtUserLogin.Focus();
                return false;
            }
            if(txtPassLogin.Text.Trim()=="")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txtPassLogin.Focus();
                return false;
            }
            sqlQuery = @"select * from account where Username=N'" + txtUserLogin.Text.Trim() + "' and pass=N'"+txtPassLogin.Text.Trim()+"'";
            int numberRow=DL.countRow(sqlQuery);
            if (numberRow==0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!!!!");
                return false;
            }
            else
            {
                sqlQuery = @"update account set online=1 where Username=N'" + txtUserLogin.Text.Trim() + "' and pass=N'" + txtPassLogin.Text.Trim() + "'";
                DL.updateData(sqlQuery);
            }
            frmMainA mainForm = new frmMainA();
            this.Hide();
            mainForm.ShowDialog();
            return true;
        }
    }
}
