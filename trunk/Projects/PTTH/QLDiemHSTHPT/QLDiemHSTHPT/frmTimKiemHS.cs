using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;

namespace QLDiemHSTHPT
{
    public partial class frmTimKiemHS : Office2007Form
    {
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        public frmTimKiemHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimKiemHS_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(cmbdantoc);
            m_TonGiaoCtrl.HienThiComboBox(cmbtongiao);
        }

 

        private void buttonTKHS_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.TimKiemHocSinh(txthotengv, cmbTheonoisinh, txtNoiSinh, cmbTheoDantoc, cmbdantoc, cmbtheotongiao, cmbtongiao, dgvTKHocSinh, bdgTKHocsinh);

            if (dgvTKHocSinh.RowCount == 0)
                MessageBoxEx.Show("Không có học sinh cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txthotengv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}