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
    public partial class frmPhanBan : Office2007Form
    {
        PhanBanCtrl m_PhanBanCtrl = new PhanBanCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmPhanBan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        
        private void frmPhanBan_Load(object sender, EventArgs e)
        {
            m_PhanBanCtrl.HienThi(dgvPhanBan,bdgPhanBan);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            dgvPhanBan.EndEdit();
            foreach (DataGridViewRow row in dgvPhanBan.Rows)
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
            if (KiemTraTruocKhiLuu("MaBan") == true && KiemTraTruocKhiLuu("TenBan") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_PhanBanCtrl.LuuBan();
            }
        }

        private void dgvPhanBan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_PhanBanCtrl.ThemDongMoi();
            m_Row["MaBan"] = "B" + quyDinh.LaySTT(dgvPhanBan.Rows.Count + 1);
            m_Row["TenBan"] = "";
            m_PhanBanCtrl.ThemBanMoi(m_Row);
            bdgPhanBan.BindingSource.MoveLast();

        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvPhanBan.RowCount == 0)
                bngXoa.Enabled = false;
            else if (MessageBoxEx.Show("Bạn chắc chắn xóa không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgPhanBan.BindingSource.RemoveCurrent();
            }
        }
        
    }
}

  
   

   