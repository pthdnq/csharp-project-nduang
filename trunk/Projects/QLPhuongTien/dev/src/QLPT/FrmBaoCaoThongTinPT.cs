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
            // TODO: This line of code loads data into the 'View_Info_PhuongTien_DataSet.View_Info_PhuongTien' table. You can move, or remove it, as needed.
          
            this.reportViewer1.RefreshReport();
        }
    }
}
