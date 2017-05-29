using System.Windows.Forms;
namespace MultiWindowsExplorer
{
    partial class MainMultiWindowsExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                StoreUrlValue();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMultiWindowsExplorer));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainerOut = new System.Windows.Forms.SplitContainer();
            this.splitContainerUp = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen0 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnUp0 = new System.Windows.Forms.Button();
            this.btnForward0 = new System.Windows.Forms.Button();
            this.btnBack0 = new System.Windows.Forms.Button();
            this.txtPath0 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch0 = new System.Windows.Forms.Button();
            this.txtSearch0 = new System.Windows.Forms.RichTextBox();
            this.ckboxMatchCase0 = new System.Windows.Forms.CheckBox();
            this.progressBar0 = new System.Windows.Forms.ProgressBar();
            this.labelProgress0 = new System.Windows.Forms.Label();
            this.tabControl0 = new System.Windows.Forms.TabControl();
            this.tabBrowser0 = new System.Windows.Forms.TabPage();
            this.webBrowser0 = new System.Windows.Forms.WebBrowser();
            this.tabListView0 = new System.Windows.Forms.TabPage();
            this.listView0 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnUp1 = new System.Windows.Forms.Button();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.RichTextBox();
            this.ckboxMatchCase1 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelProgress1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBrowser1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabListView1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainerDown = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.RichTextBox();
            this.ckboxMatchCase2 = new System.Windows.Forms.CheckBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.labelProgress2 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabBrowser2 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.tabListView2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.btnForward3 = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.txtSearch3 = new System.Windows.Forms.RichTextBox();
            this.ckboxMatchCase3 = new System.Windows.Forms.CheckBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.labelProgress3 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabBrowser3 = new System.Windows.Forms.TabPage();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.tabListView3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).BeginInit();
            this.splitContainerOut.Panel1.SuspendLayout();
            this.splitContainerOut.Panel2.SuspendLayout();
            this.splitContainerOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).BeginInit();
            this.splitContainerUp.Panel1.SuspendLayout();
            this.splitContainerUp.Panel2.SuspendLayout();
            this.splitContainerUp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControl0.SuspendLayout();
            this.tabBrowser0.SuspendLayout();
            this.tabListView0.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBrowser1.SuspendLayout();
            this.tabListView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).BeginInit();
            this.splitContainerDown.Panel1.SuspendLayout();
            this.splitContainerDown.Panel2.SuspendLayout();
            this.splitContainerDown.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabBrowser2.SuspendLayout();
            this.tabListView2.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabBrowser3.SuspendLayout();
            this.tabListView3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(54, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAbout,
            this.toolStripButtonExit});
            this.toolStrip.Location = new System.Drawing.Point(0, 32);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(717, 32);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.AutoSize = false;
            this.toolStripButtonAbout.AutoToolTip = false;
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(40, 37);
            this.toolStripButtonAbout.Click += new System.EventHandler(this.toolStripButtonAbout_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(39, 29);
            this.toolStripButtonExit.Text = "toolStripButton2";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripButtonExit_Click);
            // 
            // splitContainerOut
            // 
            this.splitContainerOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOut.Location = new System.Drawing.Point(0, 64);
            this.splitContainerOut.Name = "splitContainerOut";
            this.splitContainerOut.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerOut.Panel1
            // 
            this.splitContainerOut.Panel1.Controls.Add(this.splitContainerUp);
            // 
            // splitContainerOut.Panel2
            // 
            this.splitContainerOut.Panel2.Controls.Add(this.splitContainerDown);
            this.splitContainerOut.Size = new System.Drawing.Size(717, 388);
            this.splitContainerOut.SplitterDistance = 188;
            this.splitContainerOut.TabIndex = 2;
            // 
            // splitContainerUp
            // 
            this.splitContainerUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUp.Name = "splitContainerUp";
            // 
            // splitContainerUp.Panel1
            // 
            this.splitContainerUp.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerUp.Panel2
            // 
            this.splitContainerUp.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainerUp.Size = new System.Drawing.Size(717, 188);
            this.splitContainerUp.SplitterDistance = 348;
            this.splitContainerUp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tabControl0, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOpen0, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUp0, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnForward0, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBack0, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPath0, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(338, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnOpen0
            // 
            this.btnOpen0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen0.ImageIndex = 4;
            this.btnOpen0.ImageList = this.imageList;
            this.btnOpen0.Location = new System.Drawing.Point(153, 3);
            this.btnOpen0.Name = "btnOpen0";
            this.btnOpen0.Size = new System.Drawing.Size(44, 38);
            this.btnOpen0.TabIndex = 0;
            this.btnOpen0.UseVisualStyleBackColor = true;
            this.btnOpen0.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "894f0362.png");
            this.imageList.Images.SetKeyName(1, "back.png");
            this.imageList.Images.SetKeyName(2, "COMPUTER.ICO");
            this.imageList.Images.SetKeyName(3, "consumer.ico");
            this.imageList.Images.SetKeyName(4, "Down.png");
            this.imageList.Images.SetKeyName(5, "forward.png");
            this.imageList.Images.SetKeyName(6, "NormalIcon.ico");
            this.imageList.Images.SetKeyName(7, "sync.ico");
            this.imageList.Images.SetKeyName(8, "Up.ico");
            this.imageList.Images.SetKeyName(9, "up.png");
            this.imageList.Images.SetKeyName(10, "Right_arrow_next_play_forward.png");
            // 
            // btnUp0
            // 
            this.btnUp0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp0.ImageIndex = 9;
            this.btnUp0.ImageList = this.imageList;
            this.btnUp0.Location = new System.Drawing.Point(103, 3);
            this.btnUp0.Name = "btnUp0";
            this.btnUp0.Size = new System.Drawing.Size(44, 38);
            this.btnUp0.TabIndex = 0;
            this.btnUp0.UseVisualStyleBackColor = true;
            this.btnUp0.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnForward0
            // 
            this.btnForward0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward0.ImageIndex = 5;
            this.btnForward0.ImageList = this.imageList;
            this.btnForward0.Location = new System.Drawing.Point(53, 3);
            this.btnForward0.Name = "btnForward0";
            this.btnForward0.Size = new System.Drawing.Size(44, 38);
            this.btnForward0.TabIndex = 0;
            this.btnForward0.UseVisualStyleBackColor = true;
            this.btnForward0.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack0
            // 
            this.btnBack0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack0.ImageIndex = 1;
            this.btnBack0.ImageList = this.imageList;
            this.btnBack0.Location = new System.Drawing.Point(3, 3);
            this.btnBack0.Name = "btnBack0";
            this.btnBack0.Size = new System.Drawing.Size(44, 38);
            this.btnBack0.TabIndex = 0;
            this.btnBack0.UseVisualStyleBackColor = true;
            this.btnBack0.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPath0
            // 
            this.txtPath0.AcceptsReturn = true;
            this.txtPath0.AcceptsTab = true;
            this.txtPath0.AllowDrop = true;
            this.txtPath0.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath0.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPath0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath0.Location = new System.Drawing.Point(203, 3);
            this.txtPath0.Multiline = true;
            this.txtPath0.Name = "txtPath0";
            this.txtPath0.Size = new System.Drawing.Size(132, 38);
            this.txtPath0.TabIndex = 1;
            this.txtPath0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch0, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearch0, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ckboxMatchCase0, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar0, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelProgress0, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 137);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 44);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnSearch0
            // 
            this.btnSearch0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch0.ImageIndex = 0;
            this.btnSearch0.ImageList = this.imageList;
            this.btnSearch0.Location = new System.Drawing.Point(81, 3);
            this.btnSearch0.Name = "btnSearch0";
            this.btnSearch0.Size = new System.Drawing.Size(44, 38);
            this.btnSearch0.TabIndex = 0;
            this.btnSearch0.UseVisualStyleBackColor = true;
            this.btnSearch0.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch0
            // 
            this.txtSearch0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch0.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtSearch0.Location = new System.Drawing.Point(3, 3);
            this.txtSearch0.Name = "txtSearch0";
            this.txtSearch0.Size = new System.Drawing.Size(72, 38);
            this.txtSearch0.TabIndex = 1;
            this.txtSearch0.Text = "";
            // 
            // ckboxMatchCase0
            // 
            this.ckboxMatchCase0.AutoSize = true;
            this.ckboxMatchCase0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase0.Location = new System.Drawing.Point(131, 3);
            this.ckboxMatchCase0.Name = "ckboxMatchCase0";
            this.ckboxMatchCase0.Size = new System.Drawing.Size(74, 38);
            this.ckboxMatchCase0.TabIndex = 2;
            this.ckboxMatchCase0.Text = "Match \r\nCase";
            this.ckboxMatchCase0.UseVisualStyleBackColor = true;
            // 
            // progressBar0
            // 
            this.progressBar0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar0.Location = new System.Drawing.Point(211, 3);
            this.progressBar0.Name = "progressBar0";
            this.progressBar0.Size = new System.Drawing.Size(72, 38);
            this.progressBar0.TabIndex = 3;
            // 
            // labelProgress0
            // 
            this.labelProgress0.AutoSize = true;
            this.labelProgress0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgress0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress0.Location = new System.Drawing.Point(289, 0);
            this.labelProgress0.Name = "labelProgress0";
            this.labelProgress0.Size = new System.Drawing.Size(46, 44);
            this.labelProgress0.TabIndex = 4;
            this.labelProgress0.Text = "100 %";
            this.labelProgress0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl0
            // 
            this.tabControl0.Controls.Add(this.tabBrowser0);
            this.tabControl0.Controls.Add(this.tabListView0);
            this.tabControl0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl0.Location = new System.Drawing.Point(3, 53);
            this.tabControl0.Name = "tabControl0";
            this.tabControl0.SelectedIndex = 0;
            this.tabControl0.Size = new System.Drawing.Size(338, 78);
            this.tabControl0.TabIndex = 2;
            // 
            // tabBrowser0
            // 
            this.tabBrowser0.Controls.Add(this.webBrowser0);
            this.tabBrowser0.Location = new System.Drawing.Point(4, 29);
            this.tabBrowser0.Name = "tabBrowser0";
            this.tabBrowser0.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser0.Size = new System.Drawing.Size(330, 45);
            this.tabBrowser0.TabIndex = 0;
            this.tabBrowser0.Text = "Browser";
            this.tabBrowser0.UseVisualStyleBackColor = true;
            // 
            // webBrowser0
            // 
            this.webBrowser0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser0.Location = new System.Drawing.Point(3, 3);
            this.webBrowser0.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser0.Name = "webBrowser0";
            this.webBrowser0.Size = new System.Drawing.Size(324, 39);
            this.webBrowser0.TabIndex = 0;
            this.webBrowser0.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tabListView0
            // 
            this.tabListView0.Controls.Add(this.listView0);
            this.tabListView0.Location = new System.Drawing.Point(4, 29);
            this.tabListView0.Name = "tabListView0";
            this.tabListView0.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView0.Size = new System.Drawing.Size(330, 45);
            this.tabListView0.TabIndex = 1;
            this.tabListView0.Text = "Search Result";
            this.tabListView0.UseVisualStyleBackColor = true;
            // 
            // listView0
            // 
            this.listView0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView0.FullRowSelect = true;
            this.listView0.GridLines = true;
            this.listView0.Location = new System.Drawing.Point(3, 3);
            this.listView0.Name = "listView0";
            this.listView0.Size = new System.Drawing.Size(324, 39);
            this.listView0.TabIndex = 0;
            this.listView0.UseCompatibleStateImageBehavior = false;
            this.listView0.View = System.Windows.Forms.View.Details;
            this.listView0.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Searched File(s)";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Directory(ies)";
            this.columnHeader2.Width = 400;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(361, 184);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnOpen1, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnUp1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnForward1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnBack1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPath1, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(355, 44);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnOpen1
            // 
            this.btnOpen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen1.ImageIndex = 4;
            this.btnOpen1.ImageList = this.imageList;
            this.btnOpen1.Location = new System.Drawing.Point(153, 3);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(44, 38);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUp1
            // 
            this.btnUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp1.ImageKey = "up.png";
            this.btnUp1.ImageList = this.imageList;
            this.btnUp1.Location = new System.Drawing.Point(103, 3);
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(44, 38);
            this.btnUp1.TabIndex = 0;
            this.btnUp1.UseVisualStyleBackColor = true;
            this.btnUp1.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward1.ImageIndex = 5;
            this.btnForward1.ImageList = this.imageList;
            this.btnForward1.Location = new System.Drawing.Point(53, 3);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(44, 38);
            this.btnForward1.TabIndex = 0;
            this.btnForward1.UseVisualStyleBackColor = true;
            this.btnForward1.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack1.ImageIndex = 1;
            this.btnBack1.ImageList = this.imageList;
            this.btnBack1.Location = new System.Drawing.Point(3, 3);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(44, 38);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath1.Location = new System.Drawing.Point(203, 3);
            this.txtPath1.Multiline = true;
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(149, 38);
            this.txtPath1.TabIndex = 1;
            this.txtPath1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel6.Controls.Add(this.btnSearch1, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSearch1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.ckboxMatchCase1, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.progressBar1, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelProgress1, 4, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 137);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(355, 44);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch1.ImageIndex = 0;
            this.btnSearch1.ImageList = this.imageList;
            this.btnSearch1.Location = new System.Drawing.Point(89, 3);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(44, 38);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch1.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtSearch1.Location = new System.Drawing.Point(3, 3);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(80, 38);
            this.txtSearch1.TabIndex = 1;
            this.txtSearch1.Text = "";
            // 
            // ckboxMatchCase1
            // 
            this.ckboxMatchCase1.AutoSize = true;
            this.ckboxMatchCase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase1.Location = new System.Drawing.Point(139, 3);
            this.ckboxMatchCase1.Name = "ckboxMatchCase1";
            this.ckboxMatchCase1.Size = new System.Drawing.Size(74, 38);
            this.ckboxMatchCase1.TabIndex = 2;
            this.ckboxMatchCase1.Text = "Match \r\nCase";
            this.ckboxMatchCase1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(219, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(80, 38);
            this.progressBar1.TabIndex = 3;
            // 
            // labelProgress1
            // 
            this.labelProgress1.AutoSize = true;
            this.labelProgress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress1.Location = new System.Drawing.Point(305, 0);
            this.labelProgress1.Name = "labelProgress1";
            this.labelProgress1.Size = new System.Drawing.Size(47, 44);
            this.labelProgress1.TabIndex = 4;
            this.labelProgress1.Text = "100 %";
            this.labelProgress1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBrowser1);
            this.tabControl1.Controls.Add(this.tabListView1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 78);
            this.tabControl1.TabIndex = 2;
            // 
            // tabBrowser1
            // 
            this.tabBrowser1.Controls.Add(this.webBrowser1);
            this.tabBrowser1.Location = new System.Drawing.Point(4, 29);
            this.tabBrowser1.Name = "tabBrowser1";
            this.tabBrowser1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser1.Size = new System.Drawing.Size(347, 45);
            this.tabBrowser1.TabIndex = 0;
            this.tabBrowser1.Text = "Browser";
            this.tabBrowser1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(341, 39);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tabListView1
            // 
            this.tabListView1.Controls.Add(this.listView1);
            this.tabListView1.Location = new System.Drawing.Point(4, 29);
            this.tabListView1.Name = "tabListView1";
            this.tabListView1.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView1.Size = new System.Drawing.Size(347, 45);
            this.tabListView1.TabIndex = 1;
            this.tabListView1.Text = "Search Result";
            this.tabListView1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(341, 39);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Searched File(s)";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Directory(ies)";
            this.columnHeader4.Width = 400;
            // 
            // splitContainerDown
            // 
            this.splitContainerDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDown.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDown.Name = "splitContainerDown";
            // 
            // splitContainerDown.Panel1
            // 
            this.splitContainerDown.Panel1.Controls.Add(this.tableLayoutPanel7);
            // 
            // splitContainerDown.Panel2
            // 
            this.splitContainerDown.Panel2.Controls.Add(this.tableLayoutPanel10);
            this.splitContainerDown.Size = new System.Drawing.Size(717, 196);
            this.splitContainerDown.SplitterDistance = 348;
            this.splitContainerDown.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tabControl2, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(344, 192);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.btnOpen2, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnUp2, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnForward2, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnBack2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtPath2, 4, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(338, 44);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen2.ImageIndex = 4;
            this.btnOpen2.ImageList = this.imageList;
            this.btnOpen2.Location = new System.Drawing.Point(153, 3);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(44, 38);
            this.btnOpen2.TabIndex = 0;
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp2.ImageIndex = 9;
            this.btnUp2.ImageList = this.imageList;
            this.btnUp2.Location = new System.Drawing.Point(103, 3);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(44, 38);
            this.btnUp2.TabIndex = 0;
            this.btnUp2.UseVisualStyleBackColor = true;
            this.btnUp2.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward2.ImageIndex = 5;
            this.btnForward2.ImageList = this.imageList;
            this.btnForward2.Location = new System.Drawing.Point(53, 3);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(44, 38);
            this.btnForward2.TabIndex = 0;
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack2.ImageIndex = 1;
            this.btnBack2.ImageList = this.imageList;
            this.btnBack2.Location = new System.Drawing.Point(3, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(44, 38);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath2.Location = new System.Drawing.Point(203, 3);
            this.txtPath2.Multiline = true;
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(132, 38);
            this.txtPath2.TabIndex = 1;
            this.txtPath2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 5;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel9.Controls.Add(this.btnSearch2, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtSearch2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.ckboxMatchCase2, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.progressBar2, 3, 0);
            this.tableLayoutPanel9.Controls.Add(this.labelProgress2, 4, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(338, 44);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // btnSearch2
            // 
            this.btnSearch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch2.ImageIndex = 0;
            this.btnSearch2.ImageList = this.imageList;
            this.btnSearch2.Location = new System.Drawing.Point(80, 3);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(44, 38);
            this.btnSearch2.TabIndex = 0;
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch2.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtSearch2.Location = new System.Drawing.Point(3, 3);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(71, 38);
            this.txtSearch2.TabIndex = 1;
            this.txtSearch2.Text = "";
            // 
            // ckboxMatchCase2
            // 
            this.ckboxMatchCase2.AutoSize = true;
            this.ckboxMatchCase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase2.Location = new System.Drawing.Point(130, 3);
            this.ckboxMatchCase2.Name = "ckboxMatchCase2";
            this.ckboxMatchCase2.Size = new System.Drawing.Size(74, 38);
            this.ckboxMatchCase2.TabIndex = 2;
            this.ckboxMatchCase2.Text = "Match \r\nCase";
            this.ckboxMatchCase2.UseVisualStyleBackColor = true;
            // 
            // progressBar2
            // 
            this.progressBar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar2.Location = new System.Drawing.Point(210, 3);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(71, 38);
            this.progressBar2.TabIndex = 3;
            // 
            // labelProgress2
            // 
            this.labelProgress2.AutoSize = true;
            this.labelProgress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress2.Location = new System.Drawing.Point(287, 0);
            this.labelProgress2.Name = "labelProgress2";
            this.labelProgress2.Size = new System.Drawing.Size(48, 44);
            this.labelProgress2.TabIndex = 4;
            this.labelProgress2.Text = "100 %";
            this.labelProgress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabBrowser2);
            this.tabControl2.Controls.Add(this.tabListView2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 53);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(338, 86);
            this.tabControl2.TabIndex = 2;
            // 
            // tabBrowser2
            // 
            this.tabBrowser2.Controls.Add(this.webBrowser2);
            this.tabBrowser2.Location = new System.Drawing.Point(4, 29);
            this.tabBrowser2.Name = "tabBrowser2";
            this.tabBrowser2.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser2.Size = new System.Drawing.Size(330, 53);
            this.tabBrowser2.TabIndex = 0;
            this.tabBrowser2.Text = "Browser";
            this.tabBrowser2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 3);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(324, 47);
            this.webBrowser2.TabIndex = 0;
            this.webBrowser2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tabListView2
            // 
            this.tabListView2.Controls.Add(this.listView2);
            this.tabListView2.Location = new System.Drawing.Point(4, 29);
            this.tabListView2.Name = "tabListView2";
            this.tabListView2.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView2.Size = new System.Drawing.Size(330, 53);
            this.tabListView2.TabIndex = 1;
            this.tabListView2.Text = "Search Result";
            this.tabListView2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(324, 47);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Searched File(s)";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Directory(ies)";
            this.columnHeader6.Width = 400;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.tabControl3, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(361, 192);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 5;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.btnOpen3, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnUp3, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnForward3, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.btnBack3, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.txtPath3, 4, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(355, 44);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // btnOpen3
            // 
            this.btnOpen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen3.ImageIndex = 4;
            this.btnOpen3.ImageList = this.imageList;
            this.btnOpen3.Location = new System.Drawing.Point(153, 3);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(44, 38);
            this.btnOpen3.TabIndex = 0;
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUp3
            // 
            this.btnUp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp3.ImageIndex = 9;
            this.btnUp3.ImageList = this.imageList;
            this.btnUp3.Location = new System.Drawing.Point(103, 3);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(44, 38);
            this.btnUp3.TabIndex = 0;
            this.btnUp3.UseVisualStyleBackColor = true;
            this.btnUp3.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnForward3
            // 
            this.btnForward3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward3.ImageIndex = 5;
            this.btnForward3.ImageList = this.imageList;
            this.btnForward3.Location = new System.Drawing.Point(53, 3);
            this.btnForward3.Name = "btnForward3";
            this.btnForward3.Size = new System.Drawing.Size(44, 38);
            this.btnForward3.TabIndex = 0;
            this.btnForward3.UseVisualStyleBackColor = true;
            this.btnForward3.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack3.ImageIndex = 1;
            this.btnBack3.ImageList = this.imageList;
            this.btnBack3.Location = new System.Drawing.Point(3, 3);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(44, 38);
            this.btnBack3.TabIndex = 0;
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtPath3
            // 
            this.txtPath3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtPath3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath3.Location = new System.Drawing.Point(203, 3);
            this.txtPath3.Multiline = true;
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(149, 38);
            this.txtPath3.TabIndex = 1;
            this.txtPath3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 5;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel12.Controls.Add(this.btnSearch3, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.txtSearch3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.ckboxMatchCase3, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.progressBar3, 3, 0);
            this.tableLayoutPanel12.Controls.Add(this.labelProgress3, 4, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 145);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(355, 44);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // btnSearch3
            // 
            this.btnSearch3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch3.ImageIndex = 0;
            this.btnSearch3.ImageList = this.imageList;
            this.btnSearch3.Location = new System.Drawing.Point(89, 3);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(44, 38);
            this.btnSearch3.TabIndex = 0;
            this.btnSearch3.UseVisualStyleBackColor = true;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch3
            // 
            this.txtSearch3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch3.Font = new System.Drawing.Font("Consolas", 12F);
            this.txtSearch3.Location = new System.Drawing.Point(3, 3);
            this.txtSearch3.Name = "txtSearch3";
            this.txtSearch3.Size = new System.Drawing.Size(80, 38);
            this.txtSearch3.TabIndex = 1;
            this.txtSearch3.Text = "";
            // 
            // ckboxMatchCase3
            // 
            this.ckboxMatchCase3.AutoSize = true;
            this.ckboxMatchCase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase3.Location = new System.Drawing.Point(139, 3);
            this.ckboxMatchCase3.Name = "ckboxMatchCase3";
            this.ckboxMatchCase3.Size = new System.Drawing.Size(74, 38);
            this.ckboxMatchCase3.TabIndex = 2;
            this.ckboxMatchCase3.Text = "Match \r\nCase";
            this.ckboxMatchCase3.UseVisualStyleBackColor = true;
            // 
            // progressBar3
            // 
            this.progressBar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar3.Location = new System.Drawing.Point(219, 3);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(80, 38);
            this.progressBar3.TabIndex = 3;
            // 
            // labelProgress3
            // 
            this.labelProgress3.AutoSize = true;
            this.labelProgress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProgress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgress3.Location = new System.Drawing.Point(305, 0);
            this.labelProgress3.Name = "labelProgress3";
            this.labelProgress3.Size = new System.Drawing.Size(47, 44);
            this.labelProgress3.TabIndex = 4;
            this.labelProgress3.Text = "100 %";
            this.labelProgress3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabBrowser3);
            this.tabControl3.Controls.Add(this.tabListView3);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(3, 53);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(355, 86);
            this.tabControl3.TabIndex = 2;
            // 
            // tabBrowser3
            // 
            this.tabBrowser3.Controls.Add(this.webBrowser3);
            this.tabBrowser3.Location = new System.Drawing.Point(4, 29);
            this.tabBrowser3.Name = "tabBrowser3";
            this.tabBrowser3.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser3.Size = new System.Drawing.Size(347, 53);
            this.tabBrowser3.TabIndex = 0;
            this.tabBrowser3.Text = "Browser";
            this.tabBrowser3.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(3, 3);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(341, 47);
            this.webBrowser3.TabIndex = 0;
            this.webBrowser3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tabListView3
            // 
            this.tabListView3.Controls.Add(this.listView3);
            this.tabListView3.Location = new System.Drawing.Point(4, 29);
            this.tabListView3.Name = "tabListView3";
            this.tabListView3.Padding = new System.Windows.Forms.Padding(3);
            this.tabListView3.Size = new System.Drawing.Size(347, 53);
            this.tabListView3.TabIndex = 1;
            this.tabListView3.Text = "Search Result";
            this.tabListView3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.Location = new System.Drawing.Point(3, 3);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(341, 47);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Searched File(s)";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Directory(ies)";
            this.columnHeader10.Width = 400;
            // 
            // MainMultiWindowsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.splitContainerOut);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMultiWindowsExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMultiWindowsExplorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainerOut.Panel1.ResumeLayout(false);
            this.splitContainerOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).EndInit();
            this.splitContainerOut.ResumeLayout(false);
            this.splitContainerUp.Panel1.ResumeLayout(false);
            this.splitContainerUp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).EndInit();
            this.splitContainerUp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControl0.ResumeLayout(false);
            this.tabBrowser0.ResumeLayout(false);
            this.tabListView0.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBrowser1.ResumeLayout(false);
            this.tabListView1.ResumeLayout(false);
            this.splitContainerDown.Panel1.ResumeLayout(false);
            this.splitContainerDown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).EndInit();
            this.splitContainerDown.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabBrowser2.ResumeLayout(false);
            this.tabListView2.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabBrowser3.ResumeLayout(false);
            this.tabListView3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.SplitContainer splitContainerOut;
        private System.Windows.Forms.SplitContainer splitContainerUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSearch0;
        private System.Windows.Forms.RichTextBox txtSearch0;
        private System.Windows.Forms.CheckBox ckboxMatchCase0;
        private System.Windows.Forms.ProgressBar progressBar0;
        private System.Windows.Forms.TabControl tabControl0;
        private System.Windows.Forms.TabPage tabBrowser0;
        private System.Windows.Forms.WebBrowser webBrowser0;
        private System.Windows.Forms.TabPage tabListView0;
        private System.Windows.Forms.ListView listView0;
        private System.Windows.Forms.SplitContainer splitContainerDown;
        private System.Windows.Forms.Label labelProgress0;
        private System.Windows.Forms.Button btnOpen0;
        private System.Windows.Forms.Button btnUp0;
        private System.Windows.Forms.Button btnForward0;
        private System.Windows.Forms.Button btnBack0;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnUp1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.RichTextBox txtSearch1;
        private System.Windows.Forms.CheckBox ckboxMatchCase1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelProgress1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabListView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.RichTextBox txtSearch2;
        private System.Windows.Forms.CheckBox ckboxMatchCase2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label labelProgress2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabBrowser2;
        private System.Windows.Forms.TabPage tabListView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.Button btnForward3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.RichTextBox txtSearch3;
        private System.Windows.Forms.CheckBox ckboxMatchCase3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label labelProgress3;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabBrowser3;
        private System.Windows.Forms.TabPage tabListView3;
        private ImageList imageList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private WebBrowser webBrowser2;
        private ListView listView2;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private WebBrowser webBrowser3;
        private ListView listView3;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private TextBox txtPath0;
        private TextBox txtPath1;
        private TextBox txtPath2;
        private TextBox txtPath3;

    }
}