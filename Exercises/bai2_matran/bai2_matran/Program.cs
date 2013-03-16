using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bai2_matran
{
    class Program
    {
        static void Main(string[] args)
        {
            int err=0;
            xuly_matran xl = new xuly_matran();
            xl.NhapMT();
            int dem1;
            err=xl.demsoduong(out dem1);
            Console.Write("so duong la : " + dem1);
            Console.ReadLine();
            

        }
    }
}
