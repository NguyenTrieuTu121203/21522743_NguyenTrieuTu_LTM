using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace th3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            client f = new client();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            sever f = new sever();
            f.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sever f = new sever();
            f.Show();
        }
    }
}
