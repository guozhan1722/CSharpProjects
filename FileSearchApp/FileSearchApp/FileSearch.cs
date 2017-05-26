using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearchApp
{
    class FileSearch
    {
        private Form1 form1;
        private object sender;

        public FileSearch(Form1 form1, object sender)
        {
            this.form1 = form1;
            this.sender = sender;
            
            this.SearchBtn = form1.getControlBySender(sender, "btnSearch") as Button;
            this.MatchCaseCkb = form1.getControlBySender(sender, "ckbMatchCase") as CheckBox;
            this.ProBar = form1.getControlBySender(sender, "progressBar") as ProgressBar;
            this.ProLable = form1.getControlBySender(sender,"lblProgress") as Label;
            this.FileName = form1.getControlBySender(sender, "txtSearch") as TextBox;
            this.DirName = form1.getControlBySender(sender,"txtPath") as TextBox;
        }

        public Button SearchBtn { get; set; }

        public CheckBox MatchCaseCkb { get; set; }

        public ProgressBar ProBar { get; set; }

        public Label ProLable { get; set; }

        public TextBox FileName { get; set; }

        public TextBox DirName { get; set; }


        internal void InitSearch(int totalFiles)
        {
            this.SearchBtn.Enabled = false;
            this.MatchCaseCkb.Enabled = false;
            this.ProBar.Maximum = totalFiles;
            this.ProBar.Step = totalFiles / 100;
            this.ProBar.Value = 0;
            
        }
    }
}
