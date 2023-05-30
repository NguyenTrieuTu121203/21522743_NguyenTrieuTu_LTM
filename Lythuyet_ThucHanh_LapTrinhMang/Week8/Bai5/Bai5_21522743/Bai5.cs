using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;



namespace Bai5_21522743
{
    public partial class Bai5Form : Form
    {
        public Bai5Form()
        {
            InitializeComponent();
            txtData.ReadOnly = true;
            txtUrl.Focus();
        }

        private bool CheckInputData()
        {
            if (string.IsNullOrEmpty(txtUrl.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                return false;
            }
            return true;
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            // Gửi dữ liệu lên API
            try
            {
                if (!CheckInputData())
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Báo Lỗi", MessageBoxButtons.OK);
                    txtUrl.Focus();
                }
                // Tạo dữ liệu cần gửi lên API
                var payload = new JObject()
                {
                    {"email",txtEmail.Text },
                    {"password",txtPassword.Text}
                };
                // tạo đối tượng http client để gửi y/c http 
                using (var httpClient = new HttpClient())
                {
                    // Gửi yêu cầu Post lên API
                    var response = await httpClient.PostAsync(txtUrl.Text, new StringContent(payload.ToString(), System.Text.Encoding.UTF8, "application/json"));
                    var responseContent = await response.Content.ReadAsStringAsync();
                    // Trích xuất thông tin trường "token" từ chuỗi JSON
                    var responseJson = JObject.Parse(responseContent);
                    //Hiển thị token trên text box 
                    txtData.Text = responseJson["token"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
