namespace HN36PhoVer2GUI
{
    partial class frmLogin
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
            this.btnok = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chBoxRemember = new System.Windows.Forms.CheckBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(37, 130);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chBoxRemember
            // 
            this.chBoxRemember.AutoSize = true;
            this.chBoxRemember.Location = new System.Drawing.Point(72, 98);
            this.chBoxRemember.Name = "chBoxRemember";
            this.chBoxRemember.Size = new System.Drawing.Size(80, 17);
            this.chBoxRemember.TabIndex = 1;
            this.chBoxRemember.Text = "Remember ";
            this.chBoxRemember.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(49, 34);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(158, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(49, 72);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(158, 20);
            this.txt2.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 198);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.chBoxRemember);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnok);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chBoxRemember;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}

