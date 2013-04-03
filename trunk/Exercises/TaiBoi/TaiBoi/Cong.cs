using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiBoi
{
    class Cong
    {
        private string xau;
        private int tongso;
        public String congVao(String a, String b)
        {
            String ghep = String.Concat(a, b);
            return ghep;
        }
        public int congVao(int a, int b)
        {
            int tong = a + b;
            return tong;
        }
        public void nhapChuoi()
        {
            Console.Write("nhap chuoi thu 1: ");
            String val1 = Convert.ToString(Console.ReadLine());
            Console.Write("nhap chuoi thu 2: ");
            String val2 = Convert.ToString(Console.ReadLine());
            xau = congVao(val1, val2);
            Console.Write("Chuoi la : \"" + xau + "\"");
            Console.ReadLine();


        }
        public void nhapSo()
        {
            Console.Write("nhap so thu 1:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu 2:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            tongso = congVao(val1, val2);
            Console.Write("tong la : " + tongso);
            Console.ReadLine();
        }
    }
}
