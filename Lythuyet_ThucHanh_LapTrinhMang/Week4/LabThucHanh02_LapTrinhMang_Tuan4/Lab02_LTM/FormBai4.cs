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
    
    public partial class FormBai4 : Form
    {
        List<Sinhvien> sinhviens = new List<Sinhvien>();
        int ClickCount;
        

        string pathFile = "D:\\Ouput_Bai4.txt";
        public class Sinhvien
        {
            private string Hoten;
            private string Mssv;
            private string DienThoai;
            private float Mon1;
            private float Mon2;
            private float Mon3;
            private float Avgscore;
            

            public Sinhvien(string hoten, string mssv, string dienthoai, float mon1, float mon2, float mon3)
            {
                Hoten = hoten;
                Mssv = mssv;
                DienThoai = dienthoai;
                Mon1 = mon1;
                Mon2 = mon2;
                Mon3 = mon3;
                Avgscore = (float)(Mon1 + Mon2 + Mon3) / 3;
            }
            public string GetHoten() { return Hoten; }
            public string GetMssv() { return Mssv; }
            public string GetDienthoai() { return DienThoai; }
            public float GetMon1() { return Mon1; }
            public float GetMon2() { return Mon2; }
            public float GetMon3() { return Mon3; }

            public float GetAvgScore() { return Avgscore; }
        }

        public FormBai4()
        {
            InitializeComponent();
            
        }



        private void FormBai4_Load(object sender, EventArgs e)
        {
            ClickCount = 0;
            SetAllTextBoxesReadOnly(this, true);

        }

        // Hàm làm toàn bộ các textbox chỉ đọc chứ không khả năng chỉnh sửa
        private void SetAllTextBoxesReadOnly(Control container, bool readOnly)
        {
            foreach (Control control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnly = readOnly;
                }
                else if (control is UserControl)
                {
                    SetAllTextBoxesReadOnly(control, readOnly);
                }
                else if (control is ContainerControl)
                {
                    SetAllTextBoxesReadOnly(control, readOnly);
                }
            }
        }

        string Line = "";
        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Chưa chọn file nhé ! Mời chọn file", "Error", MessageBoxButtons.OK);
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader streamReader = new StreamReader(fs);
            Line = streamReader.ReadToEnd();
            txtData.Text = Line;
            GetDataFileInput();

            fs.Close();

            // Kiểm tra dữ liệu 

            // Kiểm tra điểm
            if (!CheckScore())
            {
                MessageBox.Show("Điểm sinh viên trong file text đã lớn hơn 10 hoặc đã bé hơn 0", "Error Format", MessageBoxButtons.OK);
                Close();
            }


            // Kiểm tra mssv
            if (!CheckIdStudent())
            {
                MessageBox.Show("Đã có mã sinh viên có số kí tự khác 8 !!!!", "Error Format", MessageBoxButtons.OK);
                Close();
            }

            // Kiểm tra số điện thoại 
            if (!CheckPhoneNumberInList())
            {
                MessageBox.Show("Trong file txt đã có số điện thoại không bắt đầu từ số 0 hoặc quá 10 chữ số!!! ", "Error Format", MessageBoxButtons.OK);
                Close();
            }

        }




        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fs);
            // Tự động mở file txt ra màn hình 
            Process.Start("notepad.exe", pathFile);
            string Data = "";
            for(int i = 0; i < sinhviens.Count; i++)
            {
                Data += DisplayInFileText(sinhviens[i].GetHoten(),
                                          sinhviens[i].GetMssv(),
                                          sinhviens[i].GetDienthoai(),
                                          sinhviens[i].GetMon1(),
                                          sinhviens[i].GetMon2(),
                                          sinhviens[i].GetMon3(), 
                                          sinhviens[i].GetAvgScore());
            }

            streamWriter.WriteLine(Data);
            streamWriter.Close();
            DisplayStudent_WriteFile(sinhviens[0]);
        }


        private string DisplayInFileText(string a,string b,string c,float m1,float m2,float m3,float m4)
        {
            string data = a  + b + c + "\n" + m1.ToString() + "\n" + m2.ToString() + "\n" + m3.ToString() + "\n" + m4.ToString() + "\n\n";
            return data;
        }

        // Hiển thị sinh viên tiếp theo 
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            ClickCount++;
            for (int i = 1; i < sinhviens.Count; i++)
            {
                lb_Indexpage.Text = ClickCount.ToString();
                if (i == ClickCount)
                {
                    // Hiển thị sinh viên khi đọc file (chưa tính điểm trung bình)
                    DisplayStudent_ReadFile(sinhviens[i]);

                    // Hiển thị sinh viên khi ghi file (đã tính điểm trung bình)
                    DisplayStudent_WriteFile(sinhviens[i]);
                }
                if (ClickCount >= sinhviens.Count)
                {
                    
                    ClickCount = sinhviens.Count - 1;
                }

            }
        }

        // Hiển thị sinh viên phía trước 
        private void btnBackPage_Click(object sender, EventArgs e)
        {
            ClickCount--;
            for (int i = sinhviens.Count - 2; i >= 0; i--)
            {
                lb_Indexpage.Text = ClickCount.ToString();
                if (ClickCount == i)
                {
                    // Hiển thị sinh viên khi đọc file (chưa tính điểm trung bình)
                    DisplayStudent_ReadFile(sinhviens[i]);

                    // Hiển thị sinh viên khi ghi file (đã tính điểm trung bình)
                    DisplayStudent_WriteFile(sinhviens[i]);
                }
                if (ClickCount < 0)
                {
                    // reset =0 khi tới trang đầu
                    ClickCount = 0;
                }
            }
        }

    
        // Lấy dữ liệu từ file txt
        private void GetDataFileInput()
        {
            int count = 0;
            Line += "\r\n";
            for(int i = 0; i < Line.Length; i++)
            {
                // Kiểm tra xem có bao nhiêu lần xuống dòng
                // Có thể dựa vào từng lần xuống dòng mà lấy từng thuộc tính của sinh viên 
                if(Line[i]=='\n') count++;
                // Kiểm tra dòng nào là (Họ tên, Mssv, Số điện thoại, Môn 1, Môn 2, Môn 3) của sinh viên
                CheckDataFormat(count, Line[i]);
                // Snh viên có 6 thuộc tính cần định dạng ==> sẽ có số lần xuống dòng là 7
                if (count == 7)
                {
                    // Sau khi đọc hết thuộc tính của sinh viên biến count sẽ reset = 0 để đọc được thuộc tính của sinh viên tiếp theo
                    count = 0;
                    // Lấy thuộc tính từ textbox
                    string hoten = txtName.Text;
                    string mssv = txtMssv.Text;
                    string dt = txtPhone.Text;
                    string m1 = txtMon1.Text;
                    string m2 = txtMon2.Text;
                    string m3 = txtMon3.Text;
                    float mon1=float.Parse(m1);
                    float mon2=float.Parse(m2);
                    float mon3 = float.Parse(m3);
                    // Nếu có sinh viên nào có điểm sai
                    Sinhvien sv = new Sinhvien(hoten, mssv, dt, mon1, mon2, mon3);
                    // Thêm vào list sinhviens
                    sinhviens.Add(sv);
                    ResetTextBox();
                }
                    
            }
            // Mặc định hiển thị sinh viên đầu tiên khi load được file txt
            DisplayStudent_ReadFile(sinhviens[0]);
            DisplayStudent_WriteFile(sinhviens[0]);
        }


        // Hiển thị một sinh viên (Đọc file)
        private void DisplayStudent_ReadFile(Sinhvien sv)
        {
            float Mon1 = sv.GetMon1(),
                  Mon2 = sv.GetMon2(),
                  Mon3 = sv.GetMon3();
            // Lưu vào và hiển thị trên textbox
            txtName.Text = sv.GetHoten();
            txtMssv.Text = sv.GetMssv();
            txtPhone.Text = sv.GetDienthoai();
            txtMon1.Text = Mon1.ToString();
            txtMon2.Text = Mon2.ToString();
            txtMon3.Text = Mon3.ToString();
            txtAvg.Text = "0";
        }

        // Hiển thị một sinh viên (Ghi file)
        private void DisplayStudent_WriteFile(Sinhvien sv)
        {
            float Mon1 = sv.GetMon1(),
                  Mon2 = sv.GetMon2(),
                  Mon3 = sv.GetMon3();
            // Lưu vào và hiển thị trên textbox
            txtWriteName.Text = sv.GetHoten();
            txtWriteID.Text = sv.GetMssv();
            txtWritePhoneNumber.Text = sv.GetDienthoai();
            txtWriteCoures1.Text = Mon1.ToString();
            txtWriteCoures2.Text = Mon2.ToString();
            txtWriteCoures3.Text = Mon3.ToString();
            txtWrireAvg.Text = sv.GetAvgScore().ToString();
            
        }


        private void ResetTextBox() 
        {
            txtName.Text = "";
            txtMssv.Text = "";
            txtPhone.Text = "";
            txtMon1.Text = "";
            txtMon2.Text = "";
            txtMon3.Text = "";
        }


        //Giúp kiểm tra dòng nào là(Họ tên, Mssv, Số điện thoại, Môn 1, Môn 2, Môn 3) của sinh viên
        private void CheckDataFormat(int count, char c)
        {
            if (count < 1 ) txtName.Text += c;
            if (count >= 1 && count < 2) txtMssv.Text += c;
            if (count >= 2 && count < 3) txtPhone.Text += c;
            if (count >= 3 && count < 4) txtMon1.Text += c;
            if (count >= 4 && count < 5) txtMon2.Text += c;
            if (count >= 5 && count < 6) txtMon3.Text += c;
        }

        // Check điểm sinh viên 
        private bool CheckScore()
        {
            float mon1, mon2, mon3;
            for (int i = 0; i < sinhviens.Count; i++)
            {
                mon1 = sinhviens[i].GetMon1();
                mon2 = sinhviens[i].GetMon2();
                mon3 = sinhviens[i].GetMon3();
                if (mon1 < 0 || mon1 > 10 || mon2 < 0 || mon2 > 10 || mon3 < 0 || mon3 > 10)
                {
                    return false;
                }

            }
            return true;
        }

        // Check mã số sinh viên 
        private bool CheckIdStudent()
        {
            string mssv = "";
            for (int i = 0; i < sinhviens.Count; i++)
            {
                mssv = sinhviens[i].GetMssv();
                if (mssv.Length - 2 != 8)
                {
                    return false;
                }
            }
            return true;
        }

        


        // Kiểm tra số điện thoại 
        private bool CheckPhoneNumberInList()
        {
            string phoneNumber = "";
            for(int i = 0; i < sinhviens.Count; i++)
            {
                phoneNumber = sinhviens[i].GetDienthoai();
                if(phoneNumber[0] != '0' &&  phoneNumber.Length - 2 != 10) return false;
                
            }
            return true;
        }
    }
}
