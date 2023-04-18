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

namespace Lab02_LTM
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
            rtbDaTa.ReadOnly = true;    
        }

        private void FormBai2_Load(object sender, EventArgs e)
        {

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            // Chọn file và đọc file 
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fs);
            string data = streamReader.ReadToEnd(); 
            rtbDaTa.Text = data;
            fs.Close();
            // Lấy tên File
            txtFileName.Text = GetFileName(ofd);
            // Lấy kích thước của file
            txtSizeFile.Text = GetSizeFile(ofd);
            // Lấy URL của file
            txtURL.Text=GetUrlFile(ofd);
            // Lấy số dòng của File
            txtLineCount.Text = GetLineCount(fs,ofd.FileName).ToString();
            // Lấy số chữ của file 
            txtWordCount.Text = GetWordsCount(ofd);
            // Lấy số kí tự 
            txtCharaterCount.Text = GetCharaterCount(ofd).ToString();
            

        }


        private string GetFileName(OpenFileDialog ofd)
        {
            string fileName;
            fileName = ofd.SafeFileName;    
            return fileName;
        }

        private string GetSizeFile(OpenFileDialog ofd)
        {
            string size = new FileInfo(ofd.FileName).Length.ToString();
            return size;
        }

        private string GetUrlFile(OpenFileDialog ofd)
        {
            string UrlFile;
            UrlFile= ofd.FileName;
            return UrlFile;
        }

        private int GetLineCount(FileStream fs,string pathFile)
        {
            fs = new FileStream(pathFile, FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fs);
            int LineCount = 0;
            while (streamReader.ReadLine() != null)
            {
                LineCount++;
            }
            fs.Close();
            return LineCount;
            
        }


        private string GetWordsCount(OpenFileDialog ofd)
        {
            var readFile = File.ReadAllText(ofd.FileName);
            var wordCount = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return wordCount.Length.ToString();
        }

        private int GetCharaterCount(OpenFileDialog ofd)
        {
            string CountCharacter = "";
            string[] Line =File.ReadAllLines(ofd.FileName);
            for(int i = 0; i < Line.Length; i++)
            {
                CountCharacter+=Line[i].ToString();
            }
            return CountCharacter.Trim().Length;
        }


    }
}
