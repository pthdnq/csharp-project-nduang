using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLPT
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
           // Application.Run(new frmMain());
           // Application.Run(new FrmReportVanHanh());
           // Application.Run(new FrmAboutUs());
          //  Application.Run(new FrmRptVanHanh());
            Application.Run(new FrmBaoCaoThongTinPT());
        }
    }
}
 