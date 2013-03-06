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
   
            string chuso = txtThu.Text;
            byte so = byte.Parse(chuso);
          
            switch (so)
            {
                
                case 2:
                    chuso.ToString("thứ hai");
                    break;
                case 3:
                    chuso.ToString(@"thứ ba");
                    break;
                case 4:
                    chuso.ToString(@"thứ tư");
                    break;
                case 5:
                    chuso.ToString(@"thứ 5");
                    break;
                case 6:
                    chuso.ToString(@"thứ 6");
                    break;
                case 7:
                    chuso.ToString(@"thứ 7");
                    break;
                case 8:
                    chuso.ToString(@"chủ nhật");
                    break;
                default:
                    chuso.ToString(@"ko có thứ");
                    break;
            }
          
            }
	
        }
    }



        }
    }
}
