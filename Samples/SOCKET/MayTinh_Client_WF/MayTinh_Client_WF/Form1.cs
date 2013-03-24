using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace MayTinh_Client_WF
{
    public partial class Form1 : Form
    {
        TcpClient cl;
        StreamWriter sw;
        StreamReader sr;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btOn_Click(object sender, EventArgs e)
        {
            cl = new TcpClient();
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"),9000);
            cl.Connect(iep);
            sr = new StreamReader(cl.GetStream());
            sw = new StreamWriter(cl.GetStream());
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            sw.WriteLine("QUIT");
            sw.Flush();
            cl.Close();
            Application.Exit();
        }

        private void btCe_Click(object sender, EventArgs e)
        {
            txtLCD.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "0";
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            txtLCD.Text += ".";
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            txtLCD.Text += " + ";
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            txtLCD.Text += " - ";
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            txtLCD.Text += " * ";
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            txtLCD.Text += " / ";
        }

        private void btSin_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "Sin ";
        }

        private void btCos_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "Cos ";
        }

        private void btTan_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "Tan ";
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "SQRT ";

        }

        private void btLog_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "Log ";
            
        }

        private void btBinhPhuong_Click(object sender, EventArgs e)
        {
            txtLCD.Text += "QRT ";

        }

        private void btKQ_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(cl.GetStream());
            //StreamWriter sw = new StreamWriter(cl.GetStream());
          
                sw.WriteLine(txtLCD.Text);
                sw.Flush();
                string st = sr.ReadLine();
                txtLCD.Text += "=" + st;
            
        }
    }
}
