using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printStrar
{
    class Print
    {
        
        public void printRow(int n)
        {
            for (int i = 0; i < n;i++ )
            {
                Console.Write("*");
            }
        }
        public void printStar_()
        {
            Console.Write("nhap n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <=n;i++ )
            {
                printRow(i);
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
