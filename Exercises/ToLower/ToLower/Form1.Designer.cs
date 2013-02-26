namespace ToUpper
{
    partial class Form1
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
            this.txtChuThuong = new System.Windows.Forms.TextBox();
            this.txtChuHoa = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChuThuong
            // 
            this.txtChuThuong.Location = new System.Drawing.Point(58, 62);
            this.txtChuThuong.Name = "txtChuThuong";
            this.txtChuThuong.Size = new System.Drawing.Size(154, 20);
            this.txtChuThuong.TabIndex = 1;
            // 
            // txtChuHoa
            // 
            this.txtChuHoa.Location = new System.Drawing.Point(58, 36);
            this.txtChuHoa.Name = "txtChuHoa";
            this.txtChuHoa.Size = new System.Drawing.Size(154, 20);
            this.txtChuHoa.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(66, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(146, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Chuyển sang chữ thường";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChuHoa);
            this.Controls.Add(this.txtChuThuong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChuThuong;
        private System.Windows.Forms.TextBox txtChuHoa;
        private System.Windows.Forms.Button btnOK;
    }
}

