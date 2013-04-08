using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VD_server
{
    class MyMath
    {
        static float TinhTong(float a, float b)
        {
            float Tong = a + b;
            return Tong;
            Console.Write("Tong la:" + Tong);
            Console.ReadLine();
        }
        static int Tachchuoi(string strA,out int A,out int B)
        {
            strA = "quang-nhung";
            string[] cat = strA.Split('-');
            A = int.Parse(cat[0]);
            B = int.Parse(cat[1]);
            return A;
            return B;
        }
    }
}
