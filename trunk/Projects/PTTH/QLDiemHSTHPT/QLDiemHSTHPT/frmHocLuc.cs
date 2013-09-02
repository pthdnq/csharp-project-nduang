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
    public partial class frmHocLuc : Office2007Form
    {
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        Tool quyDinh = new Tool();
        public frmHocLuc()
        {
            DataService.OpenConnection();
            InitializeComponent();            
        }

        private void frmHocLuc_Load(object sender, EventArgs e)
        {
            m_HocLucCtrl.HienThi(dgvhocluc, bdgHocluc);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HocLucCtrl.ThemDongMoi();
            m_Row["MaHocLuc"] = "HL" + quyDinh.LaySTT(dgvhocluc.Rows.Count + 1);
            m_Row["TenHocLuc"] = "";
            m_Row["DiemCanTren"] = 0;
            m_Row["DiemCanDuoi"] = 0;
            m_Row["DiemKhongChe"] = 0;
            m_HocLucCtrl.ThemHocLuc(m_Row);
            bdgHocluc.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvhocluc.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHocluc.BindingSource.RemoveCurrent();
            }
        }
        public Boolean KiemTraTruocKhiLuu(String cell)
        {
            foreach (DataGridViewRow row in dgvhocluc.Rows)
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

        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dgvhocluc.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String diem = row.Cells[loaiDiem].Value.ToString();
                    if (diem == "" || quyDinh.KiemTraDiem(diem) == false)
                    {
                        MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            if (KiemTraTruocKhiLuu("MaHocLuc") == true &&
                KiemTraTruocKhiLuu("TenHocLuc") == true &&
                KiemTraDiemTruocKhiLuu("DiemCanTren") == true &&
                KiemTraDiemTruocKhiLuu("DiemCanDuoi") == true &&
                KiemTraDiemTruocKhiLuu("DiemKhongChe") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_HocLucCtrl.LuuHocLuc();
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HocLucCtrl.ThemDongMoi();
            m_Row["MaHocLuc"] = "HL" + quyDinh.LaySTT(dgvhocluc.Rows.Count + 1);
            m_Row["TenHocLuc"] = "";
            m_Row["DiemCanTren"] = 0;
            m_Row["DiemCanDuoi"] = 0;
            m_Row["DiemKhongChe"] = 0;
            m_HocLucCtrl.ThemHocLuc(m_Row);
            bdgHocluc.BindingSource.MoveLast();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvhocluc.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHocluc.BindingSource.RemoveCurrent();
            }
        }
    }
}