namespace WFC___Assignment
{
    partial class frmManager
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
            this.grpManager = new System.Windows.Forms.GroupBox();
            this.grpAddEditDelete = new System.Windows.Forms.GroupBox();
            this.radDelete = new System.Windows.Forms.RadioButton();
            this.radEdit = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPhonetic = new System.Windows.Forms.Label();
            this.txtPhonetic = new System.Windows.Forms.TextBox();
            this.grpManager.SuspendLayout();
            this.grpAddEditDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManager
            // 
            this.grpManager.Controls.Add(this.grpAddEditDelete);
            this.grpManager.Controls.Add(this.txtMeaning);
            this.grpManager.Controls.Add(this.txtPhonetic);
            this.grpManager.Controls.Add(this.txtWord);
            this.grpManager.Controls.Add(this.lblPhonetic);
            this.grpManager.Controls.Add(this.lblMeaning);
            this.grpManager.Controls.Add(this.lblWord);
            this.grpManager.Location = new System.Drawing.Point(12, 12);
            this.grpManager.Name = "grpManager";
            this.grpManager.Size = new System.Drawing.Size(648, 352);
            this.grpManager.TabIndex = 0;
            this.grpManager.TabStop = false;
            this.grpManager.Text = "Words Management";
            // 
            // grpAddEditDelete
            // 
            this.grpAddEditDelete.Controls.Add(this.radDelete);
            this.grpAddEditDelete.Controls.Add(this.radEdit);
            this.grpAddEditDelete.Controls.Add(this.radAdd);
            this.grpAddEditDelete.Location = new System.Drawing.Point(47, 179);
            this.grpAddEditDelete.Name = "grpAddEditDelete";
            this.grpAddEditDelete.Size = new System.Drawing.Size(83, 149);
            this.grpAddEditDelete.TabIndex = 3;
            this.grpAddEditDelete.TabStop = false;
            // 
            // radDelete
            // 
            this.radDelete.AutoSize = true;
            this.radDelete.Location = new System.Drawing.Point(12, 111);
            this.radDelete.Name = "radDelete";
            this.radDelete.Size = new System.Drawing.Size(56, 17);
            this.radDelete.TabIndex = 2;
            this.radDelete.TabStop = true;
            this.radDelete.Text = "Delete";
            this.radDelete.UseVisualStyleBackColor = true;
            // 
            // radEdit
            // 
            this.radEdit.AutoSize = true;
            this.radEdit.Location = new System.Drawing.Point(12, 70);
            this.radEdit.Name = "radEdit";
            this.radEdit.Size = new System.Drawing.Size(43, 17);
            this.radEdit.TabIndex = 2;
            this.radEdit.TabStop = true;
            this.radEdit.Text = "Edit";
            this.radEdit.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(12, 30);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(44, 17);
            this.radAdd.TabIndex = 2;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // txtMeaning
            // 
            this.txtMeaning.Location = new System.Drawing.Point(168, 115);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(445, 213);
            this.txtMeaning.TabIndex = 1;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(168, 36);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(445, 20);
            this.txtWord.TabIndex = 1;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Location = new System.Drawing.Point(44, 115);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(51, 13);
            this.lblMeaning.TabIndex = 0;
            this.lblMeaning.Text = "Meaning:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(44, 36);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(36, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(469, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(550, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPhonetic
            // 
            this.lblPhonetic.AutoSize = true;
            this.lblPhonetic.Location = new System.Drawing.Point(44, 80);
            this.lblPhonetic.Name = "lblPhonetic";
            this.lblPhonetic.Size = new System.Drawing.Size(52, 13);
            this.lblPhonetic.TabIndex = 0;
            this.lblPhonetic.Text = "Phonetic:";
            // 
            // txtPhonetic
            // 
            this.txtPhonetic.Location = new System.Drawing.Point(168, 77);
            this.txtPhonetic.Name = "txtPhonetic";
            this.txtPhonetic.Size = new System.Drawing.Size(445, 20);
            this.txtPhonetic.TabIndex = 1;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 476);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpManager);
            this.Name = "frmManager";
            this.Text = "frmManager";
            this.grpManager.ResumeLayout(false);
            this.grpManager.PerformLayout();
            this.grpAddEditDelete.ResumeLayout(false);
            this.grpAddEditDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManager;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.GroupBox grpAddEditDelete;
        private System.Windows.Forms.RadioButton radDelete;
        private System.Windows.Forms.RadioButton radEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhonetic;
        private System.Windows.Forms.Label lblPhonetic;
    }
}