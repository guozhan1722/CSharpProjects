namespace MultiWindowsExplorer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        private void StoreUrlValue()
        {
            foreach (var cgroup in cGroup)
            {
                AppSettings.UpdateSettings(cgroup.AppSettingKeys, cgroup.PathTxt.Text);
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            StoreUrlValue();
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainerOut = new System.Windows.Forms.SplitContainer();
            this.splitContainerUp = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnForward1 = new System.Windows.Forms.Button();
            this.btnUp1 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtSearch1 = new System.Windows.Forms.TextBox();
            this.ckboxMatchCase1 = new System.Windows.Forms.CheckBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnUp2 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.txtSearch2 = new System.Windows.Forms.TextBox();
            this.ckboxMatchCase2 = new System.Windows.Forms.CheckBox();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.splitContainerDown = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnForward3 = new System.Windows.Forms.Button();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.btnUp3 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.txtSearch3 = new System.Windows.Forms.TextBox();
            this.ckboxMatchCase3 = new System.Windows.Forms.CheckBox();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.btnUp4 = new System.Windows.Forms.Button();
            this.btnForward4 = new System.Windows.Forms.Button();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch4 = new System.Windows.Forms.Button();
            this.txtSearch4 = new System.Windows.Forms.TextBox();
            this.ckboxMatchCase4 = new System.Windows.Forms.CheckBox();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bkgWorkerSearch1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).BeginInit();
            this.splitContainerOut.Panel1.SuspendLayout();
            this.splitContainerOut.Panel2.SuspendLayout();
            this.splitContainerOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).BeginInit();
            this.splitContainerUp.Panel1.SuspendLayout();
            this.splitContainerUp.Panel2.SuspendLayout();
            this.splitContainerUp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).BeginInit();
            this.splitContainerDown.Panel1.SuspendLayout();
            this.splitContainerDown.Panel2.SuspendLayout();
            this.splitContainerDown.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerOut
            // 
            this.splitContainerOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOut.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.splitContainerOut.Size = new System.Drawing.Size(1040, 606);
            this.splitContainerOut.SplitterDistance = 296;
            this.splitContainerOut.TabIndex = 0;
            // 
            // splitContainerUp
            // 
            this.splitContainerUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUp.Location = new System.Drawing.Point(0, 0);
            this.splitContainerUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerUp.Name = "splitContainerUp";
            // 
            // splitContainerUp.Panel1
            // 
            this.splitContainerUp.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerUp.Panel2
            // 
            this.splitContainerUp.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainerUp.Size = new System.Drawing.Size(1040, 296);
            this.splitContainerUp.SplitterDistance = 496;
            this.splitContainerUp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel5.Controls.Add(this.btnBack1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnForward1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnUp1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnOpen1, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPath1, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(484, 54);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnBack1
            // 
            this.btnBack1.BackColor = System.Drawing.Color.Azure;
            this.btnBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack1.Enabled = false;
            this.btnBack1.ImageIndex = 4;
            this.btnBack1.ImageList = this.imageList1;
            this.btnBack1.Location = new System.Drawing.Point(4, 4);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(59, 46);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.UseVisualStyleBackColor = false;
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "COMPUTER.ICO");
            this.imageList1.Images.SetKeyName(1, "consumer.ico");
            this.imageList1.Images.SetKeyName(2, "NormalIcon.ico");
            this.imageList1.Images.SetKeyName(3, "sync.ico");
            this.imageList1.Images.SetKeyName(4, "back.png");
            this.imageList1.Images.SetKeyName(5, "Down.png");
            this.imageList1.Images.SetKeyName(6, "forward.png");
            this.imageList1.Images.SetKeyName(7, "up.png");
            this.imageList1.Images.SetKeyName(8, "Up.ico");
            this.imageList1.Images.SetKeyName(9, "894f0362.png");
            // 
            // btnForward1
            // 
            this.btnForward1.BackColor = System.Drawing.Color.Azure;
            this.btnForward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward1.Enabled = false;
            this.btnForward1.ImageIndex = 6;
            this.btnForward1.ImageList = this.imageList1;
            this.btnForward1.Location = new System.Drawing.Point(71, 4);
            this.btnForward1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(59, 46);
            this.btnForward1.TabIndex = 0;
            this.btnForward1.UseVisualStyleBackColor = false;
            this.btnForward1.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnUp1
            // 
            this.btnUp1.BackColor = System.Drawing.Color.Azure;
            this.btnUp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp1.ImageIndex = 7;
            this.btnUp1.ImageList = this.imageList1;
            this.btnUp1.Location = new System.Drawing.Point(138, 4);
            this.btnUp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(59, 46);
            this.btnUp1.TabIndex = 0;
            this.btnUp1.UseVisualStyleBackColor = false;
            this.btnUp1.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Azure;
            this.btnOpen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen1.ImageIndex = 5;
            this.btnOpen1.ImageList = this.imageList1;
            this.btnOpen1.Location = new System.Drawing.Point(421, 4);
            this.btnOpen1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(59, 46);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPath1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath1.Location = new System.Drawing.Point(210, 9);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(198, 34);
            this.txtPath1.TabIndex = 1;
            this.txtPath1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.btnSearch1, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtSearch1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.ckboxMatchCase1, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.progressBar1, 3, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 234);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(484, 54);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.Azure;
            this.btnSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch1.ImageIndex = 9;
            this.btnSearch1.ImageList = this.imageList1;
            this.btnSearch1.Location = new System.Drawing.Point(172, 4);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(59, 46);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch1
            // 
            this.txtSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch1.Location = new System.Drawing.Point(9, 9);
            this.txtSearch1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(150, 34);
            this.txtSearch1.TabIndex = 1;
            // 
            // ckboxMatchCase1
            // 
            this.ckboxMatchCase1.AutoSize = true;
            this.ckboxMatchCase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMatchCase1.Location = new System.Drawing.Point(239, 4);
            this.ckboxMatchCase1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckboxMatchCase1.Name = "ckboxMatchCase1";
            this.ckboxMatchCase1.Size = new System.Drawing.Size(72, 46);
            this.ckboxMatchCase1.TabIndex = 2;
            this.ckboxMatchCase1.Text = "Match \r\nCase";
            this.ckboxMatchCase1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 66);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(484, 160);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.webBrowser2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(536, 292);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 5;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel6.Controls.Add(this.btnBack2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnForward2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnUp2, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnOpen2, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtPath2, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(528, 54);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Azure;
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack2.Enabled = false;
            this.btnBack2.ImageIndex = 4;
            this.btnBack2.ImageList = this.imageList1;
            this.btnBack2.Location = new System.Drawing.Point(4, 4);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(59, 46);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.BackColor = System.Drawing.Color.Azure;
            this.btnForward2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward2.Enabled = false;
            this.btnForward2.ImageIndex = 6;
            this.btnForward2.ImageList = this.imageList1;
            this.btnForward2.Location = new System.Drawing.Point(71, 4);
            this.btnForward2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(59, 46);
            this.btnForward2.TabIndex = 0;
            this.btnForward2.UseVisualStyleBackColor = false;
            this.btnForward2.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnUp2
            // 
            this.btnUp2.BackColor = System.Drawing.Color.Azure;
            this.btnUp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp2.ImageIndex = 7;
            this.btnUp2.ImageList = this.imageList1;
            this.btnUp2.Location = new System.Drawing.Point(138, 4);
            this.btnUp2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp2.Name = "btnUp2";
            this.btnUp2.Size = new System.Drawing.Size(59, 46);
            this.btnUp2.TabIndex = 0;
            this.btnUp2.UseVisualStyleBackColor = false;
            this.btnUp2.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Azure;
            this.btnOpen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen2.ImageIndex = 5;
            this.btnOpen2.ImageList = this.imageList1;
            this.btnOpen2.Location = new System.Drawing.Point(465, 4);
            this.btnOpen2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(59, 46);
            this.btnOpen2.TabIndex = 0;
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath2.Location = new System.Drawing.Point(210, 9);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(242, 34);
            this.txtPath2.TabIndex = 1;
            this.txtPath2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.btnSearch2, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.txtSearch2, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.ckboxMatchCase2, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(4, 234);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(528, 54);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.Azure;
            this.btnSearch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch2.ImageIndex = 9;
            this.btnSearch2.ImageList = this.imageList1;
            this.btnSearch2.Location = new System.Drawing.Point(194, 4);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(59, 46);
            this.btnSearch2.TabIndex = 0;
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch2
            // 
            this.txtSearch2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch2.Location = new System.Drawing.Point(9, 9);
            this.txtSearch2.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtSearch2.Name = "txtSearch2";
            this.txtSearch2.Size = new System.Drawing.Size(172, 34);
            this.txtSearch2.TabIndex = 1;
            // 
            // ckboxMatchCase2
            // 
            this.ckboxMatchCase2.AutoSize = true;
            this.ckboxMatchCase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMatchCase2.Location = new System.Drawing.Point(261, 4);
            this.ckboxMatchCase2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckboxMatchCase2.Name = "ckboxMatchCase2";
            this.ckboxMatchCase2.Size = new System.Drawing.Size(72, 46);
            this.ckboxMatchCase2.TabIndex = 2;
            this.ckboxMatchCase2.Text = "Match \r\nCase";
            this.ckboxMatchCase2.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(4, 66);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(528, 160);
            this.webBrowser2.TabIndex = 2;
            this.webBrowser2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // splitContainerDown
            // 
            this.splitContainerDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDown.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerDown.Name = "splitContainerDown";
            // 
            // splitContainerDown.Panel1
            // 
            this.splitContainerDown.Panel1.Controls.Add(this.tableLayoutPanel3);
            // 
            // splitContainerDown.Panel2
            // 
            this.splitContainerDown.Panel2.Controls.Add(this.tableLayoutPanel4);
            this.splitContainerDown.Size = new System.Drawing.Size(1040, 306);
            this.splitContainerDown.SplitterDistance = 494;
            this.splitContainerDown.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.webBrowser3, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(490, 302);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 5;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel7.Controls.Add(this.btnBack3, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnForward3, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.txtPath3, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnUp3, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnOpen3, 4, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(482, 54);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btnBack3
            // 
            this.btnBack3.BackColor = System.Drawing.Color.Azure;
            this.btnBack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack3.Enabled = false;
            this.btnBack3.ImageIndex = 4;
            this.btnBack3.ImageList = this.imageList1;
            this.btnBack3.Location = new System.Drawing.Point(4, 4);
            this.btnBack3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(59, 46);
            this.btnBack3.TabIndex = 0;
            this.btnBack3.UseVisualStyleBackColor = false;
            this.btnBack3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward3
            // 
            this.btnForward3.BackColor = System.Drawing.Color.Azure;
            this.btnForward3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward3.Enabled = false;
            this.btnForward3.ImageIndex = 6;
            this.btnForward3.ImageList = this.imageList1;
            this.btnForward3.Location = new System.Drawing.Point(71, 4);
            this.btnForward3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward3.Name = "btnForward3";
            this.btnForward3.Size = new System.Drawing.Size(59, 46);
            this.btnForward3.TabIndex = 0;
            this.btnForward3.UseVisualStyleBackColor = false;
            this.btnForward3.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath3
            // 
            this.txtPath3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath3.Location = new System.Drawing.Point(210, 9);
            this.txtPath3.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(196, 34);
            this.txtPath3.TabIndex = 1;
            this.txtPath3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // btnUp3
            // 
            this.btnUp3.BackColor = System.Drawing.Color.Azure;
            this.btnUp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp3.ImageIndex = 7;
            this.btnUp3.ImageList = this.imageList1;
            this.btnUp3.Location = new System.Drawing.Point(138, 4);
            this.btnUp3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp3.Name = "btnUp3";
            this.btnUp3.Size = new System.Drawing.Size(59, 46);
            this.btnUp3.TabIndex = 0;
            this.btnUp3.UseVisualStyleBackColor = false;
            this.btnUp3.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Azure;
            this.btnOpen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen3.ImageIndex = 5;
            this.btnOpen3.ImageList = this.imageList1;
            this.btnOpen3.Location = new System.Drawing.Point(419, 4);
            this.btnOpen3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(59, 46);
            this.btnOpen3.TabIndex = 0;
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.btnSearch3, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.txtSearch3, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.ckboxMatchCase3, 2, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(4, 244);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(482, 54);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // btnSearch3
            // 
            this.btnSearch3.BackColor = System.Drawing.Color.Azure;
            this.btnSearch3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch3.ImageIndex = 9;
            this.btnSearch3.ImageList = this.imageList1;
            this.btnSearch3.Location = new System.Drawing.Point(171, 4);
            this.btnSearch3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(59, 46);
            this.btnSearch3.TabIndex = 0;
            this.btnSearch3.UseVisualStyleBackColor = false;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch3
            // 
            this.txtSearch3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch3.Location = new System.Drawing.Point(9, 9);
            this.txtSearch3.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtSearch3.Name = "txtSearch3";
            this.txtSearch3.Size = new System.Drawing.Size(149, 34);
            this.txtSearch3.TabIndex = 1;
            // 
            // ckboxMatchCase3
            // 
            this.ckboxMatchCase3.AutoSize = true;
            this.ckboxMatchCase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMatchCase3.Location = new System.Drawing.Point(238, 4);
            this.ckboxMatchCase3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckboxMatchCase3.Name = "ckboxMatchCase3";
            this.ckboxMatchCase3.Size = new System.Drawing.Size(72, 46);
            this.ckboxMatchCase3.TabIndex = 2;
            this.ckboxMatchCase3.Text = "Match \r\nCase";
            this.ckboxMatchCase3.UseVisualStyleBackColor = true;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(4, 66);
            this.webBrowser3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(482, 170);
            this.webBrowser3.TabIndex = 2;
            this.webBrowser3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.webBrowser4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(538, 302);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 5;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel8.Controls.Add(this.btnBack4, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnOpen4, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnUp4, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnForward4, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtPath4, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(530, 54);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // btnBack4
            // 
            this.btnBack4.BackColor = System.Drawing.Color.Azure;
            this.btnBack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack4.Enabled = false;
            this.btnBack4.ImageIndex = 4;
            this.btnBack4.ImageList = this.imageList1;
            this.btnBack4.Location = new System.Drawing.Point(4, 4);
            this.btnBack4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(59, 46);
            this.btnBack4.TabIndex = 0;
            this.btnBack4.UseVisualStyleBackColor = false;
            this.btnBack4.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Azure;
            this.btnOpen4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen4.ImageKey = "Down.png";
            this.btnOpen4.ImageList = this.imageList1;
            this.btnOpen4.Location = new System.Drawing.Point(467, 4);
            this.btnOpen4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(59, 46);
            this.btnOpen4.TabIndex = 0;
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnUp4
            // 
            this.btnUp4.BackColor = System.Drawing.Color.Azure;
            this.btnUp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUp4.ImageIndex = 7;
            this.btnUp4.ImageList = this.imageList1;
            this.btnUp4.Location = new System.Drawing.Point(138, 4);
            this.btnUp4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp4.Name = "btnUp4";
            this.btnUp4.Size = new System.Drawing.Size(59, 46);
            this.btnUp4.TabIndex = 0;
            this.btnUp4.UseVisualStyleBackColor = false;
            this.btnUp4.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnForward4
            // 
            this.btnForward4.BackColor = System.Drawing.Color.Azure;
            this.btnForward4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward4.Enabled = false;
            this.btnForward4.ImageIndex = 6;
            this.btnForward4.ImageList = this.imageList1;
            this.btnForward4.Location = new System.Drawing.Point(71, 4);
            this.btnForward4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnForward4.Name = "btnForward4";
            this.btnForward4.Size = new System.Drawing.Size(59, 46);
            this.btnForward4.TabIndex = 0;
            this.btnForward4.UseVisualStyleBackColor = false;
            this.btnForward4.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath4
            // 
            this.txtPath4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath4.Location = new System.Drawing.Point(210, 9);
            this.txtPath4.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.Size = new System.Drawing.Size(244, 34);
            this.txtPath4.TabIndex = 1;
            this.txtPath4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 4;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.btnSearch4, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.txtSearch4, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.ckboxMatchCase4, 2, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 244);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(530, 54);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // btnSearch4
            // 
            this.btnSearch4.BackColor = System.Drawing.Color.Azure;
            this.btnSearch4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch4.ImageIndex = 9;
            this.btnSearch4.ImageList = this.imageList1;
            this.btnSearch4.Location = new System.Drawing.Point(195, 4);
            this.btnSearch4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch4.Name = "btnSearch4";
            this.btnSearch4.Size = new System.Drawing.Size(59, 46);
            this.btnSearch4.TabIndex = 0;
            this.btnSearch4.UseVisualStyleBackColor = false;
            this.btnSearch4.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch4
            // 
            this.txtSearch4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch4.Location = new System.Drawing.Point(9, 9);
            this.txtSearch4.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.txtSearch4.Name = "txtSearch4";
            this.txtSearch4.Size = new System.Drawing.Size(173, 34);
            this.txtSearch4.TabIndex = 1;
            // 
            // ckboxMatchCase4
            // 
            this.ckboxMatchCase4.AutoSize = true;
            this.ckboxMatchCase4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMatchCase4.Location = new System.Drawing.Point(262, 4);
            this.ckboxMatchCase4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckboxMatchCase4.Name = "ckboxMatchCase4";
            this.ckboxMatchCase4.Size = new System.Drawing.Size(72, 46);
            this.ckboxMatchCase4.TabIndex = 2;
            this.ckboxMatchCase4.Text = "Match \r\nCase";
            this.ckboxMatchCase4.UseVisualStyleBackColor = true;
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(4, 66);
            this.webBrowser4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(530, 170);
            this.webBrowser4.TabIndex = 2;
            this.webBrowser4.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(318, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(163, 48);
            this.progressBar1.TabIndex = 3;
            // 
            // bkgWorkerSearch1
            // 
            this.bkgWorkerSearch1.WorkerReportsProgress = true;
            this.bkgWorkerSearch1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkerSearch1_DoWork);
            this.bkgWorkerSearch1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkerSearch1_ProgressChanged);
            this.bkgWorkerSearch1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgWorkerSearch1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 606);
            this.Controls.Add(this.splitContainerOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M_Windows_Explorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainerOut.Panel1.ResumeLayout(false);
            this.splitContainerOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).EndInit();
            this.splitContainerOut.ResumeLayout(false);
            this.splitContainerUp.Panel1.ResumeLayout(false);
            this.splitContainerUp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).EndInit();
            this.splitContainerUp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.splitContainerDown.Panel1.ResumeLayout(false);
            this.splitContainerDown.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).EndInit();
            this.splitContainerDown.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOut;
        private System.Windows.Forms.SplitContainer splitContainerUp;
        private System.Windows.Forms.SplitContainer splitContainerDown;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Button btnUp1;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnUp2;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnForward3;
        private System.Windows.Forms.Button btnUp3;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnUp4;
        private System.Windows.Forms.Button btnForward4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button btnSearch4;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtSearch1;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.TextBox txtSearch2;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.TextBox txtSearch3;
        private System.Windows.Forms.TextBox txtPath4;
        private System.Windows.Forms.TextBox txtSearch4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.CheckBox ckboxMatchCase1;
        private System.Windows.Forms.CheckBox ckboxMatchCase2;
        private System.Windows.Forms.CheckBox ckboxMatchCase3;
        private System.Windows.Forms.CheckBox ckboxMatchCase4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bkgWorkerSearch1;

    }
}