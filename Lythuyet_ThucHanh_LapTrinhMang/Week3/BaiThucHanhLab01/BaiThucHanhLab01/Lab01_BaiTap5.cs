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
    public partial class Lab01_BaiTap5 : Form
    {
        public Lab01_BaiTap5()
        {
            InitializeComponent();
        }

        private void Form_BaiTap5_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int numberA=0,
                numberB=0;
            bool IsNumber = int.TryParse(txtNumberA.Text, out numberA)
                            && int.TryParse(txtNumberB.Text, out numberB);
            if (CheckDataIsEmpty())
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu !", "Error", MessageBoxButtons.OK);
                txtNumberA.Focus();
            }
            else if (!IsNumber)
            {
                MessageBox.Show("Vui lòng nhập số nguyên !", "Error", MessageBoxButtons.OK);
                txtNumberA.Focus();
            }
            else{
                // Tính giai thừa số A
                int FactorialNumberA = CalFactorialNumber(numberA);
                // Tính giai thừa số B
                int FactorialNumberB = CalFactorialNumber(numberB);
                // In ra kết quả A! và B!
                DisplayResultFactorialNumber(lb_AFactorial, numberA, FactorialNumberA);
                DisplayResultFactorialNumber(lb_BFactorial, numberB, FactorialNumberB); 


                // Tính tổng dãy số cho số A
                int SumofNumberS1 = SumofNumbers(numberA);
                // Tính tổng dãy số cho số B
                int SumofNumberS2 = SumofNumbers(numberB);
                // In ra kết quả tính tổng dãy số của A,B
                DisplayResultSumOfNumbers(lbCaculateS1, numberA, SumofNumberS1);
                DisplayResultSumOfNumbers(lbCaculateS2, numberB, SumofNumberS2);    


                // Tính tổng dãy số A lũy thừa B
                int ResultPower = CalSumPower(numberA, numberB);
                // In ra kết quả tổng A lũy thừa B
                lbCaculateS3.Text = ResultPower.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ResetData();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }





        // Tính giai thừa số nguyên (Hàm này tính cho cả 2 số a và b)
        private int CalFactorialNumber(int num)
        {
            int mul = 1;
            for (int i = 1; i <= num; i++) mul *= i;
            return mul;
        }

        // Tính tổng dãy số  (Hàm này tính cho cả 2 số a và b)
        private int SumofNumbers(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++) sum += i;
            return sum;
        }

        // Tính lũy thừa
        private int CalSumPower(int num1,int num2)
        {
            int sum = 0;
            for(int i = 1; i <= num2; i++) 
                sum += (int)Math.Pow(num1, i);
            return sum;
        }

        // Hiển thị kết quả tính giai thừa
        private void DisplayResultFactorialNumber(Label lb,int num,int result)
        {
            lb.Text = num.ToString()+"!= "+result.ToString();
        }
        private void DisplayResultSumOfNumbers(Label lb, int num, int result)
        {
            for(int i = 1; i <= num; i++)
            {
                if(i==1) lb.Text = i.ToString();
                else lb.Text = lb.Text + "+" + i.ToString();
            }
            lb.Text += "=" + result.ToString();
        }

 
        private void ResetData()
        {
            txtNumberA.Clear();
            txtNumberB.Clear();
            lb_AFactorial.Text = "Chưa có dữ liệu để tính";
            lb_BFactorial.Text = "Chưa có dữ liệu để tính";
            lbCaculateS1.Text = "Chưa có dữ liệu để tính";
            lbCaculateS2.Text = "Chưa có dữ liệu để tính";
            lbCaculateS3.Text = "Chưa có dữ liệu để tính";
        }

        private bool CheckDataIsEmpty()
        {
            if (string.IsNullOrEmpty(txtNumberA.Text) || string.IsNullOrEmpty(txtNumberB.Text))
                return true;
            return false;
        }

        
    }
}
