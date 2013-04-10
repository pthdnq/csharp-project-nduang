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
                MessageBox.Show("Khong the ket noi server");
            }
            
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Thread tinh = new Thread(new ThreadStart(nhapDL));
            tinh.Start();

        }
        private void nhapDL()
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
                    // txtKQ.Text += Encoding.ASCII.GetString(data, 0, k);
                    string strData = Encoding.ASCII.GetString(data, 0, k);
                    showTong(strData);
                }
                catch (System.Exception ex)
                {
                    return;
                }
        }
        delegate void SetTextCallback(string text);
        public void showTong(string strTong)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtKQ.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(showTong);
                this.Invoke(d, new object[] { strTong });
            }
            else
            {
                this.txtKQ.Text = strTong;
            }
        }

    }
}
