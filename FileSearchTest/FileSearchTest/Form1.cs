using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Control GetControlByName(String Name)
        {
            return Controls.Find(Name,true).FirstOrDefault();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchFile searchFiles = new SearchFile(this, sender);
            searchFiles.InitSearch();
            
            ProgressBar progressBar = GetControlByName("progressBar1") as ProgressBar;
            InitProgressBar(progressBar,searchFiles.fileSearching.TotalFileNumber);
            bkgSearch0.RunWorkerAsync(searchFiles);
        }

        private void InitProgressBar(ProgressBar progressBar, int max)
        {
            Label lab = GetControlByName("labelProgress") as Label;
            progressBar.Value = 0;
            lab.Text = "0 %";
            progressBar.Maximum = max;
            progressBar.Step = progressBar.Maximum / 100;
        }

        private void bkgSearch0_DoWork(object sender, DoWorkEventArgs e)
        {
            SearchFile sf = e.Argument as SearchFile;
            BackgroundWorker bkw1 = sender as BackgroundWorker;
            e.Result = sf;
            sf.bkw = bkw1;

            sf.DoSearchFile(sf.dirName, sf.fileName, false);

        }

        private void bkgSearch0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int progress = e.ProgressPercentage;
            ProgressBar progressBar = GetControlByName("progressBar1") as ProgressBar;
            UpdateProgressBar(progressBar, progress);
        }

        private void UpdateProgressBar(ProgressBar progressBar, int progress)
        {
            progressBar.PerformStep();
            labelProgress.Text = progress + " %";
        }

        private void bkgSearch0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            SearchFile sf = e.Result as SearchFile;

            ProgressBar progressBar = GetControlByName("progressBar1") as ProgressBar;
            UpdateProgressBar(progressBar, 100);
            
            sf.EnableBtnAndCkb(true);
            labelProgress.Text = 100 + "%";
        }
    }
}
