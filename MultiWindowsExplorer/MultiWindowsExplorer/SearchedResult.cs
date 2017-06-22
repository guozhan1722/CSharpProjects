using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindowsExplorer
{
    class SearchedResult
    {
        public FileInfo file;
        public string p;

        public SearchedResult(FileInfo file, string p)
        {
            // TODO: Complete member initialization
            this.file = file;
            this.p = p;
        }
    }
}
