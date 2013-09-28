using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.DataLayer;

namespace QLDiemHSTHPT
{
    public partial class frmDictionary : Office2007Form
    {
        DictionaryCtrl m_HocSinhCtrl = new DictionaryCtrl();
        public frmDictionary()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByWord(lvLopCu, txtTimkiem.Text);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtTimkiem_TextChanged_1(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByMeaning(lvLopCu, txtTimkiem.Text);
        }

        private void lvLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowWordAndMeaning();
        }
        private void ShowWordAndMeaning()
        {
            try
            {
                IEnumerator ie = lvLopCu.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem olditem = (ListViewItem)ie.Current;
                    String word = olditem.SubItems[1].Text;
                    lbWord.Text = word;
                    String meaning = olditem.SubItems[2].Text;
                    txtMeaning.Text = meaning;
                }
            }
            catch (System.Exception ex)
            {
            	
            }

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByWord(lvLopCu, txtTimkiem.Text);
        }

        private void lvLopCu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowWordAndMeaning();
        }

        private void frmPhanLop_Activated(object sender, EventArgs e)
        {
           // AutoPasteClipBoard();
        }

        private void frmDictionary_Enter(object sender, EventArgs e)
        {
            AutoPasteClipBoard();
        }

        private void frmDictionary_MouseHover(object sender, EventArgs e)
        {
           // AutoPasteClipBoard();
        }

        private void frmDictionary_MdiChildActivate(object sender, EventArgs e)
        {
           // AutoPasteClipBoard();
        }

        private void txtTimkiem_Leave(object sender, EventArgs e)
        {
            //AutoPasteClipBoard();
        }

        private void txtTimkiem_Enter(object sender, EventArgs e)
        {
           // AutoPasteClipBoard();
        }

        private void txtTimkiem_MouseHover(object sender, EventArgs e)
        {

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
           // this.Focus();
        }

        private void txtTimkiem_SizeChanged(object sender, EventArgs e)
        {
        }

        private void frmDictionary_SizeChanged(object sender, EventArgs e)
        {
            AutoPasteClipBoard();
        }
        private void AutoPasteClipBoard()
        {
            IDataObject iData = Clipboard.GetDataObject();
            // Is Data Text?
            if (iData.GetDataPresent(DataFormats.Text))
                txtTimkiem.Text = (String)iData.GetData(DataFormats.Text);
            txtTimkiem.Focus();
        }
        
    }
}