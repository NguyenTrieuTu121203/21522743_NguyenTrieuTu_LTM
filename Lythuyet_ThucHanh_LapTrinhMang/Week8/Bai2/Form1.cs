using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void download_Click(object sender, EventArgs e)
        {
            // Khởi tạo đổi tượng WebClient mới
            WebClient myClient = new WebClient();
            // OpenRead() để đọc nội dung trang web vào một Stream
            Stream response = myClient.OpenRead(urlBox.Text);
            // Tải tệp từ URL và lưu vào đường dẫn
            myClient.DownloadFile(urlBox.Text, linkBox.Text);
            try
            {
                //gọi lại hàm lấy dữ liệu và xuất ra 
                string s = getHTML(urlBox.Text);
                htmlBox.Text = s;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //hàm lấy dữ liệu từ web
        private string getHTML(string szURL)
        {
            // Tạo yêu cầu tới đường dẫn URL 
            WebRequest request = WebRequest.Create(szURL);
            // Nhận phản hồi
            WebResponse response = request.GetResponse();
            // Nhận luồng chứa nội dung được trả về bởi máy chủ
            Stream dataStream = response.GetResponseStream();
            // Mở luồng bằng stream 
            StreamReader reader = new StreamReader(dataStream);
            // Đọc nôi dung
            string responseFromServer = reader.ReadToEnd();
            // Đóng và kết thúc 
            response.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
