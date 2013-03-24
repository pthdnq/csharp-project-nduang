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

namespace UDP_Chat_WF
{
    public partial class Form1 : Form
    {
        Socket s;
        IPEndPoint iplc, iprm;
        
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            iprm=new IPEndPoint(IPAddress.Parse(txtRmIP.Text),int.Parse(txtRmPort.Text));
            iplc = new IPEndPoint(IPAddress.Parse("127.0.0.1"), int.Parse(txtLcPort.Text));
            s.Bind(iplc);
            Thread tuyen = new Thread(new ThreadStart(NhanDL));
            tuyen.Start();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            //string st;
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(txtGui.Text);
            s.SendTo(data, iprm);
            if (txtGui.Text.ToUpper().Equals("QUIT"))
                Application.Exit();
            txtGui.Clear();
        }
        void NhanDL()
        {
            while (true)
            {
                byte[] data = new byte[1024];
                EndPoint rm = (EndPoint)iprm;
                int k = s.ReceiveFrom(data, ref rm);
                string st = Encoding.ASCII.GetString(data, 0, k);
                txtNhan.Text += "Other:" + st + "\r\n";
                if (st.ToUpper().Equals("QUIT"))
                {
                    //break;
                    Application.Exit();
                }
            }
        }

        private void txtGui_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btSend.PerformClick();
        }
    }
}
