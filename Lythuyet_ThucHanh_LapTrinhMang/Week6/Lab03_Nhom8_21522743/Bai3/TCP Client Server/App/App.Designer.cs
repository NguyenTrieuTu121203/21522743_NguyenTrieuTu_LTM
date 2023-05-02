namespace App
{
    partial class App
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
            this.sv_Btn = new System.Windows.Forms.Button();
            this.cl_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sv_Btn
            // 
            this.sv_Btn.Location = new System.Drawing.Point(61, 170);
            this.sv_Btn.Name = "sv_Btn";
            this.sv_Btn.Size = new System.Drawing.Size(300, 93);
            this.sv_Btn.TabIndex = 0;
            this.sv_Btn.Text = "Server";
            this.sv_Btn.UseVisualStyleBackColor = true;
            this.sv_Btn.Click += new System.EventHandler(this.sv_Btn_Click);
            // 
            // cl_Btn
            // 
            this.cl_Btn.Location = new System.Drawing.Point(435, 170);
            this.cl_Btn.Name = "cl_Btn";
            this.cl_Btn.Size = new System.Drawing.Size(300, 93);
            this.cl_Btn.TabIndex = 1;
            this.cl_Btn.Text = "Add Client";
            this.cl_Btn.UseVisualStyleBackColor = true;
            this.cl_Btn.Click += new System.EventHandler(this.cl_Btn_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.full;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cl_Btn);
            this.Controls.Add(this.sv_Btn);
            this.Name = "App";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sv_Btn;
        private System.Windows.Forms.Button cl_Btn;
    }
}

