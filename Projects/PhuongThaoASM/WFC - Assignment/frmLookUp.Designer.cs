namespace WFC___Assignment
{
    partial class frmLookUp
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
            this.txtLookUp = new System.Windows.Forms.TextBox();
            this.lstLookUp = new System.Windows.Forms.ListBox();
            this.rtbLookUp = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Location = new System.Drawing.Point(24, 27);
            this.txtLookUp.Name = "txtLookUp";
            this.txtLookUp.Size = new System.Drawing.Size(166, 20);
            this.txtLookUp.TabIndex = 2;
            this.txtLookUp.Text = "Type a word here...";
            // 
            // lstLookUp
            // 
            this.lstLookUp.FormattingEnabled = true;
            this.lstLookUp.Location = new System.Drawing.Point(24, 53);
            this.lstLookUp.Name = "lstLookUp";
            this.lstLookUp.Size = new System.Drawing.Size(169, 342);
            this.lstLookUp.Sorted = true;
            this.lstLookUp.TabIndex = 3;
            // 
            // rtbLookUp
            // 
            this.rtbLookUp.Location = new System.Drawing.Point(199, 53);
            this.rtbLookUp.Name = "rtbLookUp";
            this.rtbLookUp.Size = new System.Drawing.Size(459, 342);
            this.rtbLookUp.TabIndex = 4;
            this.rtbLookUp.Text = "";
            // 
            // frmLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.rtbLookUp);
            this.Controls.Add(this.lstLookUp);
            this.Controls.Add(this.txtLookUp);
            this.MaximizeBox = false;
            this.Name = "frmLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Look up a word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLookUp;
        private System.Windows.Forms.ListBox lstLookUp;
        private System.Windows.Forms.RichTextBox rtbLookUp;
    }
}