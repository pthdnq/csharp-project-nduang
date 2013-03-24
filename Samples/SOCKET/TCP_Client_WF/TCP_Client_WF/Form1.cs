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
using System.IO;

namespace TCP_Client_WF
{
    public partial class Form1 : Form
    {
        TcpClient cl = new TcpClient();
        
            
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            cl.Connect(iep);
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            txtReceive.Text += "Ket noi toi Server!\r\n";
            txtReceive.Text += "Loi chao tu Server:" + sr.ReadLine() + "\r\n";
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            
            string st;
            st = txtSend.Text;
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            sw.WriteLine(st);
            sw.Flush();
            nhay:
            txtSend.Clear();
            if (st.ToUpper().Equals("QUIT"))
                Application.Exit();
            st = sr.ReadLine();
            txtReceive.Text += "Data From Server:" + st + "\r\n";
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btSend.PerformClick();
        }
    }
}