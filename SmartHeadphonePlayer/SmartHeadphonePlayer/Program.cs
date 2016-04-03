﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
            Thread thread = new Thread(new ThreadStart(poller.Run));
            PlayerPresenter presenter = new PlayerPresenter();
            poller.Subscribe(presenter);
            thread.Start();
            Application.Run();
            thread.Abort();
        }
    }
}
