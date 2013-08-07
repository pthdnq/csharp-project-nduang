using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
    class PhanBanData
    {
       DataService m_PhanBanData = new DataService();
       public DataTable LayDSBan()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM PHANBAN");
           m_PhanBanData.Load(cmd);
           return m_PhanBanData;
       }
       public DataRow ThemDongMoi()
       {
           return m_PhanBanData.NewRow();
       }
       public void ThemBan(DataRow m_Row)
       {
           m_PhanBanData.Rows.Add(m_Row);
       }
       public bool LuuBan()
       {
           return m_PhanBanData.ExecuteNoneQuery() > 0;
       }
       
    }
    
}
