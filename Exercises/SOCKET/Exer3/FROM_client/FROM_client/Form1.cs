
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
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);

        public Form1()
        {
            InitializeComponent();
            try
            {
                s.Connect(ie);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Connected fail");
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            //int k1 = s.Receive(data);
            string A = txtNumber1.Text;
            string B = txtNumber2.Text;
            string gep = string.Concat(A, "-", B).Trim();
            data = Encoding.ASCII.GetBytes(gep);
            try
            {
                s.Send(data, data.Length, SocketFlags.None);
                data = new byte[1024];
                int k = s.Receive(data);
                txtKQ.Text += Encoding.ASCII.GetString(data, 0, k);
            }
            catch (System.Exception ex)
            {
                return;
            }

        }
    }
}
