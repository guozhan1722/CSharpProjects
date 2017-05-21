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


namespace MultiWindowsExplorer
{
    public partial class MainMultiWindowsExplorer : Form
    {
        private List<ControlsGroup> cGroup = new List<ControlsGroup>();
        private int currentPosition;

        public MainMultiWindowsExplorer()
        {
            InitializeComponent();
            AddComponentToGroup();
            InitWebBrowsersTextBoxes();

        }

        private void InitWebBrowsersTextBoxes()
        {
            foreach (ControlsGroup cgroup in cGroup)
            {
                String rootPath = AppSettings.ReadSetting(cgroup.AppSettingKeys);
                UpdateWebBrowser(cgroup, rootPath);
            }
        }

        private void UpdateWebBrowser(ControlsGroup p, string rootPath)
        {
             try
            {
                p.WBrowser.Navigate(rootPath);
                p.TControl.SelectedTab = p.WBrowserTab;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddComponentToGroup()
        {
            cGroup.Add(new ControlsGroup { 
                    BackTsBtn =btnBack1,
                    ForwardTsBtn =btnForward1,
                    UpTsBtn =btnUp1,
                    OpenTsBtn =btnOpen1,
                    SearchBtn =btnSearch1,
                    PathRTxt =txtPath1,
                    SearchRTxt =txtSearch1,
                    WBrowser =webBrowser1,
                    MatchCaseCkbox =ckboxMatchCase1,
                    SearchListView =listViewSearch1,
                    AppSettingKeys = "url1"  ,
                    SearchPoBar = progressBar1,
                    BkgroundWorker = bkgWorkerSearch1,
                    TControl = tabControl1,
                    SearchTab = tabSearch1,
                    WBrowserTab = tabBrowser1,
            
            } );
        }

        private ControlsGroup GetGroupBySender(object sender)
        {
            String name;

            if (sender is ToolStripButton)
            {
                var ctl = sender as ToolStripButton;
                name = ctl.Name;
            }
            else if(sender is BackgroundWorker)
            {
                BackgroundWorker ctl = (BackgroundWorker)sender;
                name = ctl.ToString();
            }
            else
            {
                var ctl = sender as Control;
                name = ctl.Name;
            }

            String lastChar = name[name.Length - 1].ToString();
            currentPosition = Convert.ToInt16(lastChar) - 1;
            return cGroup[currentPosition];
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);

            if (curGroup.WBrowser.CanGoBack)
            {
                curGroup.WBrowser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);

            if (curGroup.WBrowser.CanGoForward)
            {
                curGroup.WBrowser.GoForward();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);

            String currentPath = curGroup.PathRTxt.Text;

            var dir = new DirectoryInfo(currentPath);
            if (dir.Parent != null)
            {
                UpdateWebBrowser(curGroup, dir.Parent.FullName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);
            UpdateWebBrowser(curGroup, curGroup.PathRTxt.Text);
        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);
            
            try
            {
                String localPath = curGroup.WBrowser.Url.LocalPath;
                curGroup.PathRTxt.Text = localPath;
                
                //refresh local button Enabled 
                var dir = new DirectoryInfo(localPath);
                curGroup.UpTsBtn.Enabled = (dir.Parent != null);

                curGroup.ForwardTsBtn.Enabled = curGroup.WBrowser.CanGoForward;
                curGroup.BackTsBtn.Enabled = curGroup.WBrowser.CanGoBack;

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
            ControlsGroup curGroup = GetGroupBySender(sender);
            UpdateWebBrowser(curGroup, curGroup.PathRTxt.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);

            String fileName = curGroup.SearchRTxt.Text;
            String dirName = curGroup.PathRTxt.Text;

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

             FileSearch fileSearch = new FileSearch
            {
                FireName = fileName,
                DirName = dirName,
                isMatchCase = curGroup.MatchCaseCkbox.Checked,
                SearchSection = currentPosition
            };

            try
            {
                curGroup.SearchBtn.Enabled = false;
                curGroup.MatchCaseCkbox.Enabled = false;

                int totalFiles = fileSearch.GetTotalSearchFilesNumber();
                InitProgressBar(curGroup,totalFiles);
                
                curGroup.BkgroundWorker.RunWorkerAsync(fileSearch);
            }
            catch (Exception fex)
            {
                MessageBox.Show(fex.Message.ToString());
            }

        }

        private void InitProgressBar(ControlsGroup curGroup, int totalFiles)
        {
            curGroup.SearchPoBar.Maximum = totalFiles;
            curGroup.SearchPoBar.Value = 0;

            if (totalFiles > 100)
            {
                curGroup.SearchPoBar.Step = totalFiles / 100;
            }
        }

        private void ShowSearchResult(ControlsGroup curGroup,List<FileInfo> searchedFiles)
        {
            curGroup.TControl.SelectedTab = curGroup.SearchTab;
            
            foreach (var fileinfo in searchedFiles)
    	    {
                ListViewItem item = new ListViewItem(fileinfo.Name);
                item.SubItems.Add(fileinfo.DirectoryName);
                listViewSearch1.Items.Add(item); 
	        }
        }
        

        private void bkgWorkerSearch1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bkw = sender as BackgroundWorker;
            
            FileSearch fileSearch = (FileSearch)e.Argument;
            e.Result = fileSearch;
            fileSearch.bkw = bkw;
       
            try
            {
                fileSearch.DoSearch();
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message.ToString());
            }


        }

        private void bkgWorkerSearch1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int step = (int)e.ProgressPercentage /100;
            cGroup[0].SearchPoBar.PerformStep();
            label1.Text = step + " %";
        }

        private void bkgWorkerSearch1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileSearch fileSearch = (FileSearch)e.Result;
            ControlsGroup curGroup = cGroup[fileSearch.SearchSection];
            
            curGroup.SearchBtn.Enabled = true;
            curGroup.MatchCaseCkbox.Enabled = true;
            curGroup.SearchPoBar.Value = fileSearch.TotalFileNumber;
            ShowSearchResult(curGroup,fileSearch.SearchedFiles);
        }


        private void listViewSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlsGroup curGroup = GetGroupBySender(sender);
            
            String DirName = curGroup.SearchListView.SelectedItems[0].SubItems[1].Text;
            UpdateWebBrowser(curGroup, DirName);
        }

    }
}
