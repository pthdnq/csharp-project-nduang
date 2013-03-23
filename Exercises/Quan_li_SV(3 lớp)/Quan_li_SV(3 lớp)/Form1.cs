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

        SinhvienList DL = new SinhvienList();
        Sinh_Vien sv = new Sinh_Vien();
        public frmMain()
        {
            InitializeComponent();
            loadData();

        }
        public void loadData()
        {
            listView1.Items.Clear();
            //string mang = sv.getMaSV() + " " + sv.getHoten() + " " + sv.getDiem();
            ArrayList dulieu = DL.getDSSinhVienFromFile();
            for (int i = 0; i < dulieu.Count;i++ )
            {
                sv = (Sinh_Vien)dulieu[i];
           //   string[] arrayStr = mang.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                ListViewItem item = new ListViewItem(sv.getMaSV().ToString());
                //item.SubItems.Add(sv.getMaSV().ToString());
                item.SubItems.Add(sv.getHoten());
                item.SubItems.Add(sv.getDiem().ToString());
                listView1.Items.Add(item);
                listView1.View = View.Details;
            }
        }
//         private void showData()
//         {
//             string[] row = { txtmasv.Text, txttensv.Text, txtdiem.Text };
//             var list = new ListViewItem(row);
//             listView1.Items.Add(list);
//             listView1.EndUpdate();
//         }
        public void xoaText()
        {
            txtdiem.Text = "";
            txtmasv.Text = "";
            txttensv.Text = "";
        }
        public void search(int index)
        {
            Sinh_Vien sv = new Sinh_Vien(0,"",0);
            if (txtmasv.Text!="")
            {
                sv.setMaSV(int.Parse(txtmasv.Text.Trim()));
            }
            
            sv.setHoten(txttensv.Text.Trim());
            if (txtdiem.Text.Trim()!="")
            {
                sv.setDiem(int.Parse(txtdiem.Text.Trim()));
            }


            ArrayList list = DL.searchDL(sv, index);//lay ket qua tim kiem dc
            ShowSearch(list);//show len giao dien


        }
        public void ShowSearch(ArrayList list)
        {
            listView1.Items.Clear();
            ArrayList dulieu = list;
            for (int i = 0; i < dulieu.Count; i++)
            {
                sv = (Sinh_Vien)dulieu[i];
                ListViewItem item = new ListViewItem(sv.getMaSV().ToString());
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
    
        private void btnxem_Click_1(object sender, EventArgs e)
        {
           //DL.hienThiList();
           loadData();

        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
           
            string chuoi = txtmasv.Text;
            string chuoi1 = txtdiem.Text;
            int masv = int.Parse(chuoi);
            int diem = int.Parse(chuoi1);
            string ten = txttensv.Text.Trim();
            bool isExist=DL.IsExist(masv);
            if (isExist==true)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại");
                return;
            }
            DL.themDL(masv, ten, diem);
            DL.luuDL();
            loadData();
            xoaText();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            DL.luuDL();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
             if (listView1.SelectedItems.Count == 0)
             {
                 MessageBox.Show("Chọn hàng cần xóa ");
             }
             else
             {
                 DialogResult dialogResult = MessageBox.Show("bạn có thực sự muốn xóa", "xác nhận xóa", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {
                     foreach (ListViewItem item in listView1.SelectedItems)
                     {
                         string chuoi = txtmasv.Text;
                         int masv = int.Parse(chuoi);
                         DL.xoaDL(masv);
                         //  xoaText();
                     }
                     DL.luuDL();
                     xoaText();
                     loadData();
                 }
           }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
//             if (listView1.SelectedItems.Count == 0)
//             {
              //  MessageBox.Show("Chọn hàng cần sữa ");
//             }
//             else
//             {
//                 foreach (ListViewItem item in listView1.SelectedItems)
//                 {
//                     DL.suaDL(tensv, maSV);
//                     xoaText();
//                 }
                Sinh_Vien sv_ = new Sinh_Vien();
                sv_.setMaSV(int.Parse(txtmasv.Text.Trim()));
                sv_.setHoten(txttensv.Text.Trim());
                sv_.setDiem(int.Parse(txtdiem.Text.Trim()));
                DL.suaDL(sv_);
                DL.luuDL();
                loadData();
 //           }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem view = listView1.SelectedItems[0];
                txtmasv.Text = listView1.SelectedItems[0].Text;
                txttensv.Text = view.SubItems[1].Text;
                txtdiem.Text = view.SubItems[2].Text;
            }
            else
            {
                return;
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            int index = comboBox.SelectedIndex;
            search(index);
        }

    }
}
    

