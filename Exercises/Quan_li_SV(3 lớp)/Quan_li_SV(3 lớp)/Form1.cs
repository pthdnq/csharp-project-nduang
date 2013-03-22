using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quan_li_SV_3_lớp_
{
    public partial class frmMain : Form
    {

        SinhvienList DL = new SinhvienList();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Tim kiem theo ma_SV");
            comboBox.Items.Add("Tim kiem theo Ten_SV");
            comboBox.Items.Add("Tim kiem theo ma_SV va Ten_SV");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DL.luuDL(); 
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string chuoi = txtmasv.Text;
            string chuoi1 = txtdiem.Text;
            int masv = int.Parse(chuoi);
            int diem = int.Parse(chuoi1);
            string ten = txttensv.Text.Trim();
            DL.themSV(masv, ten, diem);
        }

    }
}
    

