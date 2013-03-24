using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace BT3_Server
{
    class Server
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            s.Bind(iep);
            EndPoint remote = (EndPoint)iep;
            byte[] data = new byte[1024];
            int k = s.ReceiveFrom(data, ref remote);
            Console.WriteLine("Loi chao tu Client:{0}",Encoding.ASCII.GetString(data,0,k));
            data = new byte[1024];
            data = Encoding.ASCII.GetBytes("Chao Client ket noi");
            s.SendTo(data, remote);
            while (true)
            {
                data = new byte[1024];
                string st;
                k=s.ReceiveFrom(data, ref remote);
                st = Encoding.ASCII.GetString(data, 0, k);
                Console.WriteLine("Du lieu tu Client Gui la:{0}", st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                st = st.ToUpper();
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(st);
                s.SendTo(data, remote);
            }
            s.Close();
        }
    }
}
