using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HN36PhoVer2GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

       

        private void tabTroGiup_Click(object sender, EventArgs e)
        {

            frmAbout frmabout = new frmAbout();
            frmabout.ShowDialog();
        }

        
        
    }
}
