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
           SqlCommand cmd = new SqlCommand("SELECT ID,Word,Meanings FROM dict_en_vi");
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

       public DataTable SearchByWord(String word)
       {
           SqlCommand cmd = new SqlCommand("SELECT TOP 100  * FROM dict_en_vi WHERE Word LIKE /*'%'*/ + @word + '%'");
           cmd.Parameters.Add("word", SqlDbType.NVarChar).Value = word;

           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }
       public DataTable SearchByWordExtractMatch(String word)
       {
           SqlCommand cmd = new SqlCommand("SELECT TOP 20  * FROM dict_en_vi WHERE Word = @word ");
           cmd.Parameters.Add("word", SqlDbType.NVarChar).Value = word;

           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }

       public DataTable SearchByMeaning(String meaning)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM dict_en_vi WHERE Meaning LIKE '%' + @meaning + '%'");
           cmd.Parameters.Add("meaning", SqlDbType.NVarChar).Value = meaning;

           m_DictionaryData.Load(cmd);
           return m_DictionaryData;
       }
      
   }
}
