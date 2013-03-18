using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMOI
{
    class Program
    {
        static void Main(string[] args)
        {
//             Sinhvien Quang = new Sinhvien();
//             Sinhvien Ngoc = new Sinhvien(1, "Nguyen Thi Ngoc", 8);
//             int iMasv = Ngoc.getMaSv();
//             Ngoc.setMaSV(2323);
            DsSv DL = new DsSv();
            //DL.ThemSV();
            Console.Write("so luong sV can nhap: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                DL.ThemSV();   
            }
            DL.hienThiList();
          //  DL.Suadiem();
           // DL.hienThiList();

//           //  Console.Write("Nhap ma sinh vien muon xoa: ");
//             int masv = int.Parse(Console.ReadLine());
//                 DL.deleteSv(masv);
//             Console.Write("Nhap ma sinh vien muon tim: ");
//             int masv = int.Parse(Console.ReadLine());
//             DL.searchSV(masv);
            //DL.hienThiList();
//             Console.Write("Nhap ho ten sinh vien muon tim: ");
//                         string hoten = Console.ReadLine();
//                          DL.searchSV(hoten);
            Console.WriteLine("nhap ma sv can tim :");
            int masv = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ho ten sinh vien muon tim: ");
            string hoten = Console.ReadLine();
            Sinhvien sv = new Sinhvien();
            sv.setMaSV(masv);
            sv.setHoten(hoten);
            DL.searchSV(sv);
            //DL.searchSV(hoten);
                         
            Console.ReadLine();
        }
    }
}
