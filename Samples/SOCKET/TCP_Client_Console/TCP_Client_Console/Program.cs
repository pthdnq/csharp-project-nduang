using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCP_Client_Console
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpClient cl = new TcpClient();
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            cl.Connect(iep);
            Console.WriteLine("Connected to Server!!!");
            //NetworkStream ns = new NetworkStream();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            string st = sr.ReadLine();
            Console.WriteLine("Server:{0}",st);
            while (true)
            {
                //string st;
                Console.Write("Nhap du lieu gui len Server:");
                st = Console.ReadLine();
                sw.WriteLine(st);
                sw.Flush();
                if (st.ToUpper().Equals("QUIT"))
                    break;
                st = sr.ReadLine();
                Console.WriteLine("Data From Server:{0}", st);
            }
            sw.Close();
            sr.Close();
            cl.Close();
            //ns.Close();
        }
    }
}
