using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Globalization;

namespace XulyXau_Server
{
    class Server
    {
        static string ChuanHoaXau(string str)
        {
            str = str.Trim();
            str = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            StringBuilder sb = new StringBuilder();
            int i=0;
            while(i<str.Length)
            {
                sb.Append(str[i]);
                if (str[i] == ' ')
                    while (str[i] == ' ')
                    {
                        i++;
                    }
                else i++;
            }
            return sb.ToString();  
        }
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            s.Bind(iep);
            s.Listen(10);
            Console.WriteLine("Waiting Request from CLient...");
            Socket sc = s.Accept();
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes("Wellcom CLient!");
            sc.Send(data, data.Length, SocketFlags.None);
            while (true)
            {
                string st;
                data=new byte[1024];
                int k = sc.Receive(data);
                st = Encoding.ASCII.GetString(data, 0, k);
                Console.WriteLine("Data From CLient:{0}", st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                string st1 =Server.ChuanHoaXau(st);
                data = new byte[1024];
                data = Encoding.ASCII.GetBytes(st1);
                sc.Send(data, data.Length, SocketFlags.None);
            }
            sc.Close();
            s.Close();
        }
    }
}
