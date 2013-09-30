namespace WFC___Assignment
{
    partial class frmAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnustrpAsm = new System.Windows.Forms.MenuStrip();
            this.tlstrpmnuitemDictionary = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemLookUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemVocabulary = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemView = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnustrpAsm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlstrpmnuitemDictionaryContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemHomeContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemLookUpContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemVocabularyContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemViewContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemStatusbarContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemManagerContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemHelpContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemAboutUsContext = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemExitContext = new System.Windows.Forms.ToolStripMenuItem();
            this.ststrpAsm = new System.Windows.Forms.StatusStrip();
            this.stlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.nicAsm = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnustrpAsmNic = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tlstrpmnuitemShowFormNic = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemExitNic = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAsm = new System.Windows.Forms.Label();
            this.mnustrpAsm.SuspendLayout();
            this.cmnustrpAsm.SuspendLayout();
            this.ststrpAsm.SuspendLayout();
            this.cmnustrpAsmNic.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnustrpAsm
            // 
            this.mnustrpAsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemDictionary,
            this.tlstrpmnuitemView,
            this.tlstrpmnuitemManager,
            this.tlstrpmnuitemHelp,
            this.tlstrpmnuitemExit});
            this.mnustrpAsm.Location = new System.Drawing.Point(0, 0);
            this.mnustrpAsm.Name = "mnustrpAsm";
            this.mnustrpAsm.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnustrpAsm.Size = new System.Drawing.Size(804, 24);
            this.mnustrpAsm.TabIndex = 1;
            this.mnustrpAsm.Text = "Assignment Menu";
            // 
            // tlstrpmnuitemDictionary
            // 
            this.tlstrpmnuitemDictionary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemHome,
            this.tlstrpmnuitemLookUp,
            this.tlstrpmnuitemVocabulary});
            this.tlstrpmnuitemDictionary.Name = "tlstrpmnuitemDictionary";
            this.tlstrpmnuitemDictionary.Size = new System.Drawing.Size(73, 20);
            this.tlstrpmnuitemDictionary.Text = "&Dictionary";
            this.tlstrpmnuitemDictionary.ToolTipText = "Dictionary";
            this.tlstrpmnuitemDictionary.MouseHover += new System.EventHandler(this.tlstrpmnuitemDictionary_MouseHover);
            // 
            // tlstrpmnuitemHome
            // 
            this.tlstrpmnuitemHome.Name = "tlstrpmnuitemHome";
            this.tlstrpmnuitemHome.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemHome.Text = "Home";
            this.tlstrpmnuitemHome.ToolTipText = "Home";
            this.tlstrpmnuitemHome.Click += new System.EventHandler(this.tlstrpmnuitemHome_Click);
            this.tlstrpmnuitemHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemHome_MouseMove);
            // 
            // tlstrpmnuitemLookUp
            // 
            this.tlstrpmnuitemLookUp.Name = "tlstrpmnuitemLookUp";
            this.tlstrpmnuitemLookUp.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemLookUp.Text = "Look up a word";
            this.tlstrpmnuitemLookUp.ToolTipText = "Look up a work";
            this.tlstrpmnuitemLookUp.Click += new System.EventHandler(this.tlstrpmnuitemLookUp_Click);
            this.tlstrpmnuitemLookUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemLookUp_MouseMove);
            // 
            // tlstrpmnuitemVocabulary
            // 
            this.tlstrpmnuitemVocabulary.Name = "tlstrpmnuitemVocabulary";
            this.tlstrpmnuitemVocabulary.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemVocabulary.Text = "Vocabulary";
            this.tlstrpmnuitemVocabulary.ToolTipText = "Vocabulary";
            this.tlstrpmnuitemVocabulary.Click += new System.EventHandler(this.tlstrpmnuitemVocabulary_Click);
            this.tlstrpmnuitemVocabulary.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemVocabulary_MouseMove);
            // 
            // tlstrpmnuitemView
            // 
            this.tlstrpmnuitemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemStatusbar});
            this.tlstrpmnuitemView.Name = "tlstrpmnuitemView";
            this.tlstrpmnuitemView.Size = new System.Drawing.Size(44, 20);
            this.tlstrpmnuitemView.Text = "&View";
            this.tlstrpmnuitemView.ToolTipText = "View Toolbars";
            this.tlstrpmnuitemView.MouseHover += new System.EventHandler(this.tlstrpmnuitemView_MouseHover);
            // 
            // tlstrpmnuitemStatusbar
            // 
            this.tlstrpmnuitemStatusbar.Checked = true;
            this.tlstrpmnuitemStatusbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlstrpmnuitemStatusbar.Name = "tlstrpmnuitemStatusbar";
            this.tlstrpmnuitemStatusbar.Size = new System.Drawing.Size(123, 22);
            this.tlstrpmnuitemStatusbar.Text = "Statusbar";
            this.tlstrpmnuitemStatusbar.ToolTipText = "Toggle status bar";
            this.tlstrpmnuitemStatusbar.Click += new System.EventHandler(this.tlstrpmnuitemStatusbar_Click);
            this.tlstrpmnuitemStatusbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemStatusbar_MouseMove);
            // 
            // tlstrpmnuitemManager
            // 
            this.tlstrpmnuitemManager.Name = "tlstrpmnuitemManager";
            this.tlstrpmnuitemManager.Size = new System.Drawing.Size(66, 20);
            this.tlstrpmnuitemManager.Text = "&Manager";
            this.tlstrpmnuitemManager.ToolTipText = "Manage Dictionary";
            this.tlstrpmnuitemManager.Click += new System.EventHandler(this.tlstrpmnuitemManager_Click);
            this.tlstrpmnuitemManager.MouseHover += new System.EventHandler(this.tlstrpmnuitemManager_MouseHover);
            // 
            // tlstrpmnuitemHelp
            // 
            this.tlstrpmnuitemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemAboutUs});
            this.tlstrpmnuitemHelp.Name = "tlstrpmnuitemHelp";
            this.tlstrpmnuitemHelp.Size = new System.Drawing.Size(44, 20);
            this.tlstrpmnuitemHelp.Text = "&Help";
            this.tlstrpmnuitemHelp.ToolTipText = "Help";
            this.tlstrpmnuitemHelp.MouseHover += new System.EventHandler(this.tlstrpmnuitemHelp_MouseHover);
            // 
            // tlstrpmnuitemAboutUs
            // 
            this.tlstrpmnuitemAboutUs.Name = "tlstrpmnuitemAboutUs";
            this.tlstrpmnuitemAboutUs.Size = new System.Drawing.Size(123, 22);
            this.tlstrpmnuitemAboutUs.Text = "About Us";
            this.tlstrpmnuitemAboutUs.ToolTipText = "About Us";
            this.tlstrpmnuitemAboutUs.Click += new System.EventHandler(this.tlstrpmnuitemAboutUs_Click);
            this.tlstrpmnuitemAboutUs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemAboutUs_MouseMove);
            // 
            // tlstrpmnuitemExit
            // 
            this.tlstrpmnuitemExit.Name = "tlstrpmnuitemExit";
            this.tlstrpmnuitemExit.Size = new System.Drawing.Size(37, 20);
            this.tlstrpmnuitemExit.Text = "&Exit";
            this.tlstrpmnuitemExit.ToolTipText = "Exit this application";
            this.tlstrpmnuitemExit.Click += new System.EventHandler(this.tlstrpmnuitemExit_Click);
            this.tlstrpmnuitemExit.MouseHover += new System.EventHandler(this.tlstrpmnuitemExit_MouseHover);
            // 
            // cmnustrpAsm
            // 
            this.cmnustrpAsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemDictionaryContext,
            this.tlstrpmnuitemViewContext,
            this.tlstrpmnuitemManagerContext,
            this.tlstrpmnuitemHelpContext,
            this.tlstrpmnuitemExitContext});
            this.cmnustrpAsm.Name = "cmnustrpAsm";
            this.cmnustrpAsm.Size = new System.Drawing.Size(129, 114);
            this.cmnustrpAsm.Text = "Assignment Menu";
            // 
            // tlstrpmnuitemDictionaryContext
            // 
            this.tlstrpmnuitemDictionaryContext.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemHomeContext,
            this.tlstrpmnuitemLookUpContext,
            this.tlstrpmnuitemVocabularyContext});
            this.tlstrpmnuitemDictionaryContext.Name = "tlstrpmnuitemDictionaryContext";
            this.tlstrpmnuitemDictionaryContext.Size = new System.Drawing.Size(128, 22);
            this.tlstrpmnuitemDictionaryContext.Text = "&Dictionary";
            this.tlstrpmnuitemDictionaryContext.ToolTipText = "Dictionary";
            this.tlstrpmnuitemDictionaryContext.MouseHover += new System.EventHandler(this.tlstrpmnuitemDictionaryContext_MouseHover);
            // 
            // tlstrpmnuitemHomeContext
            // 
            this.tlstrpmnuitemHomeContext.Name = "tlstrpmnuitemHomeContext";
            this.tlstrpmnuitemHomeContext.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemHomeContext.Text = "Home";
            this.tlstrpmnuitemHomeContext.ToolTipText = "Home";
            this.tlstrpmnuitemHomeContext.Click += new System.EventHandler(this.tlstrpmnuitemHomeContext_Click);
            this.tlstrpmnuitemHomeContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemHomeContext_MouseMove);
            // 
            // tlstrpmnuitemLookUpContext
            // 
            this.tlstrpmnuitemLookUpContext.Name = "tlstrpmnuitemLookUpContext";
            this.tlstrpmnuitemLookUpContext.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemLookUpContext.Text = "Look up a word";
            this.tlstrpmnuitemLookUpContext.ToolTipText = "Look up a work";
            this.tlstrpmnuitemLookUpContext.Click += new System.EventHandler(this.tlstrpmnuitemLookUpContext_Click);
            this.tlstrpmnuitemLookUpContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemLookUpContext_MouseMove);
            // 
            // tlstrpmnuitemVocabularyContext
            // 
            this.tlstrpmnuitemVocabularyContext.Name = "tlstrpmnuitemVocabularyContext";
            this.tlstrpmnuitemVocabularyContext.Size = new System.Drawing.Size(156, 22);
            this.tlstrpmnuitemVocabularyContext.Text = "Vocabulary";
            this.tlstrpmnuitemVocabularyContext.ToolTipText = "Vocabulary";
            this.tlstrpmnuitemVocabularyContext.Click += new System.EventHandler(this.tlstrpmnuitemVocabularyContext_Click);
            this.tlstrpmnuitemVocabularyContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemVocabularyContext_MouseMove);
            // 
            // tlstrpmnuitemViewContext
            // 
            this.tlstrpmnuitemViewContext.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemStatusbarContext});
            this.tlstrpmnuitemViewContext.Name = "tlstrpmnuitemViewContext";
            this.tlstrpmnuitemViewContext.Size = new System.Drawing.Size(128, 22);
            this.tlstrpmnuitemViewContext.Text = "&View";
            this.tlstrpmnuitemViewContext.ToolTipText = "View Toolbars";
            this.tlstrpmnuitemViewContext.MouseHover += new System.EventHandler(this.tlstrpmnuitemViewContext_MouseHover);
            // 
            // tlstrpmnuitemStatusbarContext
            // 
            this.tlstrpmnuitemStatusbarContext.Checked = true;
            this.tlstrpmnuitemStatusbarContext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlstrpmnuitemStatusbarContext.Name = "tlstrpmnuitemStatusbarContext";
            this.tlstrpmnuitemStatusbarContext.Size = new System.Drawing.Size(123, 22);
            this.tlstrpmnuitemStatusbarContext.Text = "Statusbar";
            this.tlstrpmnuitemStatusbarContext.ToolTipText = "Toggle status bar";
            this.tlstrpmnuitemStatusbarContext.Click += new System.EventHandler(this.tlstrpmnuitemStatusbarContext_Click);
            this.tlstrpmnuitemStatusbarContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemStatusbarContext_MouseMove);
            // 
            // tlstrpmnuitemManagerContext
            // 
            this.tlstrpmnuitemManagerContext.Name = "tlstrpmnuitemManagerContext";
            this.tlstrpmnuitemManagerContext.Size = new System.Drawing.Size(128, 22);
            this.tlstrpmnuitemManagerContext.Text = "&Manager";
            this.tlstrpmnuitemManagerContext.ToolTipText = "Manage Dictionary";
            this.tlstrpmnuitemManagerContext.Click += new System.EventHandler(this.tlstrpmnuitemManagerContext_Click);
            this.tlstrpmnuitemManagerContext.MouseHover += new System.EventHandler(this.tlstrpmnuitemManagerContext_MouseHover);
            // 
            // tlstrpmnuitemHelpContext
            // 
            this.tlstrpmnuitemHelpContext.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemAboutUsContext});
            this.tlstrpmnuitemHelpContext.Name = "tlstrpmnuitemHelpContext";
            this.tlstrpmnuitemHelpContext.Size = new System.Drawing.Size(128, 22);
            this.tlstrpmnuitemHelpContext.Text = "&Help";
            this.tlstrpmnuitemHelpContext.ToolTipText = "Help";
            this.tlstrpmnuitemHelpContext.MouseHover += new System.EventHandler(this.tlstrpmnuitemHelpContext_MouseHover);
            // 
            // tlstrpmnuitemAboutUsContext
            // 
            this.tlstrpmnuitemAboutUsContext.Name = "tlstrpmnuitemAboutUsContext";
            this.tlstrpmnuitemAboutUsContext.Size = new System.Drawing.Size(123, 22);
            this.tlstrpmnuitemAboutUsContext.Text = "About Us";
            this.tlstrpmnuitemAboutUsContext.ToolTipText = "About Us";
            this.tlstrpmnuitemAboutUsContext.Click += new System.EventHandler(this.tlstrpmnuitemAboutUsContext_Click);
            this.tlstrpmnuitemAboutUsContext.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemAboutUsContext_MouseMove);
            // 
            // tlstrpmnuitemExitContext
            // 
            this.tlstrpmnuitemExitContext.Name = "tlstrpmnuitemExitContext";
            this.tlstrpmnuitemExitContext.Size = new System.Drawing.Size(128, 22);
            this.tlstrpmnuitemExitContext.Text = "&Exit";
            this.tlstrpmnuitemExitContext.ToolTipText = "Exit this application";
            this.tlstrpmnuitemExitContext.Click += new System.EventHandler(this.tlstrpmnuitemExitContext_Click);
            this.tlstrpmnuitemExitContext.MouseHover += new System.EventHandler(this.tlstrpmnuitemExitContext_MouseHover);
            // 
            // ststrpAsm
            // 
            this.ststrpAsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblStatus});
            this.ststrpAsm.Location = new System.Drawing.Point(0, 504);
            this.ststrpAsm.Name = "ststrpAsm";
            this.ststrpAsm.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ststrpAsm.Size = new System.Drawing.Size(804, 24);
            this.ststrpAsm.TabIndex = 3;
            this.ststrpAsm.Text = "statusStrip1";
            // 
            // stlblStatus
            // 
            this.stlblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.stlblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.stlblStatus.Name = "stlblStatus";
            this.stlblStatus.Size = new System.Drawing.Size(674, 19);
            this.stlblStatus.Spring = true;
            this.stlblStatus.Text = "Status";
            this.stlblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nicAsm
            // 
            this.nicAsm.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicAsm.BalloonTipText = "This application is running";
            this.nicAsm.BalloonTipTitle = "Dictionary";
            this.nicAsm.ContextMenuStrip = this.cmnustrpAsmNic;
            this.nicAsm.Text = "English Dictionary";
            this.nicAsm.Visible = true;
            this.nicAsm.DoubleClick += new System.EventHandler(this.nicAsm_DoubleClick);
            // 
            // cmnustrpAsmNic
            // 
            this.cmnustrpAsmNic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemShowFormNic,
            this.tlstrpmnuitemExitNic});
            this.cmnustrpAsmNic.Name = "cmnustrpAsmNic";
            this.cmnustrpAsmNic.Size = new System.Drawing.Size(135, 48);
            // 
            // tlstrpmnuitemShowFormNic
            // 
            this.tlstrpmnuitemShowFormNic.Name = "tlstrpmnuitemShowFormNic";
            this.tlstrpmnuitemShowFormNic.Size = new System.Drawing.Size(134, 22);
            this.tlstrpmnuitemShowFormNic.Text = "Show Form";
            this.tlstrpmnuitemShowFormNic.Click += new System.EventHandler(this.tlstrpmnuitemShowFormNic_Click);
            // 
            // tlstrpmnuitemExitNic
            // 
            this.tlstrpmnuitemExitNic.Name = "tlstrpmnuitemExitNic";
            this.tlstrpmnuitemExitNic.Size = new System.Drawing.Size(134, 22);
            this.tlstrpmnuitemExitNic.Text = "Exit";
            this.tlstrpmnuitemExitNic.Click += new System.EventHandler(this.tlstrpmnuitemExitNic_Click);
            // 
            // lblAsm
            // 
            this.lblAsm.AutoSize = true;
            this.lblAsm.BackColor = System.Drawing.SystemColors.Menu;
            this.lblAsm.Location = new System.Drawing.Point(561, 97);
            this.lblAsm.Name = "lblAsm";
            this.lblAsm.Size = new System.Drawing.Size(220, 45);
            this.lblAsm.TabIndex = 6;
            this.lblAsm.Text = "ENGLISH - VIETNAMESE DICTIONARY\r\n\r\n\r\n";
            // 
            // frmAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::WFC___Assignment.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(804, 528);
            this.Controls.Add(this.ststrpAsm);
            this.Controls.Add(this.mnustrpAsm);
            this.Controls.Add(this.lblAsm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustrpAsm;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAssignment";
            this.Text = "WFC - Assignment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAssignment_FormClosing);
            this.Load += new System.EventHandler(this.frmAssignment_Load);
            this.mnustrpAsm.ResumeLayout(false);
            this.mnustrpAsm.PerformLayout();
            this.cmnustrpAsm.ResumeLayout(false);
            this.ststrpAsm.ResumeLayout(false);
            this.ststrpAsm.PerformLayout();
            this.cmnustrpAsmNic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnustrpAsm;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemDictionary;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemView;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemHelp;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemExit;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemLookUp;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemVocabulary;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemManager;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemStatusbar;
        private System.Windows.Forms.ContextMenuStrip cmnustrpAsm;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemDictionaryContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemViewContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemManagerContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemHelpContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemExitContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemLookUpContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemVocabularyContext;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemStatusbarContext;
        private System.Windows.Forms.StatusStrip ststrpAsm;
        private System.Windows.Forms.ToolStripStatusLabel stlblStatus;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemAboutUs;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemAboutUsContext;
        private System.Windows.Forms.NotifyIcon nicAsm;
        private System.Windows.Forms.ContextMenuStrip cmnustrpAsmNic;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemShowFormNic;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemExitNic;
        private System.Windows.Forms.Label lblAsm;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemHome;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemHomeContext;
    }
}

