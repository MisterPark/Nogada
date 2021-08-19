using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nogada
{
  public partial class Form1 : Form
  {
    ImageList imageList = new ImageList();
    public Form1()
    {
      InitializeComponent();

      // 트리노드 아이콘 세팅
      imageList.Images.Add(Properties.Resources.folder_icon);
      imageList.Images.Add(Properties.Resources.file_icon);
      treeView1.ImageList = imageList;

    }

    private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog dialog = new FolderBrowserDialog();
      DialogResult result = dialog.ShowDialog();
      if(result == DialogResult.OK)
      {
        string path = dialog.SelectedPath;
        DirectoryInfo root = new DirectoryInfo(path);
        TreeNode rootNode = MakeTreeNode(root);
        rootNode.ExpandAll();
        treeView1.Nodes.Add(rootNode);
      }
    }

    private TreeNode MakeTreeNode(DirectoryInfo root)
    {
      TreeNode rootNode = new TreeNode(root.Name);
      rootNode.ImageIndex = 0;
      rootNode.SelectedImageIndex = 0;
      rootNode.Tag = root.FullName;

      foreach(var dir in root.GetDirectories())
      {
        rootNode.Nodes.Add(MakeTreeNode(dir));
      }
      foreach(var file in root.GetFiles())
      {
        if (file.Extension != ".cs") continue;
        TreeNode fileNode = new TreeNode(file.Name);
        
        fileNode.ImageIndex = 1;
        fileNode.SelectedImageIndex = 1;
        fileNode.Tag = file.FullName;
        rootNode.Nodes.Add(fileNode);
      }
      return rootNode;
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void treeView1_DoubleClick(object sender, EventArgs e)
    {
      TreeNode node = treeView1.SelectedNode;
      string path = node.Tag as string;
      DirectoryInfo directory = new DirectoryInfo(path);
      string text = File.ReadAllText(directory.FullName);
      TabPage page = new TabPage();
      page.Text = directory.Name;
      page.BackColor = Color.FromArgb(30, 30, 30);
      RichTextBox textBox = new RichTextBox();
      textBox.Dock = DockStyle.Fill;
      textBox.Parent = page;
      textBox.Text = text;
      tabControl1.TabPages.Add(page);
    }
  }
}
