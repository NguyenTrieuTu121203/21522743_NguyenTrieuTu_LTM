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
    public partial class FormBai6 : Form
    {
        public FormBai6()
        {
            InitializeComponent();
            FillDriveNodes();

        }
        private void FillDriveNodes()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    TreeNode driveNode = new TreeNode(drive.Name);
                    driveNode.Tag = drive.RootDirectory;
                    driveNode.ImageKey = "drive";
                    driveNode.SelectedImageKey = "drive";
                    treeView.Nodes.Add(driveNode);
                    driveNode.Nodes.Add(new TreeNode());
                }
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Tag == null)
            {
                e.Node.Nodes.Clear();
                DirectoryInfo directory = (DirectoryInfo)e.Node.Tag;
                try
                {
                    foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                    {
                        TreeNode subDirectoryNode = new TreeNode(subDirectory.Name);
                        subDirectoryNode.Tag = subDirectory;
                        subDirectoryNode.ImageKey = "folder";
                        subDirectoryNode.SelectedImageKey = "folder";
                        subDirectoryNode.Nodes.Add(new TreeNode());
                        e.Node.Nodes.Add(subDirectoryNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    e.Node.Nodes.Add(new TreeNode("Access Denied"));
                }
            }
        }

        // Sử dụng đệ quy để có thể duyệt tất cả thư mục và file có trong máy
        private void FillDirectoryNodes(TreeNode parentNode, DirectoryInfo directory)
        {
            try
            {
                foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                {
                    TreeNode subDirectoryNode = new TreeNode(subDirectory.Name);
                    subDirectoryNode.Tag = subDirectory;
                    subDirectoryNode.ImageKey = "folder";
                    subDirectoryNode.SelectedImageKey = "folder";
                    parentNode.Nodes.Add(subDirectoryNode);
                    subDirectoryNode.Nodes.Add(new TreeNode());
                    FillDirectoryNodes(subDirectoryNode, subDirectory);
                }
                foreach (FileInfo file in directory.GetFiles())
                {
                    TreeNode fileNode = new TreeNode(file.Name);
                    fileNode.Tag = file;
                    fileNode.ImageKey = "file";
                    fileNode.SelectedImageKey = "file";
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add(new TreeNode("Access Denied"));
            }
        }

        // Truy cạp vào thư mục con 
        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                treeView.SelectedNode = e.Node;
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                if (e.Node.Tag is DirectoryInfo)
                {
                    FillDirectoryNodes(e.Node, (DirectoryInfo)e.Node.Tag);
                }
                contextMenu.Show(treeView, e.Location);
            }
            else if (e.Button == MouseButtons.Left)
            {
                
                if (e.Node.Tag is FileInfo)
                {
                    
                    FileInfo file = (FileInfo)e.Node.Tag;
                    System.Diagnostics.Process.Start(file.FullName);
                }
                else if (e.Node.Nodes.Count > 0 && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();
                    DirectoryInfo directory = (DirectoryInfo)e.Node.Tag;
                    try
                    {
                        foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                        {
                            TreeNode subDirectoryNode = new TreeNode(subDirectory.Name);
                            subDirectoryNode.Tag = subDirectory;
                            subDirectoryNode.ImageKey = "folder";
                            subDirectoryNode.SelectedImageKey = "folder";
                            subDirectoryNode.Nodes.Add(new TreeNode());
                            e.Node.Nodes.Add(subDirectoryNode);
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        e.Node.Nodes.Add(new TreeNode("Access Denied"));
                    }
                }
            }

        }

        private void treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is DirectoryInfo)
            {
                DirectoryInfo directory = (DirectoryInfo)e.Node.Tag;
                try
                {
                    foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                    {
                        TreeNode node = new TreeNode(subDirectory.Name);
                        node.Tag = subDirectory;
                        node.Nodes.Add(new TreeNode()); 
                        e.Node.Nodes.Add(node);
                    }
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        TreeNode node = new TreeNode(file.Name);
                        node.Tag = file;
                        e.Node.Nodes.Add(node);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        // Giúp hiển thị file ảnh và file txt
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            object tag = e.Node.Tag;
            if (tag is FileInfo)
            {
                FileInfo file = (FileInfo)tag;
                string extension = file.Extension.ToLower();
                if (extension == ".txt")
                {
                    string text = File.ReadAllText(file.FullName);
                    txtViewFile.Text = text;
                }
            }
            else if (tag is DirectoryInfo)
            {
                DirectoryInfo directory = (DirectoryInfo)tag;
                try
                {
                    foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                    {
                        TreeNode node = new TreeNode(subDirectory.Name);
                        node.Tag = subDirectory;
                        node.Nodes.Add(new TreeNode()); 
                        e.Node.Nodes.Add(node);
                    }
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        TreeNode node = new TreeNode(file.Name);
                        node.Tag = file;
                        e.Node.Nodes.Add(node);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (tag is FileInfo)
            {
                FileInfo file = (FileInfo)tag;
                string extension = file.Extension.ToLower();
                if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".png")
                {
                    try
                    {
                        Image image = Image.FromFile(file.FullName);
                        Clipboard.SetImage(image);
                        txtViewFile.Paste();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else if (tag is DirectoryInfo)
            {
                DirectoryInfo directory = (DirectoryInfo)tag;
                try
                {
                    foreach (DirectoryInfo subDirectory in directory.GetDirectories())
                    {
                        TreeNode node = new TreeNode(subDirectory.Name);
                        node.Tag = subDirectory;
                        node.Nodes.Add(new TreeNode());
                        e.Node.Nodes.Add(node);
                    }
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        string extension = file.Extension.ToLower();
                        if (extension == ".jpg" || extension == ".jpeg" || extension == ".gif" || extension == ".png")
                        {
                            TreeNode node = new TreeNode(file.Name);
                            node.Tag = file;
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
