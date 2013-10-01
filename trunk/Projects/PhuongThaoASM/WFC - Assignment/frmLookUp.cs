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
using System.Speech;
using System.Speech.Synthesis;
using Utilities;
namespace WFC___Assignment
{
    public partial class frmLookUp : Office2007Form
    {
        public String m_ID;
        public String m_word;
        public String m_meaning;
        public String m_phonetis;
        DictionaryCtrl m_DictionaryCtrl = new DictionaryCtrl();
        //globalKeyboardHook gkh = new globalKeyboardHook();
        bool ctrlStatus = false;
        public frmLookUp()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLookUp_Load(object sender, EventArgs e)
        {
            DictionaryCtrl.SearchByWord(lstLookUp, "");

        }
        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Up\t" + e.KeyCode.ToString());
            e.Handled = true;
            ctrlStatus = false;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Down\t" + e.KeyCode.ToString());
            e.Handled = true;
            ctrlStatus = true;
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
                    String word = olditem.SubItems[1].Text.Trim();

                    //lbWord.Text = word;
                    String meaning = olditem.SubItems[2].Text;
                    meaning = meaning.Replace("\\n", "\n");
                    rtbLookUp.Text = meaning;
                    //set for other form
                    m_ID = olditem.SubItems[0].Text.Trim();
                    m_phonetis = olditem.SubItems[3].Text.Trim();
                    m_word = word;

                    m_meaning = meaning;
                }
            }

            catch (System.Exception)
            {

            }

        }
        public void Speech(String source)
        {
            SpeechSynthesizer speaker = new SpeechSynthesizer();
            speaker.SelectVoiceByHints(VoiceGender.Female);
            speaker.Volume = 100;
            speaker.Rate = 0;
            speaker.Speak(source);
        }
        private void lstLookUp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowWordAndMeaning();
        }

        private void txtLookUp_Click(object sender, EventArgs e)
        {
            txtLookUp.Text = "";
        }
        public String SearchByWord(String word)
        {
            String meaning = "Click icon to add dictionary!!!";
            meaning = DictionaryCtrl.SearchByWordExtractMatch(lstLookUp, word);
            return meaning;
        }
    }
}
