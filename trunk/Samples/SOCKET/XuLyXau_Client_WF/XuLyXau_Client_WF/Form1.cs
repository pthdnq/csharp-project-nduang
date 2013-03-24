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

namespace XuLyXau_Client_WF
{
    public partial class ChuanHoaXau : Form
    {
        Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public ChuanHoaXau()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            //Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(txtIP.Text),int.Parse(txtPort.Text));
            s.Connect(iep);
            txtReceive.Text += "Connected to Server!!\r\n";
            byte[] data = new byte[1024];
            int k = s.Receive(data);
            txtReceive.Text += "Wellcom From Server:" + Encoding.ASCII.GetString(data,0,k) + "\r\n";
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(txtSend.Text);
            s.Send(data, data.Length, SocketFlags.None);
            if (txtSend.Text.ToUpper().Equals("QUIT"))
                Application.Exit();
            txtSend.Clear();
            data = new byte[1024];
            int k = s.Receive(data);
            txtReceive.Text += "Data From Server:" + Encoding.ASCII.GetString(data,0,k) + "\r\n";
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            btSend.PerformClick();
        }
    }
}