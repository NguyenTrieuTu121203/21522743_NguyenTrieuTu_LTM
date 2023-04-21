namespace Nhom8_21522743_Tuan6
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.btnGetData = new System.Windows.Forms.Button();
            this.zedGraphControlFinance = new ZedGraph.ZedGraphControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 30);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(400, 66);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // zedGraphControlFinance
            // 
            this.zedGraphControlFinance.Location = new System.Drawing.Point(430, 13);
            this.zedGraphControlFinance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlFinance.Name = "zedGraphControlFinance";
            this.zedGraphControlFinance.ScrollGrace = 0D;
            this.zedGraphControlFinance.ScrollMaxX = 0D;
            this.zedGraphControlFinance.ScrollMaxY = 0D;
            this.zedGraphControlFinance.ScrollMaxY2 = 0D;
            this.zedGraphControlFinance.ScrollMinX = 0D;
            this.zedGraphControlFinance.ScrollMinY = 0D;
            this.zedGraphControlFinance.ScrollMinY2 = 0D;
            this.zedGraphControlFinance.Size = new System.Drawing.Size(626, 559);
            this.zedGraphControlFinance.TabIndex = 2;
            this.zedGraphControlFinance.UseExtendedPrintDialog = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 102);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(399, 470);
            this.dataGridView.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 585);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.zedGraphControlFinance);
            this.Controls.Add(this.btnGetData);
            this.Name = "Form3";
            this.Text = "API Finance";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetData;
        private ZedGraph.ZedGraphControl zedGraphControlFinance;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}