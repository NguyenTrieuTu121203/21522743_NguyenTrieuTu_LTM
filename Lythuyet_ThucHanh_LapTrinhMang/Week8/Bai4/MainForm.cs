using System.Net;
using System;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing;

namespace Bai4;

public partial class MainForm : Form
{
    private int _page;
    private int _totalPages;

    public MainForm()
    {
        InitializeComponent();
        _page = 1;
        _totalPages = 0;
        DisableButtons();
    }
    
    // Cài đặt nút "<<"
    private async void btn_back_Click(object sender, EventArgs e)
    {
        if (_page > 1)
        {
            _page--;
            DisableButtons();
            await GetPage();
        }
    }
    // Cài đặt nút ">>"
    private async void btn_next_Click(object sender, EventArgs e)
    {
        if (_page < _totalPages)
        {
            _page++;
            DisableButtons();
            await GetPage();
        }
    }

    private void DisableButtons()
    {
        btn_back.Enabled = false;
        btn_next.Enabled = false;
    }

    private async void MainForm_Load(object sender, EventArgs e) => await GetPage();

    private async Task GetPage()
    {
        // Tạo biến lưu địa chỉ URL của trang web bạn muốn truy cập
        var url = $"https://reqres.in/api/users?page={_page}";

        // Tạo đối tượng HttpClient
        using var client = new HttpClient();

        try
        {
            // Gửi yêu cầu GET và nhận phản hồi
            var response = await client.GetAsync(url);

            // Kiểm tra xem yêu cầu đã thành công hay không
            response.EnsureSuccessStatusCode();

            // Đọc nội dung phản hồi như một chuỗi
            var responseBody = await response.Content.ReadAsStringAsync();

            // Phân tách nội dung thành các dòng
            var pageScheme = JsonSerializer.Deserialize<PageScheme>(responseBody);

            if (pageScheme == null) return;
            page.Text = $"{pageScheme.Page}";
            perPage.Text = $"{pageScheme.PerPage}";
            total.Text = $"{pageScheme.Total}";
            totalPages.Text = $"{pageScheme.TotalPages}";
            _totalPages = pageScheme.TotalPages;

            // Khởi tạo ImageList
            var imageList = new ImageList
            {
                ImageSize = new Size(64, 64),
                ColorDepth = ColorDepth.Depth32Bit
            };
            if (pageScheme.Data == null) return;

            // Xóa dữ liệu hiện có trong ListView
            listView1.Items.Clear();

            pb.Value = 10;
            foreach (var user in pageScheme.Data)
            {
                // Thêm hình ảnh vào ImageList
                var imageStream = await client.GetStreamAsync(user.Avatar);
                var avatar = Image.FromStream(imageStream);
                imageList.Images.Add($"{user.Id}", avatar);
                if (pb.Value < 90)
                    pb.Increment(15);
            }

            // Set LargeImageList của ListView thành imageList
            listView1.LargeImageList = imageList;

            foreach (var user in pageScheme.Data)
            {
                // Thêm các dòng vào ListView
                var userItem = new ListViewItem
                {
                    Text = user.FirstName + " " + user.LastName,
                    ImageKey = $"{user.Id}",
                };

                userItem.SubItems.Add(user.Email);

                listView1.Items.Add(userItem);
            }

            pb.Value = 100;

            listView1.Refresh();

            // Nếu chỉ số _page bằng _totalPages => cuối danh sách trang
            if (_page == _totalPages)
            {
                btn_back.Enabled = true;
                btn_next.Enabled = false;
            }

            // Nếu chỉ số _page bằng 1 => đầu danh sách trang
            if (_page == 1)
            {
                btn_back.Enabled = false;
                btn_next.Enabled = _totalPages > 1;
            }

            pb.Value = 0;
        }
        catch (HttpRequestException ex)
        {
            // Xử lý lỗi nếu có
            MessageBox.Show($"Đã xảy ra lỗi HTTP: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void pb_Click(object sender, EventArgs e)
    {

    }
}