using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Chat_Conso_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint iep=new IPEndPoint(IPAddress.Any,9000);
            s.Bind(iep);
            Console.WriteLine("Dang cho ket noi tu Client...");
            s.Listen(10);
            int i = 0;
            while(true)
            {
                i++;
                Socket sc=s.Accept();
                Console.WriteLine("Client {0} da ket noi",i);
                new ClientThread(sc,i);
            }
        }
    }
    class ClientThread
    {
        Socket sc;
        int i;
        public ClientThread(Socket sc,int i)
        {
            this.sc = sc;
            this.i = i;
            Thread gui = new Thread(new ThreadStart(GuiDL));
            gui.Start();
            Thread nhan = new Thread(new ThreadStart(NhanDL));
            nhan.Start();
        }
        void GuiDL()
        {
            NetworkStream ns = new NetworkStream(sc);
            StreamWriter sw = new StreamWriter(ns);
            while (true)
            {
                string st = Console.ReadLine();
                sw.WriteLine("From Server:"+st);
                sw.Flush();
                if (st.ToUpper().Equals("QUIT"))
                    break;
            }
            Console.WriteLine("Ket Thuc Phien Gui DL toi CLient {0}", i);
        }
        void NhanDL()
        {
            NetworkStream ns = new NetworkStream(sc);
            StreamReader sr = new StreamReader(ns);
            while (true)
            {
                string st = sr.ReadLine();
                Console.Write("From CLient {0}:", i);
                Console.WriteLine(st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
            }
            Console.WriteLine("Ket thuc phien Nhan DL tu CLient {0}", i);
        }
    }
}
