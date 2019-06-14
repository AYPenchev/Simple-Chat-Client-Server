namespace SimpleChatFormClient
{
    using System;
    using System.Windows.Forms;

    public static class ClientForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmClient());                       
        }        
    }
}
