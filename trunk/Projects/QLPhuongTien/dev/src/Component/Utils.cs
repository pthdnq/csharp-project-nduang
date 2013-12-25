using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Collections;
namespace Component
{
    public class Utils
    {
        Data m_data = new Data();
        public int ERR_MA_DANG_SU_DUNG = -2146232060;
        public int ERR_MA_KHONG_TON_TAI = 242343;
        public String getIDAuto(string tblName,string fldID)
        {
            return m_data.getIDNumberAuto(tblName, fldID);
        }
        public int getMaxIDAuto(string tblName, string fldID)
        {
            int maxID = 0;
            ArrayList listID = m_data.getListIDNumberAuto(tblName, fldID);
            int i = 0;
            foreach (string strcurrentID in listID)
            {
                int icurrentID = getIntInString(strcurrentID);
                if (i == 0)
                {
                    maxID = icurrentID;
                }
                if (maxID < icurrentID)
                {
                    maxID = icurrentID;
                }
                i++;
            }
            return maxID;

        }
        public Decimal ConvertStringToDecimal(string strnumber)
        {
            return decimal.Parse(strnumber);
        }
        public float ConvertDecimalToFloat(decimal decNumber)
        {
            return float.Parse(decNumber.ToString());
        }
        public int getIntInString(string strContainsNumber)
        {
            int val = 0;
            string struNumber = string.Empty;
            
            for (int i=0; i< strContainsNumber.Length; i++)
            {
                if (Char.IsDigit(strContainsNumber[i]))
                   struNumber += strContainsNumber[i];
            }
            if (struNumber.Length>0)
                val = int.Parse(struNumber);
            return val;
        }
        public String convertIntToFormatedString(int autoNum)
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
