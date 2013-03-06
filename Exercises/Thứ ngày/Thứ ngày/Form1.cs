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

            string chuso = txtSo.Text;
            try 
            {
                byte so = byte.Parse(chuso);
                switch (so)
                {

                    case 2:
                        txtThu.Text = "thứ hai";
                        break;
                    case 3:
                        txtThu.Text = "thứ ba";
                        break;
                    case 4:
                        txtThu.Text = "thứ tư";
                        break;
                    case 5:
                        txtThu.Text = "thứ năm";
                        break;
                    case 6:
                        txtThu.Text = "thứ sáu";
                        break;
                    case 7:
                        txtThu.Text = "thứ bẩy";
                        break;
                    case 8:
                        txtThu.Text = "chủ nhật";
                        break;
                    default:
                        txtThu.Text = "không có thứ";
                        break;
                }

            }
            catch (System.Exception ex)
            {

            }
            

            
        }

    }
}



  
    

