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
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                Process_Sinh_Vien sv = new Process_Sinh_Vien();
                string chuoi = txtMaSV.Text;
                string chuoi1 = txtDiem.Text;
                int masv = int.Parse(chuoi);
                int diem = int.Parse(chuoi1);
                string ten = txtTenSV.Text.Trim();
                sv.themSV(masv, ten, diem);
                showData();
                xoaText();
            }
            else
            {
                foreach (ListViewItem item in listView1.Items)
                listView1.Items[0].Remove();
                Process_Sinh_Vien sv = new Process_Sinh_Vien();
                string chuoi = txtMaSV.Text;
                string chuoi1 = txtDiem.Text;
                int masv = int.Parse(chuoi);
                int diem = int.Parse(chuoi1);
                string ten = txtTenSV.Text.Trim();
                sv.themSV(masv, ten, diem);
                showData();
                xoaText();
 
            }
        }
        private void showData()
        {
            //row.Text = txtTenSV.Text;
            //row.SubItems.Add(txtTenSV.Text);

            //row.Text = txtDiem.Text;
            //row.SubItems.Add(txtDiem.Text);

            //row.Text = txtMaSV.Text;
            //row.SubItems.Add(txtMaSV.Text);
            string[] row = { txtMaSV.Text, txtTenSV.Text, txtDiem.Text };
            var list = new ListViewItem(row);
            listView1.Items.Add(list);
            listView1.EndUpdate();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Du lieu.txt", true);
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
        private void loadData()
        {
            StreamReader line = new StreamReader("Du lieu.txt",true);
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem view = listView1.SelectedItems[0];
                txtMaSV.Text = view.SubItems[0].Text;
                txtTenSV.Text = view.SubItems[1].Text;
                txtDiem.Text = view.SubItems[2].Text;
            }
            else
            {
                return;
            }
            anTexbox(false);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            anTexbox(true);
            
        }

       
    }
}
