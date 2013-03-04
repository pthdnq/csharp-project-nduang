using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lưu_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string chuoi =txtFile.Text;
            txtFile.Text = chuoi;
            StreamWriter strW = new StreamWriter(@"C:\test.txt");
            strW.Write(chuoi);

        }

      
    }
}
