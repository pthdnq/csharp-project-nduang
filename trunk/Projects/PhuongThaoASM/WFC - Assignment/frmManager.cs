using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace WFC___Assignment
{
    public partial class frmManager : Office2007Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtWord.Text = "";
            txtPhonetic.Text = "";
            txtMeaning.Text = "";
        }
    }
}
