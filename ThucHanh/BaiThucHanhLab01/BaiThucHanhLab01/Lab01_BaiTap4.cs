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
    public partial class Lab01_BaiTap4 : Form
    {
        public Lab01_BaiTap4()
        {
            InitializeComponent();
        }

        private void Form_BaiTap4_Load(object sender, EventArgs e)
        {
            txtResult.Enabled = false; 
            txtTyGia.Text = "Empty";

            // Chỉ cho chọn từ list của comboBox ==> Không cho điền vào comboBox
            comboBoxMoney.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMoney.AutoCompleteMode = AutoCompleteMode.None;
        }


        private void btnConvertMoney_Click(object sender, EventArgs e)
        {
            long money;
            bool IsNumber = long.TryParse(txtAmountOfMoney.Text, out money);
            // kiểm tra dữ liệu
            if (CheckDataIsEmpty())
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hoặc chọn mã tiền tệ !", "Error", MessageBoxButtons.OK);
                txtAmountOfMoney.Focus();
            }
            else if (!IsNumber)
            {
                MessageBox.Show("Vui lòng nhập số tiền!", "Error", MessageBoxButtons.OK);
                txtAmountOfMoney.Focus();
            }
            else
            {
                // Đổi tiền 
                money = money *GetDenominations();
                // Xuất kết quả sau khi đổi tiền
                txtResult.Text = money.ToString("n0");
            }
        }
        // Lấy tỷ giá tiền
        private long GetDenominations()
        {
            if (comboBoxMoney.SelectedItem.ToString() == "USD")
            {
                txtTyGia.Text = "1 USD = 22,775 VND";
                return 22775;
            }
            else if (comboBoxMoney.SelectedItem.ToString() == "EUR")
            {
                txtTyGia.Text = "1 EUR = 28,132 VND";
                return 28132;
            }
            else if (comboBoxMoney.SelectedItem.ToString() == "GBP")
            {
                txtTyGia.Text = "1 GBP = 31,538 VND";
                return 31538;
            }
            else if (comboBoxMoney.SelectedItem.ToString() == "SGD")
            {
                txtTyGia.Text = "1 SDG = 17,286 VND";
                return 17286;
            }
            else if (comboBoxMoney.SelectedItem.ToString() == "JPY")
            {
                txtTyGia.Text = "1 JPY = 214 VND";
                return 214;
            }
            txtTyGia.Text = "Empty";
            return 0;
        }

        // Kiểm tra dữ liệu đã điền hay chưa
        private bool CheckDataIsEmpty()
        {
            if (string.IsNullOrEmpty(txtAmountOfMoney.Text) || string.IsNullOrEmpty(comboBoxMoney.Text)) 
                return true;
            return false;
        }
        
        
    }
}
