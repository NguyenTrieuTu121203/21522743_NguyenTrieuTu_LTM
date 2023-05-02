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
    public partial class TCPclient : Form
    {
        TcpClient tcpClient = new TcpClient();
        NetworkStream ns;

        public TCPclient()
        {
            InitializeComponent();
        }

        private void TCPclient_Load(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            IPEndPoint ipePoint = new IPEndPoint(ipAddress, 8080);
            tcpClient.Connect(ipePoint);
            ns = tcpClient.GetStream();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes("Hello Server\n");
            ns.Write(data, 0, data.Length);

        }

        private void TCPclient_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void TCPclient_FormClosing(object sender, FormClosingEventArgs e)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes("quit\n");
            ns.Write(data, 0, data.Length);
            ns.Close();
            tcpClient.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
