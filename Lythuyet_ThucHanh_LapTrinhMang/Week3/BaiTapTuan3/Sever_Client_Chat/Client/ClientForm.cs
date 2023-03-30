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

namespace Client
{
    public partial class ClientForm : Form
    {

        string IpLocal="127.0.0.1";
        int Port = 9999;
        Socket Client;
        public ClientForm()
        {
            InitializeComponent();
            
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            lsViewMessage.View = View.List;
            txtIP_Address.Text = IpLocal;
            txtPort.Text = Port.ToString();
            txtIP_Address.Text = IpLocal;
            txtIP_Address.Enabled = false;
            txtPort.Enabled = false;    
        }

        private void btnConnectSever_Click(object sender, EventArgs e)
        {
            
            // xử lý đụng độ khi sử dụng tài nguyên 
            CheckForIllegalCrossThreadCalls = false;
            if (ConnectToSever())
            {
                MessageBox.Show("Kết nối thành công với Sever", "Thông báo", MessageBoxButtons.OK);
                // khi kết nối thành công sẽ không cho nhấn nút kết nối nữa
                btnConnectSever.Enabled = false;
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Chưa nhập tin nhắn", "Error", MessageBoxButtons.OK);
                txtMessage.Focus();
            }
            else
            {
                ClientSend();
                lsViewMessage.Items.Add(">> Client: " + txtMessage.Text);
                txtMessage.Clear();
            }
            
        }


        private bool ConnectToSever()
        {
            IPEndPoint Ip = new IPEndPoint(IPAddress.Parse(IpLocal), Port);
            Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                // Cố gắng kết nối 
                Client.Connect(Ip);
            }
            catch
            {
                MessageBox.Show("Không kết nối được", "Error", MessageBoxButtons.OK);
                return false;
            }
            // Tạo luồng để nhận dữ liệu từ sever
            Thread Listen = new Thread(ClientReciveData);
            Listen.IsBackground = true;
            Listen.Start();
            return true;

        }

        private void ClientSend()
        {
           
            if (Client != null)
            {
                byte[] ByteMessage;
                ByteMessage = ConvertStringToByte(">> Client: " + txtMessage.Text);
                Client.Send(ByteMessage);
            }
            else
            {
                MessageBox.Show("Bạn nhấn nút Connect để Sever có thể nhận dược tin nhắn! ", "Error", MessageBoxButtons.OK);
            }

        }
        private void ClientReciveData()
        {
            try
            {
                while (true)
                {
                    //khai báo một mảng byte để chứa dữ liệu
                    byte[] Data = new byte[1024 * 5000];
                    // đổ dữ liệu vừa nhận được vào mảng byte  
                    Client.Receive(Data);
                    // chuyển dữ liệu vừa nhận thành chuỗi 
                    string StringMessage = ConvertByteToString(Data);
                    lsViewMessage.Items.Add(StringMessage);
                }
            }
            catch
            {
                Close();
            }

        }
        private void ClientCloseConnet()
        {
            Client.Close();
        }
        
        private string ConvertByteToString(byte[] data)
        {
            return Encoding.UTF8.GetString(data);
        }

        private byte[] ConvertStringToByte(string data)
        {
            return Encoding.UTF8.GetBytes(data);
        }

        
    }
}