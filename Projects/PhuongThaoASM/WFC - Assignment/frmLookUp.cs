using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils.Controller;
using Utils.Component;
using DevComponents.DotNetBar;
using System.Collections;
namespace WFC___Assignment
{
    public partial class frmLookUp : Office2007Form
    {
        DictionaryCtrl m_DictionaryCtrl = new DictionaryCtrl();
        public frmLookUp()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLookUp_Load(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByWord(lstLookUp, txtLookUp.Text.Trim());
        }

        private void txtLookUp_TextChanged(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByWord(lstLookUp, txtLookUp.Text.Trim());
        }
        private void ShowWordAndMeaning()
        {
            try
            {
                IEnumerator ie = lstLookUp.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem olditem = (ListViewItem)ie.Current;
                    String word = olditem.SubItems[1].Text;
                    //lbWord.Text = word;
                    String meaning = olditem.SubItems[2].Text;
                    rtbLookUp.Text = meaning;
                    
                }
            }
            catch (System.Exception)
            {

            }

        }

        private void lstLookUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowWordAndMeaning();
        }
    }
}
