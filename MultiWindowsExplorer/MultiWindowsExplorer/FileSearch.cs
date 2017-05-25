﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;

namespace MultiWindowsExplorer
{
    class FileSearch
    {
        public String FireName { get; set; }
        public String DirName { get; set; }
        public bool isMatchCase { get; set; }
        private bool isFileFound = false;
        public int SearchSection { get; set; }
        public int SearchedFileNumber { get; set; }
        public List<FileInfo> SearchedFiles;
        public int TotalFileNumber { get; set; }
        public BackgroundWorker bkw { get; set; } 
        
        private const int MaxSearchFileNum = 10000;
        
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
            
            if (TotalFileNumber > MaxSearchFileNum)
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


        public void DoSearch()
        {
            DirectoryInfo dir = new DirectoryInfo(DirName);
            SearchedFileNumber = 0;
            SearchedFiles = new List<FileInfo>();

            SearchFileRecursive(dir);
            if(isFileFound == false)
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
            catch(Exception)
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
                wantFile = FireName;
                havefile = fi.Name;

                if (!isMatchCase)
                {
                    wantFile = FireName.ToUpper();
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
            int step = TotalFileNumber/100;
            if (SearchedFileNumber  % step == 0)
            {
                bkw.ReportProgress(SearchedFileNumber);
            }
        }
        

        public void InitProgressBar(ProgressBar pb)
        {
            pb.Maximum = TotalFileNumber;
            pb.Value = 0;
            pb.Step = TotalFileNumber/100;
        }
    }
}
