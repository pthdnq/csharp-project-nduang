using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_three
{
    class Du_lieu
    {
        public void ShowDL()
        {
            Console.Write("Nhap n=");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n+1];
            arr[0] = 1;
            string gep = "";
            Console.WriteLine(arr[0]);
            for (int i = 1; i < n;i++ )
            {
                 gep = string.Concat(arr[0], "-", arr[n-1]);
                
            }
            Console.WriteLine(gep);
            Console.ReadLine();
        }
    }
}
