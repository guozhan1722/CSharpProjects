namespace MultiWindowsExplorer
{
    partial class FormExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void StoreUrlValue()
        {
            for(int i=0; i<explorerNum;i++)
            {
                AppSettings.UpdateSettings(appSettingKeys[i], pathTxt[i].Text);
            }
        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExplorer));
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnForward3 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnForward4 = new System.Windows.Forms.Button();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack4
            // 
            this.btnBack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack4.Location = new System.Drawing.Point(3, 3);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(36, 28);
            this.btnBack4.TabIndex = 0;
            this.btnBack4.Text = "<<";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen4.Location = new System.Drawing.Point(340, 3);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(79, 28);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "Open";
            this.btnOpen4.UseVisualStyleBackColor = true;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.btnBack2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnForward2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpen2, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPath2, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(525, 34);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnBack2
            // 
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.Location = new System.Drawing.Point(3, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(46, 28);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.Text = "<<";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward2.Location = new System.Drawing.Point(55, 3);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(46, 28);
            this.btnForward2.TabIndex = 1;
            this.btnForward2.Text = ">>";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen2.Location = new System.Drawing.Point(422, 3);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(100, 28);
            this.btnOpen2.TabIndex = 3;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.AcceptsReturn = true;
            this.txtPath2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtPath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath2.Location = new System.Drawing.Point(109, 5);
            this.txtPath2.Margin = new System.Windows.Forms.Padding(5);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(305, 22);
            this.txtPath2.TabIndex = 2;
            this.txtPath2.WordWrap = false;
            this.txtPath2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnBack3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnForward3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpen3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPath3, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(458, 34);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnBack3
            // 
            this.btnBack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack3.Location = new System.Drawing.Point(3, 3);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(39, 28);
            this.btnBack3.TabIndex = 0;
            this.btnBack3.Text = "<<";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward3
            // 
            this.btnForward3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward3.Location = new System.Drawing.Point(48, 3);
            this.btnForward3.Name = "btnForward3";
            this.btnForward3.Size = new System.Drawing.Size(39, 28);
            this.btnForward3.TabIndex = 1;
            this.btnForward3.Text = ">>";
            this.btnForward3.UseVisualStyleBackColor = true;
            this.btnForward3.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen3.Location = new System.Drawing.Point(367, 3);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(88, 28);
            this.btnOpen3.TabIndex = 3;
            this.btnOpen3.Text = "Open";
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath3
            // 
            this.txtPath3.AcceptsReturn = true;
            this.txtPath3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtPath3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath3.Location = new System.Drawing.Point(95, 5);
            this.txtPath3.Margin = new System.Windows.Forms.Padding(5);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(264, 22);
            this.txtPath3.TabIndex = 2;
            this.txtPath3.WordWrap = false;
            this.txtPath3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnBack1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnForward1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPath1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOpen1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBack1
            // 
            this.btnBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack1.Location = new System.Drawing.Point(3, 3);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(42, 28);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "<<";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward1.Location = new System.Drawing.Point(51, 3);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(42, 28);
            this.btnForward1.TabIndex = 1;
            this.btnForward1.Text = ">>";
            this.btnForward1.UseVisualStyleBackColor = true;
            this.btnForward1.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen1.Location = new System.Drawing.Point(392, 3);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(94, 28);
            this.btnOpen1.TabIndex = 3;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.AcceptsReturn = true;
            this.txtPath1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath1.Location = new System.Drawing.Point(101, 5);
            this.txtPath1.Margin = new System.Windows.Forms.Padding(5);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(283, 22);
            this.txtPath1.TabIndex = 2;
            this.txtPath1.WordWrap = false;
            this.txtPath1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 43);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(489, 259);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPath);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 43);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(525, 219);
            this.webBrowser2.TabIndex = 2;
            this.webBrowser2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPath);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(3, 43);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(458, 259);
            this.webBrowser3.TabIndex = 3;
            this.webBrowser3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPath);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(3, 43);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(422, 219);
            this.webBrowser4.TabIndex = 4;
            this.webBrowser4.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPath);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(971, 582);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.TabIndex = 5;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel5);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel6);
            this.splitContainer3.Size = new System.Drawing.Size(971, 309);
            this.splitContainer3.SplitterDistance = 499;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(495, 305);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.webBrowser3, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(464, 305);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel7);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel8);
            this.splitContainer2.Size = new System.Drawing.Size(971, 269);
            this.splitContainer2.SplitterDistance = 535;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.webBrowser2, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(531, 265);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.webBrowser4, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(428, 265);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnOpen4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnForward4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPath4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnForward4
            // 
            this.btnForward4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward4.Location = new System.Drawing.Point(45, 3);
            this.btnForward4.Name = "btnForward4";
            this.btnForward4.Size = new System.Drawing.Size(36, 28);
            this.btnForward4.TabIndex = 1;
            this.btnForward4.Text = ">>";
            this.btnForward4.UseVisualStyleBackColor = true;
            this.btnForward4.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath4
            // 
            this.txtPath4.AcceptsReturn = true;
            this.txtPath4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPath4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtPath4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath4.Location = new System.Drawing.Point(89, 5);
            this.txtPath4.Margin = new System.Windows.Forms.Padding(5);
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.Size = new System.Drawing.Size(243, 22);
            this.txtPath4.TabIndex = 2;
            this.txtPath4.WordWrap = false;
            this.txtPath4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(971, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Windows Explorer";
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnForward3;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnOpen2;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnForward4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.TextBox txtPath4;



    }
}

