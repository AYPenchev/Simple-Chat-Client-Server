namespace SimpleChatFormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.txtMessageDisplay = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtMessageSend = new System.Windows.Forms.TextBox();
            this.btnMessageSend = new System.Windows.Forms.Button();
            this.btnClientName = new System.Windows.Forms.Button();
            this.btnServerConnect = new System.Windows.Forms.Button();
            this.pictBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServerPort
            // 
            this.txtServerPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtServerPort.Location = new System.Drawing.Point(272, 29);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 22;
            // 
            // lblServerPort
            // 
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblServerPort.Location = new System.Drawing.Point(206, 32);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(63, 13);
            this.lblServerPort.TabIndex = 21;
            this.lblServerPort.Text = "Server Port:";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtServerIP.Location = new System.Drawing.Point(97, 29);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 20;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.Location = new System.Drawing.Point(40, 90);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Client name:";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblServerIP.Location = new System.Drawing.Point(40, 32);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 18;
            this.lblServerIP.Text = "Server IP:";
            // 
            // txtMessageDisplay
            // 
            this.txtMessageDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMessageDisplay.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtMessageDisplay.Enabled = false;
            this.txtMessageDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMessageDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMessageDisplay.Location = new System.Drawing.Point(43, 114);
            this.txtMessageDisplay.Multiline = true;
            this.txtMessageDisplay.Name = "txtMessageDisplay";
            this.txtMessageDisplay.ReadOnly = true;
            this.txtMessageDisplay.Size = new System.Drawing.Size(535, 282);
            this.txtMessageDisplay.TabIndex = 17;
            this.txtMessageDisplay.TextChanged += new System.EventHandler(this.txtMessageDisplay_TextChanged);
            // 
            // txtClientName
            // 
            this.txtClientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtClientName.Location = new System.Drawing.Point(111, 87);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(261, 20);
            this.txtClientName.TabIndex = 16;
            // 
            // txtMessageSend
            // 
            this.txtMessageSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMessageSend.Location = new System.Drawing.Point(43, 404);
            this.txtMessageSend.Name = "txtMessageSend";
            this.txtMessageSend.Size = new System.Drawing.Size(454, 20);
            this.txtMessageSend.TabIndex = 15;
            this.txtMessageSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessageSend_keyDown);
            // 
            // btnMessageSend
            // 
            this.btnMessageSend.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMessageSend.Location = new System.Drawing.Point(503, 402);
            this.btnMessageSend.Name = "btnMessageSend";
            this.btnMessageSend.Size = new System.Drawing.Size(75, 23);
            this.btnMessageSend.TabIndex = 14;
            this.btnMessageSend.Text = "Send";
            this.btnMessageSend.UseVisualStyleBackColor = true;
            this.btnMessageSend.Click += new System.EventHandler(this.btnMessageSend_Click);
            // 
            // btnClientName
            // 
            this.btnClientName.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClientName.Location = new System.Drawing.Point(378, 85);
            this.btnClientName.Name = "btnClientName";
            this.btnClientName.Size = new System.Drawing.Size(75, 23);
            this.btnClientName.TabIndex = 13;
            this.btnClientName.Text = "Apply";
            this.btnClientName.UseVisualStyleBackColor = true;
            this.btnClientName.Click += new System.EventHandler(this.btnClientName_Click);
            // 
            // btnServerConnect
            // 
            this.btnServerConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnServerConnect.Location = new System.Drawing.Point(378, 27);
            this.btnServerConnect.Name = "btnServerConnect";
            this.btnServerConnect.Size = new System.Drawing.Size(75, 23);
            this.btnServerConnect.TabIndex = 12;
            this.btnServerConnect.Text = "Connect";
            this.btnServerConnect.UseVisualStyleBackColor = true;
            this.btnServerConnect.Click += new System.EventHandler(this.btnServerConnect_Click);
            // 
            // pictBoxLogo
            // 
            this.pictBoxLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxLogo.Image")));
            this.pictBoxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictBoxLogo.InitialImage")));
            this.pictBoxLogo.Location = new System.Drawing.Point(470, 24);
            this.pictBoxLogo.Name = "pictBoxLogo";
            this.pictBoxLogo.Size = new System.Drawing.Size(110, 63);
            this.pictBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictBoxLogo.TabIndex = 23;
            this.pictBoxLogo.TabStop = false;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 443);
            this.Controls.Add(this.pictBoxLogo);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.TextBox txtMessageDisplay;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtMessageSend;
        private System.Windows.Forms.Button btnMessageSend;
        private System.Windows.Forms.Button btnClientName;
        private System.Windows.Forms.Button btnServerConnect;
        private System.Windows.Forms.PictureBox pictBoxLogo;
    }
}

