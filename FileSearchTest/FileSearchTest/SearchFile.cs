using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchTest
{
    class SearchFile
    {
        private Form1 form1;
        private object sender;
        public Button searchBtn;
        public CheckBox ckMatch;
        public String fileName;
        public String dirName;
        private int SearchedFileNumber;
        public List<FileInfo> SearchedFiles;
        public bool isFileFound { get; set; }
        public bool isMatchCase { get; set; }
        public BackgroundWorker bkw;
        public Searching fileSearching;

        public SearchFile(Form1 form1, object sender)
        {
            // TODO: Complete member initialization
            this.form1 = form1;
            this.sender = sender;

            searchBtn = form1.GetControlByName("buttonSearch") as Button;
            ckMatch = form1.GetControlByName("checkBoxMatchCase") as CheckBox;

            var ctlFile = form1.GetControlByName("textBoxFile") as TextBox;
            var ctlDir = form1.GetControlByName("textBoxDir") as TextBox;

            fileName = ctlFile.Text;
            dirName = ctlDir.Text;


        }

        internal void InitSearch()
        {
            EnableBtnAndCkb(false);
            GetTotalSearchFilesNumber(dirName);
           
        }


        public void EnableBtnAndCkb(bool p)
        {
            searchBtn.Enabled = p;
            ckMatch.Enabled = p;
        }

        public int GetTotalSearchFilesNumber(String dirName)
        {
            
            DirectoryInfo dir = new DirectoryInfo(dirName);
            
            fileSearching = new Searching();
            fileSearching.TotalFileNumber = 0;
            fileSearching.RecursiveGetFileNumber(dir);
            return fileSearching.TotalFileNumber;
        }

        public void DoSearchFile(String dirname, String filename, bool ismatchcase)
        {
            DirectoryInfo dir = new DirectoryInfo(dirname);
            fileSearching.SearchedFileNumber = 0;
            fileSearching.SearchedFiles = new List<FileInfo>();

            fileSearching.RecursiveSearchFile(dir, filename, ismatchcase);
            if(fileSearching.isFileFound == false)
            {
                throw new FileNotFoundException(@"Cannot Find file");
            }

            //SearchedFileNumber = 0;
            //SearchedFiles = new List<FileInfo>();

            //SearchFileRecursive(dir);
            //if (isFileFound == false)
            //{
            //    //throw new FileNotFoundException(@"Cannot Find file");
            //}

        }

        public void DoSearch()
        {
            DirectoryInfo dir = new DirectoryInfo(dirName);
            SearchedFileNumber = 0;
            SearchedFiles = new List<FileInfo>();

            SearchFileRecursive(dir);
            if (isFileFound == false)
            {
                //throw new FileNotFoundException(@"Cannot Find file");
            }

        }

        private void SearchFileRecursive(DirectoryInfo dirctory )
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

        public void SearchfileinDir(DirectoryInfo dirctory)
        {
            //FileInfo[] files = dirctory.GetFiles();

            //String wantFile;
            //String havefile;

            //foreach (var fi in files)
            //{
            //    wantFile = fileName;
            //    havefile = fi.Name;

            //    if (!isMatchCase)
            //    {
            //        wantFile = fileName.ToUpper();
            //        havefile = fi.Name.ToUpper();
            //    }

            //    if (havefile.IndexOf(wantFile) != -1)
            //    {
            //        SearchedFiles.Add(fi);
            //        isFileFound = true;
            //    }
            //    //SearchedFileNumber++;
            //    //if (TotalFileNumber >= 100)
            //    //{
            //        //int step = TotalFileNumber / 100;
            //       // if (SearchedFileNumber % step == 0)
            //        //{
            //        //    bkw.ReportProgress(SearchedFileNumber);
            //        //}
            //    //}
            //}

        }
    }
}
