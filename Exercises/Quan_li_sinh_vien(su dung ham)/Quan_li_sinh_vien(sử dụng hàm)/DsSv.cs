using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BTMOI
{
    class DsSv
    {

        public void ThemSV()
        {
            Sinhvien SV_ = new Sinhvien();
            Console.Write("Nhap ma sinh vien: ");
            int masv = int.Parse(Console.ReadLine());
            SV_.setMaSV(masv);
            Console.Write("Nhap ho ten sinh vien: ");
            string hoten = Console.ReadLine();
            SV_.setHoten(hoten);
            Console.Write("Nhap diem cua sinh vien: ");
            int diem = int.Parse(Console.ReadLine());
            SV_.setDiem(diem);
           // listSinhVien.Add(SV_);
        }
        public void Suadiem()
        {
            Console.Write("Nhap ma sinh vien muon sua diem: ");
            int masv = int.Parse(Console.ReadLine());
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv = (Sinhvien)listSinhVien[i];
                if (sv.getMaSv() == masv)
                {
                    Console.Write("Nhap diem moi: ");
                    int diem_moi = int.Parse(Console.ReadLine());
                    sv.setDiem(diem_moi);
                    listSinhVien[i] = sv;
                    break;
                }
                //if ()
                //{
                //}
            }

        }
        public void hienThiSV(Sinhvien sv)
        {
            //Console.WriteLine("MSV   Hoten     Diem    ");
            Console.WriteLine(sv.getMaSv() + "     " + sv.getHoten() + "    " + sv.getDiem());

        }
        public void hienThiList()
        {
            Console.WriteLine("MSV   Hoten     Diem    ");
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv = (Sinhvien)listSinhVien[i];
                hienThiSV(sv);
            }
        }
        public void deleteSv(int masv)
        {
            //Console.Write("Nhap ma sinh vien muon xoa: ");
            // int masv = int.Parse(Console.ReadLine());
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv = (Sinhvien)listSinhVien[i];
                if (sv.getMaSv() == masv)
                {
                    listSinhVien.RemoveAt(i);
                }
            }
        }
        public void searchSV(int masv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv = (Sinhvien)listSinhVien[i];
                if (sv.getMaSv() == masv)
                {
                    hienThiSV(sv);
                    break;
                }
            }
        }
        public void searchSV(string hoten)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinhvien sv = new Sinhvien();
                sv = (Sinhvien)listSinhVien[i];
                if (sv.getHoten() == hoten)
                {
                    hienThiSV(sv);
                }
            }
          
        }
        public void searchSV(Sinhvien sv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
              //  Sinhvien sv = new Sinhvien();
                Sinhvien sv2_trong_list = (Sinhvien)listSinhVien[i];
                if (sv.getHoten() == sv2_trong_list.getHoten() && sv.getMaSv()==sv2_trong_list.getMaSv() )
                {
                    hienThiSV(sv2_trong_list);
                    break;
                }
            }
        }
        ArrayList listSinhVien = new ArrayList();
    }
}
