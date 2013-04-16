using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_two
{
    class Du_Lieu
    {
        public void ShowDL()
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            arr[0] = "*";
            Console.WriteLine(arr[0]);
            for (int i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + "*";
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
