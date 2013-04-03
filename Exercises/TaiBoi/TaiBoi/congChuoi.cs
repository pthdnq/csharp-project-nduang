using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiBoi
{
    class congChuoi
    {
        private string xau;
        public String ghepChuoi(String a, String b)
        {
             String ghep = String.Concat(a, b);
             return ghep;
        }
        public void nhapchuoi()
        {
            Console.Write("nhap chuoi thu 1: ");
            String val1 = Convert.ToString(Console.ReadLine());
            Console.Write("nhap chuoi thu 2: ");
            String val2 = Convert.ToString(Console.ReadLine());
            xau = ghepChuoi(val1, val2);
            Console.Write("Chuoi la : \"" + xau + "\"");
            Console.ReadLine();

        }
    }
}
