using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tính_tổng;

namespace Tính_tổng
{
    class Program
    {
        static void Main(string[] args)
        {
            tinhtong tt = new tinhtong();//khoi tao doi tuong cua class tinh tong de su dung duoc cac ham cua
            //class nay nhu ham nhapDl, hienthi....
            tt.nhapDL();//ham nhap du lieu se goi ham tinhtong va cho ra ket qua
            tt.hienThi();//hien thi keet qua tinh toan len man hinh
            

        }
    }
}
