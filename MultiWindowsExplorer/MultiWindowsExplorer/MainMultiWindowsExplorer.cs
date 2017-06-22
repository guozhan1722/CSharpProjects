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
    public delegate void UpdateProgressBar(int section,int max ,int cur);

    public partial class MainMultiWindowsExplorer : Form
    {
        private const int NumberSections = 4;
        private SearchFileInDir[] searchFile = new SearchFileInDir[NumberSections];
        private BackgroundSearch[] bgSearcher = new BackgroundSearch[NumberSections];
        
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
                TextBox pathTxt = GetControlByName("txtPath" + i) as TextBox;
                String value = pathTxt.Text;

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
                TabControl conTab = GetControlBySenderAndName((object)browser,"tabControl") as TabControl;
                conTab.SelectedTab = conTab.TabPages[0];

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

        private void SetButtonsEnabled(object sender, TextBox pathTxt, WebBrowser browser)
        {
            var dir = new DirectoryInfo(pathTxt.Text);
            Button upBtn = GetControlBySenderAndName(sender, "btnUp") as Button;
            upBtn.Enabled = (dir.Parent != null);

            Button forwardBtn = GetControlBySenderAndName(sender, "btnForward") as Button;
            forwardBtn.Enabled = browser.CanGoForward;

            Button backBtn = GetControlBySenderAndName(sender, "btnBack") as Button;
            backBtn.Enabled = browser.CanGoBack;

            pathTxt.SelectionStart = pathTxt.Text.Length;
            pathTxt.ScrollToCaret();
        }

        private void EnableSearchButton(int section, bool enabled)
        {
            Button searchBtn = GetControlByName("btnSearch" + section) as Button;
            CheckBox matchCkb = GetControlByName("ckboxMatchCase" + section) as CheckBox;
            CheckBox textCkb = GetControlByName("ckboxFindText" + section) as CheckBox;
            searchBtn.Enabled = enabled;
            matchCkb.Enabled = enabled;
            textCkb.Enabled = enabled;
        }

        private void RefreshProgressBar(int section, int max, int current)
        {
            ProgressBar poBar = GetControlByName("progressBar" + section) as ProgressBar;
            Label lab = GetControlByName("labelProgress" + section) as Label;
            
            if(poBar.InvokeRequired)
            {
                UpdateProgressBar u = new UpdateProgressBar(RefreshProgressBar);
                this.Invoke(u, new object[] { section, max, current });
            }
            else
            {
                poBar.Maximum = max;
                poBar.Value = current;
                lab.Text = 100 * current / poBar.Maximum + " %";
            }
        }

        private void InitSearchControls(int section,String pattern)
        {
            EnableSearchButton(section, false);

            RefreshProgressBar(section, 100, 0);

            bgSearcher[section] = new BackgroundSearch(this,section);
      
            TabControl conTab = GetControlByName("tabControl" + section) as TabControl;
            conTab.SelectedTab = conTab.TabPages[1];

            ListView view = GetControlByName("listView" + section) as ListView;

            ListView.ListViewItemCollection items = view.Items;
            items.Clear();
            ListViewItem item = new ListViewItem("Searching patten: " + pattern + " ...");
            view.Items.Add(item);
        }

        private void ShowSearchedResult(List<SearchedResult> list, ListView listView, bool isFinal)
        {
            ListView.ListViewItemCollection items = listView.Items;
            items.Clear();

            try
            {
                if (list.Count == 0 && isFinal)
                {
                    ListViewItem item = new ListViewItem("");
                    item.SubItems.Add("Could not Find This File");
                    listView.Items.Add(item);
                }
                else
                {
                    foreach (var file in list)
                    {
                        ListViewItem item = new ListViewItem(file.file.Name);
                        item.SubItems.Add(file.file.Directory.FullName);
                        item.SubItems.Add(file.p);
                        listView.Items.Add(item);
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            if (browser.CanGoBack)
            {
                TabControl conTab = GetControlBySenderAndName((object)browser, "tabControl") as TabControl;
                conTab.SelectedTab = conTab.TabPages[0];
                
                browser.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            if (browser.CanGoForward)
            {
                TabControl conTab = GetControlBySenderAndName((object)browser, "tabControl") as TabControl;
                conTab.SelectedTab = conTab.TabPages[0];

                browser.GoForward();
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            TextBox pathTxt = GetControlBySenderAndName(sender,"txtPath") as TextBox;

            var dir = new DirectoryInfo(pathTxt.Text);
            if(dir.Parent != null)
            {
                WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;
                UpdateWebBrowser(browser, dir.Parent.FullName);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            TextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as TextBox;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;

            UpdateWebBrowser(browser, pathTxt.Text);
        }

        private void OnShowPathText(object sender, WebBrowserNavigatedEventArgs e)
        {
            TextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as TextBox;
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

            TextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as TextBox;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;
            UpdateWebBrowser(browser, pathTxt.Text);
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int section = GetSectionBySender(sender);
            searchFile[section] = new SearchFileInDir();

            RichTextBox searchTxt = GetControlBySenderAndName(sender, "txtSearch") as RichTextBox;
            if(String.IsNullOrEmpty(searchTxt.Text))
            {
                MessageBox.Show("Search file can not be empty!");
                return;
            }
            TextBox pathTxt = GetControlBySenderAndName(sender, "txtPath") as TextBox;
            CheckBox matchCkb = GetControlBySenderAndName(sender, "ckboxMatchCase") as CheckBox;
            CheckBox findTextCkb = GetControlBySenderAndName(sender, "ckboxFindText") as CheckBox;

            searchFile[section].DirName = pathTxt.Text;
            searchFile[section].FileName = searchTxt.Text;
            searchFile[section].isMatch = matchCkb.Checked;
            searchFile[section].isFindText = findTextCkb.Checked;

            InitSearchControls(section, searchTxt.Text);

            bgSearcher[section].RunWorkerAsync();
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListView view = sender as ListView;
            
            if(view.SelectedItems.Count == 0)
            {
                return;
            }

            int section = GetSectionBySender(sender);

            int idx = view.SelectedItems[0].Index;

            //String dirName = searchFile[section].listSearchedResult[idx].Directory.FullName;
          
            String dirName = searchFile[section].listResult[idx].file.Directory.FullName;
            
            TextBox pathTxt = GetControlByName("txtPath" + section) as TextBox;
            pathTxt.Text = dirName;
            WebBrowser browser = GetControlBySenderAndName(sender, "webBrowser") as WebBrowser;
            UpdateWebBrowser(browser, pathTxt.Text);
        }

        public void bgSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundSearch worker = sender as BackgroundSearch;
            int section = worker.Section;

            String dirName = searchFile[section].DirName;
            String fileName = searchFile[section].FileName;

            int total = searchFile[section].getTotalFileNumber(dirName);
            RefreshProgressBar(section, total, 0);

            searchFile[section].bkSearch = worker;
            searchFile[section].SearchFile(dirName, fileName);
        }

        public void bgSearch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            BackgroundSearch worker = sender as BackgroundSearch;
            int section = worker.Section;
            int progress = (int)e.ProgressPercentage;

            RefreshProgressBar(section, searchFile[worker.Section].TotalNumberFiles, progress);

            ListView listView = GetControlByName("listView" + worker.Section) as ListView;
            ShowSearchedResult(searchFile[worker.Section].listResult, listView,false);
        }

        public void bgSearch_RunWorkerCompeted(object sender, RunWorkerCompletedEventArgs e)
        {
            BackgroundSearch worker = sender as BackgroundSearch;
            EnableSearchButton(worker.Section, true);

            int maxVal = searchFile[worker.Section].TotalNumberFiles;
            RefreshProgressBar(worker.Section, maxVal, maxVal);

            ListView listView = GetControlByName("listView" + worker.Section) as ListView;
            ShowSearchedResult(searchFile[worker.Section].listResult, listView, true);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.Show();
        }
    }
}
