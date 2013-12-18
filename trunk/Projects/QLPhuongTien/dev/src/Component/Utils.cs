using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
namespace Component
{
    public class Utils
    {
        Data m_data = new Data();
        public String getIDAuto(string tblName,string fldID)
        {
            return m_data.getIDNumberAuto(tblName, fldID);
        }
    }
}
