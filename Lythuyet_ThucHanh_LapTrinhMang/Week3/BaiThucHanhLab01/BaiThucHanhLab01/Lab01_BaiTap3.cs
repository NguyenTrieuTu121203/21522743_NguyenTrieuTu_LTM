using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhLab01
{
    public partial class Lab01_BaiTap3 : Form
    {
        public Lab01_BaiTap3()
        {
            InitializeComponent();
        }

        private void Form_BaiTap3_Load(object sender, EventArgs e)
        {
            txtResult.Enabled = false;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int num;
            bool IsNumber = int.TryParse(txtNumber.Text, out num);
            if (string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu !", "Error", MessageBoxButtons.OK);
                txtNumber.Focus();
            }
            else if (!IsNumber)
            {
                MessageBox.Show("Vui lòng nhập số nguyên !","Error", MessageBoxButtons.OK);
                txtNumber.Focus();
            }
            else
            {
                if(num >= 0 && num <=9) 
                    txtResult.Text = ReadNumber(num);
                else
                {
                    MessageBox.Show("Vui lòng nhập số từ 0 tới 9 !", "Error", MessageBoxButtons.OK);
                    txtNumber.Focus();
                }
                    
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            txtResult.Text = "Empty";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string ReadNumber(int num)
        {
            if (num == 0) return "Không";
            else if (num == 1) return "Một";
            else if (num == 2) return "Hai";
            else if (num == 3) return "Ba";
            else if (num == 4) return "Bốn";
            else if (num == 5) return "Năm";
            else if (num == 6) return "Sáu";
            else if (num == 7) return "Bảy";
            else if (num == 8) return "Tám";
            else return "Chín";
        }

        
    }
}
