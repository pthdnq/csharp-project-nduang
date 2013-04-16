using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printNumber
{
    class Print
    {
        public void printRow(int n)
        {
            for (int i = 1; i <= n;i++ )
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
        }
        public void printNumber_()
        {
            Console.Write("Nhap n =");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n;i++ )
            {
                printRow(i);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
