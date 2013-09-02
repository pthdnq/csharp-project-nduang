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
using QLDiemHSTHPT;


namespace QLDiemHSTHPT
{
    public partial class frmHocSinh : Office2007Form
    {
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            //tai khoan hoc sinh thi an nut luu diem
            String strLoaiTaiKhoan = Utilities.NguoiDung.LoaiND.MaLoaiND.Trim();
            if (strLoaiTaiKhoan == "LND004")
            {
                bngluu.Visible = false;
                bngXoa.Visible = false;
                bngThemmoi.Visible = false;
            }
            
            m_NamHocCtrl.HienThiComboBox(cmbKhoaHoc);
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);

            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(MaLop);

            m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            bngluu.Enabled = true;
            DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
            String maHocSinhLonNhat = m_HocSinhCtrl.MaHocSinhLonNhat();
            //String maHocSinhLonNhat ==
            if (maHocSinhLonNhat == "")//Không có học sinh nào cả
            {
                m_Row["MaHocSinh"] = "HS0001";//tạo mã học sinh đầu tiên
            }
            else//tạo mã học sinh tự động tiếp theo
            {
                string MaHSLast = maHocSinhLonNhat.Replace("HS", "");//Loại bỏ chữ HS.ví dụ HS0007 ==> 0007;

                int iMaHSLast = int.Parse(MaHSLast) + 1;//chuyển kiểu dữ liệu từ chuỗi sang số.
                m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT(iMaHSLast);//đưa vào hàng (row);
            }
            
            //tao ma hoc sinh tu dong - end
            m_Row["HoTen"] = "";
            m_Row["GioiTinh"] = false;
            m_Row["DanToc"] = "";
            m_Row["MaNamHoc"] = "";
            m_Row["MaKhoiLop"] = "";
            m_Row["MaLop"] = "";
            m_HocSinhCtrl.ThemHocSinh(m_Row);

            bdgHocSinh.BindingSource.MoveLast();
           // dgvhocsinh.DataBindings.Clear();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            bngluu.Enabled = true;
            if (dgvhocsinh.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHocSinh.BindingSource.RemoveCurrent();
            }
        }

        public Boolean isLopVaKhoiLop()
        {
            foreach (DataGridViewRow row in dgvhocsinh.Rows)
            {
                if (row.Cells["MaKhoiLop"].Value != null && row.Cells["MaLop"].Value != null)
                {
                    String maKhoiLop = row.Cells["MaKhoiLop"].Value.ToString();
                    String maLop = row.Cells["MaLop"].Value.ToString();
                    String strHoTen = row.Cells["HoTen"].Value.ToString();
                    if (maKhoiLop != "" && maLop != "")
                    {
                        bool isTonTai = m_HocSinhCtrl.isLopVaKhoiLop(maKhoiLop, maLop);
                        if (isTonTai == false)
                        {
                            MessageBoxEx.Show(@"Thông tin học sinh về" + strHoTen + " không hợp lệ!\n"
                            +"Lớp không thuộc khối lớp đã chọn ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvhocsinh.Rows)
            {
                i++;
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show(@"Thông tin học sinh: " + row.Cells["HoTen"].Value.ToString() + " không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            bngluu.Enabled = false;
            dgvhocsinh.EndEdit();
            if (KiemTraTruocKhiLuu("MaHocSinh") == true &&
                KiemTraTruocKhiLuu("HoTen") == true &&
                KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaKhoiLop") == true &
                isLopVaKhoiLop() == true &&
                KiemTraTruocKhiLuu("DanToc") == true &&
                KiemTraTruocKhiLuu("MaLop") == true)
            {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
            }

        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh/*, txtMaHS, textBoxTenhs, textBoxX2, checkBoxX1, checkBoxX2, dateTimeInput1, textBoxX4, comboBoxEx4, comboBoxEx3, textBoxX3, comboBoxEx2, textBoxX5, comboBoxEx1,cmbNamHoc,cmbKhoiLop,cmbLop*/);
        }

        void TimKiemHocSinh()
        {
            m_HocSinhCtrl.TimTheoMaHoTenLopNamHoc(
                                                txtMaorHoTen.Text.Trim(),
                                                cmbLop.SelectedValue.ToString(),
                                                cmbKhoaHoc.SelectedValue.ToString()
                                                );
        }
        private void btnTimKiemHS1_Click(object sender, EventArgs e)
        {
            try
            {
                TimKiemHocSinh();
            }
            catch (Exception)
            {
            }
        }

        private void dgvhocsinh_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
        }

    }

}