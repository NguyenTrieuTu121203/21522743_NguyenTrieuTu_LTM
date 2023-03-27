namespace BaiThucHanhLab01
{
    partial class Lab01_BaiTap5
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
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberA = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb_AFactorial = new System.Windows.Forms.Label();
            this.lb_BFactorial = new System.Windows.Forms.Label();
            this.lbCaculateS1 = new System.Windows.Forms.Label();
            this.lbCaculateS2 = new System.Windows.Forms.Label();
            this.lbCaculateS3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(191, 120);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(170, 27);
            this.txtNumberA.TabIndex = 0;
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(470, 120);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(184, 27);
            this.txtNumberB.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(108, 207);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(287, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(401, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(530, 207);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number B";
            // 
            // numberA
            // 
            this.numberA.AutoSize = true;
            this.numberA.Location = new System.Drawing.Point(108, 123);
            this.numberA.Name = "numberA";
            this.numberA.Size = new System.Drawing.Size(77, 20);
            this.numberA.TabIndex = 6;
            this.numberA.Text = "Number A";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Blue;
            this.label.Location = new System.Drawing.Point(79, 288);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 27);
            this.label.TabIndex = 7;
            this.label.Text = "A!= ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb.ForeColor = System.Drawing.Color.Blue;
            this.lb.Location = new System.Drawing.Point(79, 324);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(58, 27);
            this.lb.TabIndex = 8;
            this.lb.Text = "B! = ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb1.ForeColor = System.Drawing.Color.Blue;
            this.lb1.Location = new System.Drawing.Point(79, 362);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(215, 27);
            this.lb1.TabIndex = 9;
            this.lb1.Text = "S1 = 1+2+3+...+A = ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb2.ForeColor = System.Drawing.Color.Blue;
            this.lb2.Location = new System.Drawing.Point(79, 399);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(207, 27);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "S2 = 1+2+3+...+B =";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb3.ForeColor = System.Drawing.Color.Blue;
            this.lb3.Location = new System.Drawing.Point(79, 434);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(267, 27);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "S3 = A^1+A^2+...+A^B= ";
            // 
            // lb_AFactorial
            // 
            this.lb_AFactorial.AutoSize = true;
            this.lb_AFactorial.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_AFactorial.ForeColor = System.Drawing.Color.Blue;
            this.lb_AFactorial.Location = new System.Drawing.Point(121, 288);
            this.lb_AFactorial.Name = "lb_AFactorial";
            this.lb_AFactorial.Size = new System.Drawing.Size(0, 27);
            this.lb_AFactorial.TabIndex = 12;
            // 
            // lb_BFactorial
            // 
            this.lb_BFactorial.AutoSize = true;
            this.lb_BFactorial.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_BFactorial.ForeColor = System.Drawing.Color.Blue;
            this.lb_BFactorial.Location = new System.Drawing.Point(121, 324);
            this.lb_BFactorial.Name = "lb_BFactorial";
            this.lb_BFactorial.Size = new System.Drawing.Size(0, 27);
            this.lb_BFactorial.TabIndex = 13;
            // 
            // lbCaculateS1
            // 
            this.lbCaculateS1.AutoSize = true;
            this.lbCaculateS1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCaculateS1.ForeColor = System.Drawing.Color.Blue;
            this.lbCaculateS1.Location = new System.Drawing.Point(281, 362);
            this.lbCaculateS1.Name = "lbCaculateS1";
            this.lbCaculateS1.Size = new System.Drawing.Size(0, 27);
            this.lbCaculateS1.TabIndex = 14;
            // 
            // lbCaculateS2
            // 
            this.lbCaculateS2.AutoSize = true;
            this.lbCaculateS2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCaculateS2.ForeColor = System.Drawing.Color.Blue;
            this.lbCaculateS2.Location = new System.Drawing.Point(281, 399);
            this.lbCaculateS2.Name = "lbCaculateS2";
            this.lbCaculateS2.Size = new System.Drawing.Size(0, 27);
            this.lbCaculateS2.TabIndex = 15;
            // 
            // lbCaculateS3
            // 
            this.lbCaculateS3.AutoSize = true;
            this.lbCaculateS3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCaculateS3.ForeColor = System.Drawing.Color.Blue;
            this.lbCaculateS3.Location = new System.Drawing.Point(336, 434);
            this.lbCaculateS3.Name = "lbCaculateS3";
            this.lbCaculateS3.Size = new System.Drawing.Size(0, 27);
            this.lbCaculateS3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(191, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 43);
            this.label2.TabIndex = 17;
            this.label2.Text = "aggregate calculation";
            // 
            // Lab01_BaiTap5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCaculateS3);
            this.Controls.Add(this.lbCaculateS2);
            this.Controls.Add(this.lbCaculateS1);
            this.Controls.Add(this.lb_BFactorial);
            this.Controls.Add(this.lb_AFactorial);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label);
            this.Controls.Add(this.numberA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.txtNumberA);
            this.Name = "Lab01_BaiTap5";
            this.Text = "Bài 5";
            this.Load += new System.EventHandler(this.Form_BaiTap5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNumberA;
        private TextBox txtNumberB;
        private Button btnCalculate;
        private Button btnDelete;
        private Button btnExit;
        private Label label1;
        private Label numberA;
        private Label label;
        private Label lb;
        private Label lb1;
        private Label lb2;
        private Label lb3;
        private Label lb_AFactorial;
        private Label lb_BFactorial;
        private Label lbCaculateS1;
        private Label lbCaculateS2;
        private Label lbCaculateS3;
        private Label label2;
    }
}