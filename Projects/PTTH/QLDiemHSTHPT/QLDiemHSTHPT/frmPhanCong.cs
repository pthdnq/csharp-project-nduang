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
    public partial class frmPhanCong : Office2007Form
    {
        PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmPhanCong()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            bngluu.Enabled = false;
            m_NamHocCtrl.HienThiComboBox(cmbNamhoc);
            m_LopCtrl.HienThiComboBox(cmbLop);
            m_MonHocCtrl.HienThiComboBox(cmbMonhoc);
            m_GiaoVienCtrl.HienThiComboBox(cbmgiaovien);

            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(MaLop);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumn(MaMonHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(MaGiaoVien);

            m_PhanCongCtrl.HienThi(dgvPhanCong, bdgPhanCong, txtSott, cmbNamhoc, cmbLop, cmbMonhoc, cbmgiaovien);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            bngluu.Enabled = true;
            DataRow m_Row = m_PhanCongCtrl.ThemDongMoi();
            //tao ma hoc sinh tu dong - begin
            int iLastRow = dgvPhanCong.Rows.Count - 1;
            int iMaPCLast = 1;
            if (iLastRow >= 0)
            {
                string strMaPCLast = dgvPhanCong.Rows[iLastRow].Cells["STT"].Value.ToString();
                string MaPCLast = strMaPCLast.Replace("PC", "");
                iMaPCLast = int.Parse(MaPCLast) + 1;
            }
            
            m_Row["STT"] = "PC" + quyDinh.LaySTT(iMaPCLast);
            m_Row["MaNamHoc"] = "";
            m_Row["MaLop"] = "";
            m_Row["MaMonHoc"] = "";
            m_Row["MaGiaoVien"] = "";
            m_PhanCongCtrl.ThemPhanCong(m_Row);
            bdgPhanCong.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgPhanCong.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvPhanCong.Rows)
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
            dgvPhanCong.EndEdit();
            if (KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaLop") == true &&
                KiemTraTruocKhiLuu("MaMonHoc") == true &&
                KiemTraTruocKhiLuu("MaGiaoVien") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_PhanCongCtrl.LuuPhanCong();
                bngluu.Enabled = false;
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_PhanCongCtrl.HienThi(dgvPhanCong, bdgPhanCong, txtSott, cmbNamhoc, cmbLop, cmbMonhoc, cbmgiaovien);
        }

        private void cmbNamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamhoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void dgvPhanCong_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            if (cmbNamhoc.SelectedValue != null &&
                cmbLop.SelectedValue != null &&
                cmbMonhoc.SelectedValue != null &&
                cbmgiaovien.SelectedValue != null)
            {
                m_PhanCongCtrl.LuuPhanCong(cmbNamhoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhoc.SelectedValue.ToString(), cbmgiaovien.SelectedValue.ToString());

                m_PhanCongCtrl.HienThi(dgvPhanCong, bdgPhanCong, txtSott, cmbNamhoc, cmbLop, cmbMonhoc, cbmgiaovien);                

                bdgPhanCong.BindingSource.MoveLast();
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonTKGV_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemPhanCong();
        }

        void TimKiemPhanCong()
        {
            if (ckboxtheolop.Checked == true)
            {
                m_PhanCongCtrl.TimTheoTenLop(txtTimKiem.Text);
            }
            else
            {
                m_PhanCongCtrl.TimTheoTenGV(txtTimKiem.Text);
            }
        }

        private void dgvPhanCong_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
        }
    }
}