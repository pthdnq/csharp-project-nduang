using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
            if (txt1.Text == "")
            {
                MessageBox.Show("Nhap ten dang nhap");
                txt1.Focus();
                return;
            }
            if(txt2.Text == "")
            {
                MessageBox.Show("Nhap pass");
                txt2.Focus();
                return;
                

            }
            //viet tiep vao doan nay de hien ra form main va an form dang nhap


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
