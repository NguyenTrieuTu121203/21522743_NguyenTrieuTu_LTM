using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace th3._1
{
    public partial class sever : Form
    {
        private object server;


        private void StartServer()
        {
           
            // Create a new UDP client on port 8080
            UdpClient udpClient = new UdpClient(8080);

            // Continuously listen for incoming messages from the client
            while (true)
            {
                // Wait for a message to arrive
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] receiveBytes = udpClient.Receive(ref remoteEndPoint);

                // Convert the received bytes into a string
                string message = Encoding.ASCII.GetString(receiveBytes);

                // Check if the message came from the expected client
                if (remoteEndPoint.Address.ToString() == "127.0.0.1" && remoteEndPoint.Port == 8080)
                {
                    // Display the message on the RichTextBox1 control
                    Invoke((MethodInvoker)delegate {
                        richTextBox1.AppendText(message + "\n");
                    });
                }
            }
        }
        public sever()
        {
            InitializeComponent();
            Thread serverThread = new Thread(new ThreadStart(this.serverThread));
            serverThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread serverThread = new Thread(StartServer);
            serverThread.Start();
           
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(8080);
            string message;
            IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.ASCII.GetString(receiveBytes);
                message = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(message + "\n");
                    }));
                }
                else
                {
                    richTextBox1.AppendText(message + "\n");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
