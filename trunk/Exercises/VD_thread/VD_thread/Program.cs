using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections;

namespace VD_thread
{
    class Program
    {
        //ArrayList list = new ArrayList();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MethodA));
            Thread t2 =new Thread(new ThreadStart(MethodB));
            t1.Start();
            t2.Start();
            //MethodB();
            Console.ReadLine();
        }
        static void MethodA()
        {
                StreamWriter wr = new StreamWriter("luuDL.txt");
                wr.Write("100-200-300");
                wr.Close();
               // Console.ReadLine();

        }
        static void MethodB()
        {
                StreamReader doc = new StreamReader("docDL.txt");
                 while (!doc.EndOfStream)
                 {
                     string docline = doc.ReadLine();
                     String[] XYZ = docline.Split('-');
                     int x = int.Parse(XYZ[0]);
                     int y = int.Parse(XYZ[1]);
                     int z = int.Parse(XYZ[2]);
                     Console.Write(x.ToString() + "-" + y.ToString() + "-" + z.ToString());
                }
                doc.Close();
                //Console.ReadLine(); 
        }
    }
}
