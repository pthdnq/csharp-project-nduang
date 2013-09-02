using System;
using System.Text;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using QLDiemHSTHPT.Bussiness;


namespace QLDiemHSTHPT.Component
{
    public class Utilities
    {
        public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
        
    }
    public class Tool
    {
        
        ////Nhap diem
        //Chẳng hạn nhập có 3 điểm miệng là a,b,c thì hàm này
        //sẽ hiển thị trên cột điểm miệng là a;b;c
        // Sau mỗi con điểm sẽ có 1 dấu chấm phẩy
        public String ArrayToString(String[] array, int n)
        {
            String str = "";
            for (int i = 0; i < n; i++)
            {
                if (i != n - 1)
                    str += array[i] + ";";
                else
                    str += array[i];
            }
            return str;
        }

        public Boolean KiemTraDiem(String strDiemSo)
        {
            if (strDiemSo.Trim() == "")
                return false;
            try{
            float diemSo = float.Parse(strDiemSo);
            if (diemSo < 0 || diemSo > 10)
                return false;
            else
                return true;
            }
            catch(Exception)
            {
                return false;//neu diem ko dung dinh dang
            }
            
        }


        public String LaySTT(int autoNum)
        {
            if (autoNum < 10)
                return "000" + autoNum;

            else if (autoNum >= 10 && autoNum < 100)
                return "00" + autoNum;

            else if (autoNum >= 100 && autoNum < 1000)
                return "0" + autoNum;

            else if (autoNum >= 1000 && autoNum < 10000)
                return "" + autoNum;

            else
                return "";
        }

        //Hàm này chuyển chuỗi điểm thành mảng các số thực
        //Ví dụ: chuỗi chuoi ="3;5;6.5" ==>mangChuoi ={3, 5, 6.5}
        //dấu để tách(Split) ở đây là dấu chấm phẩy (";")
        public float[] StringToFloatArray(String chuoi)
        {
            String[] mangChuoi = chuoi.Split(';');// chuyển chuỗi thành mảng chuỗi
            float[] mangSoThuc = new float[mangChuoi.Length];//tạo mảng số thực
            //có cùng kích thước như mảng chuỗi
            //vòng lặp sau chuyển mảng chuỗi sang mảng số thực
            for (int i = 0; i < mangChuoi.Length; i++)
            {
                mangSoThuc[i] = float.Parse(mangChuoi[i]);
            }
            return mangSoThuc;
        }

    }
        
}
