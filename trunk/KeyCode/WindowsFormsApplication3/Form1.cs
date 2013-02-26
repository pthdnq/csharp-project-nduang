using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                //txtBox1.Text = txtBox2.Text;
                //txtBox1.Text = "";
               
            }
        }

        private void txtBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBox2.Text = txtBox1.Text;// gan chu o duoi len o tren
                txtBox1.Text = "";// xoa chu o tren

            }

        }
    }
}
