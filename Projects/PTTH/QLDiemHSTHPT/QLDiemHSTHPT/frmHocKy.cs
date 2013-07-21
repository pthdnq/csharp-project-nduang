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
    public partial class frmHocKy : Office2007Form
    {
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
      
        public frmHocKy()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmHocKy_Load(object sender, EventArgs e)
        {
            m_HocKyCtrl.HienThi(dgvhocky, bdgHocky);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HocKyCtrl.ThemDongMoi();
            m_Row["MaHocKy"] = "" ;
            m_Row["TenHocKy"] = "";
            m_HocKyCtrl.ThemHocKy(m_Row);
            bdgHocky.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvhocky.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHocky.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvhocky.Rows)
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
            if (KiemTraTruocKhiLuu("MaHocKy") == true && KiemTraTruocKhiLuu("TenHocKy") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HocKyCtrl.LuuHocKy();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}