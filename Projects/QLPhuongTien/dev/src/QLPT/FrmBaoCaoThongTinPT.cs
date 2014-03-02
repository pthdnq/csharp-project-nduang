using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPT
{
    public partial class FrmBaoCaoThongTinPT : Form
    {
        public FrmBaoCaoThongTinPT()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoThongTinPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_View_Info_PhuongTien.View_Info_PhuongTien' table. You can move, or remove it, as needed.
            try
            {
                this.View_Info_PhuongTienTableAdapter.Fill(this.DataSet_View_Info_PhuongTien.View_Info_PhuongTien);

            }
            catch { }
            this.reportViewer1.RefreshReport();
        }

        private void FrmBaoCaoThongTinPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
