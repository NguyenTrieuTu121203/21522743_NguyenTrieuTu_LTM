using System.Drawing;
using System.Windows.Forms;

namespace Bai4;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.lb_page = new System.Windows.Forms.Label();
            this.lb_ttP = new System.Windows.Forms.Label();
            this.lb_UpP = new System.Windows.Forms.Label();
            this.lb_ttU = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.page = new System.Windows.Forms.Label();
            this.perPage = new System.Windows.Forms.Label();
            this.totalPages = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(297, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER LIST";
            // 
            // lb_page
            // 
            this.lb_page.AutoSize = true;
            this.lb_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_page.Location = new System.Drawing.Point(12, 17);
            this.lb_page.Name = "lb_page";
            this.lb_page.Size = new System.Drawing.Size(35, 13);
            this.lb_page.TabIndex = 1;
            this.lb_page.Text = "Page:";
            // 
            // lb_ttP
            // 
            this.lb_ttP.AutoSize = true;
            this.lb_ttP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ttP.Location = new System.Drawing.Point(162, 16);
            this.lb_ttP.Name = "lb_ttP";
            this.lb_ttP.Size = new System.Drawing.Size(62, 13);
            this.lb_ttP.TabIndex = 1;
            this.lb_ttP.Text = "Total Page:";
            // 
            // lb_UpP
            // 
            this.lb_UpP.AutoSize = true;
            this.lb_UpP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_UpP.Location = new System.Drawing.Point(12, 37);
            this.lb_UpP.Name = "lb_UpP";
            this.lb_UpP.Size = new System.Drawing.Size(67, 13);
            this.lb_UpP.TabIndex = 1;
            this.lb_UpP.Text = "Users/Page:";
            // 
            // lb_ttU
            // 
            this.lb_ttU.AutoSize = true;
            this.lb_ttU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ttU.Location = new System.Drawing.Point(162, 37);
            this.lb_ttU.Name = "lb_ttU";
            this.lb_ttU.Size = new System.Drawing.Size(64, 13);
            this.lb_ttU.TabIndex = 1;
            this.lb_ttU.Text = "Total Users:";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(209, 80);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 22);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_next.Location = new System.Drawing.Point(405, 78);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(82, 22);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // page
            // 
            this.page.AutoSize = true;
            this.page.Location = new System.Drawing.Point(53, 16);
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(13, 15);
            this.page.TabIndex = 3;
            this.page.Text = "0";
            // 
            // perPage
            // 
            this.perPage.AutoSize = true;
            this.perPage.Location = new System.Drawing.Point(85, 35);
            this.perPage.Name = "perPage";
            this.perPage.Size = new System.Drawing.Size(13, 15);
            this.perPage.TabIndex = 4;
            this.perPage.Text = "0";
            // 
            // totalPages
            // 
            this.totalPages.AutoSize = true;
            this.totalPages.Location = new System.Drawing.Point(230, 16);
            this.totalPages.Name = "totalPages";
            this.totalPages.Size = new System.Drawing.Size(13, 15);
            this.totalPages.TabIndex = 5;
            this.totalPages.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(232, 37);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(13, 15);
            this.total.TabIndex = 6;
            this.total.Text = "0";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(8, 121);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(680, 230);
            this.listView1.TabIndex = 7;
            this.listView1.TileSize = new System.Drawing.Size(740, 100);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(579, 80);
            this.pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(109, 22);
            this.pb.TabIndex = 8;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 362);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalPages);
            this.Controls.Add(this.perPage);
            this.Controls.Add(this.page);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lb_ttU);
            this.Controls.Add(this.lb_UpP);
            this.Controls.Add(this.lb_ttP);
            this.Controls.Add(this.lb_page);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private Label label1;
    private Label lb_page;
    private Label lb_ttP;
    private Label lb_UpP;
    private Label lb_ttU;
    private Button btn_back;
    private Button btn_next;
    private Label page;
    private Label perPage;
    private Label totalPages;
    private Label total;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ProgressBar pb;
}