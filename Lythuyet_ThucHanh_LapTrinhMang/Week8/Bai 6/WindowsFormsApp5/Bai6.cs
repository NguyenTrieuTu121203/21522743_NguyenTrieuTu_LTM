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
using System.IO;
using System.Xml;
using HtmlAgilityPack;

namespace WindowsFormsApp5
{
    
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        

        

        void OpenURLInBrowser(string url)
        {

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            try
            {
                //webBrowser1.Navigate(new Uri(url));

                Form st= new Form();
                using (WebClient client = new WebClient())
                {
                    // Tải nội dung HTML của trang web
                    string html = client.DownloadString(url);

                    // Tạo đối tượng HtmlDocument và tải nội dung HTML đã tải
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                       
                        // Hiển thị nội dung HTML trong WebBrowser Control
                        RichTextBox show = new RichTextBox();
                       /* List<string> imageUrls = new List<string>();
                        var imageNodes = doc.DocumentNode.Descendants("img");
                        foreach (var imageNode in imageNodes)
                        {
                            string imageUrl = imageNode.GetAttributeValue("src", "");
                            if (!string.IsNullOrEmpty(imageUrl))
                            {
                                imageUrls.Add(imageUrl);
                            }
                        }

                        // Trích xuất tiêu đề từ trang web
                        var titleNode = doc.DocumentNode.SelectSingleNode("//title");
                        string title = titleNode?.InnerText;*/

                        // Hiển thị thông tin trong các điều khiển Windows Forms
                       
                    string cssContent = "<style>body { font-family: Arial, sans-serif; }</style>";
                    string htmlContent = doc.DocumentNode.OuterHtml;

                    // Hiển thị dữ liệu trong WebBrowser Control
                    DisplayCrawledData(htmlContent, cssContent);
                    show.Height = 400;
                        show.Width = 900;
                        show.ReadOnly = true;
                        st.Controls.Add(show);
                    // st.Show();
                    byte[] htmlBytes = client.DownloadData(url);
                    int totalBytes = htmlBytes.Length;
                    int crawledBytes = 0;
                    while (crawledBytes < totalBytes)
                    {
                        // Simulate crawling a certain number of bytes
                        int bytesCrawled = Math.Min(totalBytes - crawledBytes, 1024);
                        crawledBytes += bytesCrawled;

                        // Update the progress bar based on the crawled bytes
                        UpdateProgressBar(crawledBytes, totalBytes);
                    }
                }
            }
            catch (System.UriFormatException)
            {
                return;
            }
           
        }
        void UpdateProgressBar(int crawledBytes, int totalBytes)
        {
            // Calculate the progress percentage
            int progressPercentage = (int)((double)crawledBytes / totalBytes * 100);

            // Update the progress bar control with the calculated percentage
            // Replace "progressBar" with the actual name of your progress bar control
            progressBar1.Value = progressPercentage;
        }
        private void DisplayCrawledData(string htmlContent, string cssContent)
        {
            // Tạo một chuỗi HTML hoàn chỉnh bằng cách kết hợp dữ liệu đã crawl với CSS đã nhúng
            StringBuilder htmlBuilder = new StringBuilder();
            htmlBuilder.AppendLine("<html>");
            htmlBuilder.AppendLine("<head>");
            htmlBuilder.AppendLine(cssContent);
            htmlBuilder.AppendLine("</head>");
            htmlBuilder.AppendLine("<body>");
            htmlBuilder.AppendLine(htmlContent);
            htmlBuilder.AppendLine("</body>");
            htmlBuilder.AppendLine("</html>");

            // Hiển thị chuỗi HTML trong WebBrowser Control
            WebBrowser webBrowser = new WebBrowser();
            webBrowser1.DocumentText = htmlBuilder.ToString();

            
        }   
        
       

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;  // Giá trị tối đa

        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUrlInput.Text) || txtUrlInput.Text.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                txtUrlInput.Focus();
                return;
            }
            OpenURLInBrowser(txtUrlInput.Text);
        }

        private void btnSourse_Click(object sender, EventArgs e)
        {
            Form sr = new Form();
            sr.Height = 400;
            sr.Width = 900;
            RichTextBox show = new RichTextBox();
            show.Height = 400;
            show.Width = 900;
            show.ReadOnly = true;
            sr.Controls.Add(show);
            string uri = txtUrlInput.Text;
            WebRequest request = WebRequest.Create(uri);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            show.Text = responseFromServer;
            response.Close();
            sr.Show();
        }
    }
}
