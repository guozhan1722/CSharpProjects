using System;
using System.Collections.Generic;
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
        public String AppSettingKeys { get; set; }

        public ControlsGroup(Button BackBtn,
            Button ForwardBtn,
            Button UpBtn,
            Button OpenBtn,
            Button SearchBtn,
            TextBox PathTxt,
            TextBox SearchTxt,
            WebBrowser WBrowser,
            CheckBox MatchCaseCkbox,
            String AppSettingKeys)
        {
            this.BackBtn = BackBtn;
            this.ForwardBtn =  ForwardBtn;
            this.UpBtn=UpBtn;
            this.OpenBtn=OpenBtn;
            this.SearchBtn=SearchBtn;
            this.PathTxt=PathTxt;
            this.SearchTxt=SearchTxt;
            this.WBrowser=WBrowser;
            this.MatchCaseCkbox = MatchCaseCkbox;
            this.AppSettingKeys = AppSettingKeys;
        }

    }
}
