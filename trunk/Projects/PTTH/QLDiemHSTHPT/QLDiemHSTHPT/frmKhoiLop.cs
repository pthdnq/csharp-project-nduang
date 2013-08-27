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
    public partial class frmKhoiLop : Office2007Form
    {
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        
        public frmKhoiLop()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void frmKhoiLop_Load(object sender, EventArgs e)
        {
            m_KhoiLopCtrl.HienThi(dgvKhoilop, bdgKhoilop);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_KhoiLopCtrl.ThemDongMoi();
            m_Row["MaKhoiLop"] = "" ;
            m_Row["TenKhoiLop"] = "";
            m_KhoiLopCtrl.ThemKhoiLop(m_Row);
            bdgKhoilop.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhoilop.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgKhoilop.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvKhoilop.Rows)
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
            if (KiemTraTruocKhiLuu("MaKhoiLop") == true && KiemTraTruocKhiLuu("TenKhoiLop") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_KhoiLopCtrl.LuuKhoiLop();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}