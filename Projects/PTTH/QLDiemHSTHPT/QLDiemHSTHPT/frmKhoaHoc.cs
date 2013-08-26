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
    public partial class frmKhoaHoc : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmKhoaHoc()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThi(dgvNamHoc, bdgNamHoc);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            
            DataRow m_Row = m_NamHocCtrl.ThemDongMoi();
            int iLastRow = dgvNamHoc.Rows.Count - 1;
            int iMaHSLast = 1;
            if (iLastRow >= 0)
            {
                string strMaHSLast = dgvNamHoc.Rows[iLastRow].Cells["MaNamHoc"].Value.ToString();
                string MaHSLast = strMaHSLast.Replace("KH", "");
                iMaHSLast = int.Parse(MaHSLast) + 1;
            }
            m_Row["MaNamHoc"]  = "KH" + quyDinh.LaySTT(iMaHSLast);
            m_Row["TenNamHoc"] = "";
            m_NamHocCtrl.ThemNamHoc(m_Row);
            bdgNamHoc.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgNamHoc.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvNamHoc.Rows)
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
            if (KiemTraTruocKhiLuu("MaNamHoc") == true && KiemTraTruocKhiLuu("TenNamHoc") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_NamHocCtrl.LuuNamHoc();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}