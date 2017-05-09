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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack4 = new System.Windows.Forms.Button();
            this.btnForward4 = new System.Windows.Forms.Button();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnForward3 = new System.Windows.Forms.Button();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.webBrowser4 = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.webBrowser4, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 674);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Controls.Add(this.btnBack4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnForward4, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtPath4, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnOpen4, 3, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(570, 339);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(561, 27);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // btnBack4
            // 
            this.btnBack4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack4.Location = new System.Drawing.Point(3, 3);
            this.btnBack4.Name = "btnBack4";
            this.btnBack4.Size = new System.Drawing.Size(50, 21);
            this.btnBack4.TabIndex = 0;
            this.btnBack4.Text = "<<";
            this.btnBack4.UseVisualStyleBackColor = true;
            this.btnBack4.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward4
            // 
            this.btnForward4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward4.Location = new System.Drawing.Point(59, 3);
            this.btnForward4.Name = "btnForward4";
            this.btnForward4.Size = new System.Drawing.Size(50, 21);
            this.btnForward4.TabIndex = 1;
            this.btnForward4.Text = ">>";
            this.btnForward4.UseVisualStyleBackColor = true;
            this.btnForward4.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath4
            // 
            this.txtPath4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath4.Location = new System.Drawing.Point(115, 3);
            this.txtPath4.Multiline = true;
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.Size = new System.Drawing.Size(330, 21);
            this.txtPath4.TabIndex = 2;
            // 
            // btnOpen4
            // 
            this.btnOpen4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen4.Location = new System.Drawing.Point(451, 3);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(107, 21);
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
            this.tableLayoutPanel4.Controls.Add(this.txtPath2, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnOpen2, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 339);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(561, 27);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnBack2
            // 
            this.btnBack2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack2.Location = new System.Drawing.Point(3, 3);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(50, 21);
            this.btnBack2.TabIndex = 0;
            this.btnBack2.Text = "<<";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward2.Location = new System.Drawing.Point(59, 3);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(50, 21);
            this.btnForward2.TabIndex = 1;
            this.btnForward2.Text = ">>";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath2.Location = new System.Drawing.Point(115, 3);
            this.txtPath2.Multiline = true;
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(330, 21);
            this.txtPath2.TabIndex = 2;
            // 
            // btnOpen2
            // 
            this.btnOpen2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen2.Location = new System.Drawing.Point(451, 3);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(107, 21);
            this.btnOpen2.TabIndex = 3;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = true;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen_Click);
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
            this.tableLayoutPanel3.Controls.Add(this.txtPath3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOpen3, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(570, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(561, 27);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // btnBack3
            // 
            this.btnBack3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack3.Location = new System.Drawing.Point(3, 3);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(50, 21);
            this.btnBack3.TabIndex = 0;
            this.btnBack3.Text = "<<";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward3
            // 
            this.btnForward3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward3.Location = new System.Drawing.Point(59, 3);
            this.btnForward3.Name = "btnForward3";
            this.btnForward3.Size = new System.Drawing.Size(50, 21);
            this.btnForward3.TabIndex = 1;
            this.btnForward3.Text = ">>";
            this.btnForward3.UseVisualStyleBackColor = true;
            this.btnForward3.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath3
            // 
            this.txtPath3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath3.Location = new System.Drawing.Point(115, 3);
            this.txtPath3.Multiline = true;
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(330, 21);
            this.txtPath3.TabIndex = 2;
            // 
            // btnOpen3
            // 
            this.btnOpen3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen3.Location = new System.Drawing.Point(451, 3);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(107, 21);
            this.btnOpen3.TabIndex = 3;
            this.btnOpen3.Text = "Open";
            this.btnOpen3.UseVisualStyleBackColor = true;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen_Click);
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(561, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnBack1
            // 
            this.btnBack1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack1.Location = new System.Drawing.Point(3, 3);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(50, 21);
            this.btnBack1.TabIndex = 0;
            this.btnBack1.Text = "<<";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward1
            // 
            this.btnForward1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward1.Location = new System.Drawing.Point(59, 3);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(50, 21);
            this.btnForward1.TabIndex = 1;
            this.btnForward1.Text = ">>";
            this.btnForward1.UseVisualStyleBackColor = true;
            this.btnForward1.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath1.Location = new System.Drawing.Point(115, 3);
            this.txtPath1.Multiline = true;
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(330, 21);
            this.txtPath1.TabIndex = 2;
            // 
            // btnOpen1
            // 
            this.btnOpen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpen1.Location = new System.Drawing.Point(451, 3);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(107, 21);
            this.btnOpen1.TabIndex = 3;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = true;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 36);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(561, 297);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ShowPath);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.Location = new System.Drawing.Point(3, 372);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(561, 299);
            this.webBrowser2.TabIndex = 2;
            this.webBrowser2.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ShowPath);
            // 
            // webBrowser3
            // 
            this.webBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser3.Location = new System.Drawing.Point(570, 36);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(561, 297);
            this.webBrowser3.TabIndex = 3;
            this.webBrowser3.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ShowPath);
            // 
            // webBrowser4
            // 
            this.webBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser4.Location = new System.Drawing.Point(570, 372);
            this.webBrowser4.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser4.Name = "webBrowser4";
            this.webBrowser4.Size = new System.Drawing.Size(561, 299);
            this.webBrowser4.TabIndex = 4;
            this.webBrowser4.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.ShowPath);
            // 
            // FormExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1134, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExplorer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi File Explorer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnForward3;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.WebBrowser webBrowser4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnBack4;
        private System.Windows.Forms.Button btnForward4;
        private System.Windows.Forms.TextBox txtPath4;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnOpen2;



    }
}

