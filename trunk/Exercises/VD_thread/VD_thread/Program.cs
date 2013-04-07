using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace VD_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(MethodA));
            t.Start();
            MethodB();
        }
        static void MethodA()
        {
            StreamWriter wr = new StreamWriter("Text.txt");
            wr.Write("100-200-300");
            wr.Close();
            Console.ReadLine();
            
        }
        static void MethodB()
        {
            StreamReader doc = new StreamReader("Text.txt");
            
            string docline = doc.ReadLine();
            String[] XYZ = docline.Split('-');
            int X = int.Parse(XYZ[0]);
            int Y = int.Parse(XYZ[1]);
            int Z = int.Parse(XYZ[2]);
            doc.Close();
            Console.ReadLine(); 

        }
    }
}
