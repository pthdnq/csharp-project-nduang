using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HN36Pho
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
            Application.Run(new frmLogin());
            //Application.Run(new frmAbout());
           // Application.Run(new frmMainA());
        }
    }
}
