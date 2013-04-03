using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaiBoi
{
    class Program
    {
        static void Main(string[] args)
        {
            congSo so = new congSo();
            so.nhapso();
            congChuoi chuoi = new congChuoi();
            chuoi.nhapchuoi();

        }
    }
}
