using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VD_server
{
    class MyMath
    {
        public float TinhTong(float a, float b)
        {
            float Tong = a + b;
            return Tong;
        }
        public void Tachchuoi(string strA,out int A,out int B)
        {
            string[] cat = strA.Split('-');
            A = int.Parse(cat[0]);
            B = int.Parse(cat[1]);
        }
    }
}
