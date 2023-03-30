namespace Sever
{
    partial class SeverForm
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
            this.btnSeverSend = new System.Windows.Forms.Button();
            this.txtMessageSever = new System.Windows.Forms.TextBox();
            this.lsViewMessageSever = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnSeverSend
            // 
            this.btnSeverSend.Location = new System.Drawing.Point(537, 367);
            this.btnSeverSend.Name = "btnSeverSend";
            this.btnSeverSend.Size = new System.Drawing.Size(97, 42);
            this.btnSeverSend.TabIndex = 0;
            this.btnSeverSend.Text = "Send";
            this.btnSeverSend.UseVisualStyleBackColor = true;
            this.btnSeverSend.Click += new System.EventHandler(this.btnSeverSend_Click);
            // 
            // txtMessageSever
            // 
            this.txtMessageSever.Location = new System.Drawing.Point(25, 377);
            this.txtMessageSever.Name = "txtMessageSever";
            this.txtMessageSever.Size = new System.Drawing.Size(506, 22);
            this.txtMessageSever.TabIndex = 1;
            // 
            // lsViewMessageSever
            // 
            this.lsViewMessageSever.HideSelection = false;
            this.lsViewMessageSever.Location = new System.Drawing.Point(25, 40);
            this.lsViewMessageSever.Name = "lsViewMessageSever";
            this.lsViewMessageSever.Size = new System.Drawing.Size(606, 311);
            this.lsViewMessageSever.TabIndex = 2;
            this.lsViewMessageSever.UseCompatibleStateImageBehavior = false;
            // 
            // SeverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsViewMessageSever);
            this.Controls.Add(this.txtMessageSever);
            this.Controls.Add(this.btnSeverSend);
            this.Name = "SeverForm";
            this.Text = "Sever";
            this.Load += new System.EventHandler(this.SeverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeverSend;
        private System.Windows.Forms.TextBox txtMessageSever;
        private System.Windows.Forms.ListView lsViewMessageSever;
    }
}

