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
        DanTocCtrl m_DanTocCtrl = new DanTocCtrl();
        TonGiaoCtrl m_TonGiaoCtrl = new TonGiaoCtrl();
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        KhoiLopCtrl m_KhoiLopCtrl = new KhoiLopCtrl();
        NgheNghiepCtrl m_NgheNghiepChaCtrl = new NgheNghiepCtrl();
        NgheNghiepCtrl m_NgheNghiepMeCtrl = new NgheNghiepCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            m_DanTocCtrl.HienThiComboBox(comboBoxEx4);
            m_TonGiaoCtrl.HienThiComboBox(comboBoxEx3);
            m_NgheNghiepChaCtrl.HienThiComboBox(comboBoxEx2);
            m_NgheNghiepMeCtrl.HienThiComboBox(comboBoxEx1);

            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(MaDanToc);
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(MaTonGiao);
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(MaNgheNghiepCha);
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(MaNgheNghiepMe);
            m_NamHocCtrl.HienThiDataGridViewComboBoxColumn(MaNamHoc);
            m_KhoiLopCtrl.HienThiDataGridViewComboBoxColumn(MaKhoiLop);
            m_LopCtrl.HienThiDataGridViewComboBoxColumn(MaLop);

            m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh, txtMaHS, textBoxTenhs, textBoxX2, checkBoxX1, checkBoxX2, dateTimeInput1, textBoxX4, comboBoxEx4, comboBoxEx3, textBoxX3, comboBoxEx2, textBoxX5, comboBoxEx1);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_HocSinhCtrl.ThemDongMoi();
            int iLastRow = dgvhocsinh.Rows.Count - 1;
            int iMaHSLast = 1;
            if (iLastRow >= 0)
            {
                string strMaHSLast = dgvhocsinh.Rows[iLastRow].Cells["MaHocSinh"].Value.ToString();
                string MaHSLast = strMaHSLast.Replace("HS", "");
                iMaHSLast = int.Parse(MaHSLast) + 1;
            }
            m_Row["MaHocSinh"] = "HS" + quyDinh.LaySTT(iMaHSLast);

            m_Row["HoTen"] = "";
            m_Row["GioiTinh"] = false;
            m_Row["NgaySinh"] = DateTime.Today;
            m_Row["NoiSinh"] = "";
            m_Row["MaDanToc"] = "";
            m_Row["MaTonGiao"] = "";
            m_Row["HoTenCha"] = "";
            m_Row["MaNgheNghiepCha"] = "";
            m_Row["HoTenMe"] = "";
            m_Row["MaNgheNghiepMe"] = "";
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
                KiemTraTruocKhiLuu("MaDanToc") == true &&
                KiemTraTruocKhiLuu("MaTonGiao") == true &&
                KiemTraTruocKhiLuu("HoTenCha") == true &&
                KiemTraTruocKhiLuu("MaNgheNghiepCha") == true &&
                KiemTraTruocKhiLuu("HoTenMe") == true &&
                KiemTraTruocKhiLuu("MaNgheNghiepMe") == true)
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
            m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh, txtMaHS, textBoxTenhs, textBoxX2, checkBoxX1, checkBoxX2, dateTimeInput1, textBoxX4, comboBoxEx4, comboBoxEx3, textBoxX3, comboBoxEx2, textBoxX5, comboBoxEx1);
        }

        private void dgvhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (textBoxX2.Text == "True")
                checkBoxX2.Checked = true;
            else
                checkBoxX1.Checked = true;

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            bool gioiTinh = false;
            if (checkBoxX2.Checked == true)
                gioiTinh = true;

            if (txtMaHS.Text != "" &&
                textBoxTenhs.Text != "" &&
                textBoxX4.Text != "" &&
                textBoxX3.Text != "" &&
                textBoxX5.Text != "" &&
                dateTimeInput1.Value != null &&
                comboBoxEx4.SelectedValue != null &&
                comboBoxEx3.SelectedValue != null &&
                comboBoxEx2.SelectedValue != null &&
                comboBoxEx1.SelectedValue != null)
            {
                if (quyDinh.KiemTraDoTuoi(dateTimeInput1.Value) == true)
                {
                    m_HocSinhCtrl.LuuHocSinh(txtMaHS.Text, textBoxTenhs.Text, gioiTinh, dateTimeInput1.Value, textBoxX4.Text, comboBoxEx4.SelectedValue.ToString(), comboBoxEx3.SelectedValue.ToString(), textBoxX3.Text, comboBoxEx2.SelectedValue.ToString(), textBoxX5.Text, comboBoxEx1.SelectedValue.ToString());
                    m_HocSinhCtrl.HienThi(dgvhocsinh, bdgHocSinh, txtMaHS, textBoxTenhs, textBoxX2, checkBoxX1, checkBoxX2, dateTimeInput1, textBoxX4, comboBoxEx4, comboBoxEx3, textBoxX3, comboBoxEx2, textBoxX5, comboBoxEx1);

                    bdgHocSinh.BindingSource.MoveLast();
                }
                else
                    MessageBoxEx.Show("Tuổi của học sinh " + textBoxTenhs.Text + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        void TimKiemHocSinh()
        {
            if (checkBoxX4.Checked == true)
            {
                m_HocSinhCtrl.TimTheoMa(textBoxX7.Text);
            }
            else
            {
                m_HocSinhCtrl.TimTheoTen(textBoxX7.Text);
            }
        }
        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (textBoxX7.Text == "")
                MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TimKiemHocSinh();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            frmDanToc m_DanToc = null;
            if (m_DanToc == null || m_DanToc.IsDisposed)
            {
                m_DanToc = new frmDanToc();
                m_DanToc.MdiParent = frmMain.ActiveForm;
                m_DanToc.Show();
            }
            else m_DanToc.Activate();
            m_DanTocCtrl.HienThiDataGridViewComboBoxColumn(MaDanToc);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmTonGiao m_TonGiao = null;
            if (m_TonGiao == null || m_TonGiao.IsDisposed)
            {
                m_TonGiao = new frmTonGiao();
                m_TonGiao.MdiParent = frmMain.ActiveForm;
                m_TonGiao.Show();
            }
            else m_TonGiao.Activate();
            m_TonGiaoCtrl.HienThiDataGridViewComboBoxColumn(MaTonGiao);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmNgheNghiep m_NN = null;
            if (m_NN == null || m_NN.IsDisposed)
            {
                m_NN = new frmNgheNghiep();
                m_NN.MdiParent = frmMain.ActiveForm;
                m_NN.Show();
            }
            else m_NN.Activate();
            m_NgheNghiepChaCtrl.HienThiDataGridViewComboBoxColumnNNCha(MaNgheNghiepCha);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmNgheNghiep m_NN1 = null;
            if (m_NN1 == null || m_NN1.IsDisposed)
            {
                m_NN1 = new frmNgheNghiep();
                m_NN1.MdiParent = frmMain.ActiveForm;
                m_NN1.Show();
            }
            else m_NN1.Activate();
            m_NgheNghiepMeCtrl.HienThiDataGridViewComboBoxColumnNNMe(MaNgheNghiepMe);
        }

        private void textBoxX7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon mot file Excel";
            openDlg.RestoreDirectory = true;
            openDlg.Multiselect = false;
            openDlg.Filter = "Excel files (*.xls)|*.xls";

            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDlg.FileName;
                int viTriBatDau = fileName.LastIndexOf('\\') + 1;
                string tenFile = fileName.Substring(viTriBatDau);
                string path = fileName.Replace("\\", "\\\\");
                m_HocSinhCtrl.Import(path, dgvhocsinh);
            }
        }

        private void dgvhocsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIPExcel_Click(object sender, EventArgs e)
        {
        }

        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbNamHoc.SelectedValue != null && cmbKhoiLop.SelectedValue != null)
            //{
            //    m_LopCtrl.HienThiComboBox(cmbKhoiLop.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbLop);
            //    //m_KhoiLopMoiCtrl.HienThiComboBox(cmbKhoilopcu.SelectedValue.ToString(), cmbKhoilopMoi);
            //    cmbLop.DataBindings.Clear();
            //    //lvLopCu.Items.Clear();
            //}
        }

        private void cmbKhoiLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbKhoiLop.SelectedValue != null)
            {
                m_LopCtrl.HienThiComboBox(cmbKhoiLop.SelectedValue.ToString(), cmbNamHoc.SelectedValue.ToString(), cmbLop);
                cmbLop.DataBindings.Clear();
                //lvLopCu.Items.Clear();
            }
        }

    }


}