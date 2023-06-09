﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //timer component calls this at fixed time intervals, to maintain
        private void timer1_Tick(object sender, EventArgs e)
        {
           Program.server.Update();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.databaseDataSet.Users);
            string hostName = Dns.GetHostName(); // retrive the Name of HOST  
            // Get the IP  
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            label1.Text = "Server's IP address is: " + myIP;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.databaseDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy1(this.databaseDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy2(this.databaseDataSet.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void DebugTextBox_TextChanged(object sender, EventArgs e)
        {

            if (DebugTextBox.Lines.Count() > 200)
            {
                DebugTextBox.Clear();
            }
        }
    }
}
