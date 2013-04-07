using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        int m_TongChan = 0;
        int m_TongLe = 0;
        int[] niz;
        public void TaoMangSoNgauNhien()
        {
               niz = new int[100000];
               //int [] niz = new int[100000];
               for (int i = 0; i < 100; i++) 
               { 
                    Random m = new Random();
                    int ZOMG = m.Next(0,100000);
                    niz[i] = ZOMG;
                    Console.Write(niz[i]);//in ra man hinh xem thu
                }
        }
        public void tongChan()
        {
            int iTongChan=0;
            for (int i = 0; i < 100000;i++ )
            {
                if(niz[i]%2==0)//phan tu thu i trong mang chia het cho 2
                {
                    iTongChan = iTongChan + niz[i];//dua gia tri cua phan tu do vao tong chan
                }
            }
            Console.WriteLine("Tong chan la" + iTongChan);
        }
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}
