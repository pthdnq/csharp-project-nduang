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
    public partial class FrmBaoCaoVanHanh : Form
    {
        public FrmBaoCaoVanHanh()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoVanHanh_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'View_VanHanh_DataSet.View_VanHanh' table. You can move, or remove it, as needed.
                this.View_VanHanhTableAdapter.Fill(this.View_VanHanh_DataSet.View_VanHanh);
            }
            catch { }
           

            this.reportViewer1.RefreshReport();
        }

        private void FrmBaoCaoVanHanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
