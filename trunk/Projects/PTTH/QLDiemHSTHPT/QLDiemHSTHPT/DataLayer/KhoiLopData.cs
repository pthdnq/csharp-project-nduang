using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class KhoiLopData
    {
        DataService m_KhoiLopData = new DataService();
        public DataTable LayDSKhoiLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

       public DataTable LayDsKhoiLop(String khoiLopCu)
       {
           SqlCommand cmd = new SqlCommand();
           String sql = "SELECT * FROM KHOILOP WHERE MaKhoiLop = @khoiLopCu ";
           cmd.Parameters.Add("khoiLopCu", SqlDbType.VarChar).Value = khoiLopCu;

           if (khoiLopCu == "K10")
               sql += "OR MaKhoiLop = 'K11'";

           else if (khoiLopCu == "K11")
               sql += "OR MaKhoiLop = 'K12'";

           cmd.CommandText = sql;

           m_KhoiLopData.Load(cmd);
           return m_KhoiLopData;
       }
        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.NewRow();
        }
        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.Rows.Add(m_Row);
        }
        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.ExecuteNoneQuery() > 0;
        }
    }
}
