using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace XauKyTu_Client_Console
{
    class Client
    {
        static void Main(string[] args)
        {
            TcpClient cl = new TcpClient();
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            cl.Connect(iep);
            Console.WriteLine("Ket noi thanh cong den server");
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            while (true)
            {
                Console.Write("Nhap du lieu gui len Server:");
                string st = Console.ReadLine();
                if (st.ToUpper().Equals("QUIT"))
                    break;
                sw.WriteLine(st);
                sw.Flush();
                string sotu, chuoidao, chuanhoa;
                sotu = sr.ReadLine();
                chuoidao = sr.ReadLine();
                chuanhoa = sr.ReadLine();
                Console.WriteLine(sotu);
                Console.WriteLine(chuoidao);
                Console.WriteLine(chuanhoa);
            }
            sr.Close();
            sw.Close();
            cl.Close();
        }
    }
}
