using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowsExplorer
{
    class SearchFileInDir
    {
        public int TotalNumberFiles { get; set; }
        public string DirName { get; set; }
        public string FileName { get; set; }
        public BackgroundSearch bkSearch { get; set; }
        private int searchCount;
        public List<FileInfo> listSearchedFiles { get; set; }
        public bool isMatch { get; set; }

        internal int getTotalFileNumber(string dirName)
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
                FileInfo[] files = dir.GetFiles();
                TotalNumberFiles += files.Length;

                foreach (var di in dir.GetDirectories())
                {
                    getRecursiveNumber(di);
                }
            }
            catch (Exception)
            {

            }
        }

        internal void SearchFile(string dirName, string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(dirName);
            searchCount = 0;
            listSearchedFiles = new List<FileInfo>();
            SearchRecursive(dir, fileName);
        }

        private void SearchRecursive(DirectoryInfo dir, string fileName)
        {
            String haveName;
            String wantName = fileName;
           
            try
            {
                foreach (var file in dir.GetFiles())
                {
                    haveName = file.Name;

                    if(!isMatch)
                    {
                        wantName = wantName.ToUpper();
                        haveName = haveName.ToUpper();
                    }

                    if (haveName.IndexOf(wantName) != -1)
                    {
                        listSearchedFiles.Add(file);
                    }

                    searchCount++;
                    int step = (TotalNumberFiles > 100) ? (TotalNumberFiles / 100) : 1;
                    if (searchCount % step == 0)
                    {
                        bkSearch.ReportProgress(searchCount);
                    }
                }
                foreach (var di in dir.GetDirectories())
                {
                    SearchRecursive(di, fileName);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

    }
}
