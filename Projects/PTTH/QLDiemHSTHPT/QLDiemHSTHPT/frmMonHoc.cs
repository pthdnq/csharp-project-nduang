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
    public partial class frmMonHoc : Office2007Form
    {
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        Tool quyDinh = new Tool();
        public frmMonHoc()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            m_MonHocCtrl.HienThi(dgvMonHoc, bdgMonHoc);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_MonHocCtrl.ThemDongMoi();
            m_Row["MaMonHoc"] = "MH" + quyDinh.LaySTT(dgvMonHoc.Rows.Count + 1);
            m_Row["TenMonHoc"] = "";
            m_Row["SoTiet"] = 0;
            m_Row["HeSoBanCoBan"] = 0;
            m_Row["HeSoBanKHTN"] = 0;
            m_Row["HeSoBanKHXHNV"] = 0;
            m_MonHocCtrl.ThemMonHoc(m_Row);
            bdgMonHoc.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvMonHoc.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgMonHoc.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvMonHoc.Rows)
            {
                if (row.Cells[cell].Value != null)
                {
                    String str = row.Cells[cell].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị ô không được rỗng, số tiết và hệ số phải lớn hơn 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaMonHoc") == true && KiemTraTruocKhiLuu("TenMonHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_MonHocCtrl.LuuMonHoc();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}