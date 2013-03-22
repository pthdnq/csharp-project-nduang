﻿using System;
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
                 StreamReader line = new StreamReader("Du lieu.txt");
                  while (!line.EndOfStream)
                     {
                          string docline = line.ReadLine();
                          String[] cat = docline.Split(' ');
                          string masv1 = cat[0];
                            if (masv.ToString() == masv1)
                                {
                                    listSinhVien.Add(cat[0] + "" + cat[1] + "" + cat[2]);
                                    //listSinhVien.Add(cat[0]);
                                    //listSinhVien.Add(cat[1]);
                                    //listSinhVien.Add(cat[2]);
                                }
                            line.Close();
                      }
                }
           }
        public void timSV(string tensv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                StreamReader line = new StreamReader("Du lieu.txt");
                while (!line.EndOfStream)
                {
                    string docline = line.ReadLine();
                    String[] cat = docline.Split(' ');
                    string tensv1 = cat[1];
                    if (tensv == tensv1)
                    {
                        listSinhVien.Add(cat[0] + "" + cat[1] + "" + cat[2]);
                    }
                    line.Close();
                }
            }
        }
        public void timSV(int masv, string tensv)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                StreamReader line = new StreamReader("Du lieu.txt");
                while (!line.EndOfStream)
                {
                    string docline = line.ReadLine();
                    String[] cat = docline.Split(' ');
                    string tensv1 = cat[1];
                    string masv1 = cat[0];
                    if (masv.ToString() == masv1 && tensv == tensv1)
                    {
                        listSinhVien.Add(cat[0] + "" + cat[1] + "" + cat[2]);
                    }
                    line.Close();
                }
            }
        }
        public void readFile()
        {
            Stream s = File.OpenRead("node.txt");
            StreamReader st = new StreamReader(s);
            string str = st.ReadLine();
        }
        public void luuDLfile()
        {
            
            StreamWriter sw = new StreamWriter("Du lieu.txt", false);
             for ( int i=0; i < listSinhVien.Count ; i ++)
            {
                 Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSinhVien[i];
                sw.WriteLine(sv.getMaSV() + " " + sv.getHoten() + " " + sv.getDiem());
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
        }
//         public void docDLfile()
//         {
//             StreamReader line = new StreamReader("Du lieu.txt");
//             while (!line.EndOfStream)
//             {
//                 string docline = line.ReadLine();
//                 String[] cat = docline.Split(' ');
//                 listSinhVien.Add(cat[0] +"" +cat[1] +"" +cat[2]);
//                 //listSinhVien.Add(cat[1]);
//                 //listSinhVien.Add(cat[2]);
//             }
// 
//             line.Close();
//         }
        public ArrayList getDSSinhVienFromFile()
        {
            listSinhVien.Clear();
            StreamReader line = new StreamReader("Du lieu.txt");
            while (!line.EndOfStream)
            {
                string docline = line.ReadLine();
                String[] cat = docline.Split(' ');
               // listSinhVien.Add(cat[0] + "" + cat[1] + "" + cat[2]);
<<<<<<< .mine
                Sinh_Vien sv = new Sinh_Vien();//tao 1 sinh vien
                sv.setMaSV(int.Parse(cat[0]));//dua thong tin tung dong doc duoc vao sinh vien nay
                sv.setHoten(cat[1].Trim());
                sv.setDiem(int.Parse(cat[2]));
                
                listSinhVien.Add(sv);//dua sinh vien vao danh sach
=======
                //Sinh_Vien sv = new Sinh_Vien();//tao 1 sinh vien
//                 sv.setMaSV(int.Parse(cat[0]));//dua thong tin tung dong doc duoc vao sinh vien nay
//                 sv.setHoten(cat[1].Trim());
//                 sv.setDiem(int.Parse(cat[2]));
//                 listSinhVien.Clear();
//                 listSinhVien.Insert(0, sv);//dua sinh vien vao danh sach
                int masv = int.Parse(cat[0]);
                string strHoten = cat[1];
                int diem = int.Parse(cat[2]);
                themSV(masv, strHoten, diem);

>>>>>>> .r202
            }
            line.Close();
            return listSinhVien;// tra ve danh sach sinh vien
        }

    }
}
