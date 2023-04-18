namespace Lab02_LTM
{
    partial class FormBai1
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
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.Lime;
            this.btnReadFile.Location = new System.Drawing.Point(71, 122);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(177, 75);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "ĐỌC FILE";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.BackColor = System.Drawing.Color.Lime;
            this.btnWriteFile.Location = new System.Drawing.Point(71, 230);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(177, 75);
            this.btnWriteFile.TabIndex = 1;
            this.btnWriteFile.Text = "GHI FILE";
            this.btnWriteFile.UseVisualStyleBackColor = false;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // rtbData
            // 
            this.rtbData.BackColor = System.Drawing.Color.Silver;
            this.rtbData.Location = new System.Drawing.Point(311, 44);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(422, 319);
            this.rtbData.TabIndex = 2;
            this.rtbData.Text = "";
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnReadFile);
            this.Name = "FormBai1";
            this.Text = "Bài 1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReadFile;
        private Button btnWriteFile;
        private RichTextBox rtbData;
    }
}