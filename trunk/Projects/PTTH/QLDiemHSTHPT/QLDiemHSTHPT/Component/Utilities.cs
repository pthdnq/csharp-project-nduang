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
    public class QuyDinh
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
            float diemSo = float.Parse(strDiemSo);
            if (diemSo < 0 || diemSo > 10)
                return false;
            return true;
        }
        public Boolean KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataService dS = new DataService();
            int doTuoiMin;
            int doTuoiMax;
            dS.Load(new SqlCommand("SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH"));
            try
            {
                doTuoiMin = Convert.ToInt32(dS.Rows[0]["TuoiCanDuoi"]);
                doTuoiMax = Convert.ToInt32(dS.Rows[0]["TuoiCanTren"]);
            }
            catch (System.Exception)
            {
                return false;
            }


            int doTuoi = DateTime.Today.Year - ngaySinh.Year;

            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)
                return true;
            else
                return false;
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
    }
        
}
