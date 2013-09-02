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
    public partial class frmKetQua : Office2007Form
    {
        KetQuaCtrl m_KetQuaCtrl = new KetQuaCtrl();
        Tool quyDinh = new Tool();
        public frmKetQua()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmKetQua_Load(object sender, EventArgs e)
        {
            m_KetQuaCtrl.HienThi(dgvketqua, bdgKetqua);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_KetQuaCtrl.ThemDongMoi();
            m_Row["MaKetQua"] = "KQ" + quyDinh.LaySTT(dgvketqua.Rows.Count + 1);
            m_Row["TenKetQua"] = "";
            m_KetQuaCtrl.ThemKetQua(m_Row);
            bdgKetqua.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvketqua.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgKetqua.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvketqua.Rows)
            {
                if (row.Cells[cell].Value != null)
                {
                    String str = row.Cells[cell].Value.ToString();
                    if (str == "")
                    {
                        MessageBox.Show("Giá trị ô không được rỗng!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaKetQua") == true && KiemTraTruocKhiLuu("TenKetQua") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KetQuaCtrl.LuuKetQua();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}