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

namespace Chat_UDP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient send = new UdpClient();
            IPEndPoint iepRemote = new IPEndPoint(IPAddress.Parse(txtRemoteIP.Text), int.Parse(txtRemotePort.Text));
            byte[] data = new byte[1024];
            data = Encoding.UTF8.GetBytes(txtSend.Text);
            send.Send(data, data.Length, iepRemote);
            txtReceive.Text += "Toi:" + txtSend.Text + "\r\n";
            txtSend.Clear();
            if (txtSend.Text.ToUpper().Equals("QUIT"))
            {
                this.Dispose();
                Application.Exit();
            }
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread tuyen = new Thread(new ThreadStart(NhanDL));
            tuyen.Start();
        }
        void NhanDL()
        {
            UdpClient receive = new UdpClient(int.Parse(txtLocalPort.Text));
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                byte[] data = new byte[1024];
                data = receive.Receive(ref iep);
                string st = Encoding.UTF8.GetString(data);
                if (st.Trim().ToUpper().Equals("QUIT"))
                    break;
                txtReceive.Text += "Other:" + st + "\r\n";
            }

        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSend.PerformClick();
        }

    }
}
