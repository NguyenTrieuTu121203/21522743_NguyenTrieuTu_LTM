using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace th3._1
{
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the IP address and port number from the text boxes
            string ip = textBox1.Text;
            int port = int.Parse(textBox2.Text);

            // Get the message to send from the richtextbox
            string message =richTextBox1.Text;

            // Create a UdpClient to send the message
            using (UdpClient udpClient = new UdpClient())
            {
                // Convert the message to bytes
                byte[] messageBytes = System.Text.Encoding.ASCII.GetBytes(message);

                // Create an IPEndPoint with the IP address and port number
                IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ip), port);

                // Send the message to the remote endpoint
                udpClient.Send(messageBytes, messageBytes.Length, remoteEP);
            }
        }

        private void client_Load(object sender, EventArgs e)
        {

        }
    }

}
