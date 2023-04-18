namespace Lab02_LTM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void btnBai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai1 formBai1 = new FormBai1();
            formBai1.ShowDialog();
            this.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai2 formBai2 = new FormBai2(); 
            formBai2.ShowDialog();
            this.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai3 formBai3 = new FormBai3();
            formBai3.ShowDialog();
            this.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai4 formBai4 = new FormBai4();
            formBai4.ShowDialog();
            this.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai5 formBai5 = new FormBai5();
            formBai5.ShowDialog();
            this.Show();
        }
        private void btnBai6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBai6 formBai6 = new FormBai6();
            formBai6.ShowDialog();
            this.Show();
        }

        
    }
}