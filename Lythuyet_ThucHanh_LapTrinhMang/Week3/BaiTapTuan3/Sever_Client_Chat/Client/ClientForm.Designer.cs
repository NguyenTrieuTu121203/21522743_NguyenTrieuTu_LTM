namespace Client
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.lsViewMessage = new System.Windows.Forms.ListView();
            this.btnConnectSever = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP_Address = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(38, 373);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(477, 22);
            this.txtMessage.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(521, 361);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 47);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsViewMessage
            // 
            this.lsViewMessage.HideSelection = false;
            this.lsViewMessage.Location = new System.Drawing.Point(38, 26);
            this.lsViewMessage.Name = "lsViewMessage";
            this.lsViewMessage.Size = new System.Drawing.Size(587, 322);
            this.lsViewMessage.TabIndex = 3;
            this.lsViewMessage.UseCompatibleStateImageBehavior = false;
            // 
            // btnConnectSever
            // 
            this.btnConnectSever.Location = new System.Drawing.Point(13, 150);
            this.btnConnectSever.Name = "btnConnectSever";
            this.btnConnectSever.Size = new System.Drawing.Size(220, 47);
            this.btnConnectSever.TabIndex = 4;
            this.btnConnectSever.Text = "Connect";
            this.btnConnectSever.UseVisualStyleBackColor = true;
            this.btnConnectSever.Click += new System.EventHandler(this.btnConnectSever_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIP_Address);
            this.panel1.Controls.Add(this.btnConnectSever);
            this.panel1.Location = new System.Drawing.Point(648, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 222);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP_Address ( Example: 127.X.Y.Z)";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(13, 89);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(220, 22);
            this.txtPort.TabIndex = 6;
            // 
            // txtIP_Address
            // 
            this.txtIP_Address.Location = new System.Drawing.Point(13, 38);
            this.txtIP_Address.Name = "txtIP_Address";
            this.txtIP_Address.Size = new System.Drawing.Size(220, 22);
            this.txtIP_Address.TabIndex = 5;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsViewMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListView lsViewMessage;
        private System.Windows.Forms.Button btnConnectSever;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP_Address;
    }
}

