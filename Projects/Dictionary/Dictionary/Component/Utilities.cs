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
       // public static NguoiDungInfo NguoiDung;
        public static String DatabaseName;
    }
    public class QuyDinh
    {
        
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
