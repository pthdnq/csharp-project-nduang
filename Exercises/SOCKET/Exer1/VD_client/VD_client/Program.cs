using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace VD_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s=new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
            IPEndPoint ie=new IPEndPoint(IPAddress.Parse("127.0.0.1"),9000);
            s.Connect(ie);
            Console.WriteLine("Connected to Server.....");
            byte[] data=new byte[1024];
            int k=s.Receive(data);
            Console.WriteLine("Loi chao tu Server:{0}",Encoding.ASCII.GetString(data,0,k));
            while(true)
            {
                Console.WriteLine("Moi nhap du lieu can tinh");
                string st=Console.ReadLine();
                byte[] dl=new byte[1024];
                dl=Encoding.ASCII.GetBytes(st);
                s.Send(dl,dl.Length,SocketFlags.None);
                if(st.ToUpper().Equals("QUIT"))
                    break;
                dl=new byte[1024];
                int k1=s.Receive(dl);
                Console.WriteLine("Ket qua tinh tong tu server tra ve:{0}", Encoding.ASCII.GetString(dl, 0, k1));
            }
            s.Disconnect(true);
            s.Close();
        }
    }
}
