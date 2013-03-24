using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace BT2_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            s.Bind(iep);
            s.Listen(10);
            Console.WriteLine("Waiting Client...");
            Socket sc = s.Accept();
            NetworkStream ns = new NetworkStream(sc);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine("Chao Client");
            sw.Flush();
            while (true)
            {
                string st;
                st = sr.ReadLine();
                Console.WriteLine("Client gui len:{0}",st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                st = st.ToUpper();
                sw.WriteLine(st);
                sw.Flush();
            }
            sw.Close();
            sr.Close();
            ns.Close();
            sc.Close();
            s.Close();
        }
    }
}
