using System;
using System.Collections.Generic;
using System.Text;
using Utils.Component;
using System.Data;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Utils.DataLayer
{
   public class DictionaryData
    {
       DataService m_DictionaryData = new DataService();

       public DataTable getDictionaryList()
       {
           SqlCommand cmd = new SqlCommand("SELECT ID_Word,Word,Meaning FROM Dictionary");
           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }



       public DataRow NewRow()
       {
           return m_DictionaryData.NewRow();
       }

       public void AddRow(DataRow m_Row)
       {
           m_DictionaryData.Rows.Add(m_Row);
       }

       public bool SaveWord()
       {
           return m_DictionaryData.ExecuteNoneQuery() > 0;
       }

       public DataTable SearchByWord(String ma)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM Dictionary WHERE Word LIKE '%' + @ma + '%'");
           cmd.Parameters.Add("ma", SqlDbType.VarChar).Value = ma;

           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }

       public DataTable SearchByMeaning(String ten)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM Dictionary WHERE Meaning LIKE '%' + @ten + '%'");
           cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }
      
   }
}
