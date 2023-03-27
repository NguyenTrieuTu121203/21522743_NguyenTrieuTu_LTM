namespace BaiThucHanhLab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Lab01_BaiTap1 _BaiTap1 = new Lab01_BaiTap1();
            _BaiTap1.ShowDialog();
            
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Lab01_BaiTap2 _BaiTap2 = new Lab01_BaiTap2();
            _BaiTap2.ShowDialog();  
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            Lab01_BaiTap3 _BaiTap3 = new Lab01_BaiTap3();
            _BaiTap3.ShowDialog();  
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            Lab01_BaiTap4 _BaiTap4 = new Lab01_BaiTap4();
            _BaiTap4.ShowDialog();  
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Lab01_BaiTap5 _BaiTap5 =new Lab01_BaiTap5();
            _BaiTap5.ShowDialog();
        }
    }
}