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
        private void showData()
        {
            //             row.Text = txtTenSV.Text;
            //             row.SubItems.Add(txtTenSV.Text);
            //             row.Text = txtDiem.Text;
            //             row.SubItems.Add(txtDiem.Text);
            //             row.Text = txtMaSV.Text;
            //             row.SubItems.Add(txtMaSV.Text);
            //             listView1.Items.Add(row);
            string[] row = { txtMaSV.Text, txtTenSV.Text, txtDiem.Text };
            var list = new ListViewItem(row);
            listView1.Items.Add(list);
        }
        private void luudl()
        {
            using (StreamWriter sw = new StreamWriter("file.txt", true))
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    sw.Write(item.Text);
                    for (int i = 1; i < item.SubItems.Count; i++)
                    {
                        sw.Write("        " + item.SubItems[i].Text);
                        sw.Write("\n");

                    }
                    sw.WriteLine();
                }
                
            }

        }
        private void fillData()
        {
            string a;
            StreamReader ReadFile = new StreamReader("File.txt");
            a = ReadFile.ReadLine();
            while (a != null)
            {
                string[] str = a.Split(',');
                ListViewItem item = new ListViewItem(str[0]); //Đưa vào cột Mã sv
                item.SubItems.Add(str[1]); //Đưa vào cột tên sv
                item.SubItems.Add(str[2]);//đưa vào cột điểm
                listView1.Items.Add(item);
                a = ReadFile.ReadLine();
                break;
            }
            ReadFile.Close();
            ReadFile.Dispose();
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
           txtMaSV.Text = "";
           txtTenSV.Text = "";
           txtDiem.Text = "";
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
         {
             luudl();
         }

        private void btnShow_Click(object sender, EventArgs e)
        {
            fillData();
        }
         }
       
    }


