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
        //private void readFile()
        //{
        //   StreamWriter w = new StreamWriter("dulieu.txt", true);
        //   w.WriteLine(txtMaSV.Text);
        //   w.WriteLine(txtTenSV.Text);
        //   w.WriteLine(txtDiem.Text);
        //}
        public void anTexbox(bool status)
        {
            txtDiem.Enabled = status;
            txtMaSV.Enabled = status;
            txtTenSV.Enabled = status;

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Process_Sinh_Vien sv = new Process_Sinh_Vien();
            string chuoi = txtMaSV.Text;
            string chuoi1 = txtDiem.Text;
            int masv = int.Parse(chuoi);
            int diem = int.Parse(chuoi1);
            string ten = txtTenSV.Text.Trim();
            sv.themSV(masv, ten, diem);
            showData();
        }
        private void showData()
        {
            row.Text = txtTenSV.Text;
            row.SubItems.Add(txtTenSV.Text);

            row.Text = txtDiem.Text;
            row.SubItems.Add(txtDiem.Text);

            row.Text = txtMaSV.Text;
            row.SubItems.Add(txtMaSV.Text);
           
            listView1.Items.Add(row);

        }
    }
}
