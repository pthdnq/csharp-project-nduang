using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Form_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkq_Click(object sender, EventArgs e)
        {

            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            s.Connect(ie);
            byte[] data = new byte[1024];
            int k = s.Receive(data);
            MessageBox.Show("welcome",Encoding.ASCII.GetString(data,0,k));
            while (true)
            {
                String strA = txta.Text.ToString();
                String strB = txtb.Text.ToString();
                String str = strA +  strB;
                byte[] dl = new byte[1024];
                dl = Encoding.ASCII.GetBytes(str);
                s.Send(dl, dl.Length, SocketFlags.None);
                if (str.ToUpper().Equals("QUIT"))
                    break;
                dl = new byte[1024];
                int k1 = s.Receive(dl);
                String KQ = Encoding.ASCII.GetString(dl,0,k1);
                txtkq.Text = KQ.ToString();
            }
            s.Disconnect(true);
            s.Close();



        }
    }
}
