using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
namespace baith4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string url = txtInputData.Text;
            string outputFolder = @"C:\Users\Ngo Minh Quan\source\repos\baith4.2\baith4.2\src";
            string filePath = Path.Combine(outputFolder, "webpage.html");

            await DownloadAndSaveHtml(url, filePath);

            // Hiển thị nội dung trang web lên form
            string html = File.ReadAllText(filePath);
            webBrowser1.DocumentText = html;
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtInputData.Text;
            string outputFolder = @"C:\Users\Ngo Minh Quan\source\repos\baith4.2\baith4.2\src";

            DownloadResources(url, outputFolder);
        }

        private async Task DownloadAndSaveHtml(string url, string filePath)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    using (Stream contentStream = await response.Content.ReadAsStreamAsync(),
                                  fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await contentStream.CopyToAsync(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu cần thiết)
                MessageBox.Show("Đã xảy ra lỗi khi tải và lưu trang web: " + ex.Message);
            }
        }

        

        
        private async void DownloadResources(string url, string outputFolder)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string html = await client.GetStringAsync(url);

                    // Tạo một thư mục mới nếu thư mục đầu ra chưa tồn tại
                    Directory.CreateDirectory(outputFolder);

                    HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();
                    htmlDocument.LoadHtml(html);

                    var resourceUrls = GetResourceUrls(htmlDocument);

                    foreach (var resourceUrl in resourceUrls)
                    {
                        string fileName = Path.GetFileName(resourceUrl);
                        string outputPath = Path.Combine(outputFolder, fileName);

                        using (HttpResponseMessage response = await client.GetAsync(resourceUrl))
                        using (Stream contentStream = await response.Content.ReadAsStreamAsync())
                        using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
                        {
                            await contentStream.CopyToAsync(fileStream);
                        }
                    }

                    MessageBox.Show("Tải xuống thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải xuống: " + ex.Message);
                }
            }
        }

        private List<string> GetResourceUrls(HtmlAgilityPack.HtmlDocument htmlDocument)
        {
            List<string> resourceUrls = new List<string>();

            var imgElements = htmlDocument.DocumentNode.SelectNodes("//img[@src]");
            var linkElements = htmlDocument.DocumentNode.SelectNodes("//link[@href]");
            var scriptElements = htmlDocument.DocumentNode.SelectNodes("//script[@src]");

            if (imgElements != null)
            {
                foreach (var imgElement in imgElements)
                {
                    string imgUrl = imgElement.GetAttributeValue("src", "");
                    resourceUrls.Add(imgUrl);
                }
            }

            if (linkElements != null)
            {
                foreach (var linkElement in linkElements)
                {
                    string linkUrl = linkElement.GetAttributeValue("href", "");
                    resourceUrls.Add(linkUrl);
                }
            }

            if (scriptElements != null)
            {
                foreach (var scriptElement in scriptElements)
                {
                    string scriptUrl = scriptElement.GetAttributeValue("src", "");
                    resourceUrls.Add(scriptUrl);
                }
            }

            return resourceUrls;
        }

        
    }
}
