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
    public partial class frmLop : Office2007Form
    {
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        PhanBanCtrl m_PhanBanCtrl = new PhanBanCtrl();
        QuyDinh quyDinh = new QuyDinh();

        public frmLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThiComboBox(cmbKhoilop);
            m_NamHocCtrl.HienThiComboBox(cmbNamhoc);
            m_GiaoVienCtrl.HienThiComboBox(cmbGiaovien);
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(MaGiaoVien);

            m_PhanBanCtrl.HienThiDataGridViewComboBoxColumn(Ban);

            m_LopCtrl.HienThi(dgvLop, bdgLop, txtMaLop, txtTenLop, cmbKhoilop, cmbNamhoc, itiSiso, cmbGiaovien);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_LopCtrl.ThemDongMoi();
            int iLastRow = dgvLop.Rows.Count - 1;
            int iMaLopLast = 1;
            if (iLastRow >= 0)
            {
                string strMaHSLast = dgvLop.Rows[iLastRow].Cells["MaLop"].Value.ToString();
                string MaHSLast = strMaHSLast.Replace("LOP", "");
                iMaLopLast = int.Parse(MaHSLast) + 1;
            }
            m_Row["MaLop"] = "LOP" + quyDinh.LaySTT(iMaLopLast);
            m_Row["TenLop"] = "";
            m_Row["MaKhoiLop"] = "";
            m_Row["MaNamHoc"] = "";
            m_Row["SiSo"] = 0;
            m_Row["MaGiaoVien"] = "";
            m_LopCtrl.ThemLop(m_Row);
            bdgLop.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgLop.BindingSource.RemoveCurrent();
            }
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            dgvLop.EndEdit();
            if (KiemTraTruocKhiLuu("MaLop") == true &&
                KiemTraTruocKhiLuu("TenLop") == true &&
                KiemTraTruocKhiLuu("MaKhoiLop") == true &&
                KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaGiaoVien") == true //&&
                /*KiemTraSiSoTruocKhiLuu("SiSo") == true*/)
            {
                bindingNavigatorPositionItem.Focus();
                m_LopCtrl.LuuLop();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_LopCtrl.HienThi(dgvLop, bdgLop, txtMaLop, txtTenLop, cmbKhoilop, cmbNamhoc, itiSiso, cmbGiaovien);
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            if (txtMaLop.Text != "" &&
                txtTenLop.Text != "" &&
                cmbKhoilop.SelectedValue != null &&
                cmbNamhoc.SelectedValue != null &&
                cmbGiaovien.SelectedValue != null 
                )
            {
                m_LopCtrl.LuuLop(txtMaLop.Text, txtTenLop.Text, cmbKhoilop.SelectedValue.ToString(), cmbNamhoc.SelectedValue.ToString(), itiSiso.Value, cmbGiaovien.SelectedValue.ToString());
                m_LopCtrl.HienThi(dgvLop, bdgLop, txtMaLop, txtTenLop, cmbKhoilop, cmbNamhoc, itiSiso, cmbGiaovien);

                bdgLop.BindingSource.MoveLast();
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng và sỉ số phải theo quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void TimKiemLop()
        {
            if (ckboxtheoMa.Checked == true)
            {
                m_LopCtrl.TimTheoMa(txtTimKiemGV.Text);
            }
            else
            {
                m_LopCtrl.TimTheoTen(txtTimKiemGV.Text);
            }
        }
        
        private void buttonTKGV_Click(object sender, EventArgs e)
        {
            TimKiemLop();
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            frmKhoiLop m_KhoiLop = null;
            if (m_KhoiLop == null || m_KhoiLop.IsDisposed)
            {
                m_KhoiLop = new frmKhoiLop();
                m_KhoiLop.MdiParent = frmMain.ActiveForm;
                m_KhoiLop.Show();
            }
            else m_KhoiLop.Activate();
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
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
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            frmGiaoVien m_GV = null;
            if (m_GV == null || m_GV.IsDisposed)
            {
                m_GV = new frmGiaoVien();
                m_GV.MdiParent = frmMain.ActiveForm;
                m_GV.Show();
            }
            else m_GV.Activate();
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(MaGiaoVien);
        }
    }
}