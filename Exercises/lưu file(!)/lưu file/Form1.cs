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
            
            string chuoi = txtFile.Text;
            StreamWriter strW = new StreamWriter(@"E:\phan mem.txt");
            strW.Write(chuoi);
            strW.Close();
            button1.Enabled = false;//mờ button


        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;//hiện button
        }


      
    }
}
    