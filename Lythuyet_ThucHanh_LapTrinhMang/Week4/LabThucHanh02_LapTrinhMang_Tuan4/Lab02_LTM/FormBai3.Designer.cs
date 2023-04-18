namespace Lab02_LTM
{
    partial class FormBai3
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
            this.btnCal = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(38, 138);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(264, 63);
            this.btnReadFile.TabIndex = 1;
            this.btnReadFile.Text = "Read from File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(38, 230);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(264, 63);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "Tính";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(385, 53);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(392, 349);
            this.txtData.TabIndex = 4;
            // 
            // FormBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnReadFile);
            this.Name = "FormBai3";
            this.Text = "Bài 3";
            this.Load += new System.EventHandler(this.FormBai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnReadFile;
        private Button btnCal;
        private TextBox txtData;
    }
}