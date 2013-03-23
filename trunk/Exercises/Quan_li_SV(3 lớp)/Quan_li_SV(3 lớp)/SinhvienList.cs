using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Quan_li_SV_3_lớp_
{
    class SinhvienList
    {
        ArrayList listSV = new ArrayList();
        ArrayList listSearch = new ArrayList();
      //  int i;
     // ArrayList Items=new ArrayList();
        public void timDL(int masv) 
        {
            for (int i = 0; i < listSV.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if (sv.getMaSV() == masv)
                {
                    hienthiSV(sv);
                    break;
                }
            }
        }
        public void themDL(int masv, string ten, int diem)
        {
            Sinh_Vien SV_=new Sinh_Vien();
            SV_.setMaSV(masv);
            SV_.setHoten(ten);
            SV_.setDiem(diem);
            listSV.Add(SV_);
        }
        public void suaDL(Sinh_Vien sv_)
        {
            for (int i=0; i < listSV.Count;i++ )
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if (sv.getMaSV() == sv_.getMaSV())
                {
                    listSV[i] = sv_;
                }
            }
        }
        public void xoaDL(int masv)
        {
         for (int i= 0; i < listSV.Count; i++)
            
              {
             
                     Sinh_Vien sv = new Sinh_Vien();
                     sv = (Sinh_Vien)listSV[i];
                     if (sv.getMaSV().ToString() == masv.ToString())
                    {
                        listSV.RemoveAt(i);
                    }
                    //listSV.RemoveAt(i);
            }
        }
        public ArrayList getDSSinhVienFromFile()
        {
            listSV.Clear();
            StreamReader line = new StreamReader("Du lieu.txt");
            while (!line.EndOfStream)
            {
                string docline = line.ReadLine();
                String[] cat = docline.Split(' ');

               // listSV.Add(cat[0] + "" + cat[1] + "" + cat[2]);
                Sinh_Vien sv = new Sinh_Vien();//tao 1 sinh vien
                sv.setMaSV(int.Parse(cat[0]));//dua thong tin tung dong doc duoc vao sinh vien nay
                sv.setHoten(cat[1].Trim());
                sv.setDiem(int.Parse(cat[2]));
                //listSV.Clear();
                listSV.Add(sv);//dua sinh vien vao danh sach
            }
            line.Close();
            return listSV;// tra ve danh sach sinh vien
        }
        public void hienthiSV(Sinh_Vien sv)
        {
            StreamWriter sw = new StreamWriter("Du lieu.txt");
            sw.WriteLine(sv.getMaSV() + " " + sv.getHoten() + " " + sv.getDiem());
        }
        public void hienThiList()
        {
            for (int i = 0; i < listSV.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];

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

            StreamWriter sw = new StreamWriter("Du lieu.txt");
            int i;
            for (i = 0; i < listSV.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];//ép mỗi phần tử của arraylist về kiểu sinh viên
                sw.WriteLine(sv.getMaSV() + " " + sv.getHoten() + " " + sv.getDiem());
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
         }
        public bool IsExist(int masv)
        {
            for (int i = 0; i < listSV.Count;i++ )
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if(sv.getMaSV()==masv)
                {
                    return true;///ma sinh vien da ton tai
                }
            }
            return false;//ma sinh vien chua ton tai
        }
        public ArrayList searchDL(Sinh_Vien sv_,int index)
        {
//               for (int i=0; i < listSV.Count;i++ )
//                {
               // Sinh_Vien sv = new Sinh_Vien();
//                 sv = (Sinh_Vien)listSV[i];
                    switch(index)
                     {
                        case 0:
                        SearchSV(sv_.getMaSV());//masv
                            break;
                        case 1:
                        SearchSV(sv_.getHoten());//ho ten
                            break;
                        case 2:
                        SearchSV(sv_.getMaSV(),sv_.getHoten());//ho ten va maSV
                            break;
                        default:
                         SearchSV(sv_.getMaSV());//masv
                            break;
                     }
//                 if (sv.getMaSV() == sv_.getMaSV()&&sv.getHoten()==sv_.getHoten())
//                 {
// 
 //                }

                    return listSearch;
        }
        public ArrayList SearchSV(int masv)
        {
            listSearch.Clear();
            for (int i = 0; i < listSV.Count;i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if(sv.getMaSV()==masv)
                {
                    listSearch.Add(sv);
                }
            }
            return listSearch;
        }
        public ArrayList SearchSV(string strHoTen)
        {
            listSearch.Clear();
            for (int i = 0; i < listSV.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if (sv.getHoten() == strHoTen)
                {
                    listSearch.Add(sv);
                }
            }
            return listSearch;
        }
        public ArrayList SearchSV(int masv,string strHoten)
        {
            listSearch.Clear();
            for (int i = 0; i < listSV.Count; i++)
            {
                Sinh_Vien sv = new Sinh_Vien();
                sv = (Sinh_Vien)listSV[i];
                if (sv.getMaSV() == masv&&sv.getHoten()==strHoten)
                {
                    listSearch.Add(sv);
                }
            }
            return listSearch;
        }
    }
    
}
