using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
//using System.Math;

namespace MayTinh_Server
{
    class Server
    {
        static float Tinh(string s)
        {
            string[] mang = s.Split(' ');
            float kq=0;
            if (mang.Length == 3)
            {
                switch (mang[1])
                {
                    case "+": kq = (float)int.Parse(mang[0]) + int.Parse(mang[2]);
                        break;
                    case "-": kq = (float)int.Parse(mang[0]) - int.Parse(mang[2]);
                        break;
                    case "*": kq = (float)int.Parse(mang[0]) * int.Parse(mang[2]);
                        break;
                    case "/": kq = (float)int.Parse(mang[0]) / int.Parse(mang[2]);
                        break;

                }
                return kq;
            }
            else
            {
                if (mang.Length == 2)
                {
                    switch (mang[0])
                    {
                        case "Sin": kq = (float)Math.Sin(int.Parse(mang[1]));
                            break;
                        case "Cos": kq = (float)Math.Cos(int.Parse(mang[1]));
                            break;
                        case "Tan": kq = (float)Math.Tan(int.Parse(mang[1]));
                            break;
                        case "SQRT": kq = (float)Math.Sqrt(int.Parse(mang[1]));
                            break;
                        case "QRT": kq = (float)Math.Pow(int.Parse(mang[1]), 2);
                            break;
                        case "Log": kq = (float)Math.Log10(int.Parse(mang[1]));
                            break;
                    }
                    return kq;
                }
                else
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            TcpListener sv = new TcpListener(iep);
            sv.Start();
            TcpClient cl = sv.AcceptTcpClient();
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            while (true)
            {
                string st = sr.ReadLine();
                if (st.ToUpper().Equals("QUIT"))
                    break;
                float kq1=Tinh(st);
                sw.WriteLine(kq1.ToString());
                sw.Flush();
            }
            sr.Close();
            sw.Close();
            cl.Close();
        }
    }
}
