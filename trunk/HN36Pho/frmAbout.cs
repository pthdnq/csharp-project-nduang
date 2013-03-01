using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace HN36Pho
{
    partial class frmAbout : DevComponents.DotNetBar.Office2007Form
    {
        public frmAbout()
        {
            InitializeComponent();
            this.Text =  ModuleConfig.Title;
            this.labelProductName.Text = ModuleConfig.Product;
            this.labelVersion.Text =  ModuleConfig.Version;
            this.labelCopyright.Text = ModuleConfig.Copyright;
            this.labelCompanyName.Text = ModuleConfig.Company;
            this.textBoxDescription.Text = ModuleConfig.Description;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
