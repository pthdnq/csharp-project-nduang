﻿using System;
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

            }
            catch (System.Exception ex)
            {
            	
            }


            this.reportViewer1.RefreshReport();
        }
    }
}