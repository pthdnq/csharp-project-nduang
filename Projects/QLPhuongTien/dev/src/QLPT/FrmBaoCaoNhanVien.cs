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
    public partial class FrmBaoCaoNhanVien : Form
    {
        public FrmBaoCaoNhanVien()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoNhanVien_Load(object sender, EventArgs e)
        {
            try{// TODO: This line of code loads data into the 'DataSet_View_NhanVien.View_NhanVien' table. You can move, or remove it, as needed.
            this.View_NhanVienTableAdapter.Fill(this.DataSet_View_NhanVien.View_NhanVien);

            
            }
            catch { }
            this.reportViewer1.RefreshReport();
        }
    }
}
