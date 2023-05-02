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
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = "8080";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UDPServer_Load(object sender, EventArgs e)
        {

        }

        public void serverThread()
        {
            UdpClient udpClient = new UdpClient(Int32.Parse(textBox1.Text));
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                string returnData = Encoding.UTF8.GetString(receiveBytes);
                string mess = RemoteIpEndPoint.Address.ToString() + ":" + returnData.ToString();
                addMess(mess);
            }
        }
        public void addMess(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
