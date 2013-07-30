using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace QLDiemHSTHPT
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
            Application.Run(new frmPhanLop());
            //Application.Run(new frmMain());
         //  Application.Run(new frmLoaiDiem());
//             foreach (var f in new DirectoryInfo(@"E:\Projects C#\Projects\PTTH\QLDiemHSTHPT").GetFiles("*.cs", SearchOption.AllDirectories))
//             {
//                 string s = File.ReadAllText(f.FullName);
//                 var utf8WithoutBom = new System.Text.UTF8Encoding(false);
//                // File.WriteAllText(f.FullName, s, utf8WithoutBom);
//                 using (var sink = new StreamWriter(f.FullName, false, utf8WithoutBom))
//                 {
//                     sink.Write(s);
//                 }
//             }
         }
    }
}