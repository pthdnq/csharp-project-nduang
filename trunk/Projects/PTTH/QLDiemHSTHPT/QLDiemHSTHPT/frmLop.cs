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
    public partial class frmLop : Office2007Form
    {
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        GiaoVienCtrl m_GiaoVienCtrl = new GiaoVienCtrl();
        PhanBanCtrl m_PhanBanCtrl = new PhanBanCtrl();
        Tool quyDinh = new Tool();

        public frmLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            HienThiDSLop();
        }
        public void HienThiDSLop()
        {
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_GiaoVienCtrl.HienThiDataGridViewComboBoxColumn(MaGiaoVien);

            m_PhanBanCtrl.HienThiDataGridViewComboBoxColumn(Ban);
            BindingSource bS = new BindingSource();
            m_LopCtrl.HienThi(dgvLop, bdgLop);
            bngluu.Enabled = false;
        }
        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_LopCtrl.ThemDongMoi();
            int iLastRow = dgvLop.Rows.Count - 1;
            int iMaLopLast = 1;
            if (iLastRow >= 0)
            {
                string strMaHSLast = dgvLop.Rows[iLastRow].Cells["MaLop"].Value.ToString();
                string MaHSLast = strMaHSLast.Replace("LOP", "");
                iMaLopLast = int.Parse(MaHSLast) + 1;
            }
            m_Row["MaLop"] = "LOP" + quyDinh.LaySTT(iMaLopLast);
            m_Row["TenLop"] = "";
            m_Row["MaKhoiLop"] = "";
            m_Row["MaNamHoc"] = "";
            m_Row["SiSo"] = 0;
            m_Row["MaGiaoVien"] = "";
            m_LopCtrl.ThemLop(m_Row);
            bdgLop.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            
            if (dgvLop.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgLop.BindingSource.RemoveCurrent();
                bngluu.Enabled = true;
            }
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvLop.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Giá trị của ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            dgvLop.EndEdit();
            if (KiemTraTruocKhiLuu("MaLop") == true &&
                KiemTraTruocKhiLuu("TenLop") == true &&
                KiemTraTruocKhiLuu("MaKhoiLop") == true &&
                KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaGiaoVien") == true 
                )

            {
                bindingNavigatorPositionItem.Focus();
                bool ok = m_LopCtrl.LuuLop();
                if (ok == false)
                {
                    MessageBoxEx.Show("Lớp đang tồn tại học sinh nên không thể xóa !!!!");
                    HienThiDSLop();

                }
                else
                {
                    //làm mờ nút lưu sau khi lưu thành công
                    bngluu.Enabled = false;
                }
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSLop();
        }

        void TimKiemLop()
        {
            if (ckboxtheoMa.Checked == true)
            {
                m_LopCtrl.TimTheoMa(txtTimKiemGV.Text);
            }
            else
            {
                m_LopCtrl.TimTheoTen(txtTimKiemGV.Text);
            }
        }
        
        private void buttonTKGV_Click(object sender, EventArgs e)
        {
            TimKiemLop();
        }

        private void dgvLop_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //khi dữ liệu có sự thay đổi thì nút lưu hiện lên
            bngluu.Enabled = true;
        }
    }
}