using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace BT3_Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            string st = "Chao Server";
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes(st);
            s.SendTo(data, iep);
            EndPoint remote=(EndPoint)iep;
            data = new byte[1024];
            int k=s.ReceiveFrom(data,ref remote);
            Console.WriteLine("Loi chao tu Server:{0}", Encoding.ASCII.GetString(data, 0, k));
            while (true)
            {
                Console.Write("Nhap du lieu gui len Server:");
                string st1 = Console.ReadLine();
                byte[] dl = new byte[1024];
                dl = Encoding.ASCII.GetBytes(st1);
                s.SendTo(dl, remote);
                if (st1.ToUpper().Equals("QUIT"))
                    break;
                dl = new byte[1024];
                int k1=s.ReceiveFrom(dl, ref remote);
                Console.WriteLine("Du lieu tu Server la:{0}", Encoding.ASCII.GetString(dl, 0, k1));
            }
            s.Close();
        }
    }
}