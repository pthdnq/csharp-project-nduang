namespace CoSoDuLieu
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
            this.bntConnection = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntConnection
            // 
            this.bntConnection.Location = new System.Drawing.Point(61, 45);
            this.bntConnection.Name = "bntConnection";
            this.bntConnection.Size = new System.Drawing.Size(175, 63);
            this.bntConnection.TabIndex = 0;
            this.bntConnection.Text = "Connection";
            this.bntConnection.UseVisualStyleBackColor = true;
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(108, 155);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(79, 31);
            this.bntExit.TabIndex = 1;
            this.bntExit.Text = "Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.bntConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntConnection;
        private System.Windows.Forms.Button bntExit;
    }
}

