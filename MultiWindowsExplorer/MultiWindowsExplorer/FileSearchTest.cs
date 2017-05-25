using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowsExplorer
{
    class FileSearchTest
    {
        public object  Sender { get; set; }
        private String FileName { get; set; }
        private String DirName  { get; set; }
        private MainMultiWindowsExplorer mainMultiWindowsExplorer { get; set; }
        private bool isMatchCase { get; set; }
        public int currentSection { get; set; }
        private Button searchBtn { get; set; }
        private CheckBox matchCkB { get; set; }
        private ProgressBar progressBar { get; set; }
        private int TotalFileNumber { get; set; }
        public BackgroundWorker bkw;
        private int SearchedFileNumber;
        List<FileInfo> SearchedFiles;
        public bool isFileFound { get; set; }

        public FileSearchTest(object sender)
        {
            this.Sender = sender;

        }

        public FileSearchTest(MainMultiWindowsExplorer mainForm, object sender)
        {
            // TODO: Complete member initialization
            this.mainMultiWindowsExplorer = mainForm;
            this.Sender = sender;

            var dirCtl = mainForm.GetControlBySenderAndName(sender, "txtPath") as RichTextBox;
            var fileCtl = mainForm.GetControlBySenderAndName(sender, "txtSearch") as RichTextBox;
            matchCkB = mainForm.GetControlBySenderAndName(sender, "ckboxMatchCase") as CheckBox;
            searchBtn = mainForm.GetControlBySenderAndName(sender, "btnSearch") as Button;
            progressBar = mainForm.GetControlBySenderAndName(sender, "progressBar") as ProgressBar;

            this.DirName = dirCtl.Text;
            this.FileName = fileCtl.Text;
            this.isMatchCase = matchCkB.Checked;
            this.currentSection = mainForm.GetSectionBySender(sender);
        }

        internal bool isFileNameDirEmpty()
        {
            return (String.IsNullOrEmpty(FileName) || String.IsNullOrEmpty(DirName));
        }

        internal void InitSearch()
        {
            EnableBtnAndCheckbox(false);
            GetTotalSearchFilesNumber();
            InitProgressBar();

        }

        private void InitProgressBar()
        {
            progressBar.Maximum = TotalFileNumber;
            progressBar.Value = 0;
            progressBar.Step = TotalFileNumber / 100;
        }


        public void EnableBtnAndCheckbox(bool p)
        {
            matchCkB.Enabled = p;
            searchBtn.Enabled = p;
        }

        public int GetTotalSearchFilesNumber()
        {
            TotalFileNumber = 0;
            DirectoryInfo dir = new DirectoryInfo(DirName);
            GetNumberFileRecursive(dir);
            return TotalFileNumber;
        }

        private void GetNumberFileRecursive(DirectoryInfo directory)
        {
            DirectoryInfo[] dirDirs;

            if (TotalFileNumber > 10000)
            {
                return;
            }

            try
            {
                dirDirs = directory.GetDirectories();
                if (dirDirs.Length == 0)
                {
                    GetFilesNumberInDir(directory);
                    return;
                }
                else
                {
                    foreach (var dir in dirDirs)
                    {
                        GetNumberFileRecursive(dir);
                    }
                }

            }
            catch (Exception)
            {
            }

        }

        private void GetFilesNumberInDir(DirectoryInfo directory)
        {
            FileInfo[] files = directory.GetFiles();
            TotalFileNumber += files.Length;
        }


         internal void DoSearch()
        {
            DirectoryInfo dir = new DirectoryInfo(DirName);
            SearchedFileNumber = 0;
            SearchedFiles = new List<FileInfo>();

            SearchFileRecursive(dir);
            if (isFileFound == false)
            {
                throw new FileNotFoundException(@"Cannot Find file");
            }

        }

        private void SearchFileRecursive(DirectoryInfo dirctory)
        {
            DirectoryInfo[] dirDirs;

            try
            {
                dirDirs = dirctory.GetDirectories();
                if (dirDirs.Length == 0)
                {
                    SearchfileinDir(dirctory);
                    return;
                }
                else
                {
                    foreach (var di in dirDirs)
                    {
                        SearchFileRecursive(di);
                    }
                }

            }
            catch (Exception)
            {
            }

        }

        private void SearchfileinDir(DirectoryInfo dirtory)
        {
            FileInfo[] files = dirtory.GetFiles();

            String wantFile;
            String havefile;

            foreach (var fi in files)
            {
                wantFile = FileName;
                havefile = fi.Name;

                if (!isMatchCase)
                {
                    wantFile = FileName.ToUpper();
                    havefile = fi.Name.ToUpper();
                }

                if (havefile.IndexOf(wantFile) != -1)
                {
                    SearchedFiles.Add(fi);
                    isFileFound = true;
                }
                SearchedFileNumber++;
                ReportProgress();
            }
        }

        private void ReportProgress()
        {
            int step = TotalFileNumber / 100;
            if (SearchedFileNumber % step == 0)
            {
                bkw.ReportProgress(SearchedFileNumber);
            }
        }


        
    }
}
