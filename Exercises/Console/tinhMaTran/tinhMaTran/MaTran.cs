using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinhMaTran
{
    class MaTran
    {
        int m;
        int n;
        int iTongVtren = 0;
        int iTongVtrai = 0;
        int iTongVduoi = 0;
        int iTongVphai = 0;
        int iTongAll = 0;
        int [,] arr=new int[100,100];
        public void nhapMaTran()
        {
            Console.Write("nhap so hang: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("nhap so cot: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < m;i++ )
            {
                for (int j = 0; j < n;j++ )
                {
                    Console.Write("Nhap a[" + i + "][" + j + "] =");
                    arr[i, j] = int.Parse(Console.ReadLine());
                   // Console.Write(arr[i, j]);
                }
            }
        }
        public void tongDuongVienMaTran()
        {
            nhapMaTran();
            for (int j = 0; j <= n - 1; j++)
            {
                if (arr[0,j] > 0)
                {
                    iTongVtren = iTongVtren + arr[0,j];
                }
            }
            for (int i = 0; i <= m - 1;i++ )
            {
                if (arr[i,0]>0)
                {
                    iTongVtrai = iTongVtrai + arr[i, 0];
                }
            }
            for (int j = 0; j <= n - 1;j++ )
            {
                if (arr[m-1,j]>0)
                {
                    iTongVduoi = iTongVduoi + arr[m - 1, j];
                }
            }
            for (int i = 0; i <= m - 1;i++ )
            {
                if (arr[i,n-1]>0)
                {
                    iTongVphai = iTongVphai + arr[i, n - 1];
                }
            }
            iTongAll = iTongVtren + iTongVtrai + iTongVduoi + iTongVphai;
            Console.Write("\n Tong so duong vien tren = " + iTongVtren);
            Console.Write("\n Tong so duong vien trai = " + iTongVtrai);
            Console.Write("\n Tong so duong vien duoi = " + iTongVduoi);
            Console.Write("\n Tong so duong vien phai = " + iTongVphai);
            Console.Write("\n Tong cac so duong tren tat ca duong vien = " + iTongAll);
            Console.ReadKey();
        }
    }
}
