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
    public partial class frmTimKiemGV : Office2007Form
    {
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        public frmTimKiemGV()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmTimKiemGV_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cmbchuyenmon);
        }

        private void buttonTKGV_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.TimKiemGiaoVien(txthotengv, cmbTheodiachi, txtDiaChi, cmbTheoCMon, cmbchuyenmon, dgvTKGiaoVien, bdgTKGiaoVien);

            if (dgvTKGiaoVien.RowCount == 0)
                MessageBoxEx.Show("Không có giáo viên cần tìm trong hệ thống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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