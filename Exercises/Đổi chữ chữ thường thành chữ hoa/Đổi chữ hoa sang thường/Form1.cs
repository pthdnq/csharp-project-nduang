using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Đổi_chữ_hoa_sang_thường
{
    public partial class frmDoichu : Form
    {
        public frmDoichu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoithuong = txtA.Text;
            string chuoihoa = chuoithuong.ToUpper();
            txtB.Text = chuoihoa;
        }
    }
}
