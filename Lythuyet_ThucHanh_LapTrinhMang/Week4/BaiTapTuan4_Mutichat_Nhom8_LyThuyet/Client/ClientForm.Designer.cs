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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMessage.Location = new System.Drawing.Point(16, 358);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(477, 27);
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
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSend.Location = new System.Drawing.Point(499, 346);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(104, 47);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lsViewMessage
            // 
            this.lsViewMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.lsViewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsViewMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsViewMessage.HideSelection = false;
            this.lsViewMessage.Location = new System.Drawing.Point(16, 18);
            this.lsViewMessage.Name = "lsViewMessage";
            this.lsViewMessage.Size = new System.Drawing.Size(587, 322);
            this.lsViewMessage.TabIndex = 3;
            this.lsViewMessage.UseCompatibleStateImageBehavior = false;
            // 
            // btnConnectSever
            // 
            this.btnConnectSever.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConnectSever.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnConnectSever.Location = new System.Drawing.Point(13, 150);
            this.btnConnectSever.Name = "btnConnectSever";
            this.btnConnectSever.Size = new System.Drawing.Size(220, 47);
            this.btnConnectSever.TabIndex = 4;
            this.btnConnectSever.Text = "Connect";
            this.btnConnectSever.UseVisualStyleBackColor = false;
            this.btnConnectSever.Click += new System.EventHandler(this.btnConnectSever_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIP_Address);
            this.panel1.Controls.Add(this.btnConnectSever);
            this.panel1.Location = new System.Drawing.Point(648, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 236);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP_Address ";
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPort.Location = new System.Drawing.Point(13, 89);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(220, 22);
            this.txtPort.TabIndex = 6;
            // 
            // txtIP_Address
            // 
            this.txtIP_Address.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtIP_Address.Location = new System.Drawing.Point(13, 38);
            this.txtIP_Address.Name = "txtIP_Address";
            this.txtIP_Address.Size = new System.Drawing.Size(220, 22);
            this.txtIP_Address.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.lsViewMessage);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Location = new System.Drawing.Point(22, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 403);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.tải_xuống;
            this.pictureBox1.Location = new System.Drawing.Point(678, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(926, 485);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

