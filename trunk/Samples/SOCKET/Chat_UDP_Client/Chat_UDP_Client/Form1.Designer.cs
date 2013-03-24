namespace Chat_UDP_Client
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
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(379, 12);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(69, 20);
            this.txtRemotePort.TabIndex = 0;
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(379, 51);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(69, 20);
            this.txtLocalPort.TabIndex = 1;
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(102, 12);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(177, 20);
            this.txtRemoteIP.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(414, 95);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 50);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(414, 291);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 58);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(26, 291);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(382, 58);
            this.txtSend.TabIndex = 5;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(26, 95);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(382, 182);
            this.txtReceive.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remote IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Remote Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Local Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtRemoteIP);
            this.Controls.Add(this.txtLocalPort);
            this.Controls.Add(this.txtRemotePort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

