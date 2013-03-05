using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lưu_file_vào_1_nơi_nào_đó_bất_kỳ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDlg = new SaveFileDialog();
                //saveFileDlg.InitialDirectory = Application.ExecutablePath;
                saveFileDlg.Filter = "all file (*.txt)|*.txt";
                if (saveFileDlg.ShowDialog() == DialogResult.OK)
                {
                   // FileStream fs = new FileStream(saveFileDlg.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(saveFileDlg.FileName);
                    sw.Write(txtFile.Text.ToString());
                    sw.Flush();
                    sw.Close();
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "");
            }
        }
    }
}
