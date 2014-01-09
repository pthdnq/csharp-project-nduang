using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using DataAcess;
using System.Data.SqlClient;
using Component;


namespace QLPT
{
    public partial class FrmPhuongTien : Form
    {
        public static int iDatimeVHPT = 0;
        public FrmPhuongTien()
        {
            InitializeComponent();
        }
        //   Data dt = new Data();
        Data dt = new Data();
        Utils utils = new Utils();

        PhuongTienBUS m_PhuongTienBUS = new PhuongTienBUS();
        public void resetControl()
        {
            txtPhuongTienID.Text = "";
            txtTongVH.Text = "";
            txtXuaXu.Text = "";
            txtBienDK.Text = "";
            txtLanBDTX.Text = "";
            txtLanTieuTu.Text = "";
            txtLanTrungTu.Text = "";
            txtLanDaiTu.Text = "";
            cmbDVQL.Text = "";
            cmbDVTC.Text = "";
            cmbLoaiPT.Text = "";
        }
        public void ShowComboxForLoaiPTCol()
        {
            try
            {
                //Loại PT
                this.cmbLoaiPT.DataSource = m_PhuongTienBUS.selectLoaiPT();
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["LoaiPTMa"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectLoaiPT();
                comboBoxColumn.DisplayMember = "LoaiPTTen";
                comboBoxColumn.ValueMember = "LoaiPTMa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        public void ShowComboxForNguyenMauCol()
        {

            try
            {
                // Loại Nguyên Mẫu
                this.cmbNguyenMau.DataSource = m_PhuongTienBUS.selectPhuongTienData_LoaiPT();
                this.cmbNguyenMau.DisplayMember = "NguyenMauTen";
                this.cmbNguyenMau.ValueMember = "NguyenMauID";
                cmbNguyenMau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        public void ShowComboxForDVTCCol()
        {
            try
            {
                //Đơn vị TC
                this.cmbDVTC.DataSource = m_PhuongTienBUS.selectDonViTC();
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
                cmbDVTC.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["DonViTCID"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectDonViTC();
                comboBoxColumn.DisplayMember = "DonViTCTen";
                comboBoxColumn.ValueMember = "DonViTCID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        public void ShowComboxForDVQLCol()
        {

            try
            {
                // Đơn VỊ QL
                this.cmbDVQL.DataSource = m_PhuongTienBUS.selectDonViQL();
                this.cmbDVQL.DisplayMember = "DonViQLTen";
                this.cmbDVQL.ValueMember = "DonVIQLID";
                cmbDVQL.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["DonVIQLID"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectDonViQL();
                comboBoxColumn.DisplayMember = "DonViQLTen";
                comboBoxColumn.ValueMember = "DonVIQLID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        private void FrmPhuongTien_Load(object sender, EventArgs e)
        {
            // resetControl();
            DataTable dat = new DataTable();
            dat = m_PhuongTienBUS.select();
            dgvPhuongTien.DataSource = dat;

            ShowComboxForLoaiPTCol();

            ShowComboxForNguyenMauCol();
            ShowComboxForDVTCCol();
            ShowComboxForDVQLCol();
            selectPhuongTienData_LoaiPT_ByMaLoaiPT();
            string strDatimeVHPT = dtpNgayVH.Value.ToString("yyyyMMdd");
            iDatimeVHPT = int.Parse(strDatimeVHPT);
        }

        public bool validData()
        {
            if (this.txtAutoNum.Text.Length == 0)
            {
                MessageBox.Show("Trường AutoNum không được bỏ trống !");
                return false;
            }
            if (this.txtPhuongTienID.Text.Length == 0)
            {
                MessageBox.Show("Trường Mã PT không được bỏ trống !");
                return false;
            }
            if (this.cmbLoaiPT.Text.Length == 0)
            {
                MessageBox.Show("Trường Loại PT không được bỏ trống !");
                return false;
            }
            else if (this.cmbNguyenMau.Text.Length == 0)
            {
                MessageBox.Show("Trường Loại Nguyên mẫu không được bỏ trống !");
                return false;
            }
            else if (this.txtBienDK.Text.Length == 0)
            {
                MessageBox.Show("Trường Biển ĐK không được bỏ trống !");
                return false;
            }
            else if (this.txtXuaXu.Text.Length == 0)
            {
                MessageBox.Show("Trường Xuất xứ không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVTC.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị TC không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVQL.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị QL không được bỏ trống !");
                return false;
            }
            else if (this.dtpNgayVH.Text.Length == 0)
            {
                MessageBox.Show("Trường Ngày VH không được bỏ trống !");
                return false;
            }
            return true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            resetControl();
            dt.moketnoi();
            txtTongVH.Text = "0";
            txtLanBDTX.Text = "0";
            txtLanTieuTu.Text = "0";
            txtLanTrungTu.Text = "0";
            txtLanDaiTu.Text = "0";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            txtPhuongTienID.Text = generatePhuongTien();

            bool Ok = validData();
            if (Ok == false)
            {
                return;
            }
            try
            {
                m_PhuongTienBUS.insert(
               txtAutoNum.Text,
               cmbLoaiPT.SelectedValue.ToString(),
               txtPhuongTienID.Text,
               cmbNguyenMau.SelectedValue.ToString(),
               cmbDVQL.SelectedValue.ToString(),
               cmbDVTC.SelectedValue.ToString(),
               txtBienDK.Text,
               dtpNgayVH.Text,
               txtLanBDTX.Text,
               txtLanTieuTu.Text,
               txtLanTrungTu.Text,
               txtLanDaiTu.Text,
               txtXuaXu.Text,
               txtTongVH.Text

                          );

                FrmPhuongTien_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm :" + ex);
            }

        }
        private void btSua_Click(object sender, EventArgs e)
        {
            bool ok = validData();

            if (!ok)
                return;
            //else if ()
            //{
            //    cmbLoaiPT.Enabled = false;
            //}
            try
            {
                m_PhuongTienBUS.update(
               txtAutoNum.Text,
               cmbLoaiPT.SelectedValue.ToString(),
               txtPhuongTienID.Text,
               cmbNguyenMau.SelectedValue.ToString(),
               cmbDVQL.SelectedValue.ToString(),
               cmbDVTC.SelectedValue.ToString(),
               txtBienDK.Text,
               dtpNgayVH.Text,
               txtLanBDTX.Text,
               txtLanTieuTu.Text,
               txtLanTrungTu.Text,
               txtLanDaiTu.Text,
               txtXuaXu.Text,
               txtTongVH.Text
                          );
                FrmPhuongTien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa :" + ex);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPhuongTien.SelectedRows)
            {

                cmbLoaiPT.SelectedValue = row.Cells["LoaiPTMa"].Value.ToString();
                cmbDVQL.SelectedValue = row.Cells["DonVIQLID"].Value.ToString();
                cmbDVTC.SelectedValue = row.Cells["DonViTCID"].Value.ToString();
                cmbNguyenMau.SelectedValue = row.Cells["NguyenMauID"].Value.ToString();

                txtAutoNum.Text = row.Cells["AutoNum"].Value.ToString();
                txtPhuongTienID.Text = row.Cells["PhuongTienID"].Value.ToString();
                txtXuaXu.Text = row.Cells["XuatXu"].Value.ToString();
                txtBienDK.Text = row.Cells["BienDK"].Value.ToString();
                txtLanBDTX.Text = row.Cells["LanBDTX"].Value.ToString();
                txtLanTrungTu.Text = row.Cells["LanTrungTu"].Value.ToString();
                txtLanDaiTu.Text = row.Cells["LanDaiTu"].Value.ToString();
                txtTongVH.Text = row.Cells["TongVH"].Value.ToString();
                txtLanTieuTu.Text = row.Cells["LanTieuTu"].Value.ToString();
                dtpNgayVH.Text = row.Cells["NgayVH"].Value.ToString();

                btSua.Enabled = true;

            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvPhuongTien.RowCount; i++)
            {
                dgvPhuongTien.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtPhuongTienID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    // m_PhuongTienBUS.delete1(txtPhuongTienID.Text);
                    m_PhuongTienBUS.updateHienTrang(txtPhuongTienID.Text, "0");
                    FrmPhuongTien_Load(sender, e);//trở về giao diện đầu     
                }
            }
            catch (SqlException ex)
            {

            }
        }
        private string generatePhuongTien()
        {
            int IDMax = utils.getMaxIDAuto("PhuongTien", "AutoNum");
            IDMax++;
            string strIDMax = utils.convertIntToFormatedString(IDMax);
            txtAutoNum.Text = strIDMax;
            return cmbLoaiPT.SelectedValue.ToString() + strIDMax;
        }
        private void cmbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectPhuongTienData_LoaiPT_ByMaLoaiPT();
        }
        private void selectPhuongTienData_LoaiPT_ByMaLoaiPT()
        {
            try
            {
                string strMaLoaiPt = cmbLoaiPT.SelectedValue.ToString();
                cmbNguyenMau.DataSource = m_PhuongTienBUS.selectPhuongTienData_LoaiPT_ByMaLoaiPT(strMaLoaiPt);
                cmbNguyenMau.DisplayMember = "NguyenMauTen";
                cmbNguyenMau.ValueMember = "NguyenMauID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi rồi" + ex);
            }
        }

        private void txtSearchPhuongTien_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }
        private void timKiem()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvPhuongTien.DataSource;
            //bs.Filter = dgvNhanVien.Columns["NhanVienTen"].HeaderText.ToString() + " LIKE '%" + txtTimKiem.Text + "%'";
            bs.Filter = "LoaiPTMa like '*" + txtSearchPhuongTien.Text.Trim() + "*'";
            dgvPhuongTien.DataSource = bs;
            dgvPhuongTien.Refresh();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void txtSearchPhuongTien_Click(object sender, EventArgs e)
        {
            txtSearchPhuongTien.Text = "";
        }

        private void txtTongVH_TextChanged(object sender, EventArgs e)
        {
            if (txtTongVH != null && txtTongVH.Text.Trim() != "")
            {
                try
                {
                    float tongVH = float.Parse(txtTongVH.Text.Trim());
                    if(tongVH>0)
                    {
                        cmbLoaiPT.Enabled = false;
                        cmbNguyenMau.Enabled = false;
                        return;
                    }
                }
                catch (System.Exception ex)
                {

                }
            }
            cmbLoaiPT.Enabled = true;
            cmbNguyenMau.Enabled = true;
        }
       
        private void dtpNgayVH_ValueChanged(object sender, EventArgs e)
        {
            string strDatimeVHPT = dtpNgayVH.Value.ToString("yyyyMMdd");
            iDatimeVHPT = int.Parse(strDatimeVHPT);
        }


    
    }
}
