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
            this.rtbLookUp = new System.Windows.Forms.RichTextBox();
            this.lstLookUp = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhonetis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMeaning = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtLookUp
            // 
            this.txtLookUp.Location = new System.Drawing.Point(24, 27);
            this.txtLookUp.Name = "txtLookUp";
            this.txtLookUp.Size = new System.Drawing.Size(156, 20);
            this.txtLookUp.TabIndex = 2;
            this.txtLookUp.Text = "Type a word here...";
            this.txtLookUp.TextChanged += new System.EventHandler(this.txtLookUp_TextChanged);
            // 
            // rtbLookUp
            // 
            this.rtbLookUp.Location = new System.Drawing.Point(199, 53);
            this.rtbLookUp.Name = "rtbLookUp";
            this.rtbLookUp.Size = new System.Drawing.Size(459, 328);
            this.rtbLookUp.TabIndex = 4;
            this.rtbLookUp.Text = "";
            // 
            // lstLookUp
            // 
            // 
            // 
            // 
            this.lstLookUp.Border.Class = "ListViewBorder";
            this.lstLookUp.Border.PaddingLeft = 5;
            this.lstLookUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colWord,
            this.colPhonetis,
            this.colMeaning});
            this.lstLookUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLookUp.FullRowSelect = true;
            this.lstLookUp.Location = new System.Drawing.Point(24, 53);
            this.lstLookUp.Name = "lstLookUp";
            this.lstLookUp.Size = new System.Drawing.Size(156, 328);
            this.lstLookUp.TabIndex = 16;
            this.lstLookUp.UseCompatibleStateImageBehavior = false;
            this.lstLookUp.View = System.Windows.Forms.View.Details;
            this.lstLookUp.SelectedIndexChanged += new System.EventHandler(this.lstLookUp_SelectedIndexChanged);
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 0;
            // 
            // colWord
            // 
            this.colWord.Text = "Word";
            this.colWord.Width = 180;
            // 
            // colPhonetis
            // 
            this.colPhonetis.Text = "Phonetis";
            // 
            // colMeaning
            // 
            this.colMeaning.Text = "Meaning";
            // 
            // frmLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.lstLookUp);
            this.Controls.Add(this.rtbLookUp);
            this.Controls.Add(this.txtLookUp);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Look up a word";
            this.Load += new System.EventHandler(this.frmLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLookUp;
        private System.Windows.Forms.RichTextBox rtbLookUp;
        private DevComponents.DotNetBar.Controls.ListViewEx lstLookUp;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colWord;
        private System.Windows.Forms.ColumnHeader colPhonetis;
        private System.Windows.Forms.ColumnHeader colMeaning;
    }
}