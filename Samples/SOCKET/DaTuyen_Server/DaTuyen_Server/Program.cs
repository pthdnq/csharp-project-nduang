using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace DaTuyen_Server
{
    class Server
    {
       public static Socket s;
        static void Main(string[] args)
        {
            s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            s.Bind(iep);
            s.Listen(20);
            Console.WriteLine("Dang choi ket noi tu Client...");
            int i = 1;
            while (true)
            {
                Socket sc = s.Accept();
                Console.WriteLine("Client {0} da ket noi thanh cong!!!", i);
                new ClientThread(sc);
                i++;

            }
        }
    }
    class ClientThread
    {
        Socket sc;
        public ClientThread(Socket sc)
        {
            this.sc = sc;
            //Console.WriteLine("Client {0} da ket noi thanh cong", i);
            Thread t = new Thread(new ThreadStart(GuiNhanDL));
            t.Start();
        }
        void GuiNhanDL()
        {
            NetworkStream ns = new NetworkStream(sc);
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine("Chao CLient ket noi");
            sw.Flush();
            while (true)
            {
                string st;
                st = sr.ReadLine();
                Console.WriteLine("Du lieu tu Client la:{0}", st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                st = st.ToUpper();
                sw.WriteLine(st);
                sw.Flush();
            }
            sr.Close();
            sw.Close();
            ns.Close();
            sc.Close();
            //Server.s.Close();
        }
    }
}