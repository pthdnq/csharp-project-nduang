using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using Utils.DataLayer;
using System.Data;
using DevComponents.Editors.DateTimeAdv;


namespace Utils.Controller
{
   public class DictionaryCtrl
    {
       DictionaryData m_DictionaryData = new DictionaryData();



       public void ShowData(DataGridViewX dGV,
                            BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_DictionaryData.getDictionaryList();
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }


       public DataRow NewRow()
       {
           return m_DictionaryData.NewRow();
       }

       public void AddRow(DataRow m_Row)
       {
           m_DictionaryData.AddRow(m_Row);
       }

       public bool LuuHocSinh()
       {
           return m_DictionaryData.SaveWord();
       }

       public static void SearchByWord(ListView lvw, String m_Word)
       {
           DictionaryData data = new DictionaryData();
           DataTable table= data.SearchByWord(m_Word);
           lvw.Items.Clear();
           foreach (DataRow row in table.Rows)
           {
               ListViewItem item = new ListViewItem(row["ID"].ToString());
               item.SubItems.Add(row["Word"].ToString());
               item.SubItems.Add(row["Meanings"].ToString());
               item.SubItems.Add(row["Phonetic"].ToString());
               lvw.Items.Add(item);
           }

       }
       public static String SearchByWordExtractMatch(ListView lvw, String m_Word)
       {
           String meaning = "";
           DictionaryData data = new DictionaryData();
           DataTable table = data.SearchByWordExtractMatch(m_Word);
           lvw.Items.Clear();
           if(table.Rows.Count ==1)
           {
               foreach (DataRow row in table.Rows)
               {
                   ListViewItem item = new ListViewItem(row["ID"].ToString());
                   item.SubItems.Add(row["Word"].ToString());
                   item.SubItems.Add(row["Meanings"].ToString());
                   item.SubItems.Add(row["Phonetic"].ToString());
                   lvw.Items.Add(item);
                   meaning = row["Meanings"].ToString().Trim();
                   meaning = meaning.Replace("\\n", "\n");
               }
           }
           return meaning;
       }
       public static void SearchByMeaning(ListViewEx lvw, String m_TenHocSinh)
       {
          DictionaryData data = new DictionaryData();
           DataTable table = data.SearchByMeaning(m_TenHocSinh);
           lvw.Items.Clear();
           foreach (DataRow row in table.Rows)
           {
               ListViewItem item = new ListViewItem(row["ID"].ToString());
               item.SubItems.Add(row["Word"].ToString());
               item.SubItems.Add(row["Meaning"].ToString());
               lvw.Items.Add(item);
           }

       }

       public void SearchByWord(String m_Word)
       {
           m_DictionaryData.SearchByWord(m_Word);
       }

       public void SearchByMeaning(String m_Meaning)
       {
           m_DictionaryData.SearchByMeaning(m_Meaning);
       }
    }
         
}
