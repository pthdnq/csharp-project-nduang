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
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(MaLop);

            m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
            //tao ma hoc sinh tu dong - begin
            int iLastRow = dgvhocsinh.Rows.Count - 1;
            int iMaHSLast = 1;
            if (iLastRow >= 0)
            {
                string strMaHSLast = dgvhocsinh.Rows[iLastRow].Cells["MaHocSinh"].Value.ToString();
                string MaHSLast = strMaHSLast.Replace("HS", "");
                iMaHSLast = int.Parse(MaHSLast) + 1;
            }
            m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT(iMaHSLast);
            //tao ma hoc sinh tu dong - end
            m_Row["HoTen"] = "";
            m_Row["GioiTinh"] = false;
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["NoiSinh"] = "";
            m_Row["DanToc"] = "";
            m_Row["TonGiao"] = "";
            m_Row["HoTenCha"] = "";
            m_Row["NgheNghiepCha"] = "";
            m_Row["HoTenMe"] = "";
            m_Row["NgheNghiepMe"] = "";
            m_Row["MaNamHoc"] = "";
            m_Row["MaKhoiLop"] = "";
            m_Row["MaLop"] = "";
            m_HocSinhCtrl.ThemHocSinh(m_Row);

            bdgHocSinh.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvhocsinh.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgHocSinh.BindingSource.RemoveCurrent();
            }
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
                        MessageBoxEx.Show("Thông tin học sinh " + row.Cells["HoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        public Boolean KiemTraDoTuoiTruocKhiLuu(String doTuoiColumn)
        {
            foreach (DataGridViewRow row in dgvhocsinh.Rows)
            {
                if (row.Cells[doTuoiColumn].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[doTuoiColumn].Value.ToString());

                    if (quyDinh.KiemTraDoTuoi(ngaySinh) == false)
                    {
                        MessageBoxEx.Show("Tuổi học sinh " + row.Cells["HoTen"].Value.ToString() + " không đúng quy định!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }
        private void bngluu_Click(object sender, EventArgs e)
        {
            //Fixbug - 2013/07/30 - NTHUE - BEGIN
            dgvhocsinh.EndEdit();
            //Fixbug - 2013/07/30 - NTHUE - END
            if (KiemTraTruocKhiLuu("MaHocSinh") == true &&
                KiemTraTruocKhiLuu("HoTen") == true &&
                KiemTraTruocKhiLuu("NoiSinh") == true &&
                //KiemTraTruocKhiLuu("MaDanToc") == true &&
                //KiemTraTruocKhiLuu("MaTonGiao") == true &&
                KiemTraTruocKhiLuu("HoTenCha") == true &&
                //KiemTraTruocKhiLuu("MaNgheNghiepCha") == true &&
                KiemTraTruocKhiLuu("HoTenMe") == true &&
               // KiemTraTruocKhiLuu("MaNgheNghiepMe") == true && 
                KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaKhoiLop") == true &&
                KiemTraTruocKhiLuu("MaLop") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("NgaySinh") == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
                }

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

        private void buttonX4_Click(object sender, EventArgs e)
        {
            //bool gioiTinh = false;
            //if (checkBoxX2.Checked == true)
            //    gioiTinh = true;

            //if (txtMaHS.Text != "" &&
            //    textBoxTenhs.Text != "" &&
            //    textBoxX4.Text != "" &&
            //    textBoxX3.Text != "" &&
            //    textBoxX5.Text != "" &&
            //    dateTimeInput1.Value != null &&
            //    comboBoxEx4.SelectedValue != null &&
            //    comboBoxEx3.SelectedValue != null &&
            //    comboBoxEx2.SelectedValue != null &&
            //    comboBoxEx1.SelectedValue != null)
            //{
            //    if (quyDinh.KiemTraDoTuoi(dateTimeInput1.Value) == true)
            //    {
            //        m_HocSinhCtrl.LuuHocSinh(txtMaHS.Text, textBoxTenhs.Text, gioiTinh, dateTimeInput1.Value, textBoxX4.Text, comboBoxEx4.SelectedValue.ToString(), comboBoxEx3.SelectedValue.ToString(), textBoxX3.Text, comboBoxEx2.SelectedValue.ToString(), textBoxX5.Text, comboBoxEx1.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbKhoiLop.SelectedValue.ToString(), cmbLop.SelectedValue.ToString());
            //        m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh/*, txtMaHS, textBoxTenhs, textBoxX2, checkBoxX1, checkBoxX2, dateTimeInput1, textBoxX4, comboBoxEx4, comboBoxEx3, textBoxX3, comboBoxEx2, textBoxX5, comboBoxEx1,cmbNamHoc,cmbKhoiLop,cmbLop*/);

            //        bdgHocSinh.BindingSource.MoveLast();
            //    }
            //    else
            //        MessageBoxEx.Show("Tuổi của học sinh " + textBoxTenhs.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //    MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        void TimKiemHocSinh()
        {
            if (checkBoxX4.Checked == true)
            {
                m_HocSinhCtrl.TimTheoMa(txtTimKiemHS.Text.Trim());
            }
            else
            {
                m_HocSinhCtrl.TimTheoTen(txtTimKiemHS.Text.Trim());
            }
        }
        private void btnTimKiemHS1_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh();
        }
        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            //Fixbug - 2013/07/30 - NTHUE - BEGIN
            dgvhocsinh.EndEdit();
            //Fixbug - 2013/07/30 - NTHUE - END
            if (KiemTraTruocKhiLuu("MaHocSinh") == true &&
                KiemTraTruocKhiLuu("HoTen") == true &&
                KiemTraTruocKhiLuu("NoiSinh") == true &&
                KiemTraTruocKhiLuu("MaDanToc") == true &&
                KiemTraTruocKhiLuu("MaTonGiao") == true &&
                KiemTraTruocKhiLuu("HoTenCha") == true &&
                KiemTraTruocKhiLuu("MaNgheNghiepCha") == true &&
                KiemTraTruocKhiLuu("HoTenMe") == true &&
                KiemTraTruocKhiLuu("MaNgheNghiepMe") == true &&
                KiemTraTruocKhiLuu("MaNamHoc") == true &&
                KiemTraTruocKhiLuu("MaKhoiLop") == true &&
                KiemTraTruocKhiLuu("MaLop") == true)
            {
                if (KiemTraDoTuoiTruocKhiLuu("NgaySinh") == true)
                {
                    bindingNavigatorPositionItem.Focus();
                    m_HocSinhCtrl.LuuHocSinh();
                }

            }
        }

    }

}