using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowsExplorer
{
    class ControlsGroup
    {

        public Button BackBtn { get; set; }
        public Button ForwardBtn { get; set; }
        public Button UpBtn { get; set; }
        public Button OpenBtn { get; set; }
        public Button SearchBtn { get; set; }
        public TextBox PathTxt { get; set; }
        public TextBox SearchTxt { get; set; }
        public WebBrowser WBrowser { get; set; }
        public CheckBox MatchCaseCkbox { get; set; }
        public ListView  SearchListView { get; set; }
        public String AppSettingKeys { get; set; }

        public ToolStripButton BackTsBtn { get; set; }
        public ToolStripButton ForwardTsBtn { get; set; }
        public ToolStripButton UpTsBtn { get; set; }
        public ToolStripButton OpenTsBtn { get; set; }
        public RichTextBox PathRTxt { get; set; }
        public RichTextBox SearchRTxt { get; set; }
        public ProgressBar SearchPoBar { get; set; }
        public BackgroundWorker BkgroundWorker {get; set;}
        public TabControl TControl { get; set; }
        public TabPage SearchTab { get; set; }
        public TabPage WBrowserTab { get; set; }
        
    }
}
