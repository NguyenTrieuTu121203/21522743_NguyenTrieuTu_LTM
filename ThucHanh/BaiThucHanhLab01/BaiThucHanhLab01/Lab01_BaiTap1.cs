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
    public partial class Lab01_BaiTap1 : Form
    {
        public Lab01_BaiTap1()
        {
            InitializeComponent();
        }

        private void Form_BaiTap1_Load(object sender, EventArgs e)
        {

            txtResult.Enabled = false;
            txtResult.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SumOfNumber();
            
        }

        private void SumOfNumber()
        {
            int Number1 = 0;
            int Number2 = 0;
            int sum = 0;
            bool IsNumber = int.TryParse(txtNumber1.Text, out Number1) 
                            && int.TryParse(txtNumber2.Text, out Number2);
            if(CheckDataIsEmpty())
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu !", "Error", MessageBoxButtons.OK);
                txtNumber1.Focus();
            }
            else if(!IsNumber)
            {
                MessageBox.Show("Vui lòng nhập số nguyên !", "Error", MessageBoxButtons.OK);
                txtNumber1.Focus(); 
                ClearData();
            }
            else
            {
                sum = Number1 + Number2;
                txtResult.Text = sum.ToString();
            }
        }

        private bool CheckDataIsEmpty()
        {
            if(string.IsNullOrEmpty(txtNumber1.Text) || string.IsNullOrEmpty(txtNumber2.Text)) 
                return true;
            return false;
        }


        // Xóa dữ liệu sau khi tính xong

        private void ClearData()
        {
            txtNumber1.Clear();
            txtNumber2.Clear();
        }
       
    }
}
