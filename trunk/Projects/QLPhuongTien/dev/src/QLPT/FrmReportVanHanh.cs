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
    public partial class FrmReportVanHanh : Form
    {
        public FrmReportVanHanh()
        {
            InitializeComponent();
        }

        private void FrmReportVanHanh_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.View_PhuongTienTableAdapter.Fill(this.QuanLy_PTDataSet.View_PhuongTien);
            }
            catch (System.Exception ex)
            {
            	
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
