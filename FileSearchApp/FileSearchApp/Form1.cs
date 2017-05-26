using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FileSearchApp
{
    delegate void updateTxt(String data);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Searching search;
        private void btnSearch0_Click(object sender, EventArgs e)
        {
            search = new Searching();
            
            String dirName = txtPath0.Text;
            
            int total = search.getTotalFileNumber(dirName);
            
            progressBar0.Maximum = total;
            progressBar0.Step = 1;
            if (total > 100)
            {
                progressBar0.Step = total / 100;
            }

            bkgSearch0.RunWorkerAsync();
            //this.txtSearch0.Text = total.ToString();
        }

        public Control getControlBySender(object sender, String baseName)
        {
            return Controls.Find(baseName + 0, true).FirstOrDefault();
        }

        private void bkgSearch0_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            String dirName = txtPath0.Text;
            String fileName = txtSearch0.Text;
            search.BackWorker = worker;

            search.SearchFileInDir(dirName, fileName);
            

        }

        private void bkgSearch0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar0.PerformStep();
        }

        private void bkgSearch0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ShowSearchedResult(search.searchedFiles);  
        }

        private void ShowSearchedResult(List<FileInfo> list)
        {
            foreach (var file in list)
            {
                ListViewItem lv = new ListViewItem(file.Name);
                lv.SubItems.Add(file.Directory.FullName);
                listView1.Items.Add(lv);
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
