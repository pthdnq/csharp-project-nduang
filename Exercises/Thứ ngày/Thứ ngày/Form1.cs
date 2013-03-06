using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Thứ_ngày
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void txtSo_TextChanged(object sender, EventArgs e)
        {
           
            byte so;
            Console.Write("nhập số của thứ");
            so = byte.Parse(Console.ReadLine());
            switch (so)
            {
                case 2:
                    Console.Write(@"tthứ hai");
                    break;
                case 3:
                    Console.Write(@"thứ ba");
                    break;
                case 4:
                    Console.Write(@"thứ tư");
                    break;
                case 5:
                    Console.Write(@"thứ 5");
                    break;
                case 6:
                    Console.Write(@"thứ 6");
                    break;
                case 7:
                    Console.Write(@"thứ 7");
                    break;
                case 8:
                    Console.Write(@"chủ nhật");
                    break;
                default:
                    Console.Write(@"ko có thứ");
                    break;
            }
            Console.ReadLine();
            }
	
        }
    }

