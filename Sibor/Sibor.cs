using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System.Collections.Generic;
using Newtonsoft.Json;
using Sibor.Properties;
using System.ComponentModel;

namespace Sibor
{
	public partial class Sibor : TitleBarTabs
    {
        private BookmarkFolder BookmarksBar = new BookmarkFolder();
        private BookmarkFolder OtherBookmarks = new BookmarkFolder();
        readonly List<string> BookmarkURLs = new List<string>();
        public Sibor()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Resources.DefaultIcon;
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += LoadBookmarks;
            bgw.ProgressChanged += UpdateBookmarks;
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = false;
            bgw.RunWorkerAsync();
        }

        private void UpdateBookmarks(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == 0)
            {
                BookmarksBar = e.UserState as BookmarkFolder;
            } else if(e.ProgressPercentage == 50)
            {
                OtherBookmarks = e.UserState as BookmarkFolder;
            } else
            {

            }
        }

        private void LoadBookmarks(object sender, DoWorkEventArgs e)
        {
            if (Settings.Default.BookmarksBar.Length > 0)
            {
                BookmarkFolder bmb = JsonConvert.DeserializeObject<BookmarkFolder>(Settings.Default.BookmarksBar);
                ((BackgroundWorker)sender).ReportProgress(0, bmb);
                foreach (BookmarkFolder folder in bmb.Subfolders)
                {

                }
            }
            if (Settings.Default.OtherBookmarks.Length > 0)
            {
                ((BackgroundWorker)sender).ReportProgress(50, OtherBookmarks = JsonConvert.DeserializeObject<BookmarkFolder>(Settings.Default.OtherBookmarks));
            }
        }

        static Sibor()
        {
            // This is only so that generating a thumbnail for Aero peek works properly:  with GPU acceleration enabled, all you get is a black box
            // when you try to "snapshot" the web browser control.  If you don't plan on using Aero peek, remove this method.
            CefSettings cefSettings = new CefSettings();
            cefSettings.DisableGpuAcceleration();

            Cef.Initialize(cefSettings);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new TabWindow
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
