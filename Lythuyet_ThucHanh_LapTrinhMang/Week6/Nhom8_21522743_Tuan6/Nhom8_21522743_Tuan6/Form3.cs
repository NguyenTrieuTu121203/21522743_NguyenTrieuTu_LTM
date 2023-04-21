using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ZedGraph;



namespace Nhom8_21522743_Tuan6
{
    public partial class Form3 : Form
    {

        // Bài này bọn em sẽ sử dụng ZedGraph để làm 

        private GraphPane graphPane;
        public Form3()
        {
            InitializeComponent();
            // Khởi tạo  GraphPane
            graphPane = zedGraphControlFinance.GraphPane;
            graphPane.Title.Text = "Giá chứng khoán";
            graphPane.XAxis.Title.Text = "Thời gian";
            graphPane.YAxis.Title.Text = "Giá";

            // Thiết lập kiểu dữ liệu _ Cột X
            graphPane.XAxis.Type = AxisType.Date;
            graphPane.XAxis.Scale.Format = "yyyy-MM-dd";

            // Thiết lập kiểu dữ liệu _ Cột Y
            graphPane.YAxis.Type = AxisType.Linear;
            graphPane.YAxis.Scale.Format = "$#,##0";

            // Thiết lập kiểu đường vẽ
            LineItem curve = graphPane.AddCurve("", new PointPairList(), Color.Blue, SymbolType.None);
            curve.Line.Width = 2;

            
            zedGraphControlFinance.IsShowPointValues = true;
            zedGraphControlFinance.PointValueEvent += new ZedGraphControl.PointValueHandler(PointValueHandler);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            string url = "https://api.coincap.io/v2/assets/bitcoin/history?interval=d1&start=1612137600000&end=1619827200000";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        
                        JObject data = JObject.Parse(content);
                        // Lấy data cho biểu đồ 
                        List<Price> prices = JsonConvert.DeserializeObject<List<Price>>(data["data"].ToString());
                        // Lấy data cho dataGridView
                        List<Asset> assets = JsonConvert.DeserializeObject<List<Asset>>(data["data"].ToString());

                        // Đưa dữ liệu vài dataGridview
                        dataGridView.DataSource = assets;

                        // Đưa dữ liệu vào biểu đồ đ
                        PointPairList pointPairList = new PointPairList();
                        foreach (Price price in prices)
                        {
                            DateTime dateTime = DateTimeOffset.FromUnixTimeMilliseconds(price.time).DateTime;
                            pointPairList.Add(new XDate(dateTime), price.priceUsd);
                        }
                        graphPane.CurveList[0].Points = pointPairList;
                        zedGraphControlFinance.AxisChange();
                        zedGraphControlFinance.Invalidate();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi kết nối API.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string PointValueHandler(ZedGraphControl control, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair point = curve[iPt];
            DateTime dateTime = DateTime.FromOADate(point.X);
            return $"Ngày: {dateTime.ToString("yyyy-MM-dd")}, Giá: {point.Y.ToString("$#,##0.00")}";
        }
    }
    // Hiển thị lên biểu đồ 
    public class Price
    {
        public long time { get; set; }
        public double priceUsd { get; set; }
    }

    // Hiển thị lên dataGridview 
    public class Asset
    {
        
        public string priceUsd { get; set; }
        
    }
}
