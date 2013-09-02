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
    public partial class frmLoaiDiem : Office2007Form
    {
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        Tool quyDinh = new Tool();
        public frmLoaiDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLoaiDiem_Load(object sender, EventArgs e)
        {
            m_LoaiDiemCtrl.HienThi(dgvLD ,bdgLoaiDiem);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_LoaiDiemCtrl.ThemDongMoi();
            m_Row["MaLoaiDiem"] = "LD" + quyDinh.LaySTT(dgvLD.Rows.Count + 1);
            m_Row["TenLoaiDiem"] = "";
            m_Row["HeSo"] = 0;
            m_LoaiDiemCtrl.ThemLoaiDiem(m_Row);
           bdgLoaiDiem.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvLD.RowCount == 0)
                bdgLoaiDiem.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc xóa này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgLoaiDiem.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLD.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "" || str == "0")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng và hệ số phải lớn hơn 0!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaLoaiDiem") == true &&
                KiemTraTruocKhiLuu("TenLoaiDiem") == true &&
                KiemTraTruocKhiLuu("HeSo") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_LoaiDiemCtrl.LuuLoaiDiem();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}