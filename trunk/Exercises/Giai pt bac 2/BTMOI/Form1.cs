using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTMOI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = txta.Text;
            string b = txtb.Text;
            string c = txtc.Text;
            
            //float x;
            //float a1 = float.Parse(a);
            //float b1 = float.Parse(b);
            //float c1 = float.Parse(c);
            
            //float delta = (b1*b1-4*a1*c1);
            //if (delta < 0)
            //{
            //    txtKQ.Text = "vo nghiem";
            //}
            //if (delta==0)
            //{
            //    x = -b1/(2*a1);
            //    txtKQ.Text = x.ToString();
            //}
            //if (delta > 0)
            //{
            //    float x1;
            //    float x2;
            //    string strDelta = delta.ToString();
            //    Double tmp = Double.Parse(strDelta);
            //    x1 = (-b1 - float.Parse(Math.Sqrt(tmp).ToString()) / (2 * a1));
            //    x2 = (-b1 + float.Parse(Math.Sqrt(tmp).ToString()) / (2 * a1));

            //txtKQ.Text = x1.ToString()+";"+x2.ToString();

            //    //String.Format("{0:0.00}", x1.ToString());
            //    //String.Format("{0:0.00}", x2.ToString());
            //    txtKQ.Text = String.Format("{0:00.0}", x1.ToString()) + ";" + String.Format("{0:00.0}", x2.ToString());
               
            //}
            float x;
            float a1 = float.Parse(a);
            float b1 = float.Parse(b);
            float c1 = float.Parse(c);
            double delta = (b1*b1-4*a1*c1);
            if (delta < 0)
            {
                //deltaAm();
                txtKQ.Text = deltaAm();
            }
            if (delta == 0)
            {
                txtKQ.Text = delta0(a1, b1);
            }
            if (delta >0)

            {
                txtKQ.Text= delta1(delta,a1,b1);
            }
            
        
                

   
        }
        private string deltaAm()
        {
            return "vo nghiem";
        }
        private string delta0(float a1,float b1)
        {
             double x = -b1 / (2 * a1);
             return x.ToString();

 
        }
        private string delta1(double delta, float a1, float b1)
        {
            double x1 = (-b1 - (Math.Sqrt(delta)) / (2 * a1));
            double x2 = (-b1 + (Math.Sqrt(delta)) / (2 * a1));
            string kq= x1.ToString()+";"+x2.ToString();//noi x1+x2
            return kq;
        }

    }
}
