using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiBoi
{
    class congSo
    {
        private int tongso;
        public int cong(int a, int b)
        {
           int tong = a + b;
            return tong;
        }
        public void nhapso()
        {
            Console.Write("nhap so thu 1:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap so thu 2:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            tongso = cong(val1,val2);
            Console.Write("tong la : " + tongso);
            Console.ReadLine();

        }
    }
}
