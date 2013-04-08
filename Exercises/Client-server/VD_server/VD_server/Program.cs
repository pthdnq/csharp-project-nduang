using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace VD_server
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath Math = new MyMath();
            string strA_;
            int A;
            int B;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 9000);
            s.Bind(ie);
            s.Listen(10);
            Console.WriteLine("Waiting data from Client....");
            Socket sc = s.Accept();
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes("Chao Client");
            sc.Send(data, data.Length, SocketFlags.None);
            while (true)
            {
                string st;
                byte[] dl = new byte[1024];
                int k = sc.Receive(dl);
                st = Encoding.ASCII.GetString(dl, 0, k);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                Console.WriteLine("Du lieu tu Client:{0}", st);
                st = st.ToUpper();
                dl = new byte[1024];
                dl = Encoding.ASCII.GetBytes(st);
                sc.Send(dl, dl.Length, SocketFlags.None);
            }
            Math.Tachchuoi(strA_, out A, out B);
            sc.Close();
            s.Close();
        }
    }
}
