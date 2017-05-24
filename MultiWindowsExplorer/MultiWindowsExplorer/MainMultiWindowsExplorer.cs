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
        private const int NumberSections = 4;
        public MainMultiWindowsExplorer()
        {
            InitializeComponent();
            InitWebBrowsersTextBoxes();
        }
        
        private void StoreUrlValue()
        {
            for (int i = 0; i < NumberSections; i++)
            {
                String key = "url" + i;
                String value =GetControlByName("txtPath" + i).Text;

                AppSettings.UpdateSettings(key, value);
            }
        }

        private void InitWebBrowsersTextBoxes()
        {
            for (int i = 0; i < NumberSections; i++ )
            {
                String rootPath = AppSettings.ReadSetting("url"+i);
                Control browser = GetControlByName("webBrowser" + i) as WebBrowser;
                UpdateWebBrowser(browser, rootPath);
            }
        }

        private void UpdateWebBrowser(Control browser, string rootPath)
        {
             try
            {
                WebBrowser wb = browser as WebBrowser;
                wb.Navigate(rootPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Control GetControlByName(String name)
        {
            return Controls.Find(name, true).FirstOrDefault();
        }

        private int GetSectionBySender(object sender)
        {
            String name;

            var ctl = sender as Control;
            name = ctl.Name;

            String lastChar = name[name.Length - 1].ToString();

            return Convert.ToInt16(lastChar);;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);
            String controlName = "webBrowser" + section;

            WebBrowser browser = GetControlByName(controlName) as WebBrowser;

            if (browser.CanGoBack)
            {
                browser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);
            String controlName = "webBrowser" + section;

            WebBrowser browser = GetControlByName(controlName) as WebBrowser;

            if (browser.CanGoForward)
            {
                browser.GoForward();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);
            String controlName = "txtPath" + section;

            RichTextBox tb = GetControlByName(controlName) as RichTextBox;

            var dir = new DirectoryInfo(tb.Text);
            if(dir.Parent != null)
            {
                Control ctl  = GetControlByName("webBrowser" + section);
                UpdateWebBrowser(ctl, dir.Parent.FullName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);

            RichTextBox tb = GetControlByName("txtPath" + section) as RichTextBox;
            WebBrowser ctl = GetControlByName("webBrowser" + section) as WebBrowser;
            UpdateWebBrowser(ctl, tb.Text);

        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            int section = GetSectionBySender(sender);
            WebBrowser browser = GetControlByName("webBrowser" + section) as WebBrowser;
            RichTextBox pathText = GetControlByName("txtPath"+section) as RichTextBox;

            pathText.Text = browser.Url.LocalPath;

            var dir = new DirectoryInfo(pathText.Text);
            Button upBtn = GetControlByName("btnUp" + section) as Button;
            upBtn.Enabled = (dir.Parent != null);

            Button forwardBtn = GetControlByName("btnForward" + section) as Button;
            forwardBtn.Enabled = browser.CanGoForward;

            Button backBtn = GetControlByName("btnBack" + section) as Button;
            backBtn.Enabled = browser.CanGoBack;
        }

        private void OntxtPathKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            int section = GetSectionBySender(sender);

            RichTextBox tb = GetControlByName("txtPath" + section) as RichTextBox;
            WebBrowser ctl = GetControlByName("webBrowser" + section) as WebBrowser;
            UpdateWebBrowser(ctl, tb.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);
            RichTextBox dirtb = GetControlByName("txtPath" + section) as RichTextBox;
            RichTextBox filetb = GetControlByName("txtSearch" + section) as RichTextBox;

            String fileName = filetb.Text;
            String dirName = dirtb.Text;

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

            // FileSearch fileSearch = new FileSearch
            //{
            //    FireName = fileName,
            //    DirName = dirName,
            //    isMatchCase = curGroup.MatchCaseCkbox.Checked,
            //    SearchSection = currentPosition
            //};

            //try
            //{
            //    curGroup.SearchBtn.Enabled = false;
            //    curGroup.MatchCaseCkbox.Enabled = false;

            //    int totalFiles = fileSearch.GetTotalSearchFilesNumber();
            //    InitProgressBar(curGroup,totalFiles);
                
            //    curGroup.BkgroundWorker.RunWorkerAsync(fileSearch);
            //}
            //catch (Exception fex)
            //{
            //    MessageBox.Show(fex.Message.ToString());
            //}

        }

        //private void InitProgressBar(ControlsGroup curGroup, int totalFiles)
        //{
        //    curGroup.SearchPoBar.Maximum = totalFiles;
        //    curGroup.SearchPoBar.Value = 0;

        //    if (totalFiles > 100)
        //    {
        //        curGroup.SearchPoBar.Step = totalFiles / 100;
        //    }
        //}

        //private void ShowSearchResult(ControlsGroup curGroup,List<FileInfo> searchedFiles)
        //{
        //    curGroup.TControl.SelectedTab = curGroup.SearchTab;
            
        //    foreach (var fileinfo in searchedFiles)
        //    {
        //        ListViewItem item = new ListViewItem(fileinfo.Name);
        //        item.SubItems.Add(fileinfo.DirectoryName);
        //        listView1.Items.Add(item); 
        //    }
        //}
        

        //private void bkgWorkerSearch1_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker bkw = sender as BackgroundWorker;
            
        //    FileSearch fileSearch = (FileSearch)e.Argument;
        //    e.Result = fileSearch;
        //    fileSearch.bkw = bkw;
       
        //    try
        //    {
        //        fileSearch.DoSearch();
        //    }
        //    catch (FileNotFoundException fex)
        //    {
        //        MessageBox.Show(fex.Message.ToString());
        //    }


        //}

        //private void bkgWorkerSearch1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    int step = (int)e.ProgressPercentage /100;
        //    cGroup[0].SearchPoBar.PerformStep();
        //    labelProgress0.Text = step + " %";
        //}

        //private void bkgWorkerSearch1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    FileSearch fileSearch = (FileSearch)e.Result;
        //    ControlsGroup curGroup = cGroup[fileSearch.SearchSection];
            
        //    curGroup.SearchBtn.Enabled = true;
        //    curGroup.MatchCaseCkbox.Enabled = true;
        //    curGroup.SearchPoBar.Value = fileSearch.TotalFileNumber;
        //    ShowSearchResult(curGroup,fileSearch.SearchedFiles);
        //}


        private void listViewSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ControlsGroup curGroup = GetGroupBySender(sender);
            
            //String DirName = curGroup.SearchListView.SelectedItems[0].SubItems[1].Text;
            //UpdateWebBrowser(curGroup, DirName);
        }


    }
}
