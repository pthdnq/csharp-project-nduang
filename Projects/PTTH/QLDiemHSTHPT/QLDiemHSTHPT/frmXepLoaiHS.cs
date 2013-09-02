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
using QLDiemHSTHPT.DataLayer;

namespace QLDiemHSTHPT
{
    public partial class frmXepLoaiHS : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        KQHKMonHocCtrl m_KQHocKyMonHocCtrl = new KQHKMonHocCtrl();
        KQHKTongHopCtrl m_KQHocKyTongHopCtrl = new KQHKTongHopCtrl();
        KQCNMonHocCtrl m_KQCaNamMonHocCtrl = new KQCNMonHocCtrl();
        KQCNTongHopCtrl m_KQCaNamTongHopCtrl = new KQCNTongHopCtrl();
        PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
        HanhKiemCtrl m_HanhKiemCtrl = new HanhKiemCtrl();
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        DiemData m_DiemData = new DiemData();
        QuyDinh quyDinh = new QuyDinh();
        public frmXepLoaiHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhapDiemChung_Load(object sender, EventArgs e)
        {
            m_HanhKiemCtrl.HienThiDataGridViewComboBoxColumn(MaHanhKiem);
            m_HocLucCtrl.HienThiDataGridViewComboBoxColumn(MaHocLuc);
            m_NamHocCtrl.HienThiComboBox(cmbKhoaHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocky);
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);
            String strLoaiTaiKhoan = Utilities.NguoiDung.LoaiND.MaLoaiND.Trim();
            //tai khoan hoc sinh thi an nut luu diem
            if (strLoaiTaiKhoan == "LND004")
            {
                bngluu.Visible = false;
            }
            HienThiDSHanhKiemHS();
            
            
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDSHanhKiemHS();
            }
            catch (Exception)
            {
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
        }
        private void HienThiDSHanhKiemHS()
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocky.SelectedValue != null && cmbKhoaHoc.SelectedValue != null)
                m_HocSinhCtrl.LayDsHocSinhTheoLopChoCapNhatHanhKiem(
                    dgvXepLoaiHanhKiem, 
                    bdgXepHanhKiemHS, 
                    cmbKhoaHoc.SelectedValue.ToString(), 
                    cmbLop.SelectedValue.ToString(), 
                    cmbHocky.SelectedValue.ToString(),
                    txtMaHS_Or_hoTenHS.Text.Trim());
        }
        private void bngluu_Click_1(object sender, EventArgs e)
        {
            dgvXepLoaiHanhKiem.EndEdit();
            String strTenDangNhap = Utilities.NguoiDung.TenDangNhap.Trim();
            String strMaLop = cmbLop.SelectedValue.ToString().Trim();
            String strTenLop = cmbLop.Text.Trim();
            String strMaKhoaHoc = cmbKhoaHoc.SelectedValue.ToString().Trim();
            String strHocKy = cmbHocky.SelectedValue.ToString().Trim();
            foreach (DataGridViewRow row in dgvXepLoaiHanhKiem.Rows)
            {
                if (row.Cells["MaHocSinh"].Value != null)
                {
                    m_KQHocKyTongHopCtrl.CapNhatHanhKiemHocKy(
                        row.Cells["MaHocSinh"].Value.ToString(),
                        strMaLop,
                        strHocKy,
                        strMaKhoaHoc,
                        row.Cells["MaHanhKiem"].Value.ToString().Trim()
                    );
                }
            }
            //bool OK = m_PhanCongCtrl.isDuocPhepSuaDiem(strTenDangNhap,
            //                                strMaLop,
            //                                strMaMonHoc,
            //                                strMaKhoaHoc
            //                                );
            ////if (OK == false)
            //{
            //    MessageBoxEx.Show(@"Bạn không được phân công dạy lớp "
            //                        + strTenLop +
            //                        " môn " + strTenMonHoc +
            //                        " nên không có quyền cập nhật điểm"
            //        );
            //    //thoat khoi ham
            //    return;
            //}
        }

        private void dgvXepLoaiHanhKiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNamhoc_Click(object sender, EventArgs e)
        {
            frmKhoaHoc m_NamHoc = null;
            if (m_NamHoc == null || m_NamHoc.IsDisposed)
            {
                m_NamHoc = new frmKhoaHoc();
                m_NamHoc.MdiParent = frmMain.ActiveForm;
                m_NamHoc.Show();
            }
            else m_NamHoc.Activate();
           // m_NamHocCtrl.HienThiComboBox(cbmnamhoc);
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            frmLop m_Lop = null;
            if (m_Lop == null || m_Lop.IsDisposed)
            {
                m_Lop = new frmLop();
                m_Lop.MdiParent = frmMain.ActiveForm;
                m_Lop.Show();
            }
            else m_Lop.Activate();
        }

        private void cbmKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbmnamhoc.SelectedValue != null)
             //   m_LopCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop);
            //cmblop.DataBindings.Clear();
        }

        private void cmblop_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cbmnamhoc.SelectedValue != null && cmblop.SelectedValue != null)
           //     m_MonHocCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop.SelectedValue.ToString(), cmbMonhoc);
            ///cmbMonhoc.DataBindings.Clear();
        }

        private void cmbNanhocCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            //m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhocCN);
            cmbKhoaHoc.DataBindings.Clear();
        }

        private void dgvNhapdiemchung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMonhocCN_Click(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbKhoaHoc);
            cmbKhoaHoc.DataBindings.Clear();
        }
        public void setEnableControl(bool status)
        {
            bngluu.Enabled = status;

   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSHanhKiemHS();
        }

        private void dgvNhapdiemchung_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
        }


    }
}