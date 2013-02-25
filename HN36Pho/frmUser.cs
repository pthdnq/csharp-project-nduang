using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HN36Pho
{
    public partial class frmUser : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
