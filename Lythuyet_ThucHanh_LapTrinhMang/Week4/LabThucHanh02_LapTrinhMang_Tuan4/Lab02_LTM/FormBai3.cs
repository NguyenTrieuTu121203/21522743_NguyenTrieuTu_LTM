using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab02_LTM
{
    public partial class FormBai3 : Form
    {
        string data = "";
        string str = "";
        string dataDisplay="";
        string pathFile = "D:\\Ouput_Bai3.txt";
        List<string> listExpression = new List<string>();
        List<double> listResultExpression = new List<double>();

        public FormBai3()
        {
            InitializeComponent();
            
        }

        private void FormBai3_Load(object sender, EventArgs e)
        {
            txtData.ReadOnly = true;
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            // Kiểm tra đã chọn file chưa 
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Bạn chưa chọn file nhé", "Error", MessageBoxButtons.OK);
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            data = sr.ReadToEnd();
            data = data.Trim();
            txtData.Text = data;
            // Nếu file chứa những kí hiệu lạ hoặc không phải toán tử,không phải toán hạng sẽ thông báo và đóng form
            if(!IsExpression()) Close();

            // Lấy dữ liệu theo định dạng
            GetDataExpression();
            fs.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            GetResultExpression();
            DisplayInFileText();
            FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fs);


            // Kiểm tra xem đã đọc file trước khi tính hay chưa
            if (string.IsNullOrEmpty(dataDisplay))
            {
                MessageBox.Show("Chưa đọc file !!! Không có dữ liệu để tính", "Error", MessageBoxButtons.OK);
                return ;
            }

            // Tự động mở file txt ra màn hình 
            Process.Start("notepad.exe", pathFile);
            streamWriter.WriteLine(dataDisplay);
            streamWriter.Close();

        }

        private void DisplayInFileText()
        {
            for(int i = 0; i < listExpression.Count; i++)
            {
                dataDisplay+=listExpression[i].ToString().TrimEnd('\r', '\n') +"="+listResultExpression[i].ToString()+"\r\n";
            } 
        }
       

        // Theo định dạng của file thì mỗi dòng là một biểu thức
        // Ta có thể thấy môĩ lần xuống dòng là kết thúc một biểu thức
        // ==> Dựa vào dấu xuống dòng để xác nhận từng biểu thức
        private void GetDataExpression()
        {
            // Thêm vào một xuống dòng để tránh bị lỗi khi định dạng dữ liệu
            data += "\r\n";
            for(int i = 0; i < data.Length; i++)
            {
                
                if (data[i] != '\n') str += data[i].ToString();
                if(data[i]=='\n')
                {
                    // Thêm một biểu thức vào danh sách listExpression
                    listExpression.Add(str);
                    // Sau khi kết thúc str sẽ reset về rỗng để chứa biểu thức tiếp theo
                    str = "";
                }
            }
            
        }


        // Lấy kết quả của từng biểu thức lưu vào listResultExpression
        private void GetResultExpression()
        {
            double result = 0;
            for(int i = 0; i < listExpression.Count; i++)
            {
                // Tính toán kết quả của một biểu thức
                result = EvaluateExpression(listExpression[i]);
                // Đưa kết quả vừa tính vào listResultExpression
                listResultExpression.Add(result);
            }
        }

        // Kiểm tra biểu thức chỉ chứa toán hạng và toán tử
        private bool IsExpression()
        {
            for(int i = 0; i < data.Length; i++)
            {
                if ((data[i]!='+' && data[i]!='-' && data[i] != '/' && data[i] != '*') && (!char.IsDigit(data[i])) && data[i] !='\n' && data[i] != '\r')
                {
                    MessageBox.Show("Kiểm tra lại file text!! Có thể không đúng định dạng! Biểu thức phải là toán tử hoặc toán hạn !!!", "Error", MessageBoxButtons.OK);
                    return false;
                }  
            }
            return true;
        }

        // Tính toán biểu thức dùng stack
        double EvaluateExpression(string expression)
        {
            Stack<double> numbers = new Stack<double>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];

                if (Char.IsDigit(c))
                {
                    int numStart = i;
                    while (i < expression.Length && Char.IsDigit(expression[i]))
                    {
                        i++;
                    }
                    double num = double.Parse(expression.Substring(numStart, i - numStart));
                    numbers.Push(num);
                    i--;
                }
                else if (c == '(')
                {
                    operators.Push(c);
                }
                else if (c == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        double num2 = numbers.Pop();
                        double num1 = numbers.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(num1, num2, op);
                        numbers.Push(result);
                    }
                    operators.Pop();
                }
                else if (IsOperator(c))
                {
                    while (operators.Count > 0 && ShouldEvaluateOperator(c, operators.Peek()))
                    {
                        double num2 = numbers.Pop();
                        double num1 = numbers.Pop();
                        char op = operators.Pop();
                        double result = ApplyOperator(num1, num2, op);
                        numbers.Push(result);
                    }
                    operators.Push(c);
                }
            }

            while (operators.Count > 0)
            {
                double num2 = numbers.Pop();
                double num1 = numbers.Pop();
                char op = operators.Pop();
                double result = ApplyOperator(num1, num2, op);
                numbers.Push(result);
            }

            return numbers.Pop();
        }

        bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        bool ShouldEvaluateOperator(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            return true;
        }

        // Hàm xác định toán toán tử để tính 
        double ApplyOperator(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+': return num1 + num2;
                case '-': return num1 - num2;
                case '*': return num1 * num2;
                case '/': return num1 / num2;
                default: throw new ArgumentException("Invalid operator: " + op);
            }
        }
    }

}
