using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSearchApp
{
    class Searching
    {
        public int TotalNumberFiles { get; set; }
        public List<FileInfo> searchedFiles;
        public System.ComponentModel.BackgroundWorker BackWorker { get; set; }


        internal int getTotalFileNumber(String dirName)
        {
            TotalNumberFiles = 0;
            DirectoryInfo dir = new DirectoryInfo(dirName);
            getRecursiveNumber(dir);
            return TotalNumberFiles;
        }

        private void getRecursiveNumber(DirectoryInfo dir)
        {
            try
            {
                DirectoryInfo[] dirDirs = dir.GetDirectories();

                if (TotalNumberFiles > 10000)
                {
                    return;
                }
                else if (dirDirs.Length == 0)
                {
                    FileInfo[] files = dir.GetFiles();
                    TotalNumberFiles += files.Length;
                }
                else
                {
                    foreach (var di in dirDirs)
                    {
                        getRecursiveNumber(di);
                    }
                }
            }
            catch (Exception)
            {
            }

            return;
        }

        internal void SearchFileInDir(string dirName, string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(dirName);
            SearchCount = 0;
            searchedFiles = new List<FileInfo>();
            SearchRecursive(dir,fileName);
        }
        
        private void SearchRecursive(DirectoryInfo dir, string fileName)
        {
            try
            {
                foreach(var file in dir.GetFiles())
                {
                    if(file.Name.IndexOf(fileName) != -1)
                    {
                        searchedFiles.Add(file);
                    }
                    SearchCount++;
                    int step = 1;
                    if (TotalNumberFiles > 100)
                    {
                        step = TotalNumberFiles / 100;
                    }

                    if (SearchCount % step == 0)
                    {
                        BackWorker.ReportProgress(SearchCount);
                    }

                }

                foreach (var di in dir.GetDirectories())
                {
                    SearchRecursive(di, fileName);
                }
            }
            catch (Exception)
            {
                
            }
        }
        //private void SearchRecursive(DirectoryInfo dir, string fileName)
        //{
        //    DirectoryInfo[] dirDirs = dir.GetDirectories();

        //    if (dirDirs.Length == 0)
        //    {
        //        FileInfo[] files = dir.GetFiles();
        //        foreach(var file in files)
        //        {
        //            if(file.Name.IndexOf(fileName) !=-1)
        //            {
        //                searchedFiles.Add(file);
        //            }
        //            SearchCount++;
        //            int step = 1;
        //            if (TotalNumberFiles > 100)
        //            {
        //                 step= TotalNumberFiles / 100;
        //            }

        //            if(SearchCount % step == 0)
        //            {
        //                BackWorker.ReportProgress(SearchCount);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        foreach (var di in dirDirs)
        //        {
        //            SearchRecursive(di, fileName);
        //        }
        //    }
        //}


        public int SearchCount { get; set; }
    }
}
