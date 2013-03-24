using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace XuLyXau_Client
{
    class Client
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            s.Connect(iep);
            Console.Write("Connected to Server!");
            byte[] data = new byte[1024];
            int k = s.Receive(data);
            Console.WriteLine("Server:{0}", Encoding.ASCII.GetString(data, 0, k));
            while (true)
            {
                Console.Write("Nhap xau can chuan hoa:");
                string st = Console.ReadLine();
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(st);
                s.Send(data, data.Length, SocketFlags.None);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                data = new byte[1024];
                k = s.Receive(data);
                Console.WriteLine("Data From Server:{0}", Encoding.ASCII.GetString(data, 0, k));
            }
            s.Close();
        }
    }
}
