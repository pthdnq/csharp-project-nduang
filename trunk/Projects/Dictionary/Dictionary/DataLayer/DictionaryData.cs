using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace QLDiemHSTHPT.DataLayer
{
   public class DictionaryData
    {
       DataService m_HocSinhData = new DataService();

       public DataTable getDictionaryList()
       {
           SqlCommand cmd = new SqlCommand("SELECT ID_Word,Word,Meaning FROM Dictionary");
           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }



       public DataRow NewRow()
       {
           return m_HocSinhData.NewRow();
       }

       public void AddRow(DataRow m_Row)
       {
           m_HocSinhData.Rows.Add(m_Row);
       }

       public bool SaveWord()
       {
           return m_HocSinhData.ExecuteNoneQuery() > 0;
       }

       public DataTable SearchByWord(String ma)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM Dictionary WHERE Word LIKE '%' + @ma + '%'");
           cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }

       public DataTable SearchByMeaning(String ten)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM Dictionary WHERE Meaning LIKE '%' + @ten + '%'");
           cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

           m_HocSinhData.Load(cmd);
           return m_HocSinhData;
       }
      
   }
}
