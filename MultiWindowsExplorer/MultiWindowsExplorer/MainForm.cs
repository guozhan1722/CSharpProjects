using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultiWindowsExplorer
{
    public partial class MainForm : Form
    {

        private List<ControlsGroup> cGroup = new List<ControlsGroup>();
        public List<FileInfo> fileSearchResult;
        public int currentPosition;

        public MainForm()
        {
            InitializeComponent();
            AddComponentToGroup();
            InitWebBrowsersTextBoxes();

        }

        private void AddComponentToGroup()
        {
            cGroup.Clear();
            cGroup.Add(new ControlsGroup {BackBtn=btnBack1, 
                ForwardBtn = btnForward1,
                UpBtn = btnUp1,
                OpenBtn = btnOpen1, 
                SearchBtn = btnSearch1, 
                PathTxt = txtPath1, 
                SearchTxt = txtSearch1,
                WBrowser =webBrowser1,
                MatchCaseCkbox = ckboxMatchCase1, 
                AppSettingKeys = "url1"
            });

            cGroup.Add(new ControlsGroup
            {
                BackBtn = btnBack2,
                ForwardBtn = btnForward2,
                UpBtn = btnUp2,
                OpenBtn = btnOpen2,
                SearchBtn = btnSearch2,
                PathTxt = txtPath2,
                SearchTxt = txtSearch2,
                WBrowser = webBrowser2,
                MatchCaseCkbox = ckboxMatchCase2,
                AppSettingKeys = "url2"
            });
            
            cGroup.Add(new ControlsGroup
            {
                BackBtn = btnBack3,
                ForwardBtn = btnForward3,
                UpBtn = btnUp3,
                OpenBtn = btnOpen3,
                SearchBtn = btnSearch3,
                PathTxt = txtPath3,
                SearchTxt = txtSearch3,
                WBrowser = webBrowser3,
                MatchCaseCkbox = ckboxMatchCase3,
                AppSettingKeys = "url3"
            });

            cGroup.Add(new ControlsGroup
            {
                BackBtn = btnBack4,
                ForwardBtn = btnForward4,
                UpBtn = btnUp4,
                OpenBtn = btnOpen4,
                SearchBtn = btnSearch4,
                PathTxt = txtPath4,
                SearchTxt = txtSearch4,
                WBrowser = webBrowser4,
                MatchCaseCkbox = ckboxMatchCase4,
                AppSettingKeys = "url4"
            });
        }

        private void InitWebBrowsersTextBoxes()
        {
            int i = 0;
            foreach (ControlsGroup cgroup in cGroup)
            {
                String rootPath = AppSettings.ReadSetting(cgroup.AppSettingKeys);
                cgroup.PathTxt.Text = rootPath;
                UpdateWebBrowser(i++, rootPath);
            }
        }

        private void UpdateWebBrowser(int position, String content)
        {
            try
            {
                cGroup[position].WBrowser.Navigate(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private int GetPositionBySender(object sender)
        {
            Control ctl = sender as Control;
            String name = ctl.Name;

            String lastChar = name[name.Length - 1].ToString();
            currentPosition = Convert.ToInt16(lastChar) - 1;
            return currentPosition;
        }

        private void ShowSearchResult(List<FileInfo> searchResult)
        {

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            if (cGroup[position].WBrowser.CanGoBack)
            {
                cGroup[position].WBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            if (cGroup[position].WBrowser.CanGoForward)
            {
                cGroup[position].WBrowser.GoForward();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);

            String currentPath = cGroup[position].PathTxt.Text;

            var dir = new DirectoryInfo(currentPath);
            if (dir.Parent != null)
            {
                cGroup[position].PathTxt.Text = dir.Parent.FullName;
                UpdateWebBrowser(position, cGroup[position].PathTxt.Text);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);
            UpdateWebBrowser(position, cGroup[position].PathTxt.Text);
        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            int position = GetPositionBySender(sender);
            WebBrowser wBrowser = sender as WebBrowser;

            try
            {
                cGroup[position].PathTxt.Text = wBrowser.Url.LocalPath;

                var dir = new DirectoryInfo(cGroup[position].PathTxt.Text);
                cGroup[position].UpBtn.Enabled = (dir.Parent != null);

                cGroup[position].ForwardBtn.Enabled = wBrowser.CanGoForward;
                cGroup[position].BackBtn.Enabled = wBrowser.CanGoBack;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void OntxtPathKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            int position = GetPositionBySender(sender);
            var txt = sender as TextBox;
            UpdateWebBrowser(position, txt.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender);
            String fileName = cGroup[position].SearchTxt.Text;
            String dirName = cGroup[position].PathTxt.Text;

            if (String.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("File name cannot be empty!");
                return;
            }
            if (String.IsNullOrEmpty(dirName))
            {
                MessageBox.Show("Directory name cannot be empty!");
                return;
            }

            fileSearchResult = new List<FileInfo>();

            FileSearch fileSearch = new FileSearch
            {
                FireName = fileName,
                DirName = dirName,
                isMatchCase = cGroup[position].MatchCaseCkbox.Checked,
                //SearchResult = fileSearchResult
            };


            try
            {
                bkgWorkerSearch1.RunWorkerAsync(fileSearch);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message.ToString());
            }

        }

        private void bkgWorkerSearch1_DoWork(object sender, DoWorkEventArgs e)
        {
            FileSearch fSearch = (FileSearch)e.Argument;
            fSearch.DoSearch();
        }

        private void bkgWorkerSearch1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ShowSearchResult(fileSearchResult);

        }

        private void bkgWorkerSearch1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }


    }
}
