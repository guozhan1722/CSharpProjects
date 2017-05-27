using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindowsExplorer
{
    class BackgroundSearch: BackgroundWorker
    {
        private MainMultiWindowsExplorer mainWindow;
        public int Section { get; set; }

        public BackgroundSearch(MainMultiWindowsExplorer mainForm, int section)
        {
            // TODO: Complete member initialization
            this.mainWindow = mainForm;
            this.Section = section;

            this.WorkerReportsProgress = true;
            this.DoWork += mainForm.bgSearch_DoWork;
            this.ProgressChanged += mainForm.bgSearch_ProgressChanged;
            this.RunWorkerCompleted += mainForm.bgSearch_RunWorkerCompeted;
        }


    }
}
