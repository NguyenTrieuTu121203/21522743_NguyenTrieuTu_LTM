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

namespace Nhom8_21522743_Tuan6
{
    
    public partial class Form2 : Form
    {

        private const string API_URL = "https://randombig.cat/roar.json";
        public Form2()
        {
            InitializeComponent();
        }

        private async void btnGetCat_Click(object sender, EventArgs e)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync(API_URL);

                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(data);
                        string imageUrl = result.url.ToString();

                        using (HttpClient imageClient = new HttpClient())
                        {
                            HttpResponseMessage imageResponse = await imageClient.GetAsync(imageUrl);

                            if (imageResponse.IsSuccessStatusCode)
                            {
                                pictureBox1.Load(imageUrl);
                            }
                            else
                            {
                                MessageBox.Show("Không thấy ảnh mèo", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thấy ảnh mèo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
