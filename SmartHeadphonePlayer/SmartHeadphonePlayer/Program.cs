using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartHeadphonePlayer
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
            HeadphonePoller poller = new HeadphonePoller();
            PlayerPresenter presenter = new PlayerPresenter();
            poller.Subscribe(presenter);
            Application.Run();
        }
    }
}
