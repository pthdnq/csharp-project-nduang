using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTMOI
{
    public class Sinhvien
    {
        public Sinhvien()
        {
            maSV = 0;
            hoten = "";
            diem = 0;
        }
        public Sinhvien(int maSV_,string hoten_,int diem_)
        {
            maSV = maSV_;
            hoten = hoten_;
            diem = diem_;
        }
        public int getMaSv()
        {
            return maSV;
        }
        public void setMaSV(int maSV_)
        {
            maSV = maSV_;
        }
        public string getHoten()
        {
            return hoten;
        }
        public void setHoten(string newHoten)
        {
            hoten = newHoten;
        }
        public int getDiem()
        {
            return diem;
        }
        public void setDiem(int newdiem)
        {
            diem = newdiem;
        }
        private int maSV;
        private string hoten;
        private int diem;
    

    }
}
