namespace Thứ_ngày
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(73, 81);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 20);
            this.txtSo.TabIndex = 0;
            this.txtSo.TextChanged += new System.EventHandler(this.txtSo_TextChanged);
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(73, 150);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(100, 20);
            this.txtThu.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtThu);
            this.Controls.Add(this.txtSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.TextBox txtThu;
    }
}

