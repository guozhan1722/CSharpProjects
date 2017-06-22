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
        //public List<FileInfo> listSearchedResult { get; set; }
        public List<SearchedResult> listResult { get; set; }
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
            //listSearchedResult = new List<FileInfo>();
            listResult = new List<SearchedResult>();
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

                    if (isFindText)
                    {
                        FindTextinFile(file, wantName,isMatch);
                    }
                    else
                    {
                        MatchAndAddResult(wantName, haveName, isMatch, file);
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
                    if((di.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                    {
                        continue;
                    }
                    SearchRecursive(di, fileName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void MatchAndAddResult(string wantName, string haveName, bool isMatch, FileInfo file)
        {
            String wantString = wantName;
            String haveString = haveName;

            if (!isMatch)
            {
                wantString = wantString.ToUpper();
                haveString = haveString.ToUpper();
            }

            if (haveString.IndexOf(wantString) != -1)
            {
                //listSearchedResult.Add(file);
                listResult.Add(new SearchedResult(file, haveName));
            }

        }

        private void FindTextinFile(FileInfo file, string wantName,bool isMatch)
        {
            FileAttributes fa = file.Attributes;
            if(((fa & FileAttributes.Hidden) == FileAttributes.Hidden)
                ||((fa & FileAttributes.Compressed)==FileAttributes.Compressed)
                ||((fa & FileAttributes.Directory)==FileAttributes.Directory)
                || ((fa & FileAttributes.Device) == FileAttributes.Device)
                || ((fa & FileAttributes.Encrypted) == FileAttributes.Encrypted)
                || ((fa & FileAttributes.System) == FileAttributes.System)
                )
            {
                return;
            }

            if(isBinaryFile(file))
            {
                return;
            }

            try
            {
                int lineNum = 0;
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    String haveName;
                    while ((haveName = sr.ReadLine()) != null)
                    {
                        haveName = "Line " + lineNum++ + ":   " + haveName;
                        MatchAndAddResult(wantName, haveName, isMatch, file);
                    }

                }
            }
            catch (Exception)
            {
                
                
            }

            return;
            
        }

        private bool isBinaryFile(FileInfo file)
        {
            char NUL = (char)0;
            char BS = (char)8;
            char CR = (char)13;
            char SUB = (char)26;

            try
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    int ch;
                    while ((ch = sr.Read()) != -1)
                    {
                        if ((ch > NUL && ch < BS) ||
                        (ch > CR && ch < SUB))
                        {
                            return true;
                        }
                    }

                }
            }
            catch (Exception)
            {
                
                
            }
            return false;
        }


        public bool isFindText { get; set; }
    }
}
