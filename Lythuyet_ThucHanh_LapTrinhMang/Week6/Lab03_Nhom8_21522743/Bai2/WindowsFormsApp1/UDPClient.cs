using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
            textBox1.Text = "127.0.0.1";
            textBox2.Text = "8080";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(textBox4.Text);
            udpClient.Send(sendBytes, sendBytes.Length, textBox1.Text, Int32.Parse(textBox2.Text));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UDPClient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
