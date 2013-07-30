using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class NamHocData
    {
        DataService m_NamHocData = new DataService();
        public DataTable LayDSNamHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NAMHOC");
            m_NamHocData.Load(cmd);
            return m_NamHocData;
        }
      //HTQuang begin 30/07/2013
       public DataTable LayDSNamHoc(String NamHocCu)
       {
           SqlCommand cmd = new SqlCommand();
           String sql = "SELECT * FROM NAMHOC WHERE MaNamHoc = @NamHocCu ";
           cmd.Parameters.Add("NamHocCu", SqlDbType.VarChar).Value = NamHocCu;

           if (NamHocCu == "NH0607")
               sql += "OR MaNamHoc = 'NH0708'";

           else if (NamHocCu == "NH0708")
               sql += "OR MaNamHoc = 'NH0809'";
           else if(NamHocCu == "NH0809")
               sql += "OR MaNamHoc = 'NH0910'";

           cmd.CommandText = sql;

           m_NamHocData.Load(cmd);
           return m_NamHocData;
       }
       //HTQuang end 30/07/2013
        public DataRow ThemDongMoi()
        {
            return m_NamHocData.NewRow();
        }
        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.Rows.Add(m_Row);
        }
        public bool LuuNamHoc()
        {
            return m_NamHocData.ExecuteNoneQuery() > 0;
        }
       
    }
}
