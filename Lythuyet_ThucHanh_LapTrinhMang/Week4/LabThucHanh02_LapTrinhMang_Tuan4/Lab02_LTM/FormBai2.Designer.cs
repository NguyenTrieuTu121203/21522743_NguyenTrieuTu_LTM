namespace Lab02_LTM
{
    partial class FormBai2
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
            this.rtbDaTa = new System.Windows.Forms.RichTextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSizeFile = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharaterCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbDaTa
            // 
            this.rtbDaTa.Location = new System.Drawing.Point(410, 45);
            this.rtbDaTa.Name = "rtbDaTa";
            this.rtbDaTa.Size = new System.Drawing.Size(363, 353);
            this.rtbDaTa.TabIndex = 0;
            this.rtbDaTa.Text = "";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReadFile.Location = new System.Drawing.Point(37, 45);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(327, 37);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Read from File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(137, 122);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(234, 27);
            this.txtFileName.TabIndex = 2;
            // 
            // txtSizeFile
            // 
            this.txtSizeFile.Location = new System.Drawing.Point(137, 162);
            this.txtSizeFile.Name = "txtSizeFile";
            this.txtSizeFile.Size = new System.Drawing.Size(234, 27);
            this.txtSizeFile.TabIndex = 3;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(137, 208);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(234, 27);
            this.txtURL.TabIndex = 4;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(137, 261);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(234, 27);
            this.txtLineCount.TabIndex = 5;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(137, 311);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(234, 27);
            this.txtWordCount.TabIndex = 6;
            // 
            // txtCharaterCount
            // 
            this.txtCharaterCount.Location = new System.Drawing.Point(137, 354);
            this.txtCharaterCount.Name = "txtCharaterCount";
            this.txtCharaterCount.Size = new System.Drawing.Size(234, 27);
            this.txtCharaterCount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Line Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Words Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Character Count";
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCharaterCount);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSizeFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.rtbDaTa);
            this.Name = "FormBai2";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.FormBai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbDaTa;
        private Button btnReadFile;
        private TextBox txtFileName;
        private TextBox txtSizeFile;
        private TextBox txtURL;
        private TextBox txtLineCount;
        private TextBox txtWordCount;
        private TextBox txtCharaterCount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}