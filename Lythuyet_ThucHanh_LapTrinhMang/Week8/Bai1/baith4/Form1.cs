using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baith4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            string url = txtInput.Text;
            string html = await GetHtmlFromUrl(url);

            // Xóa dữ liệu hiện có trong listView1
            lsData.Items.Clear();

            // Hiển thị nội dung HTML trong listView1
            lsData.Items.Add(html);
        }

        private async Task<string> GetHtmlFromUrl(string url)
        {
            string html = string.Empty;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    html = await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu cần thiết)
                MessageBox.Show("Đã xảy ra lỗi khi tải trang web: " + ex.Message);
            }

            return html;
        }

        
    }
}
