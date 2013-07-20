using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class DanTocData
    {
       DataService m_DanTocData = new DataService();
       public DataTable LayDSDanToc()
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DANTOC");
           m_DanTocData.Load(cmd);
           return m_DanTocData;
       }
       public DataRow ThemDongMoi()
       {
           return m_DanTocData.NewRow();
       }
       public void ThemDanToc(DataRow m_Row)
       {
           m_DanTocData.Rows.Add(m_Row);
       }
       public bool LuuDanToc()
       {
           return m_DanTocData.ExecuteNoneQuery() > 0;
       }
       
    }
}
