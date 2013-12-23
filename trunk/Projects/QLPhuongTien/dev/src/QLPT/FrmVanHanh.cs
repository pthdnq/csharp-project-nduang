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
    public partial class FrmVanHanh : Form
    {
        public FrmVanHanh()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        Utils utils = new Utils();
        VanHanhBUS m_VanHanhBUS = new VanHanhBUS();
        BaoTriBUS m_BaoTriBUS = new BaoTriBUS();
        public void resetControl()
        {
            dtpNgayVH.Text = "";
            spbCaLamViec.Value = 0;
            cmbPhuongTienID.Text = "";
            txtVanHanhID.Text = "";
            spbVanHanh.Value = 0;
            txtDonVi.Text = "";
            cmbDVTC.Text = "";
            cmbNhanVienID.Text = "";
            txtMoTa.Text = "";
        }

        public bool validData()
        {
            if (this.dtpNgayVH.Text.Length == 0)
            {
                MessageBox.Show("Trường Ngày Vận hành không được bỏ trống !");
                return false;
            }
            if (this.cmbPhuongTienID.Text.Length == 0)
            {
                MessageBox.Show("Trường Phương tiện không được bỏ trống !");
                return false;
            }
            else if (this.txtVanHanhID.Text.Length == 0)
            {
                MessageBox.Show("Trường vận hành không được bỏ trống !");
                return false;
            }
            else if (this.txtDonVi.Text.Length == 0)
            {
                MessageBox.Show("Trường đơn vị không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVTC.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị TC không được bỏ trống !");
                return false;
            }
            else if (this.cmbNhanVienID.Text.Length == 0)
            {
                MessageBox.Show("Trường Nhân viên vận hành không được bỏ trống !");
                return false;
            }
            else if (this.txtMoTa.Text.Length == 0)
            {
                MessageBox.Show("Trường Mô tả không được bỏ trống !");
                return false;
            }
            return true;
        }

        public void ShowComboxForDVTCCol()
        {
            try
            {
                //Đơn vị TC
                this.cmbDVTC.DataSource = m_VanHanhBUS.selectDonViTC();
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
                cmbDVTC.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvVanHanh.Columns["DonViTCID"];
                comboBoxColumn.DataSource = m_VanHanhBUS.selectDonViTC();
                comboBoxColumn.DisplayMember = "DonViTCTen";
                comboBoxColumn.ValueMember = "DonViTCID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        public void ShowComboxForNhanVienCol()
        {
            try
            {
                //Đơn vị TC
                this.cmbNhanVienID.DataSource = m_VanHanhBUS.selectNhanVien();
                this.cmbNhanVienID.DisplayMember = "NhanVienTen";
                this.cmbNhanVienID.ValueMember = "NhanVienID";
                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvVanHanh.Columns["NhanVienID"];
                comboBoxColumn.DataSource = m_VanHanhBUS.selectNhanVien();
                comboBoxColumn.DisplayMember = "NhanVienTen";
                comboBoxColumn.ValueMember = "NhanVienID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        public void ShowComboxForPhuongTienCol()
        {
            try
            {
                //Đơn vị TC
                this.cmbPhuongTienID.DataSource = m_VanHanhBUS.selectVanHanh_TenPhuongTien();
                this.cmbPhuongTienID.DisplayMember = "PhuongTienInfo";
                this.cmbPhuongTienID.ValueMember = "PhuongTienID2";
                cmbPhuongTienID.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvVanHanh.Columns["PhuongTienID2"];
                comboBoxColumn.DataSource = m_VanHanhBUS.selectVanHanh_TenPhuongTien();
                comboBoxColumn.DisplayMember = "PhuongTienInfo";
                comboBoxColumn.ValueMember = "PhuongTienID2";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        private void FrmVanHanh_Load(object sender, EventArgs e)
        {
            DataTable dat = new DataTable();
            dat = m_VanHanhBUS.selectVanHanh();
            dgvVanHanh.DataSource = dat;
            ShowComboxForDVTCCol();
            ShowComboxForNhanVienCol();
            ShowComboxForPhuongTienCol();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            txtVanHanhID.Enabled = true;
            btLuu.Enabled = true;
            resetControl();
            btSua.Enabled = false;
            string returnMaximumVanHanhID = utils.getIDAuto("VanHanh", "VanHanhID");//= getIDNumberAuto
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumVanHanhID.Replace("VH", ""));
            }
            catch { }
            txtVanHanhID.Text = "VH" + dt.LaySTT(maximumNum + 1);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bool Ok = validData();
            if (Ok == false)
            {
                return;
            }
            try
            {
                m_VanHanhBUS.insert( 
                                        txtVanHanhID.Text.Trim()
                                        ,cmbPhuongTienID.SelectedValue.ToString()
                                        , dtpNgayVH.Text
                                        , spbVanHanh.Text
                                        , txtDonVi.Text
                                        , spbCaLamViec.Text
                                        , cmbNhanVienID.SelectedValue.ToString()
                                        , cmbDVTC.SelectedValue.ToString()
                                        , txtMoTa.Text
                                         
                                        );
                updateMocBaoTri();
                updateTongVHToPhuongTien();
                FrmVanHanh_Load(sender, e);
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm :" + ex);
            }


        }
        private void updateTongVHToPhuongTien()
        {
            DataTable dtTongVanHanh = m_VanHanhBUS.getTongVanHanh();
            for (int i = 0; i < dtTongVanHanh.Rows.Count; i++)
            {
                DataRow row = dtTongVanHanh.Rows[i];
                string PhuongTienID = row["PhuongTienID"].ToString();
                string TongVH = row["TongVH"].ToString();
                m_VanHanhBUS.update_TongVHToPhuongTien(PhuongTienID, TongVH);
            }
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (!ok)
                return;
            try
            {
                m_VanHanhBUS.update(
                                    txtVanHanhID.Text.Trim()
                                    ,cmbPhuongTienID.SelectedValue.ToString()
                                    , dtpNgayVH.Text
                                    , spbVanHanh.Text
                                    , txtDonVi.Text
                                    , spbCaLamViec.Text
                                    , cmbNhanVienID.SelectedValue.ToString()
                                    , cmbDVTC.SelectedValue.ToString()
                                    , txtMoTa.Text
                    );
               
                updateTongVHToPhuongTien();
                updateMocBaoTri();
                FrmVanHanh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa :" + ex);
            }
        }

        private void dgvVanHanh_Click(object sender, EventArgs e)
        {

            fillDataGridViewToControl();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;
            txtVanHanhID.Enabled = false;
          
        }
        private void fillDataGridViewToControl()
        {
            try
            {
                foreach (DataGridViewRow row in dgvVanHanh.SelectedRows)
                {
                    dtpNgayVH.Text = row.Cells["NgayVanHanh"].Value.ToString();
                    txtVanHanhID.Text = row.Cells["VanHanhID"].Value.ToString();
                    txtVanHanhID.Text = row.Cells["VanHanhID"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                    txtDonVi.Text = row.Cells["VanHanhDV"].Value.ToString();


                    cmbNhanVienID.SelectedValue = row.Cells["NhanVienID"].Value.ToString();
                    cmbDVTC.SelectedValue = row.Cells["DonViTCID"].Value.ToString();
                    cmbPhuongTienID.SelectedValue = row.Cells["PhuongTienID2"].Value.ToString();

                    //spbVanHanh.Maximum = utils.ConvertStringToDecimal(row.Cells["VanHanh"].Value.ToString());
                    //spbCaLamViec.Maximum = utils.ConvertStringToDecimal(row.Cells["CaLamViec"].Value.ToString());


                    spbVanHanh.Value = utils.ConvertStringToDecimal(row.Cells["VanHanh"].Value.ToString());
                    spbCaLamViec.Value = utils.ConvertStringToDecimal(row.Cells["CaLamViec"].Value.ToString());

                }
            }
            catch (System.Exception ex)
            {
            	
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtVanHanhID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                m_VanHanhBUS.delete1(txtVanHanhID.Text);
                MessageBox.Show("Đã xóa " + this.txtVanHanhID.Text + " thành công !");
                FrmVanHanh_Load(sender, e);//trở về giao diện đầu     
            }
        }

        private void dgvVanHanh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvVanHanh.RowCount; i++)
            {
                dgvVanHanh.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }

        private void cmbPhuongTienID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPhuongTienID.SelectedValue.ToString().Contains("XT"))
            {
                spbVanHanh.Enabled = false;
                spbKm.Enabled = true;
                spbTan.Enabled = true;
                
            }
            else
            {
                spbVanHanh.Enabled = true;
                spbKm.Enabled = false;
                spbTan.Enabled = false;
                spbKm.Value = 0;
                spbTan.Value = 0;
            }
        }

        private void spbKm_ValueChanged(object sender, EventArgs e)
        {
            spbVanHanh.Value = spbTan.Value * spbKm.Value;
        }

        private void spbTan_ValueChanged(object sender, EventArgs e)
        {
            spbVanHanh.Value = spbTan.Value * spbKm.Value;
        }
        public void updateMocBaoTri()
        {
            DataTable dtb = new DataTable();
            dtb = m_VanHanhBUS.getMocBaoTriForPhuongTien();
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow currentRow = dtb.Rows[i];
                string strPhuongTienID = currentRow["PhuongTienID"].ToString();
                float fDataTu = float.Parse(currentRow["DaiTu"].ToString());
                float fTrungTu = float.Parse(currentRow["TrungTu"].ToString());
                float fTieuTu = float.Parse(currentRow["TieuTu"].ToString());
                float fBDTX = float.Parse(currentRow["BDTX"].ToString());
                float fTongVH = float.Parse(currentRow["TongVH"].ToString());
                m_BaoTriBUS.tinhSoLanBaoTri(fBDTX, fTieuTu, fTrungTu, fDataTu,fTongVH);
                m_VanHanhBUS.update_LanBaoTri
                    (
                    strPhuongTienID,
                    (m_BaoTriBUS.LanBDTX).ToString(),
                    (m_BaoTriBUS.LanTieuTu).ToString(),
                    (m_BaoTriBUS.LanTrungTu).ToString(),
                    (m_BaoTriBUS.LanDaiTu).ToString()

                    );

            }

        }
    
    }
}
