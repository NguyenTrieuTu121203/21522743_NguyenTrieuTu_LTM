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
using Newtonsoft.Json;

namespace Nhom8_21522743_Tuan6
{
    public partial class Form1 : Form
    {

        private readonly HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLink.Enabled = false;
            txtLink.Text = "https://jsonplaceholder.typicode.com/todos";
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var todos = JsonConvert.DeserializeObject<List<ToDoItem>>(responseContent);
                DisplayToDos(todos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving to-do list: {ex.Message}");
            }
        }

        private void DisplayToDos(List<ToDoItem> todos)
        {
            dataGridView.DataSource = todos;
        }


    }
    public class ToDoItem
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }
}
