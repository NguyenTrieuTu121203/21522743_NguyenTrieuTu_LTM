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
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Client : Form
    {

        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connected();
        }
        IPEndPoint ipep;
        Socket client;

        private void button1_Click(object sender, EventArgs e)
        {
            Send();
            textBox2.Clear();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        void Received()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string text = (string)Deserialize(data);
                    listView1.Items.Add(new ListViewItem(text));
                }
            }
            catch
            {
                Close();
            }
        }

        void Send()
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                string text = textBox1.Text + ": " + textBox2.Text;
                client.Send(Serialize(text));
            }
        }


        void Connected()
        {
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                client.Connect(ipep);
            }
            catch
            {
                MessageBox.Show("Khong the ket noi toi server!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Received);
            listen.IsBackground = true;
            listen.Start();
        }


        void Close()
        {
            client.Close();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream mmStream = new MemoryStream();
            BinaryFormatter bnrFormatter = new BinaryFormatter();
            bnrFormatter.Serialize(mmStream, obj);
            return mmStream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream mmStream = new MemoryStream(data);
            BinaryFormatter bnrFormatter = new BinaryFormatter();
            return bnrFormatter.Deserialize(mmStream);

        }


    }
}
