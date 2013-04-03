using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace napchong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho ten: ");
            String str = Convert.ToString(Console.ReadLine());
            //Person p = new Person();
            //p.PrintPerson(str);
            Childern c = new Childern();
            c.PrintChirlden(str);
        }
    }
}
