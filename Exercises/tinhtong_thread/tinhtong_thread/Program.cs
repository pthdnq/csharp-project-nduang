using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tinhtong_thread
{
    class Program
    {
//         int m_TongChan = 0;
//         int m_TongLe = 0;
        static int[] niz = new int[100000];
        static void Main(string[] args)

        {
            Thread t1 = new Thread(new ThreadStart(tongChan));
            Thread t2 = new Thread(new ThreadStart(tongLe));
            //Console.Write("Nhap N= ");
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        static public void TaoMangSoNgauNhien(int[] niz)
        {
            for (int i = 0; i < 100000; i++)
            {
                Random m = new Random();
                int ZOMG = m.Next(0, 100000);
                niz[i] = ZOMG;
               // Console.Write(niz[i]);//in ra man hinh xem thu
            }
        }
        static public void tongChan()
        {
            TaoMangSoNgauNhien(niz);
            int iTongChan = 0;
            for (int i = 0; i < 100000; i++)
            {
                if (niz[i] % 2 == 0)//phan tu thu i trong mang chia het cho 2
                {
                    iTongChan = iTongChan + niz[i];//dua gia tri cua phan tu do vao tong chan
                }
            }
            Console.WriteLine("Tong chan la" + iTongChan);
        }
        static public void tongLe()
        {
            TaoMangSoNgauNhien(niz);
            int iTongChan = 0;
            for (int i = 0; i < 100000; i++)
            {
                if (niz[i] % 2 != 0)//phan tu thu i trong mang chia het cho 2
                {
                    iTongChan = iTongChan + niz[i];//dua gia tri cua phan tu do vao tong chan
                }
            }
            Console.WriteLine("Tong le la" + iTongChan);
        }
       
    }
}
