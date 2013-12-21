using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GenerateData;
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
            //Application.Run(new frmDonVi_QL());
            GenerateDataToTables generateDataToTables = new GenerateDataToTables();
            try
            {
                generateDataToTables.generateDonViQuanLyData();
            }
            catch (System.Exception ex)
            {
                Console.Write("Khong the sinh du lieu");
            }
           


        }
    }
}
