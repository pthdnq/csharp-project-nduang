using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApplication3;
namespace bai2_matran
{
    class Program
    {
        static void Main(string[] args)
        {
            int err=0;
            xuly_matran xl = new xuly_matran();
           // xl.NhapMT();
            int [,] MT;
            int m,n;
            int tong;
            Matrantruyxuattufile mtFile = new Matrantruyxuattufile();
            mtFile.ReadFile("matran.txt", out m,out n, out MT);
            int dem1;
            err=xl.demsoduong(out dem1,m,n,MT);
            Console.Write("so duong la : " + dem1);
            xl.tinhtongduong(m, n, MT, out tong);
            Console.Write("tong so duong la : " +tong );
            float GTTB=(float)tong/dem1;
            Console.Write("Gia tri tb cua cac so duong la : " + GTTB );
            Console.ReadLine();

        }
    }
}
