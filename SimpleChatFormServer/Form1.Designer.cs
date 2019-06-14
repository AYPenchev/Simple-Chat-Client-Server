namespace SimpleChatFormServer
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.txtMessageDisplay = new System.Windows.Forms.TextBox();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblConnectedClients = new System.Windows.Forms.Label();
            this.txtClientList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessageDisplay
            // 
            this.txtMessageDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessageDisplay.Enabled = false;
            this.txtMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMessageDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMessageDisplay.Location = new System.Drawing.Point(20, 125);
            this.txtMessageDisplay.Multiline = true;
            this.txtMessageDisplay.Name = "txtMessageDisplay";
            this.txtMessageDisplay.ReadOnly = true;
            this.txtMessageDisplay.Size = new System.Drawing.Size(535, 333);
            this.txtMessageDisplay.TabIndex = 29;
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(20, 96);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(166, 23);
            this.btnServerStart.TabIndex = 41;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnServerStart_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(86, 28);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 42;
            this.txtServerIP.TextChanged += new System.EventHandler(this.txtServerIP_TextChanged);
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(86, 59);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 43;
            this.txtServerPort.TextChanged += new System.EventHandler(this.txtServerPort_TextChanged);
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(17, 62);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 13);
            this.lblServerPort.TabIndex = 44;
            this.lblServerPort.Text = "Server Port:";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(17, 31);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 45;
            this.lblServerIP.Text = "Server IP:";
            // 
            // lblConnectedClients
            // 
            this.lblConnectedClients.AutoSize = true;
            this.lblConnectedClients.Location = new System.Drawing.Point(269, 9);
            this.lblConnectedClients.Name = "lblConnectedClients";
            this.lblConnectedClients.Size = new System.Drawing.Size(93, 13);
            this.lblConnectedClients.TabIndex = 47;
            this.lblConnectedClients.Text = "Connected Clients";
            // 
            // txtClientList
            // 
            this.txtClientList.Enabled = false;
            this.txtClientList.Location = new System.Drawing.Point(232, 28);
            this.txtClientList.Multiline = true;
            this.txtClientList.Name = "txtClientList";
            this.txtClientList.Size = new System.Drawing.Size(168, 91);
            this.txtClientList.TabIndex = 48;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(574, 470);
            this.Controls.Add(this.txtClientList);
            this.Controls.Add(this.lblConnectedClients);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnServerStart);
            this.Controls.Add(this.txtMessageDisplay);
            this.Name = "FrmServer";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMessageDisplay;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblConnectedClients;
        private System.Windows.Forms.TextBox txtClientList;
    }
}

