using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToUpper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string chuoiHoa = txtChuHoa.Text;// lay chu Hoa vao bien chuoi
            string chuoiThuong = chuoiHoa.ToLower();//doi chu hoa sang chu thuong va gan vao chuoiThuong
            txtChuThuong.Text = chuoiThuong;// gan chuoi hoa len textbox
        }
    }
}
