using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCP_Listener_Console
{
    class Server
    {
        static void Main(string[] args)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            TcpListener sv = new TcpListener(iep);
            sv.Start();
            TcpClient cl = sv.AcceptTcpClient();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            sw.WriteLine("Chao Client da ket noi");
            sw.Flush();
            while (true)
            {
                string st = sr.ReadLine();
                Console.WriteLine("Du lieu tu Client:{0}", st);
                if (st.ToUpper().Equals("QUIT"))
                    break;
                st = st.ToUpper();
                sw.WriteLine(st);
                sw.Flush();
            }
            sw.Close();
            sr.Close();
            cl.Close();
        }
    }
}
