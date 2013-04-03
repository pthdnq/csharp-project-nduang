using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dientich_kethua
{
    class Program
    {
        static void Main(string[] args)
        {
            Hinhtron htron = new Hinhtron();
            htron.hienThi();
            Hinhtru htru = new Hinhtru();
            htru.htHT();
        }
    }
    class Hinhtron
    {
        double r;
        double p;
        double dt;
        public double dtHinhtron(double r)
        {
            double p = 3.14;
            double s = p * r * r;
            return s;
        }
        public void hienThi()
        {
            Console.Write("Nhap Ban kinh : ");
            double val1 = Convert.ToInt32(Console.ReadLine());
            dt = dtHinhtron(val1);
            Console.Write("dientich : " + dt);
            Console.ReadLine();
        }
    }
    class Hinhtru : Hinhtron
    {
        private float h;
        private double thetich;
        
        public double dtHinhtru(double r,double h)
        {

            double ttht = base.dtHinhtron(r) * h;
            return ttht;
          
        }
        public void htHT()
        {
            Console.Write("Nhap Ban kinh : ");
            double val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chieu cao : ");
            double val2 = Convert.ToInt32(Console.ReadLine());
            thetich = dtHinhtru(val1, val2);
            Console.Write("the tich : " + thetich);
            Console.ReadLine();
        }


        }
    }

