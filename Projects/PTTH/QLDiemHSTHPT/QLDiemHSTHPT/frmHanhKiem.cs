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
    public partial class frmHanhKiem : Office2007Form
    {
        HanhKiemCtrl m_HanhKiemCtrl = new HanhKiemCtrl();
        Tool quyDinh = new Tool();
        public frmHanhKiem()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            m_HanhKiemCtrl.HienThi(dgvhanhkiem, bdgHanhkiem);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            if (dgvhanhkiem.RowCount == 0)
                bngXoa.Enabled = true;
            DataRow m_Row = m_HanhKiemCtrl.ThemDongMoi();
            m_Row["MaHanhKiem"] = "HK" + quyDinh.LaySTT(dgvhanhkiem.Rows.Count + 1);
            m_Row["TenHanhKiem"] = "";
            m_HanhKiemCtrl.ThemHanhKiem(m_Row);
            bdgHanhkiem.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvhanhkiem.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHanhkiem.BindingSource.RemoveCurrent();
            }
        }

        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvhanhkiem.Rows)
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
            if (KiemTraTruocKhiLuu("MaHanhKiem") == true && KiemTraTruocKhiLuu("TenHanhKiem") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HanhKiemCtrl.LuuHanhKiem();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HanhKiemCtrl.ThemDongMoi();
            m_Row["MaHanhKiem"] = "HK" + quyDinh.LaySTT(dgvhanhkiem.Rows.Count + 1);
            m_Row["TenHanhKiem"] = "";
            m_HanhKiemCtrl.ThemHanhKiem(m_Row);
            bdgHanhkiem.BindingSource.MoveLast();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (dgvhanhkiem.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHanhkiem.BindingSource.RemoveCurrent();
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaHanhKiem") == true && KiemTraTruocKhiLuu("TenHanhKiem") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HanhKiemCtrl.LuuHanhKiem();
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}