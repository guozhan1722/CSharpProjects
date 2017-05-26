﻿namespace FileSearchApp
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPath0 = new System.Windows.Forms.TextBox();
            this.txtSearch0 = new System.Windows.Forms.TextBox();
            this.btnSearch0 = new System.Windows.Forms.Button();
            this.ckboxMatchCase0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bkgSearch0 = new System.ComponentModel.BackgroundWorker();
            this.progressBar0 = new System.Windows.Forms.ProgressBar();
            this.lblprogress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(40, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 161);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
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
            // txtPath0
            // 
            this.txtPath0.Location = new System.Drawing.Point(138, 206);
            this.txtPath0.Margin = new System.Windows.Forms.Padding(2);
            this.txtPath0.Name = "txtPath0";
            this.txtPath0.Size = new System.Drawing.Size(188, 20);
            this.txtPath0.TabIndex = 1;
            // 
            // txtSearch0
            // 
            this.txtSearch0.Location = new System.Drawing.Point(138, 236);
            this.txtSearch0.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch0.Name = "txtSearch0";
            this.txtSearch0.Size = new System.Drawing.Size(188, 20);
            this.txtSearch0.TabIndex = 1;
            // 
            // btnSearch0
            // 
            this.btnSearch0.Location = new System.Drawing.Point(14, 277);
            this.btnSearch0.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch0.Name = "btnSearch0";
            this.btnSearch0.Size = new System.Drawing.Size(81, 28);
            this.btnSearch0.TabIndex = 2;
            this.btnSearch0.Text = "Search";
            this.btnSearch0.UseVisualStyleBackColor = true;
            this.btnSearch0.Click += new System.EventHandler(this.btnSearch0_Click);
            // 
            // ckboxMatchCase0
            // 
            this.ckboxMatchCase0.AutoSize = true;
            this.ckboxMatchCase0.Location = new System.Drawing.Point(107, 284);
            this.ckboxMatchCase0.Margin = new System.Windows.Forms.Padding(2);
            this.ckboxMatchCase0.Name = "ckboxMatchCase0";
            this.ckboxMatchCase0.Size = new System.Drawing.Size(82, 17);
            this.ckboxMatchCase0.TabIndex = 3;
            this.ckboxMatchCase0.Text = "Match case";
            this.ckboxMatchCase0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
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
            this.progressBar0.Location = new System.Drawing.Point(188, 290);
            this.progressBar0.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar0.Name = "progressBar0";
            this.progressBar0.Size = new System.Drawing.Size(130, 19);
            this.progressBar0.TabIndex = 5;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(331, 290);
            this.lblprogress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(35, 13);
            this.lblprogress.TabIndex = 6;
            this.lblprogress.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 352);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.progressBar0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckboxMatchCase0);
            this.Controls.Add(this.btnSearch0);
            this.Controls.Add(this.txtSearch0);
            this.Controls.Add(this.txtPath0);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}
