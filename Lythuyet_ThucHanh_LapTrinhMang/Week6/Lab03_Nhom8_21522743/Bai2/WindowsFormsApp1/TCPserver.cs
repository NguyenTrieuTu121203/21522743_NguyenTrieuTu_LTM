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
    public partial class TCPserver : Form
    {
        public TCPserver()
        {
            InitializeComponent();


        }
        void startThread()
        {
            int bytesReceited = 0;
            byte[] recv = new byte[1];
            Socket clientSocket;
            Socket listenedSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));
            listenedSocket.Bind(ipepServer);
            listenedSocket.Listen(-1);
            clientSocket = listenedSocket.Accept();
            listView1.Items.Add(new ListViewItem("New client connected"));
            while (clientSocket.Connected)
            {
                string text = "";
                do
                {
                    bytesReceited = clientSocket.Receive(recv);
                    text += Encoding.ASCII.GetString(recv);
                } while (text[text.Length - 1] != '\n');
                listView1.Items.Add(new ListViewItem(text));


            }
            listenedSocket.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TCPserver_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread t = new Thread(new ThreadStart(startThread));
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
