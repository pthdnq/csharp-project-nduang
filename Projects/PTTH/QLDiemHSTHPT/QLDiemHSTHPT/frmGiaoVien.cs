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
    public partial class frmGiaoVien : Office2007Form
    {
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThiComboBox(cbmChuyenmon);
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(MaMonHoc);
            m_GiaoVienCtrl.HienThi(dgvGiaoVien, bdgGiaoVien, txtMaGV, txtTenGV, txtDiachi, txtDThoai, cbmChuyenmon);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_GiaoVienCtrl.ThemDongMoi();
            m_Row["MaGiaoVien"] = "GV" + quyDinh.LaySTT(dgvGiaoVien.Rows.Count + 1);
            m_Row["TenGiaoVien"] = "";
            m_Row["DiaChi"] = "";
            m_Row["DienThoai"] = "";
            m_Row["MaMonHoc"] = "";
            m_GiaoVienCtrl.ThemGiaoVien(m_Row);
            bdgGiaoVien.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgGiaoVien.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvGiaoVien.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin giáo viên " + row.Cells["TenGiaoVien"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaGiaoVien") == true &&
               KiemTraTruocKhiLuu("TenGiaoVien") == true &&
               KiemTraTruocKhiLuu("DiaChi") == true &&
               KiemTraTruocKhiLuu("DienThoai") == true &&
               KiemTraTruocKhiLuu("MaMonHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_GiaoVienCtrl.LuuGiaoVien();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_GiaoVienCtrl.HienThi(dgvGiaoVien, bdgGiaoVien, txtMaGV, txtTenGV, txtDiachi, txtDThoai, cbmChuyenmon);
        }

        private void btnLuuDS_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (checkBoxX2.Checked == true)
                gioiTinh = true;
            if (txtTenGV.Text != "" &&
               txtDiachi.Text != "" &&
               txtDThoai.Text != "" &&
               cbmChuyenmon.SelectedValue != null)
            {
                m_GiaoVienCtrl.LuuGiaoVien(txtMaGV.Text, txtTenGV.Text, txtDiachi.Text, txtDThoai.Text, cbmChuyenmon.SelectedValue.ToString(),gioiTinh);
                m_GiaoVienCtrl.HienThi(dgvGiaoVien, bdgGiaoVien, txtMaGV, txtTenGV, txtDiachi, txtDThoai, cbmChuyenmon);
                bdgGiaoVien.BindingSource.MoveLast();
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void TimKiemGiaoVien()
        {
            if (ckboxtheoMa.Checked == true)
            {
                m_GiaoVienCtrl.TimTheoMa(txtTimKiemGV.Text);
            }
            else
            {
                m_GiaoVienCtrl.TimTheoTen(txtTimKiemGV.Text);
            }
        }

        private void btnMHoc_Click(object sender, EventArgs e)
        {
            frmMonHoc m_MonHoc = null;
            if (m_MonHoc == null || m_MonHoc.IsDisposed)
            {
                m_MonHoc = new frmMonHoc();
                m_MonHoc.MdiParent = frmMain.ActiveForm;
                m_MonHoc.Show();
            }
            else m_MonHoc.Activate();
            m_MonHocCtrl.HienThiDataGridViewComboBoxColumnGiaoVien(MaMonHoc);
        }

        private void txtTimKiemGV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimKiemGiaoVien();
            }
        }

        private void lblTenGV_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemGV_Click(object sender, EventArgs e)
        {
            if (txtTimKiemGV.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemGiaoVien();
        }

        private void btnIPExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot file Excel";
            openDlg.RestoreDirectory = true;
            openDlg.Multiselect = false;
            openDlg.Filter = "Excel files (*.xls)|*.xls";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDlg.FileName;
                int viTriBatDau = fileName.LastIndexOf('\\') + 1;
                string tenFile = fileName.Substring(viTriBatDau);
                string path = fileName.Replace("\\", "\\\\");
                m_GiaoVienCtrl.Import(path, dgvGiaoVien);
            }
        }
    }
}