using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSearchTest
{
    class Searching
    {
        public int TotalFileNumber { get; set; }
        public int SearchedFileNumber { get; set; }
        public List<FileInfo> SearchedFiles { get; set; }
        public bool isFileFound { get; set; }

        internal void RecursiveGetFileNumber(System.IO.DirectoryInfo dirctory)
        {
            DirectoryInfo[] dirDirs;
            if(TotalFileNumber > 10000)
            {
                return;
            }
            try
            {
                dirDirs = dirctory.GetDirectories();
                if (dirDirs.Length == 0)
                {
                    GetNumberFileinDir(dirctory);
                    return;
                }
                else
                {
                    foreach (var di in dirDirs)
                    {
                        RecursiveGetFileNumber(di);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void GetNumberFileinDir(DirectoryInfo dirctory)
        {
            FileInfo[] files = dirctory.GetFiles();
            TotalFileNumber += files.Length;
        }



        internal void RecursiveSearchFile(DirectoryInfo dir, string filename, bool ismatchcase)
        {
            DirectoryInfo[] dirDirs;

            try
            {
                dirDirs = dir.GetDirectories();
                if (dirDirs.Length == 0)
                {
                    SearchfileinDir(dir,filename,ismatchcase);
                    return;
                }
                else
                {
                    foreach (var di in dirDirs)
                    {
                        RecursiveSearchFile(di, filename, ismatchcase);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void SearchfileinDir(DirectoryInfo dirctory, string filename, bool ismatchcase)
        {
            FileInfo[] files = dirctory.GetFiles();

            String wantFile;
            String havefile;

            foreach (var fi in files)
            {
                wantFile = filename;
                havefile = fi.Name;

                if (!ismatchcase)
                {
                    wantFile = filename.ToUpper();
                    havefile = fi.Name.ToUpper();
                }

                if (havefile.IndexOf(wantFile) != -1)
                {
                    SearchedFiles.Add(fi);
                    isFileFound = true;
                }
                SearchedFileNumber++;
                //if (TotalFileNumber >= 100)
                //{
                //int step = TotalFileNumber / 100;
                // if (SearchedFileNumber % step == 0)
                //{
                //    bkw.ReportProgress(SearchedFileNumber);
                //}
                //}
            }

        }

    }
}
