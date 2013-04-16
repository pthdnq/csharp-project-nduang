using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printTongSoNguyenTo
{
    class Print
    {
        public bool isNguyenTo(int n)
        {
            for (int i = 2; i < n;i++ )
            {
                if (n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public void printTongSoNguyenTo_()
        {
            int iTong = 0;
            Console.Write("Nhap n=");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n;i++ )
            {
                bool bOK = false;
                bOK = isNguyenTo(i);
                if (bOK == true)
                {
                    if (i==1)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("-");
                        Console.Write(i);
                    }
                }
                iTong = iTong + i;

            }
            Console.Write("\n");
            Console.Write(iTong);
            Console.ReadKey();
        }
    }
}
