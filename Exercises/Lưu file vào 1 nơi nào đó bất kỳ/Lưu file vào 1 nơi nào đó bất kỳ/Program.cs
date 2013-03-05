using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lưu_file_vào_1_nơi_nào_đó_bất_kỳ
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
            Application.Run(new Form1());
        }
    }
}
