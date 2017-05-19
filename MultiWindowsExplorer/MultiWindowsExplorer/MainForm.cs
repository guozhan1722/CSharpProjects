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
    public partial class MainForm : Form
    {

        List<ControlsGroup> cGroup = new List<ControlsGroup>();

        public MainForm()
        {
            InitializeComponent();
            AddComponentToGroup();
            InitWebBrowsersTextBoxes();
            
        }

        private void AddComponentToGroup()
        {
            cGroup.Clear();
            cGroup.Add(new ControlsGroup(btnBack1,btnForward1,
                btnUp1, btnOpen1, btnSearch1,txtPath1, txtSearch1,
                webBrowser1, ckboxMatchCase1, "url1"));
            cGroup.Add(new ControlsGroup(btnBack2, btnForward2,
                btnUp2, btnOpen2, btnSearch2, txtPath2, txtSearch2,
                webBrowser2, ckboxMatchCase2, "url2"));
            cGroup.Add(new ControlsGroup(btnBack3, btnForward3,
                btnUp3, btnOpen3, btnSearch3, txtPath3, txtSearch3,
                webBrowser3, ckboxMatchCase3, "url3"));
            cGroup.Add(new ControlsGroup(btnBack4, btnForward4,
                btnUp4, btnOpen4, btnSearch4, txtPath4, txtSearch4,
                webBrowser4, ckboxMatchCase4, "url4"));
        }

        private void InitWebBrowsersTextBoxes()
        {
            int i=0;
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
                cGroup[position].WBrowser.Url = new Uri(content);
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
            return Convert.ToInt16(lastChar) -1;
        }

        private string SearchfileinDir(String fileName, String dirName, bool isMatchCase)
        {
            DirectoryInfo di = new DirectoryInfo(dirName);
            FileInfo[] files = di.GetFiles();
            String wantFile;
            String havefile;

            foreach (var fi in files)
            {
                wantFile = fileName;
                havefile = fi.Name;

                if (!isMatchCase)
                {
                    wantFile = fileName.ToUpper();
                    havefile = fi.Name.ToUpper();
                }
                
                if(wantFile == havefile)
                {
                    return dirName;
                }
            }

            throw new FileNotFoundException(@"Cannot Find file\n");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int position = GetPositionBySender(sender) ;

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
            String dir = cGroup[position].PathTxt.Text;
            bool matchCase = cGroup[position].MatchCaseCkbox.Checked;

            if (String.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("File name cannot be empty!");
                return;
            }
            if (String.IsNullOrEmpty(dir))
            {
                MessageBox.Show("Directory name cannot be empty!");
                return;
            }

            try
            {
                String dirName = SearchfileinDir(fileName, dir, matchCase);
            }
            catch (FileNotFoundException fex)
            {

                MessageBox.Show(fex.Message.ToString());
            }
            

        }

    }
}
