namespace UDP_Chat_WF
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
            this.txtRmIP = new System.Windows.Forms.TextBox();
            this.txtRmPort = new System.Windows.Forms.TextBox();
            this.txtNhan = new System.Windows.Forms.TextBox();
            this.txtGui = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.txtLcPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "RemoteIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "RemotePort";
            // 
            // txtRmIP
            // 
            this.txtRmIP.Location = new System.Drawing.Point(89, 12);
            this.txtRmIP.Name = "txtRmIP";
            this.txtRmIP.Size = new System.Drawing.Size(139, 20);
            this.txtRmIP.TabIndex = 2;
            this.txtRmIP.Text = "127.0.0.1";
            // 
            // txtRmPort
            // 
            this.txtRmPort.Location = new System.Drawing.Point(349, 12);
            this.txtRmPort.Name = "txtRmPort";
            this.txtRmPort.Size = new System.Drawing.Size(69, 20);
            this.txtRmPort.TabIndex = 3;
            // 
            // txtNhan
            // 
            this.txtNhan.Location = new System.Drawing.Point(22, 65);
            this.txtNhan.Multiline = true;
            this.txtNhan.Name = "txtNhan";
            this.txtNhan.Size = new System.Drawing.Size(348, 178);
            this.txtNhan.TabIndex = 4;
            // 
            // txtGui
            // 
            this.txtGui.Location = new System.Drawing.Point(22, 249);
            this.txtGui.Multiline = true;
            this.txtGui.Name = "txtGui";
            this.txtGui.Size = new System.Drawing.Size(348, 59);
            this.txtGui.TabIndex = 5;
            this.txtGui.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGui_KeyDown);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(383, 64);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(62, 61);
            this.btStart.TabIndex = 6;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(383, 249);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(62, 61);
            this.btSend.TabIndex = 7;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txtLcPort
            // 
            this.txtLcPort.Location = new System.Drawing.Point(349, 39);
            this.txtLcPort.Name = "txtLcPort";
            this.txtLcPort.Size = new System.Drawing.Size(69, 20);
            this.txtLcPort.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "LocalPort";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLcPort);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.txtGui);
            this.Controls.Add(this.txtNhan);
            this.Controls.Add(this.txtRmPort);
            this.Controls.Add(this.txtRmIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "UDP Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRmIP;
        private System.Windows.Forms.TextBox txtRmPort;
        private System.Windows.Forms.TextBox txtNhan;
        private System.Windows.Forms.TextBox txtGui;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.TextBox txtLcPort;
        private System.Windows.Forms.Label label3;
    }
}

