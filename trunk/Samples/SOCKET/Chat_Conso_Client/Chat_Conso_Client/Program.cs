using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Chat_Conso_Client
{
    class Server
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            s.Connect(iep);
            new ClientThread(s);
            Console.WriteLine("Connected to Server!!!");
        }
    }
    class ClientThread
    {
        Socket s;
        public ClientThread(Socket s)
        {
            this.s = s;
            Thread gui = new Thread(new ThreadStart(GuiDL));
            gui.Start();
            Thread nhan = new Thread(new ThreadStart(NhanDL));
            nhan.Start();
        }
        void GuiDL()
        {
            NetworkStream ns = new NetworkStream(s);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                //Console.Write("Client:");
                string st = Console.ReadLine();
                sw.WriteLine(st);
                sw.Flush();
                if (st.ToUpper().Equals("QUIT"))
                {
                    Console.WriteLine("Ban da ngat ket noi voi Server Chat");
                    break;
                }
            }
            sw.Close();
            ns.Close();
        }
        void NhanDL()
        {
            NetworkStream ns = new NetworkStream(s);
            StreamReader sr = new StreamReader(ns);
            while (true)
            {
                string st = sr.ReadLine();
                //Console.Write("Server:");
                Console.WriteLine(st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
            }
            sr.Close();
            ns.Close();
        }
    }
}
