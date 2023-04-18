using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab02_LTM
{
    public partial class FormBai1 : Form
    {
        string pathFile = "D:\\Ouput_Bai1.txt"; 

        public FormBai1()
        {
            InitializeComponent();
            rtbData.ReadOnly=true;
        }

        

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            
            if (string.IsNullOrEmpty(ofd.FileName))
            {
                MessageBox.Show("Chưa chọn file nhé ! Mời chọn file", "Error", MessageBoxButtons.OK);
                return;
            }
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fs);
            string data = streamReader.ReadToEnd();
            rtbData.Text = data;
            fs.Close();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            
            FileStream fs = new FileStream(pathFile, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fs);
            // Tự động mở file txt ra màn hình 
            Process.Start("notepad.exe", pathFile);
            string Data = rtbData.Text.ToUpper();
            streamWriter.WriteLine(Data);
            streamWriter.Close();
        }

        
    }
}
