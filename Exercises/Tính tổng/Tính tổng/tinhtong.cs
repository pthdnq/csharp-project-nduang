using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tính_tổng
{
    class tinhtong
    {
        public float getTong( float a, float b)
        {
            float kq = a + b;
            return kq;
        }
        public void nhapDL()
        {
             // output to the console
                     Console.Write("Please enter value 1 : ");
                     // readin the console input, and then convert to a integer value
                     int val1 = Convert.ToInt32(Console.ReadLine());
                     Console.Write("Please enter value 2 : ");
                     int val2 = Convert.ToInt32(Console.ReadLine());
            // write out the answer 
                     tong=getTong(val1, val2);
            
        }
        public void hienThi()
        {
            Console.Write("Tong la : "+tong);
            Console.ReadLine();//dung man hinh xem ket qua
        }
        float tong;
    }
}
