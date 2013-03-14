using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class hinhtron
    {
        public double Chuvi(double r)
        {
            double p = 3.14;
            double cv = 2 * p * r;
            return cv;

        }
        public double dientich(double r)
        {
            double p = 3.14;
            double s = p * r * r;
            return s;
        }
        public void nhapR()
        {
            Console.Write("Nhap Ban kinh : ");
            double val1 = Convert.ToInt32(Console.ReadLine());
           chuv=Chuvi(val1);
            dt=dientich(val1);
        }
        public void hienThi()
        {
            Console.Write("chu vi : " + chuv);
            Console.ReadLine();
            Console.Write("dientich : " +dt);
            Console.ReadLine();
        }
        double chuv;
        double dt;
    }
}
