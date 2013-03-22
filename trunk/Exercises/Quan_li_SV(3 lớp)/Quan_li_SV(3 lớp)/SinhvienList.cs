using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.IO;
namespace Quan_li_SV_3_lớp_
{
    class SinhvienList
    {
        ArrayList listSinhVien = new ArrayList();

        public void themSV(int masv, string ten, int diem)
        {
            Sinh_Vien SV_ = new Sinh_Vien();
            SV_.setMaSV(masv);
            SV_.setHoten(ten);
            SV_.setDiem(diem);
            listSinhVien.Add(SV_);
        }
        public void xoaDL()
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                listSinhVien.RemoveAt(i);
            }

        }
        public void suaDL(string tenmoi, int diemmoi)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                sv.setHoten(tenmoi);
                sv.setDiem(diemmoi);
                listSinhVien[i] = sv;
            }
        }
     
        public void timSV(int masv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                if (sv.getMaSV() == masv)
                {

                }
            }

        }
        public void timSV(string tensv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                if (sv.getHoten() == tensv)
                {

                }
            }
        }
        public void timSV(int masv, string tensv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                if (sv.getMaSV() == masv && sv.getHoten() == tensv)
                {
                    
                }
            }
        }
        public void readFile()
        {
            Stream s = File.OpenRead("node.txt");
            StreamReader st = new StreamReader(s);
            string str = st.ReadLine();
        }
        public void luuDL()
        {
            StreamWriter sw = new StreamWriter("Du lieu.txt", false);
             for ( int i=0; i < listSinhVien.Count ; i ++)
            {
                sw.WriteLine(listSinhVien[0].ToString() + " " + listSinhVien[1].ToString() + " " + listSinhVien[2].ToString());
                 
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
        public void docDL()
        {
            StreamReader line = new StreamReader("Du lieu.txt");
            while (!line.EndOfStream)
            {
                string docline = line.ReadLine();
                String[] cat = docline.Split(' ');
                listSinhVien.Add(cat[0]);
                listSinhVien.Add(cat[1]);
                listSinhVien.Add(cat[2]);
            }

            line.Close();
        }
    }
}
