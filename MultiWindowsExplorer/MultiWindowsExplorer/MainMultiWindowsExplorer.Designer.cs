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
            this.splitContainerOut = new System.Windows.Forms.SplitContainer();
            this.splitContainerUp = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack1 = new System.Windows.Forms.ToolStripButton();
            this.btnForward1 = new System.Windows.Forms.ToolStripButton();
            this.btnUp1 = new System.Windows.Forms.ToolStripButton();
            this.btnOpen1 = new System.Windows.Forms.ToolStripButton();
            this.txtPath1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBrowser1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabSearch1 = new System.Windows.Forms.TabPage();
            this.listViewSearch1 = new System.Windows.Forms.ListView();
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ckboxMatchCase1 = new System.Windows.Forms.CheckBox();
            this.txtSearch1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainerDown = new System.Windows.Forms.SplitContainer();
            this.bkgWorkerSearch1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).BeginInit();
            this.splitContainerOut.Panel1.SuspendLayout();
            this.splitContainerOut.Panel2.SuspendLayout();
            this.splitContainerOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).BeginInit();
            this.splitContainerUp.Panel1.SuspendLayout();
            this.splitContainerUp.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBrowser1.SuspendLayout();
            this.tabSearch1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).BeginInit();
            this.splitContainerDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerOut
            // 
            this.splitContainerOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOut.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainerOut.Size = new System.Drawing.Size(872, 462);
            this.splitContainerOut.SplitterDistance = 215;
            this.splitContainerOut.TabIndex = 0;
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
            this.splitContainerUp.Size = new System.Drawing.Size(872, 215);
            this.splitContainerUp.SplitterDistance = 426;
            this.splitContainerUp.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtPath1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(416, 44);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack1,
            this.btnForward1,
            this.btnUp1,
            this.btnOpen1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(200, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnBack1
            // 
            this.btnBack1.AutoSize = false;
            this.btnBack1.AutoToolTip = false;
            this.btnBack1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack1.Image = ((System.Drawing.Image)(resources.GetObject("btnBack1.Image")));
            this.btnBack1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(40, 41);
            this.btnBack1.Text = "toolStripButton1";
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.AutoSize = false;
            this.btnForward1.AutoToolTip = false;
            this.btnForward1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward1.Image = ((System.Drawing.Image)(resources.GetObject("btnForward1.Image")));
            this.btnForward1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(40, 41);
            this.btnForward1.Text = "toolStripButton1";
            this.btnForward1.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnUp1
            // 
            this.btnUp1.AutoSize = false;
            this.btnUp1.AutoToolTip = false;
            this.btnUp1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUp1.Image = ((System.Drawing.Image)(resources.GetObject("btnUp1.Image")));
            this.btnUp1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUp1.Name = "btnUp1";
            this.btnUp1.Size = new System.Drawing.Size(40, 41);
            this.btnUp1.Text = "toolStripButton1";
            this.btnUp1.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnOpen1
            // 
            this.btnOpen1.AutoSize = false;
            this.btnOpen1.AutoToolTip = false;
            this.btnOpen1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen1.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen1.Image")));
            this.btnOpen1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(40, 41);
            this.btnOpen1.Text = "toolStripButton1";
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath1.Location = new System.Drawing.Point(203, 3);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(210, 38);
            this.txtPath1.TabIndex = 1;
            this.txtPath1.Text = "";
            this.txtPath1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OntxtPathKeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBrowser1);
            this.tabControl1.Controls.Add(this.tabSearch1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(416, 105);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.TabStop = false;
            // 
            // tabBrowser1
            // 
            this.tabBrowser1.Controls.Add(this.webBrowser1);
            this.tabBrowser1.Location = new System.Drawing.Point(4, 25);
            this.tabBrowser1.Name = "tabBrowser1";
            this.tabBrowser1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrowser1.Size = new System.Drawing.Size(408, 76);
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
            this.webBrowser1.Size = new System.Drawing.Size(402, 70);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.OnShowPathText);
            // 
            // tabSearch1
            // 
            this.tabSearch1.Controls.Add(this.listViewSearch1);
            this.tabSearch1.Location = new System.Drawing.Point(4, 25);
            this.tabSearch1.Name = "tabSearch1";
            this.tabSearch1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch1.Size = new System.Drawing.Size(408, 76);
            this.tabSearch1.TabIndex = 1;
            this.tabSearch1.Text = "Search Result";
            this.tabSearch1.UseVisualStyleBackColor = true;
            // 
            // listViewSearch1
            // 
            this.listViewSearch1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFile,
            this.columnHeaderDir});
            this.listViewSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSearch1.FullRowSelect = true;
            this.listViewSearch1.GridLines = true;
            this.listViewSearch1.Location = new System.Drawing.Point(3, 3);
            this.listViewSearch1.Name = "listViewSearch1";
            this.listViewSearch1.Size = new System.Drawing.Size(402, 70);
            this.listViewSearch1.TabIndex = 0;
            this.listViewSearch1.UseCompatibleStateImageBehavior = false;
            this.listViewSearch1.View = System.Windows.Forms.View.Details;
            this.listViewSearch1.SelectedIndexChanged += new System.EventHandler(this.listViewSearch_SelectedIndexChanged);
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "Searched Files Name(s)";
            this.columnHeaderFile.Width = 194;
            // 
            // columnHeaderDir
            // 
            this.columnHeaderDir.Text = "Directory";
            this.columnHeaderDir.Width = 204;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSearch1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ckboxMatchCase1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearch1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.progressBar1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 164);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(416, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch1.ImageIndex = 1;
            this.btnSearch1.ImageList = this.imageList1;
            this.btnSearch1.Location = new System.Drawing.Point(121, 3);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(44, 38);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "894f0362 - Copy.png");
            this.imageList1.Images.SetKeyName(1, "894f0362.png");
            this.imageList1.Images.SetKeyName(2, "back - Copy.png");
            this.imageList1.Images.SetKeyName(3, "back.png");
            this.imageList1.Images.SetKeyName(4, "COMPUTER - Copy.ICO");
            this.imageList1.Images.SetKeyName(5, "COMPUTER.ICO");
            this.imageList1.Images.SetKeyName(6, "consumer - Copy.ico");
            this.imageList1.Images.SetKeyName(7, "consumer.ico");
            this.imageList1.Images.SetKeyName(8, "Down - Copy.png");
            this.imageList1.Images.SetKeyName(9, "Down.png");
            // 
            // ckboxMatchCase1
            // 
            this.ckboxMatchCase1.AutoSize = true;
            this.ckboxMatchCase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckboxMatchCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckboxMatchCase1.Location = new System.Drawing.Point(171, 3);
            this.ckboxMatchCase1.Name = "ckboxMatchCase1";
            this.ckboxMatchCase1.Size = new System.Drawing.Size(74, 38);
            this.ckboxMatchCase1.TabIndex = 1;
            this.ckboxMatchCase1.Text = "Match \r\nCase";
            this.ckboxMatchCase1.UseVisualStyleBackColor = true;
            // 
            // txtSearch1
            // 
            this.txtSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch1.Location = new System.Drawing.Point(3, 3);
            this.txtSearch1.Name = "txtSearch1";
            this.txtSearch1.Size = new System.Drawing.Size(112, 38);
            this.txtSearch1.TabIndex = 2;
            this.txtSearch1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(251, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 38);
            this.progressBar1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "0%";
            // 
            // splitContainerDown
            // 
            this.splitContainerDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDown.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDown.Name = "splitContainerDown";
            this.splitContainerDown.Size = new System.Drawing.Size(872, 243);
            this.splitContainerDown.SplitterDistance = 426;
            this.splitContainerDown.TabIndex = 0;
            // 
            // bkgWorkerSearch1
            // 
            this.bkgWorkerSearch1.WorkerReportsProgress = true;
            this.bkgWorkerSearch1.WorkerSupportsCancellation = true;
            this.bkgWorkerSearch1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkerSearch1_DoWork);
            this.bkgWorkerSearch1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkerSearch1_ProgressChanged);
            this.bkgWorkerSearch1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgWorkerSearch1_RunWorkerCompleted);
            // 
            // MainMultiWindowsExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 462);
            this.Controls.Add(this.splitContainerOut);
            this.Name = "MainMultiWindowsExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMultiWindowsExplorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainerOut.Panel1.ResumeLayout(false);
            this.splitContainerOut.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOut)).EndInit();
            this.splitContainerOut.ResumeLayout(false);
            this.splitContainerUp.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUp)).EndInit();
            this.splitContainerUp.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBrowser1.ResumeLayout(false);
            this.tabSearch1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDown)).EndInit();
            this.splitContainerDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOut;
        private System.Windows.Forms.SplitContainer splitContainerUp;
        private System.Windows.Forms.SplitContainer splitContainerDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack1;
        private System.Windows.Forms.ToolStripButton btnForward1;
        private System.Windows.Forms.ToolStripButton btnUp1;
        private System.Windows.Forms.ToolStripButton btnOpen1;
        private System.Windows.Forms.RichTextBox txtPath1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch1;
        private System.Windows.Forms.TabPage tabBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListView listViewSearch1;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ColumnHeader columnHeaderDir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.CheckBox ckboxMatchCase1;
        private System.Windows.Forms.RichTextBox txtSearch1;
        private System.ComponentModel.BackgroundWorker bkgWorkerSearch1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}