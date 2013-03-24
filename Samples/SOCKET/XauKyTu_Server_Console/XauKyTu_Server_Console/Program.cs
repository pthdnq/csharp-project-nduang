using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Globalization;

namespace XauKyTu_Server_Console
{
    class Server
    {
        static void Main(string[] args)
        {
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9000);
            TcpListener sv = new TcpListener(iep);
            sv.Start();
            Console.WriteLine("Cho ket noi tu lient...");
            int i = 1;
            while (true)
            {
                TcpClient cl = sv.AcceptTcpClient();
                Console.WriteLine("Client {0} da ket noi thanh cong", i);
                new ThreadClient(cl,i);
                i++;
            }
        }
    }
    class ThreadClient
    {
        TcpClient cl;
        int i;
        Thread tuyen;
        public ThreadClient(TcpClient cl, int i)
        {
            this.cl = cl;
            tuyen = new Thread(new ThreadStart(GuiNhanDL));
            tuyen.Start();
            this.i = i;
        }
        int DemSoTu(string s)
        {
            int dem = 1;
            s = s.Trim();
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == ' ' && s[i + 1] != ' ')
                    dem++;
            }
            return (dem);
        }
        void TachChuoi(string s)
        {
            string[] ArrayString = new string[DemSoTu(s)];
            ArrayString = s.Split(' ');
            for (int i = 0; i < ArrayString.Length; i++)
            {
                Console.WriteLine("\t{0}", ArrayString[i]);
            }
        }

        string ChuanHoaChuoi(string s)
        {
            s = s.Trim();
            s = s.ToLower();
            s = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(s);
            StringBuilder sb = new StringBuilder(); //nên dùng StringBuilder sẽ tối ưu hơn so với string  
            int i = 0;
            while (i < s.Length)
            {
                sb.Append(s[i]);
                if (s[i] == ' ')
                {
                    while (s[i] == ' ')
                        i++;
                }
                else
                    i++;
            }
            return sb.ToString();
        }
        string DaoChuoi(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }
            return sb.ToString();
        }
        void DaoNguocTu(string s)
        {
            string[] ArrayString = new string[DemSoTu(s)];
            ArrayString = s.Split(' ');
            for (int i = ArrayString.Length - 1; i >= 0; i--)
            {
                Console.Write("\t{0}", ArrayString[i]);
            }
        }
        void GuiNhanDL()
        {
            StreamReader sr = new StreamReader(cl.GetStream());
            StreamWriter sw = new StreamWriter(cl.GetStream());
            while(true)
            {
                string st=sr.ReadLine();
                if (st.ToUpper().Equals("QUIT"))
                    break;
                Console.Write("Data From Client {0}:", i);
                Console.WriteLine(st);
                int sotu = DemSoTu(st);
                string chuoidao = DaoChuoi(st);
                string chuanhoa = ChuanHoaChuoi(st);
                sw.WriteLine("So tu cua chuoi la:" + sotu.ToString());
                sw.Flush();
                sw.WriteLine("Chuoi dao la:" + chuoidao);
                sw.Flush();
                sw.WriteLine("Chuoi sau chuan hoa la:" + chuanhoa);
                sw.Flush();
            }
            sr.Close();
            sw.Close();
            cl.Close();
            tuyen.Abort();
            Console.WriteLine("Client {0} da ngat ket noi", i);
        }
    }
}
