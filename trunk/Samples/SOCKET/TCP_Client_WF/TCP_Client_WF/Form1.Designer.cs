namespace TCP_Client_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(65, 16);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(153, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(320, 16);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "9000";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(27, 76);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(465, 191);
            this.txtReceive.TabIndex = 4;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(27, 284);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(465, 55);
            this.txtSend.TabIndex = 5;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(498, 76);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 42);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(498, 284);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 55);
            this.btSend.TabIndex = 7;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 338);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP Client Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSend;
    }
}

