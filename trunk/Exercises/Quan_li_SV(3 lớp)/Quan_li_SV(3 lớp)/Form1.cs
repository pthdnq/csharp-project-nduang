using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows.Forms;

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
            listView1.Items.Clear();
             ArrayList ds = DL.getDSSinhVienFromFile();
             for (int i = 0; i < ds.Count; i++)
             {
                 Sinh_Vien sv = new Sinh_Vien();
                 sv = (Sinh_Vien)ds[i];
                 ListViewItem item = new ListViewItem(sv.getMaSV().ToString());
                 //item.SubItems.Add(sv.getMaSV().ToString());
                 item.SubItems.Add(sv.getHoten());
                 item.SubItems.Add(sv.getDiem().ToString());
                 listView1.Items.Add(item);
                 listView1.View = View.Details;
             }
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
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn hàng cần xóa ^-^ :d ");
            }
            else
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    DL.xoaDL();
                    //listView1.Items.Remove(item);
                    
                }
            }

            
        }
        private void btnxem_Click(object sender, EventArgs e)
        {
            loadData();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
    

