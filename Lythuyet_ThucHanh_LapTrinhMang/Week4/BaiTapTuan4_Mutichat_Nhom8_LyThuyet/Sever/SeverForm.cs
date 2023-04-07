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

namespace Sever
{
    public partial class SeverForm : Form
    {

        int Port = 9999;
        Socket server;
        List<Socket> ClientList;

        public SeverForm()
        {
            InitializeComponent();
            // Xử lý đụng độ
            CheckForIllegalCrossThreadCalls =false;
            // Kết nối khi Form được mở 
            Connected_Clients();
        }

        private void SeverForm_Load(object sender, EventArgs e)
        {
            lsViewMessageSever.View = View.List;
        }
        private void btnSeverSend_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtMessageSever.Text))
            {
                MessageBox.Show("Chưa nhập tin nhắn", "Error", MessageBoxButtons.OK);
                txtMessageSever.Focus();
            }
            else
            {
                // Duyệt qua tất cả client và gửi dữ liệu qua các client có trong danh sách
                foreach (Socket client in ClientList) SeverSend(client);
                // Đưa vào list view
                lsViewMessageSever.Items.Add(">> Sever: " + txtMessageSever.Text);

                txtMessageSever.Clear();
            }
            
        }

        private void Connected_Clients()
        {
            
            ClientList = new List<Socket>();
            IPEndPoint Ip = new IPEndPoint(IPAddress.Any, Port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(Ip);

            
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        ClientList.Add(client);
                        // Tạo luồng đề nhận dữ liệu từ các client
                        Thread Receive = new Thread(ServerReciveData);
                        Receive.IsBackground = true;
                        Receive.Start(client);
                    }
                }
                catch
                {
                    // Hai câu lệnh bên dưới dùng để tránh lỗi khi có một hoặc nhiều client bất ngờ ngắt kết nối

                    Ip = new IPEndPoint(IPAddress.Any, Port);
                    server= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();

        }

        // Sever gửi dữ liệu đến các client
        private void SeverSend(Socket client)
        {
            byte[] ByteMessage;
            ByteMessage = ConvertStringToByte(">> Sever: " + txtMessageSever.Text);
            client.Send(ByteMessage);
        }
        private void ServerReciveData(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    // Tạo một mảng byte để chứa dữ liệu
                    byte[] Data = new byte[1024 * 5000];
                    client.Receive(Data);
                    string StringMessage = ConvertByteToString(Data);
                    // 
                    foreach(Socket c in ClientList)
                    {
                        
                        if (c != null && c!=client)
                        { 
                            // tin nhắn sẽ được đổi thành dạng byte và gửi đi cho tất cả client
                            c.Send(ConvertStringToByte(">> Client: "+StringMessage));   
                        }
                     
                    }
                    // Hiển thị lên list view của Server
                    lsViewMessageSever.Items.Add(">> Client: "+StringMessage);

                }
            }
            catch
            {
                // Xóa client ngắt kết nối ra khỏi danh sách client
                ClientList.Remove(client);
                client.Close();
            }

        }
        private void ClientCloseConnet()
        {
            server.Close();
        }

        
        
        private string ConvertByteToString(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        private byte[] ConvertStringToByte(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
