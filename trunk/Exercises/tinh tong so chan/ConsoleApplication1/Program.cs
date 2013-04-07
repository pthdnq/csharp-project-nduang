using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
             static void tinhtong()
        {
            Console.Write("Nhap N= ");
            int n=int.Parse(Console.ReadLine());

            Console.Write("Cac so chan: ");

            int tong = 0;
            for (int i = 2; i <= n;i++ )
            {
                if (i%2==0)
                {
                    Console.Write("{0}   ", i); 
                    tong=tong+i;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Tong cac so chan: {0}", tong);
        }
        static void Main(string[] args)
        {
            tinhtong();
            Console.ReadLine();
        }
        }
    }
