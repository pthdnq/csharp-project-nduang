using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace BT2_Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep=new IPEndPoint(IPAddress.Parse("127.0.0.1"),9000);
            s.Connect(iep);
            Console.WriteLine("Connected to Server...");
            NetworkStream ns=new NetworkStream(s);
            StreamReader sr=new StreamReader(ns);
            StreamWriter sw=new StreamWriter(ns);
            Console.WriteLine("Data From Server:{0}",sr.ReadLine());
            while(true)
            {
                string st;
                Console.Write("Nhap du  lieu gui len Server:");
                st=Console.ReadLine();
                sw.WriteLine(st);
                sw.Flush();
                if (st.ToUpper().Equals("QUIT"))
                    break;
                Console.WriteLine("Du lieu tu Server la:{0}",sr.ReadLine());
            }
            sr.Close();
            sw.Close();
            ns.Close();
            s.Close();
        }
    }
}
