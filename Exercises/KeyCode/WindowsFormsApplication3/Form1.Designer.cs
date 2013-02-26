namespace WindowsFormsApplication3
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
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(64, 107);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(156, 20);
            this.txtBox2.TabIndex = 0;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(64, 154);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(156, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox1_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 262);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.txtBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox1;
    }
}

