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
using System.IO.Compression;





namespace Lab02_LTM
{
    public partial class FormBai5 : Form
    {
        string pathFile = "D:\\";
        string outputFilePath = "";
        public FormBai5()
        {
            InitializeComponent();
        }

        private void FormBai5_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
            } 
        }



        private void btnZipFol_Click(object sender, EventArgs e)
        {
            string inputFilePath = txtFileName.Text;
            outputFilePath = pathFile;

            

            
            // compress file
            if (outputFilePath.EndsWith(".zip"))
            {
                ZipFile.CreateFromDirectory(inputFilePath, outputFilePath);
            }
            else if (outputFilePath.EndsWith(".gz"))
            {
                using (FileStream inputFileStream = File.OpenRead(inputFilePath))
                {
                    using (FileStream outputFileStream = File.Create(outputFilePath))
                    {
                        using (GZipStream compressionStream = new GZipStream(outputFileStream, CompressionMode.Compress))
                        {
                            inputFileStream.CopyTo(compressionStream);
                        }
                    }
                }
            }

            
            // decompress file
            string decompressedFilePath = txtFileName.Text;
            
            if (outputFilePath.EndsWith(".zip"))
            {
                ZipFile.ExtractToDirectory(outputFilePath, decompressedFilePath);
            }
            else if (outputFilePath.EndsWith(".gz"))
            {
                using (FileStream inputFileStream = File.OpenRead(outputFilePath))
                {
                    using (FileStream outputFileStream = File.Create(decompressedFilePath))
                    {
                        using (GZipStream decompressionStream = new GZipStream(inputFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(outputFileStream);
                        }
                    }
                }
            }
        }

        

        private void btnUnzip_Click(object sender, EventArgs e)
        {
            string decompressedFilePath = pathFile;
            if (outputFilePath.EndsWith(".zip"))
            {
                ZipFile.ExtractToDirectory(outputFilePath, decompressedFilePath);
            }
            else if (outputFilePath.EndsWith(".gz"))
            {
                using (FileStream inputFileStream = File.OpenRead(outputFilePath))
                {
                    using (FileStream outputFileStream = File.Create(decompressedFilePath))
                    {
                        using (GZipStream decompressionStream = new GZipStream(inputFileStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(outputFileStream);
                        }
                    }
                }
            }
        }
    }
}
