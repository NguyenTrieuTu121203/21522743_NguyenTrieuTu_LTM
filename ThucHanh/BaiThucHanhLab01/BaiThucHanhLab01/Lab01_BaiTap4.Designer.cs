namespace BaiThucHanhLab01
{
    partial class Lab01_BaiTap4
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
            this.txtAmountOfMoney = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnConvertMoney = new System.Windows.Forms.Button();
            this.comboBoxMoney = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTyGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmountOfMoney
            // 
            this.txtAmountOfMoney.Location = new System.Drawing.Point(206, 147);
            this.txtAmountOfMoney.Name = "txtAmountOfMoney";
            this.txtAmountOfMoney.Size = new System.Drawing.Size(208, 27);
            this.txtAmountOfMoney.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(206, 286);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(208, 27);
            this.txtResult.TabIndex = 3;
            // 
            // btnConvertMoney
            // 
            this.btnConvertMoney.Location = new System.Drawing.Point(206, 214);
            this.btnConvertMoney.Name = "btnConvertMoney";
            this.btnConvertMoney.Size = new System.Drawing.Size(461, 42);
            this.btnConvertMoney.TabIndex = 4;
            this.btnConvertMoney.Text = "Convert";
            this.btnConvertMoney.UseVisualStyleBackColor = true;
            this.btnConvertMoney.Click += new System.EventHandler(this.btnConvertMoney_Click);
            // 
            // comboBoxMoney
            // 
            this.comboBoxMoney.FormattingEnabled = true;
            this.comboBoxMoney.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.comboBoxMoney.Location = new System.Drawing.Point(516, 146);
            this.comboBoxMoney.Name = "comboBoxMoney";
            this.comboBoxMoney.Size = new System.Drawing.Size(151, 28);
            this.comboBoxMoney.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số tiền cần đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số tiền đã đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã tiền tệ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(277, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Convert Money";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tỷ giá quy đổi";
            // 
            // txtTyGia
            // 
            this.txtTyGia.AutoSize = true;
            this.txtTyGia.Location = new System.Drawing.Point(160, 380);
            this.txtTyGia.Name = "txtTyGia";
            this.txtTyGia.Size = new System.Drawing.Size(0, 20);
            this.txtTyGia.TabIndex = 11;
            // 
            // Lab01_BaiTap4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTyGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMoney);
            this.Controls.Add(this.btnConvertMoney);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtAmountOfMoney);
            this.Name = "Lab01_BaiTap4";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.Form_BaiTap4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtAmountOfMoney;
        private TextBox txtResult;
        private Button btnConvertMoney;
        private ComboBox comboBoxMoney;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtTyGia;
    }
}