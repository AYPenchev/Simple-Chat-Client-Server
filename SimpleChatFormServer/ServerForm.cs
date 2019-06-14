﻿namespace SimpleChatFormServer
{
    using System;
    using System.Windows.Forms;

    static class ServerForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmServer());
        }
    }
}
