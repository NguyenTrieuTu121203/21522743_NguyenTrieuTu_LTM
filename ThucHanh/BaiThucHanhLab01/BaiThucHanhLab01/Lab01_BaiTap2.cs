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
    public partial class Lab01_BaiTap2 : Form
    {
       
        public Lab01_BaiTap2()
        {
            InitializeComponent();
        }

        private void Form_BaiTap2_Load(object sender, EventArgs e)
        {
            // Reset dữ liệu khi Form được mở
            txtMinNum.Text = "0";
            txtMaxNum.Text = "0";   
            txtMaxNum.Enabled = false;
            txtMinNum.Enabled = false;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            float number1 = 0f,
                  number2 = 0f, 
                  number3 = 0f;
            // Kiểm tra phải dứ liệu phải là số 
            bool IsNumber = float.TryParse(txtNumber1.Text, out number1)
                            && float.TryParse(txtNumber2.Text, out number2)
                            && float.TryParse(txtNumber3.Text, out number3);
            if (CheckDataIsEmpty())
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu ! Vui lòng nhập dữ liệu", "Error", MessageBoxButtons.OK);
                txtNumber1.Focus();
            }
            else if (!IsNumber)
            {
                MessageBox.Show("Vui lòng nhập số !", "Error", MessageBoxButtons.OK);
                txtNumber1.Focus();
            }
            else
            {
                txtMaxNum.Text = FindMax(number1, number2, number3).ToString();
                txtMinNum.Text = FindMin(number1, number2, number3).ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
            txtNumber3.Clear();
            txtMaxNum.Text = "0";
            txtMinNum.Text = "0";
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Kiểm tra dữ liệu đã điền hay chưa
        private bool CheckDataIsEmpty()
        {
            if(string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text) || string.IsNullOrEmpty(txtNumber3.Text))
                return true;
            return false;
        }
        private float FindMax(float num1,float num2,float num3)
        {
            if (num1 >= num2 && num1 >= num3) return num1;
            else if(num2 >= num1 && num2 >= num3) return num2;
            else if(num3>= num1 && num3 >= num2) return num3;
            return 0;
        }
        private float FindMin(float num1, float num2, float num3)
        {
            if (num1 <= num2 && num1 <= num3) return num1;
            else if (num2 <= num1 && num2 <= num3) return num2;
            else if (num3 <= num1 && num3 <= num2) return num3;
            return 0;
        }

    }
}
