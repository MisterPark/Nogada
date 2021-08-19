
namespace Nogada
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.leftPanel = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.centerPanel = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.menuStrip1.SuspendLayout();
      this.leftPanel.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.centerPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.종료ToolStripMenuItem.Text = "종료";
      this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
      // 
      // leftPanel
      // 
      this.leftPanel.BackColor = System.Drawing.Color.DimGray;
      this.leftPanel.Controls.Add(this.groupBox1);
      this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.leftPanel.Location = new System.Drawing.Point(0, 24);
      this.leftPanel.Name = "leftPanel";
      this.leftPanel.Size = new System.Drawing.Size(200, 426);
      this.leftPanel.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.treeView1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.groupBox1.ForeColor = System.Drawing.Color.Linen;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 426);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "파일 탐색기";
      // 
      // 열기ToolStripMenuItem
      // 
      this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
      this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.열기ToolStripMenuItem.Text = "열기";
      this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.splitter1.Location = new System.Drawing.Point(200, 24);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(5, 426);
      this.splitter1.TabIndex = 2;
      this.splitter1.TabStop = false;
      // 
      // centerPanel
      // 
      this.centerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.centerPanel.Controls.Add(this.tabControl1);
      this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.centerPanel.Location = new System.Drawing.Point(205, 24);
      this.centerPanel.Name = "centerPanel";
      this.centerPanel.Size = new System.Drawing.Size(595, 426);
      this.centerPanel.TabIndex = 3;
      // 
      // tabControl1
      // 
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(595, 426);
      this.tabControl1.TabIndex = 1;
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treeView1.Location = new System.Drawing.Point(3, 18);
      this.treeView1.Name = "treeView1";
      this.treeView1.Size = new System.Drawing.Size(194, 405);
      this.treeView1.TabIndex = 4;
      this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.centerPanel);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.leftPanel);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "노가다";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.leftPanel.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.centerPanel.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    private System.Windows.Forms.Panel leftPanel;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel centerPanel;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TreeView treeView1;
  }
}

