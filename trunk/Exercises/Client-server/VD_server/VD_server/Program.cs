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
            //string strA_;
//             int A;
//             int B;
            float fA;
            float fB;
            float fTong;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//giao tieo socket
            IPEndPoint ie = new IPEndPoint(IPAddress.Any, 9000);// dia chi bat ky, cong server nghe la 9000
            s.Bind(ie);// gan dia chi truy cap vao socket
            s.Listen(10);//so cong nghe
            Console.WriteLine("Waiting data from Client....");
            Socket sc = s.Accept();// socket bat chap nhap ket noi
            byte[] data = new byte[1024];
            data = Encoding.ASCII.GetBytes("Chao Client");// gui cau chao client dang ma byte cho client
            sc.Send(data, data.Length, SocketFlags.None);// gui du lieu
            while (true)
            {
                string st;
                byte[] dl = new byte[1024];
                int k = sc.Receive(dl);// du lieu nhan ve tu client dang mang byte
                st = Encoding.ASCII.GetString(dl, 0, k);// chuyen thanh chuoi

                if (st.ToUpper().Equals("QUIT"))//kiem tra xem chuoi la tu QUIT thi thoat
                    break;
                Console.WriteLine("Du lieu tu Client:{0}", st);//In chuoi server nhan duoc tu client
                //st = st.ToUpper();
                dl = new byte[1024];
                
                
                Math.Tachchuoi(st, out fA, out fB);// tach chuoi nhan duoc de lay ra 2 so
                fTong = Math.TinhTong(fA, fB);//tinh tong 2 so
                string strTong = fTong.ToString();//chuyen tong thanh chuoi
                dl = Encoding.ASCII.GetBytes(strTong);//chuyen chuoi sang mang byte
                sc.Send(dl, dl.Length, SocketFlags.None);//gui du lieu cho client

            }
            
            sc.Close();
            s.Close();
        }
    }
}
