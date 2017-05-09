using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MultiWindowsExplorer
{
    public partial class FormExplorer : Form
    {
        //FolderBrowserDialog folderBrowser;
        public const int explorerNum = 4;
        WebBrowser[] webBrowsers;
        Button[] openBtn;
        TextBox[] pathTxt;
        Button[] backBtn;
        Button[] forwardBtn;
        String[] appSettingKeys;

        public FormExplorer()
        {
            InitializeComponent();

            AddComponentToGroup();
            SetRootPath();
            
        }

        private void AddComponentToGroup()
        {
            webBrowsers = new WebBrowser[explorerNum] { webBrowser1, webBrowser2, webBrowser3, webBrowser4 };
            openBtn = new Button[explorerNum] { btnOpen1, btnOpen2, btnOpen3, btnOpen4 };
            backBtn = new Button[explorerNum] { btnBack1, btnBack2, btnBack3, btnBack4 };
            forwardBtn = new Button[explorerNum] { btnForward1, btnForward2, btnForward3, btnForward4 };
            pathTxt = new TextBox[explorerNum] { txtPath1, txtPath2, txtPath3, txtPath4 };
            appSettingKeys = new String[explorerNum]{"url1","url2","url3","url4"};
        }

        private void SetRootPath()
        {
            for (int i = 0; i < explorerNum;i++ )
            {
                pathTxt[i].Text = AppSettings.ReadSetting(appSettingKeys[i]);
                //pathTxt[i].Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                webBrowsers[i].Url = new Uri(pathTxt[i].Text);
            }
        }

        int GetButtonAreaPosition(Button btn)
        {

            for(int i=0;i<explorerNum;i++)
            {
                if((btn.Name == openBtn[i].Name) ||(btn.Name == backBtn[i].Name)||(btn.Name == forwardBtn[i].Name))
                {
                    return i;
                }
            }

            return 0;
        }

        int GetWebBrowserPosition(WebBrowser wBrowser)
        {
            for (int i = 0; i < explorerNum; i++)
            {
                if (wBrowser.Name == webBrowsers[i].Name) 
                {
                    return i;
                }
            }

            return 0;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int number = GetButtonAreaPosition(sender as Button);

            try
            {
                webBrowsers[number].Url = new Uri(pathTxt[number].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }

            //folderBrowser = new FolderBrowserDialog();
            //folderBrowser.Description = "Select your path: ";
            //folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            //folderBrowser.ShowNewFolderButton = false;
            
            //if (folderBrowser.ShowDialog() == DialogResult.OK)
            //{

            //    pathTxt[number].Text = folderBrowser.SelectedPath;
            //    webBrowsers[number].Url = new Uri(folderBrowser.SelectedPath);
            //}
            
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int number = GetButtonAreaPosition(sender as Button);

            if (webBrowsers[number].CanGoForward)
            {
                webBrowsers[number].GoForward();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int number = GetButtonAreaPosition(sender as Button);

            if (webBrowsers[number].CanGoBack)
            {
                webBrowsers[number].GoBack();
            }
        }

        private void ShowPath(object sender, WebBrowserNavigatedEventArgs e)
        {
            int position = GetWebBrowserPosition(sender as WebBrowser);
            WebBrowser wBrowser = sender as WebBrowser;
            try
            {
                pathTxt[position].Text = wBrowser.Url.LocalPath;
                //AppSettings.UpdateSettings(appSettingKeys[position], pathTxt[position].Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        

    }
}
