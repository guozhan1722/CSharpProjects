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

        public Control GetControlByName(String name)
        {
            return Controls.Find(name, true).FirstOrDefault();
        }

        public int GetSectionBySender(object sender)
        {
            String name;

            var ctl = sender as Control;
            name = ctl.Name;

            String lastChar = name[name.Length - 1].ToString();

            return Convert.ToInt16(lastChar);;
        }

        public Control GetControlBySenderAndName(object sender, String basename)
        {
            int section = GetSectionBySender(sender);
            return Controls.Find(basename+section, true).FirstOrDefault();
        }

        private void SetButtonsEnabled(object sender, RichTextBox pathTxt, WebBrowser browser)
        {
            var dir = new DirectoryInfo(pathTxt.Text);
            Button upBtn = GetControlBySenderAndName(sender, "btnUp") as Button;
            upBtn.Enabled = (dir.Parent != null);

            Button forwardBtn = GetControlBySenderAndName(sender, "btnForward") as Button;
            forwardBtn.Enabled = browser.CanGoForward;

            Button backBtn = GetControlBySenderAndName(sender, "btnBack") as Button;
            backBtn.Enabled = browser.CanGoBack;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            if (browser.CanGoBack)
            {
                browser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            if (browser.CanGoForward)
            {
                browser.GoForward();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            RichTextBox pathTxt = GetControlBySenderAndName(sender,"txtPath") as RichTextBox;

            var dir = new DirectoryInfo(pathTxt.Text);
            if(dir.Parent != null)
            {
                WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;
                UpdateWebBrowser(browser, dir.Parent.FullName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            RichTextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as RichTextBox;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            UpdateWebBrowser(browser, pathTxt.Text);
        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            RichTextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as RichTextBox;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            pathTxt.Text = browser.Url.LocalPath;

            SetButtonsEnabled(sender, pathTxt, browser);
        }

        private void OntxtPathKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
            {
                return;
            }
            int section = GetSectionBySender(sender);

            RichTextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as RichTextBox;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;
            UpdateWebBrowser(browser, pathTxt.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FileSearchTest fst = new FileSearchTest(this,sender);
            
            if(fst.isFileNameDirEmpty())
            {
                MessageBox.Show("File name or Dir Name cannot be empty!");
                return;
            }

            fst.InitSearch();
                
            bgSearcher0.RunWorkerAsync(fst);
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

        private void bgSearcher0_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bkw = sender as BackgroundWorker;

            FileSearchTest fileSearch = (FileSearchTest)e.Argument;
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

        private void bgSearcher0_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int step = (int)e.ProgressPercentage;
            progressBar0.Value = step;
            labelProgress0.Text = step + " %";
        }

        private void bgSearcher0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileSearchTest fileSearch = (FileSearchTest)e.Result;
            fileSearch.EnableBtnAndCheckbox(true);


        }


    }
}
