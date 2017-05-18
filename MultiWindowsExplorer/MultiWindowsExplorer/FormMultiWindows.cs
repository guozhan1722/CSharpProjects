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
using System.IO;

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
        Button[] upBtn;
        String[] appSettingKeys;

        public FormExplorer()
        {
            InitializeComponent();

            AddComponentToGroup();
            InitWebBrowsersTextBoxes();
        }

        private void AddComponentToGroup()
        {
            webBrowsers = new WebBrowser[explorerNum] { webBrowser1, webBrowser2, webBrowser3, webBrowser4 };
            openBtn = new Button[explorerNum] { btnOpen1, btnOpen2, btnOpen3, btnOpen4 };
            backBtn = new Button[explorerNum] { btnBack1, btnBack2, btnBack3, btnBack4 };
            forwardBtn = new Button[explorerNum] { btnForward1, btnForward2, btnForward3, btnForward4 };
            upBtn = new Button[explorerNum] { btnUp1, btnUp2, btnUp3, btnUp4 };
            pathTxt = new TextBox[explorerNum] { txtPath1, txtPath2, txtPath3, txtPath4 };
            appSettingKeys = new String[explorerNum]{"url1","url2","url3","url4"};
        }


        private void InitWebBrowsersTextBoxes()
        {
            for (int i = 0; i < explorerNum;i++ )
            {
                String rootPath = AppSettings.ReadSetting(appSettingKeys[i]);
                pathTxt[i].Text = rootPath;
                UpdateWebBrowser(i,rootPath);
            }
        }

        private int GetPositionBySender(object sender)
        {
            if (sender is Button)
            {
                var btn = sender as Button;
                for (int i = 0; i < explorerNum; i++) { 
                    if ((btn.Name == openBtn[i].Name) 
                        || (btn.Name == backBtn[i].Name) 
                        || (btn.Name == forwardBtn[i].Name) 
                        ||(btn.Name == upBtn[i].Name))
                    {
                        return i;
                    }
                }
            }

            else if (sender is WebBrowser)
            {
                var wBrowser = sender as WebBrowser;
                for (int i = 0; i < explorerNum; i++)
                {
                    if (wBrowser.Name == webBrowsers[i].Name)
                    {
                        return i;
                    }
                }
            
            }
            else if (sender is TextBox)
            {
                var txt = sender as TextBox;
                for (int i = 0; i < explorerNum; i++)
                {
                    if(txt.Name == pathTxt[i].Name)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }

        private void UpdateWebBrowser(int position, String content)
        {
            try
            {
                webBrowsers[position].Url = new Uri(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);
            UpdateWebBrowser(position, pathTxt[position].Text);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            if (webBrowsers[position].CanGoForward)
            {
                webBrowsers[position].GoForward();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            if (webBrowsers[position].CanGoBack)
            {
                webBrowsers[position].GoBack();
            }
        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            int position = GetPositionBySender(sender);
            WebBrowser wBrowser = sender as WebBrowser;

            try
            {
                pathTxt[position].Text = wBrowser.Url.LocalPath;

                //Make sure will show up the last few of words
                
                int txtBoxCharNum =pathTxt[position].Size.Width /(int)pathTxt[position].Font.SizeInPoints;
                if (pathTxt[position].Text.Length > txtBoxCharNum)
                {
                    int start = pathTxt[position].Text.Length - txtBoxCharNum;
                    //pathTxt[position].Select(start, txtBoxCharNum);
                    pathTxt[position].SelectionStart = start ;
                    pathTxt[position].SelectionLength = txtBoxCharNum;
                    pathTxt[position].ScrollToCaret();
                }

                var dir = new DirectoryInfo(pathTxt[position].Text);
                if (dir.Parent == null)
                {
                    upBtn[position].Enabled = false;
                }
                else
                {
                    upBtn[position].Enabled = true;
                }

                forwardBtn[position].Enabled = wBrowser.CanGoForward;
                backBtn[position].Enabled = wBrowser.CanGoBack;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void OntxtPathKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode != Keys.Return)
            {
                return; 
            }
            int position = GetPositionBySender(sender);
            UpdateWebBrowser(position, pathTxt[position].Text);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            String currentPath = pathTxt[position].Text;
            
            var dir = new DirectoryInfo(currentPath);
            if(dir.Parent != null)
            {
                pathTxt[position].Text = dir.Parent.FullName;
                UpdateWebBrowser(position, pathTxt[position].Text);
            }
        }


    }
}
