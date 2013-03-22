using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Quan_li_SV_3_lớp_
{
    public partial class frmMain : Form
    {
        ListViewItem list = new ListViewItem();
        SinhvienList DL = new SinhvienList();
        public frmMain()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            DL.docDLfile();
            listView1.Items.Clear();
            //Sinh_Vien sv = new Sinh_Vien();
            //sv = (Sinh_Vien)list
           // for(int i =0; i< listSinhVien
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Tim kiem theo ma_SV");
            comboBox.Items.Add("Tim kiem theo Ten_SV");
            comboBox.Items.Add("Tim kiem theo ma_SV va Ten_SV");
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            DL.luuDLfile(); 
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
        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            DL.xoaDL();
        }
        private void btnxem_Click(object sender, EventArgs e)
        {
            DL.docDLfile();
        }

    }
}
    

