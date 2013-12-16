﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils.Component;
using DevComponents.DotNetBar;
using Gma.UserActivityMonitor;
using Utilities;

namespace WFC___Assignment
{
    public partial class frmAssignment : Office2007Form
    {
        frmAboutUs aboutUs = new frmAboutUs();
        frmLookUp m_frmLookUp = new frmLookUp();
        frmManager m_frmManager = new frmManager();
        String m_word ="";
        bool m_addWord = true;
        String m_NewWord = "";
        bool ctrlStatus = false;
        globalKeyboardHook gkh = new globalKeyboardHook();
        Keys lastKey = Keys.None;
       
        public frmAssignment()
        {
            InitializeComponent();
            DataService.OpenConnection();


        }

		void gkh_KeyDown(object sender, KeyEventArgs e) {
			Console.WriteLine("Down\t" + e.KeyCode.ToString());
            if ((lastKey == Keys.LControlKey) && (e.KeyCode == Keys.C))
            {
                showWordAndMeaningNotifyIcon();
                
            }
            lastKey = e.KeyCode;
            
		}
        //Loads the frmAssignment form
        private void frmAssignment_Load(object sender, EventArgs e)
        {
            stlblStatus.Text = "For help, contact youngrangrace@gmail.com";
            this.ContextMenuStrip = cmnustrpAsm;
            gkh.HookedKeys.Add(Keys.LControlKey);
            gkh.HookedKeys.Add(Keys.C);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);         
            nicAsm.Icon = this.Icon;

        }
        //Toggles the status bar
        private void tlstrpmnuitemStatusbar_Click(object sender, EventArgs e)
        {
            if (ststrpAsm.Visible == true)
            {
                ststrpAsm.Visible = false;
            }
            else
            {
                ststrpAsm.Visible = true;
            }
        }

        private void tlstrpmnuitemStatusbarContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemStatusbar_Click(sender, e);
        }

        //Displays the status on the status bar
        //--
        private void tlstrpmnuitemDictionary_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemDictionary.ToolTipText;
        }

        private void tlstrpmnuitemDictionaryContext_MouseHover(object sender, EventArgs e)
        {
            tlstrpmnuitemDictionary_MouseHover(sender, e);
        }
        //--
        private void tlstrpmnuitemView_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemView.ToolTipText;
        }

        private void tlstrpmnuitemViewContext_MouseHover(object sender, EventArgs e)
        {
            tlstrpmnuitemView_MouseHover(sender, e);
        }
        //--
        private void tlstrpmnuitemManager_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemManager.ToolTipText;
        }

        private void tlstrpmnuitemManagerContext_MouseHover(object sender, EventArgs e)
        {
            tlstrpmnuitemManager_MouseHover(sender, e);
        }
        //--
        private void tlstrpmnuitemHelp_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemHelp.ToolTipText;
        }

        private void tlstrpmnuitemHelpContext_MouseHover(object sender, EventArgs e)
        {
            tlstrpmnuitemHelp_MouseHover(sender, e);
        }
        //--
        private void tlstrpmnuitemExit_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemExit.ToolTipText;
        }

        private void tlstrpmnuitemExitContext_MouseHover(object sender, EventArgs e)
        {
            tlstrpmnuitemExit_MouseHover(sender, e);
        }

        //Displays the status on the status bar
        //--
        private void tlstrpmnuitemHome_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemHome.ToolTipText;
        }

        private void tlstrpmnuitemHomeContext_MouseMove(object sender, MouseEventArgs e)
        {
            tlstrpmnuitemHome_MouseMove(sender, e);
        }
        //--
        private void tlstrpmnuitemLookUp_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemLookUp.ToolTipText;
        }

        private void tlstrpmnuitemLookUpContext_MouseMove(object sender, MouseEventArgs e)
        {
            tlstrpmnuitemLookUp_MouseMove(sender, e);
        }
        //--
        private void tlstrpmnuitemVocabulary_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemVocabulary.ToolTipText;
        }

        private void tlstrpmnuitemVocabularyContext_MouseMove(object sender, MouseEventArgs e)
        {
            tlstrpmnuitemVocabulary_MouseMove(sender, e);
        }
        //--
        private void tlstrpmnuitemStatusbar_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemStatusbar.ToolTipText;
        }

        private void tlstrpmnuitemStatusbarContext_MouseMove(object sender, MouseEventArgs e)
        {
            tlstrpmnuitemStatusbar_MouseMove(sender, e);
        }
        //--
        private void tlstrpmnuitemAboutUs_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemAboutUs.ToolTipText;
        }

        private void tlstrpmnuitemAboutUsContext_MouseMove(object sender, MouseEventArgs e)
        {
            tlstrpmnuitemAboutUs_MouseMove(sender, e);
        }

        //Hide frmAssignment form
        private void frmAssignment_Hide(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.ActiveMdiChild.Close();
            }
            lblAsm.Hide();
        }

        //Show frmAssignment form
        private void frmAssignment_Show(object sender, EventArgs e)
        {
            lblAsm.Show();
        }
        
        //Home
        private void tlstrpmnuitemHome_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0)
            {
                frmAssignment_Show(sender, e);
            }
            else
            {
                this.ActiveMdiChild.Close();
                frmAssignment_Show(sender, e);
            }
        }

        private void tlstrpmnuitemHomeContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemHome_Click(sender, e);
        }

        //Look up a word
        private void tlstrpmnuitemLookUp_Click(object sender, EventArgs e)
        {
            frmAssignment_Hide(sender, e);

            m_frmLookUp.MdiParent = this;
            m_frmLookUp.WindowState = FormWindowState.Maximized;
            m_frmLookUp.Show();
        }

        private void tlstrpmnuitemLookUpContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemLookUp_Click(sender, e);
        }

        //Vocabulary
        private void tlstrpmnuitemVocabulary_Click(object sender, EventArgs e)
        {
            frmAssignment_Hide(sender, e);
            frmVocabulary newChild = new frmVocabulary();
            newChild.MdiParent = this;
            newChild.WindowState = FormWindowState.Maximized;
            newChild.Show();
        }

        private void tlstrpmnuitemVocabularyContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemVocabulary_Click(sender, e);
        }

        //Manager
        private void tlstrpmnuitemManager_Click(object sender, EventArgs e)
        {
            frmAssignment_Hide(sender, e);

            m_frmManager.MdiParent = this;
            m_frmManager.WindowState = FormWindowState.Maximized;
            m_frmManager.Show();
        }

        private void tlstrpmnuitemManagerContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemManager_Click(sender, e);
        }

        //About Us
        private void tlstrpmnuitemAboutUs_Click(object sender, EventArgs e)
        {           
            
            aboutUs.StartPosition = FormStartPosition.CenterParent;
            aboutUs.ShowDialog(); 
        }

        private void tlstrpmnuitemAboutUsContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemAboutUs_Click(sender, e);
        }

        //Eixt this application
        private void tlstrpmnuitemExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void tlstrpmnuitemExitContext_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemExit_Click(sender, e);
        }

        //Notify Icon
        private void frmAssignment_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.ShowInTaskbar = true;
            nicAsm.Icon = this.Icon;
            nicAsm.BalloonTipTitle = "Dictionary";
            nicAsm.BalloonTipText = "Dictionary has minized to tray";
            nicAsm.ShowBalloonTip(1000);
        }

        private void nicAsm_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            if (this.MdiChildren.Length > 0)
            {               
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            }
            AddNewWord();
        }
        private void AddNewWord()
        {
            if (m_addWord == true)
            {
                if (this.MdiChildren.Length > 0)
                {
                    this.ActiveMdiChild.Close();
                }
                lblAsm.Hide();
                m_frmManager.MdiParent = this;
                m_frmManager.WindowState = FormWindowState.Maximized;
                m_frmManager.txtWord.Text = m_NewWord;
                m_frmManager.txtPhonetic.Text = "";
                m_frmManager.txtMeaning.Text = "";
                m_frmManager.Show();
            }
        }
        private void tlstrpmnuitemShowFormNic_Click(object sender, EventArgs e)
        {
            nicAsm_DoubleClick(sender, e);
        }

        private void tlstrpmnuitemExitNic_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemExit_Click(sender, e);
        }

        private void editWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editWord();
        }

        private void mnSpeech_Click(object sender, EventArgs e)
        {
            m_word = m_frmLookUp.m_word;
            m_frmLookUp.Speech(m_word);
        }
        private void editWord()
        {
            //get word
            String m_ID = m_frmLookUp.m_ID;
            String m_Meaning = m_frmLookUp.m_meaning;
            String m_phonetis = m_frmLookUp.m_phonetis;
            m_word = m_frmLookUp.m_word;

            //set word 
            m_frmManager.txtWord.Text = m_word;
            m_frmManager.txtMeaning.Text = m_Meaning;
            m_frmManager.txtPhonetic.Text = m_phonetis;
            m_frmManager.MdiParent = this;
            m_frmManager.WindowState = FormWindowState.Maximized;
            m_frmManager.Show();
        }
        private void showWordAndMeaningNotifyIcon()
        {
           IDataObject iData = Clipboard.GetDataObject();
            // Is Data Text?
            if (iData.GetDataPresent(DataFormats.Text))
            {    
                String word = (String)iData.GetData(DataFormats.Text);
                String meaning =m_frmLookUp.SearchByWord(word);
                if(meaning =="")
                {
                    m_addWord = true;
                    m_NewWord = word;
                    meaning = "Not found a meaning. \nClick icon to add dictionary :v";
                }
                else
                {
                    m_addWord = false;
                }
                nicAsm.Icon =this.Icon ;
                nicAsm.BalloonTipTitle = "Translate: "+ word;
                nicAsm.BalloonTipText = meaning;
                nicAsm.ShowBalloonTip(2000);
             
            }
        }












    }
}