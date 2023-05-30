namespace Bai5_21522743
{
    partial class Bai5Form
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.LURL = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.Lpass = new System.Windows.Forms.Label();
            this.Lusername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(42, 214);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(714, 193);
            this.txtData.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(572, 106);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(184, 82);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 155);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(416, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 95);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(416, 31);
            this.txtEmail.TabIndex = 3;
            // 
            // LURL
            // 
            this.LURL.AutoSize = true;
            this.LURL.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LURL.Location = new System.Drawing.Point(82, 46);
            this.LURL.Name = "LURL";
            this.LURL.Size = new System.Drawing.Size(42, 22);
            this.LURL.TabIndex = 4;
            this.LURL.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(130, 46);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(626, 31);
            this.txtUrl.TabIndex = 6;
            // 
            // Lpass
            // 
            this.Lpass.AutoSize = true;
            this.Lpass.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpass.Location = new System.Drawing.Point(27, 155);
            this.Lpass.Name = "Lpass";
            this.Lpass.Size = new System.Drawing.Size(85, 22);
            this.Lpass.TabIndex = 7;
            this.Lpass.Text = "Password";
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lusername.Location = new System.Drawing.Point(70, 95);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(54, 22);
            this.Lusername.TabIndex = 8;
            this.Lusername.Text = "Email";
            // 
            // Bai5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lusername);
            this.Controls.Add(this.Lpass);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.LURL);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtData);
            this.Name = "Bai5Form";
            this.Text = "Bài 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label LURL;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label Lpass;
        private System.Windows.Forms.Label Lusername;
    }
}

