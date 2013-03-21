using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Quản_lý_sinh_viên
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }
        ListViewItem row = new ListViewItem();
        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox.Items.Add("Tim kiem theo Ma SV");
            comboBox.Items.Add("Tim kiem theo Ho ten");
            comboBox.Items.Add("Tim kiem theo ma SV va Ho ten");

        }
        private void readFile()
        {
            Stream s = File.OpenRead("node.txt");
            StreamReader st = new StreamReader(s);
            string str = st.ReadLine();
        }
        public void anTexbox(bool status)
        {
            txtDiem.Enabled = status;
            txtMaSV.Enabled = status;
            txtTenSV.Enabled = status;

        }
        public void xoaText()
        {
            txtDiem.Text = "";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
        }
        private void showData()
        {
            string[] row = { txtMaSV.Text, txtTenSV.Text, txtDiem.Text };
            var list = new ListViewItem(row);
            listView1.Items.Add(list);
            listView1.EndUpdate();
        }
        private void loadData()
        {
            listView1.Items.Clear();
            StreamReader line = new StreamReader("Du lieu.txt", true);
            while (!line.EndOfStream)
            {
                string docline = line.ReadLine();
                String[] cat = docline.Split(' ');
                ListViewItem item = new ListViewItem(cat[0]);
                //item.SubItems.Add(cat[0]);
                item.SubItems.Add(cat[1]);
                item.SubItems.Add(cat[2]);
                listView1.Items.Add(item);
                listView1.View = View.Details;
            }

            line.Close();

        }
        private void luuDl()
        {
            StreamWriter sw = new StreamWriter("Du lieu.txt", false);
            foreach (ListViewItem row in listView1.Items)
            {
                //int i;
                //for(i=0; i< listView1.Items.Count; i++)
                //{ if 
                sw.WriteLine(row.SubItems[0].Text + " " + row.SubItems[1].Text + " " + row.SubItems[2].Text);
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
        private void upDate()
        {
            if (listView1.SelectedItems != null)
            {
//                 foreach (ListViewItem item in listView1.SelectedItems )
//                 {
                    //ListViewItem view = listView1.SelectedItems[0];
                listView1.SelectedItems[0].SubItems[0].Text = txtMaSV.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txtTenSV.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txtDiem.Text;
// 
//                 }
             }
        }
        private void searchMaSV()
        {
//             loadData();
//             for (int i=0; i< listView1.Items.Count ; i++)
//             {
//                 if (listView1.Items[i].SubItems[0].ToString() == txtMaSV.Text)
//                 {
//                     listView1.Items.Clear();
//                     ListViewItem item = new ListViewItem();
//                     //item.SubItems.Add(item[1]);
//                     //item.SubItems.Add(cat[2]);
//                     listView1.Items.Add(item);
//                     listView1.View = View.Details;
//                 }
//             }

            listView1.Items.Clear();
            if(txtMaSV.Text.Trim()=="")//neu chua nhap ma sinh vien thi ket qua tim kiem la tat ca
            {
                loadData();
                return;
            }
            StreamReader line = new StreamReader("Du lieu.txt", true);
            while (!line.EndOfStream)
            {
                string docline = line.ReadLine();
                String[] cat = docline.Split(' ');
                string masv= cat[0];//phan tu dau tien la ma sv trong 1 hang doc duoc
                if (masv.Trim() == txtMaSV.Text.Trim())
                {
                    ListViewItem item = new ListViewItem(cat[0]);
                    //item.SubItems.Add(cat[0]);
                    item.SubItems.Add(cat[1]);
                    item.SubItems.Add(cat[2]);
                    listView1.Items.Add(item);
                    listView1.View = View.Details;
                }
            }

            line.Close();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
                loadData();
                Process_Sinh_Vien sv = new Process_Sinh_Vien();
                string chuoi = txtMaSV.Text;
                string chuoi1 = txtDiem.Text;
                int masv = int.Parse(chuoi);
                int diem = int.Parse(chuoi1);
                string ten = txtTenSV.Text.Trim();
                if (listView1.Items.Count == 0)
                    {
                        //sv.themSV(masv, ten, diem);
                        showData();
                        xoaText();
                    }
                else
                    {
//                         foreach (ListViewItem item in listView1.Items)
//                         listView1.Items[0].Remove();
                        sv.themSV(masv, ten, diem);
                        showData();
                        xoaText();
 
                    }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            luuDl();
        }
        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
            loadData();
            }
            else
            {
            foreach (ListViewItem item in listView1.Items)
            listView1.Items[0].Remove();
            loadData();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem view = listView1.SelectedItems[0];
                txtMaSV.Text = listView1.SelectedItems[0].Text;
                txtTenSV.Text = view.SubItems[1].Text;
                txtDiem.Text = view.SubItems[2].Text;
            }
            else
            {
                return;
            }
            //anTexbox(false);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
           // anTexbox(true);
            upDate();
            
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chọn hàng cần xóa ^-^ :d ");
            }
            else
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    listView1.Items.Remove(item);
                    xoaText();
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            searchMaSV();
        }

    }
}
