namespace bai2
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
            this.urlBox = new System.Windows.Forms.TextBox();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.download = new System.Windows.Forms.Button();
            this.htmlBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(29, 23);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(484, 20);
            this.urlBox.TabIndex = 0;
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(29, 67);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(484, 20);
            this.linkBox.TabIndex = 1;
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(533, 23);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(91, 20);
            this.download.TabIndex = 2;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // htmlBox
            // 
            this.htmlBox.Location = new System.Drawing.Point(29, 109);
            this.htmlBox.Name = "htmlBox";
            this.htmlBox.Size = new System.Drawing.Size(579, 329);
            this.htmlBox.TabIndex = 3;
            this.htmlBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.htmlBox);
            this.Controls.Add(this.download);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.urlBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.RichTextBox htmlBox;
        private System.Windows.Forms.Button button1;
    }
}

