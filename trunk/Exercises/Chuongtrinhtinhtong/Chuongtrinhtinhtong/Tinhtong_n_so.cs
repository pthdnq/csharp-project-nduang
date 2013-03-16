using System;
using System.Collections.Generic;
using System.Text;



namespace Tinh_tong_n_so
{
    class Tinhtong_n_so
    {
        int n;
        int[] arr;
        int tongla;
        public void nhapn()
        {
            Console.Write("Nhap so phan tu cua mang N= ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n]; 
            for (int i = 0; i < n; i++)
            {
                Console.Write("Number {0}= ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine();
           // Console.ReadLine();
            tongla = tongn(arr, n);

        }
        public int tongn(int[] arr,int n)
        {
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                tong = tong + arr[i];
            }
            return tong;

        }
        public void hienthi()
        {
            Console.Write("Tong la : " + tongla);
            Console.ReadLine();
        }
            
    }
}
