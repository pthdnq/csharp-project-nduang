using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quản_lý_sinh_viên
{
    class Sinh_Vien
    {
        private int maSV;
        private string tenSV;
        private int diem;
        public Sinh_Vien()
        {
            maSV = 0;
            tenSV = "";
            diem = 0;
        }
        public Sinh_Vien(int maSVnew, string hotennew, int diemnew)
        {
            maSV = maSVnew;
            tenSV = hotennew;
            diem = diemnew;
        }
        public int getMaSV()
        {
            return maSV;
        }
        public void setMaSV(int maSVnew)
        {
            maSV = maSVnew;
        }
        public string getHoten()
        {
            return tenSV;
        }
        public void setHoten(string hotennew)
        {
            tenSV = hotennew;
        }
        public int getDiem()
        {
            return diem;
        }
        public void setDiem(int diemnew)
        {
            diem = diemnew;
        }
    }
}
