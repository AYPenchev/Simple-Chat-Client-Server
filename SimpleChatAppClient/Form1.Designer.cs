namespace SimpleChatAppClient
{
    partial class frmClient
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
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.btnClientName = new System.Windows.Forms.Button();
            this.btnMessageSend = new System.Windows.Forms.Button();
            this.txtMessageSend = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtMessageDisplay = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnServerConnect
            // 
            this.btnServerConnect.Location = new System.Drawing.Point(377, 21);
            this.btnServerConnect.Name = "btnServerConnect";
            this.btnServerConnect.Size = new System.Drawing.Size(75, 23);
            this.btnServerConnect.TabIndex = 0;
            this.btnServerConnect.Text = "Connect";
            this.btnServerConnect.UseVisualStyleBackColor = true;
            this.btnServerConnect.Click += new System.EventHandler(this.btnServerConnect_Click);
            // 
            // btnClientName
            // 
            this.btnClientName.Location = new System.Drawing.Point(377, 79);
            this.btnClientName.Name = "btnClientName";
            this.btnClientName.Size = new System.Drawing.Size(75, 23);
            this.btnClientName.TabIndex = 1;
            this.btnClientName.Text = "Apply";
            this.btnClientName.UseVisualStyleBackColor = true;
            // 
            // btnMessageSend
            // 
            this.btnMessageSend.Location = new System.Drawing.Point(497, 396);
            this.btnMessageSend.Name = "btnMessageSend";
            this.btnMessageSend.Size = new System.Drawing.Size(75, 23);
            this.btnMessageSend.TabIndex = 2;
            this.btnMessageSend.Text = "Send";
            this.btnMessageSend.UseVisualStyleBackColor = true;
            this.btnMessageSend.Click += new System.EventHandler(this.btnMessageSend_Click);
            // 
            // txtMessageSend
            // 
            this.txtMessageSend.Location = new System.Drawing.Point(37, 398);
            this.txtMessageSend.Name = "txtMessageSend";
            this.txtMessageSend.Size = new System.Drawing.Size(454, 20);
            this.txtMessageSend.TabIndex = 3;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(105, 81);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(266, 20);
            this.txtClientName.TabIndex = 4;
            // 
            // txtMessageDisplay
            // 
            this.txtMessageDisplay.Location = new System.Drawing.Point(37, 108);
            this.txtMessageDisplay.Multiline = true;
            this.txtMessageDisplay.Name = "txtMessageDisplay";
            this.txtMessageDisplay.Size = new System.Drawing.Size(535, 282);
            this.txtMessageDisplay.TabIndex = 6;
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(34, 26);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 7;
            this.lblServerIP.Text = "Server IP:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 84);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Client name:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(91, 23);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 9;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(271, 23);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 11;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(205, 26);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 13);
            this.lblServerPort.TabIndex = 10;
            this.lblServerPort.Text = "Server Port:";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 447);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.txtMessageDisplay);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.txtMessageSend);
            this.Controls.Add(this.btnMessageSend);
            this.Controls.Add(this.btnClientName);
            this.Controls.Add(this.btnServerConnect);
            this.Name = "frmClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnServerConnect;
        private System.Windows.Forms.Button btnClientName;
        private System.Windows.Forms.Button btnMessageSend;
        private System.Windows.Forms.TextBox txtMessageSend;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtMessageDisplay;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
    }
}