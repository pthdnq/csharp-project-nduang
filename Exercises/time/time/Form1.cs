using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();//lay time hien tai cua he thong
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Interval = (1000) * (1);//set so giay chay va gia tri tang len sau moi lan
                timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
