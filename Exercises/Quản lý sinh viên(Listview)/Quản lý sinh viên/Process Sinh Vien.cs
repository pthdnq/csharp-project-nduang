using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Quản_lý_sinh_viên
{
    class Process_Sinh_Vien
    {

        public void themSV(int masv, string ten, int diem)
        {
            Sinh_Vien SV_ = new Sinh_Vien();
            SV_.setMaSV(masv);
            SV_.setHoten(ten);
            SV_.setDiem(diem);


        }
        //public void suaSV(string ten, int diem)
        //{

        //}
       
    }
}
