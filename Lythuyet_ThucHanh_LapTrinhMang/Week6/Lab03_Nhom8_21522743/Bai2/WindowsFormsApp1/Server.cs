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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint ipep;
        Socket server;
        List<Socket> clientList;
        string t;
        private void button1_Click(object sender, EventArgs e)
        {
            //Connected();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {
            Connected();
        }



        void Received(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    t = (string)Deserialize(data);
                    string text = client.RemoteEndPoint.ToString() + ": " + t;
                    listView1.Items.Add(new ListViewItem(text));
                    foreach (Socket item in clientList)
                    {
                        Send(item);
                    }

                }
            }
            catch
            {
                Close();
            }
        }

        void Send(Socket client)
        {
            if (t != string.Empty)
            {
                string text = t;
                client.Send(Serialize(text));
            }
        }


        void Connected()
        {
            clientList = new List<Socket>();
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listView1.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));

            server.Bind(ipep);


            Thread listen = new Thread(() =>
            {
                int i = 6789;
                try
                {
                    while (true)
                    {
                        string s = "New client connected from: 127.0.0.1:" + i.ToString();
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        listView1.Items.Add(new ListViewItem(s));
                        i++;
                        Thread received = new Thread(Received);
                        received.IsBackground = true;
                        received.Start(client);
                    }
                }
                catch
                {
                    ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }

            });

            listen.IsBackground = true;
            listen.Start();

        }


        void Close()
        {
            server.Close();
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
