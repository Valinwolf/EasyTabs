using System;
using System.Windows.Forms;
using EasyTabs;

namespace Sibor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			Sibor Sibor = new Sibor();
	        
			Sibor.Tabs.Add(
		        new TitleBarTab(Sibor)
			        {
				        Content = new TabWindow
					                  {
						                  Text = "New Tab"
					                  }
			        });
			Sibor.SelectedTabIndex = 0;

			TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
			applicationContext.Start(Sibor);

            Application.Run(applicationContext);
        }
    }
}
