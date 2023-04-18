namespace Lab02_LTM
{
    partial class FormBai5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnZipFile = new System.Windows.Forms.Button();
            this.btnUnzip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path FILE";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(144, 111);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(447, 27);
            this.txtFileName.TabIndex = 2;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(144, 165);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(118, 41);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnZipFile
            // 
            this.btnZipFile.Location = new System.Drawing.Point(268, 165);
            this.btnZipFile.Name = "btnZipFile";
            this.btnZipFile.Size = new System.Drawing.Size(105, 41);
            this.btnZipFile.TabIndex = 7;
            this.btnZipFile.Text = "Zip File";
            this.btnZipFile.UseVisualStyleBackColor = true;
            this.btnZipFile.Click += new System.EventHandler(this.btnZipFol_Click);
            // 
            // btnUnzip
            // 
            this.btnUnzip.Location = new System.Drawing.Point(379, 165);
            this.btnUnzip.Name = "btnUnzip";
            this.btnUnzip.Size = new System.Drawing.Size(105, 41);
            this.btnUnzip.TabIndex = 8;
            this.btnUnzip.Text = "UnZip File";
            this.btnUnzip.UseVisualStyleBackColor = true;
            this.btnUnzip.Click += new System.EventHandler(this.btnUnzip_Click);
            // 
            // FormBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 373);
            this.Controls.Add(this.btnUnzip);
            this.Controls.Add(this.btnZipFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "FormBai5";
            this.Text = " Bài 5";
            this.Load += new System.EventHandler(this.FormBai5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnSelectFile;
        private Button btnZipFile;
        private Button btnUnzip;
    }
}