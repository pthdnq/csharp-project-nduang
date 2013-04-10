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
using System.Collections;
using System.Threading;

namespace FROM_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Thread tinh = new Thread(new ThreadStart(nhapDL));
            tinh.Start();   
        }
        private void nhapDL()
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            s.Connect(ie);
            while (true)
            {
                MessageBox.Show("Connected to Server.....");
                byte[] data = new byte[1024];
                int k1 = s.Receive(data);
                string A = txtNumber1.Text;
                string B = txtNumber2.Text;
                string gep = string.Concat(A, "-", B).Trim();
                data = Encoding.ASCII.GetBytes(gep);
                s.Send(data, data.Length, SocketFlags.None);
                data = new byte[1024];
                int k = s.Receive(data);
                txtKQ.Text += Encoding.ASCII.GetString(data, 0, k);
                if (Convert.ToInt32(txtNumber1.Text)==0 && Convert.ToInt32(txtNumber2.Text)==0)
                {
                    MessageBox.Show("End connect...");
                    break;
                }
            }
        }
    }
}
