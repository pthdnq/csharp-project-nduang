using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tinh_tong_n_so;

namespace Chuongtrinhtinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string strInput = txtInput.Text;
            string[] matran=strInput.Split(',');
            int n = matran.Length;
            int[] arr = new int[n];
            //for (int i = 0; i < n;i++ )
            //{
            //    arr[i] = int.Parse(matran[i]);
            //}
            int error = convertStringArraryToIntArrary(matran, out arr);
            Tinhtong_n_so tinhtong = new Tinhtong_n_so();
            if (error==-1)
            {
                return;
            }
            txtOutput.Text=tinhtong.tongn(arr, n).ToString();
        }
        private int convertStringArraryToIntArrary(string[] inputArray, out int[] outPut1)
        {
            int n = inputArray.Length;
            int[] outPut = new int[n];
            try
            {
                for (int i = 0; i < n; i++)
                {
                    outPut[i] = int.Parse(inputArray[i]);
                }
                outPut1 = outPut;
                return 0;
            }
            catch (System.Exception ex)
            {
                outPut1 = null;
                return -1;
            }
            
           // Tinhtong_n_so tinhtong = new Tinhtong_n_so();
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}
    }
}
