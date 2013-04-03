using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace napchong
{
    class Childern : Person
    {
        public void PrintChirlden(string strHo_ten)
        {
            //base.PrintPerson(strHo_ten);
            Console.Write("***************************");
            Console.ReadLine();
            Console.Write("******" + strHo_ten+"******");
            Console.ReadLine();
            Console.Write("***************************");
            Console.ReadLine();
            
        }
    }
}
