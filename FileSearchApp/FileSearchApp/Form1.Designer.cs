namespace FileSearchApp
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtPath0 = new System.Windows.Forms.TextBox();
            this.txtSearch0 = new System.Windows.Forms.TextBox();
            this.btnSearch0 = new System.Windows.Forms.Button();
            this.ckboxMatchCase0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bkgSearch0 = new System.ComponentModel.BackgroundWorker();
            this.progressBar0 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(53, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(380, 197);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // txtPath0
            // 
            this.txtPath0.Location = new System.Drawing.Point(184, 254);
            this.txtPath0.Name = "txtPath0";
            this.txtPath0.Size = new System.Drawing.Size(249, 22);
            this.txtPath0.TabIndex = 1;
            // 
            // txtSearch0
            // 
            this.txtSearch0.Location = new System.Drawing.Point(184, 291);
            this.txtSearch0.Name = "txtSearch0";
            this.txtSearch0.Size = new System.Drawing.Size(249, 22);
            this.txtSearch0.TabIndex = 1;
            // 
            // btnSearch0
            // 
            this.btnSearch0.Location = new System.Drawing.Point(19, 341);
            this.btnSearch0.Name = "btnSearch0";
            this.btnSearch0.Size = new System.Drawing.Size(108, 34);
            this.btnSearch0.TabIndex = 2;
            this.btnSearch0.Text = "Search";
            this.btnSearch0.UseVisualStyleBackColor = true;
            this.btnSearch0.Click += new System.EventHandler(this.btnSearch0_Click);
            // 
            // ckboxMatchCase0
            // 
            this.ckboxMatchCase0.AutoSize = true;
            this.ckboxMatchCase0.Location = new System.Drawing.Point(143, 349);
            this.ckboxMatchCase0.Name = "ckboxMatchCase0";
            this.ckboxMatchCase0.Size = new System.Drawing.Size(102, 21);
            this.ckboxMatchCase0.TabIndex = 3;
            this.ckboxMatchCase0.Text = "Match case";
            this.ckboxMatchCase0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dir";
            // 
            // bkgSearch0
            // 
            this.bkgSearch0.WorkerReportsProgress = true;
            this.bkgSearch0.WorkerSupportsCancellation = true;
            this.bkgSearch0.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgSearch0_DoWork);
            this.bkgSearch0.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgSearch0_ProgressChanged);
            this.bkgSearch0.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgSearch0_RunWorkerCompleted);
            // 
            // progressBar0
            // 
            this.progressBar0.Location = new System.Drawing.Point(251, 357);
            this.progressBar0.Name = "progressBar0";
            this.progressBar0.Size = new System.Drawing.Size(173, 23);
            this.progressBar0.TabIndex = 5;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(441, 357);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(46, 17);
            this.lblprogress.TabIndex = 6;
            this.lblprogress.Text = "label3";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Searched File Name";
            this.columnHeader1.Width = 136;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Directories";
            this.columnHeader2.Width = 240;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 433);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.progressBar0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckboxMatchCase0);
            this.Controls.Add(this.btnSearch0);
            this.Controls.Add(this.txtSearch0);
            this.Controls.Add(this.txtPath0);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtPath0;
        private System.Windows.Forms.TextBox txtSearch0;
        private System.Windows.Forms.Button btnSearch0;
        private System.Windows.Forms.CheckBox ckboxMatchCase0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bkgSearch0;
        private System.Windows.Forms.ProgressBar progressBar0;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

