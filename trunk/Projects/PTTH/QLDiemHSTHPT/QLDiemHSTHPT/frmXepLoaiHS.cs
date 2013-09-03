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
using System.Threading;

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
        Tool quyDinh = new Tool();
        public frmXepLoaiHS()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmXepLoaiHS_Load(object sender, EventArgs e)
        {
            m_HanhKiemCtrl.HienThiDataGridViewComboBoxColumn(MaHanhKiem);
            m_HocLucCtrl.HienThiDataGridViewComboBoxColumn(MaHocLuc);
            m_NamHocCtrl.HienThiComboBox(cmbKhoaHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocky);
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);
            String strLoaiTaiKhoan = Utilities.NguoiDung.LoaiND.MaLoaiND.Trim();
            //tai khoan hoc sinh thi an nut luu diem
            if (strLoaiTaiKhoan == "LND002")//tai khoản giáo viên mới đc sửa hạnh kiểm
            {
                bngluu.Visible = true;
            }
            else
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
            //Chỉ giáo viên chủ nhiệm mới được sửa hạnh kiểm
            try
            {
                String strTenDangNhap = Utilities.NguoiDung.TenDangNhap;
                bool ok = m_LopCtrl.isGiaoVienChuNhiem(strTenDangNhap,
                                            cmbLop.SelectedValue.ToString(),
                                            cmbKhoaHoc.SelectedValue.ToString());
                LuuXepLoaiHanhKiem();
                bngluu.Enabled = false;
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Lưu thất bại, có thể dữ liệu về lớp, khóa học bị trống");
            }
        }
        private void LuuXepLoaiHanhKiem()
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
            bngluu.Enabled = false;
        }
        private void dgvXepLoaiHanhKiem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhoc);
            cmbKhoaHoc.DataBindings.Clear();
        }

        private void cmbMonhocCN_Click(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbKhoaHoc);
            cmbKhoaHoc.DataBindings.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSHanhKiemHS();
        }

        private void dgvXepLoaiHanhKiem_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
        }


    }
}