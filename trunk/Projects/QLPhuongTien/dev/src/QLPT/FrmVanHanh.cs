﻿using System;
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
        int iDatimeVH = 0;
        public FrmVanHanh()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        Utils utils = new Utils();
        VanHanhBUS m_VanHanhBUS = new VanHanhBUS();
        BaoTriBUS m_BaoTriBUS = new BaoTriBUS();
        enum LOAI_CONG_THUC
        {
            KM_TAN = 1
            ,
            GIO = 2
                ,
            M3 = 5
                ,
            TAN = 3
                ,
            KG = 4
                , M3_TAN = 6
        };
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
            spbGio.Value = 0;
            spbm3.Value = 0;
            cmbLoaiPT.Text = "";
            cmbCongThucVH.Text = "";
            cmbNhanVienID.Text = "";
        }

        public void lockControlStartLoadForm()
        {
            dtpNgayVH.Enabled = false;
            cmbPhuongTienID.Enabled = false;
            txtDonVi.Enabled = false;
            cmbNhanVienID.Enabled = false;
            txtMoTa.Enabled = false;
            spbVanHanh.Enabled = false;
            spbGio.Enabled = false;
            spbCaLamViec.Enabled = false;
            txtVanHanhID.Enabled = false;
            cmbDVTC.Enabled = false;
            cmbLoaiPT.Enabled = false;
            spbm3.Enabled = false;
        }

        public void unlockControlEndLoadForm()
        {
            dtpNgayVH.Enabled = true;
            cmbPhuongTienID.Enabled = true;
            txtDonVi.Enabled = true;
            cmbNhanVienID.Enabled = true;
            txtMoTa.Enabled = true;
            spbVanHanh.Enabled = true;
            spbGio.Enabled = true;
            spbCaLamViec.Enabled = true;
            txtVanHanhID.Enabled = true;
            cmbDVTC.Enabled = true;
            cmbLoaiPT.Enabled = true;
            spbm3.Enabled = true;
        }
        public bool validData()
        {
            if(spbVanHanh.Value<0)
            {
                MessageBox.Show("Số liệu vận hành phải lớn hơn 0");
                return false;
            }
            if (cmbPhuongTienID.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn phương tiện");
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

        public void ShowComboxForLoaiPT()
        {
            try
            {

                this.cmbLoaiPT.DataSource = m_VanHanhBUS.selectLoaiPT();
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvVanHanh.Columns["LoaiPTMa"];
                comboBoxColumn.DataSource = m_VanHanhBUS.selectLoaiPT();
                comboBoxColumn.DisplayMember = "LoaiPTTen";
                comboBoxColumn.ValueMember = "LoaiPTMa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        public void ShowComboxForCongThucVH()
        {
            try
            {
                this.cmbCongThucVH.DataSource = m_VanHanhBUS.selectLoaiPT();
                this.cmbCongThucVH.DisplayMember = "CongThucVH_";
                this.cmbCongThucVH.ValueMember = "LoaiPTMa";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvVanHanh.Columns["CongThucVH_"];
                comboBoxColumn.DataSource = m_VanHanhBUS.selectLoaiPT();
                comboBoxColumn.DisplayMember = "TenCT";
                comboBoxColumn.ValueMember = "CongThucVH_";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        private void FrmVanHanh_Load(object sender, EventArgs e)
        {
            // lockControlStartLoadForm();
            DataTable dat = new DataTable();
            dat = m_VanHanhBUS.selectVanHanh();
            dgvVanHanh.DataSource = dat;
            ShowComboxForDVTCCol();
            ShowComboxForNhanVienCol();
            ShowComboxForPhuongTienCol();
            ShowComboxForLoaiPT();
            ShowComboxForCongThucVH();


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
            //unlockControlEndLoadForm();
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

            bool contain_Ngay_Ca_PhuongTien = m_VanHanhBUS.contain_Ngay_Ca_PhuongTien(dtpNgayVH.Text, spbCaLamViec.Text, cmbPhuongTienID.SelectedValue.ToString());
            if (contain_Ngay_Ca_PhuongTien == true)
            {
                MessageBox.Show("Trùng ngày vận hành và ca làm việc với lần vận hành trước đó !");
            }
            else
            {
                try
                {
                    //DataTable dt = m_VanHanhBUS.selectNgayVHByNgayBatDauVH(cmbPhuongTienID.SelectedValue.ToString());
                    //string strNgayBatDauVH = dt.Rows[0][0].ToString();
                    // int i = int.Parse(strNgayBatDauVH);
                    //if (0 > iDatimeVH)
                    //{
                    //    MessageBox.Show("khong hop le");

                    //}
                    //else


                    m_VanHanhBUS.insert(
                                        txtVanHanhID.Text.Trim()
                                        , cmbPhuongTienID.SelectedValue.ToString()
                                        , dtpNgayVH.Text
                                        , spbVanHanh.Text
                                        , txtDonVi.Text
                                        , spbCaLamViec.Text
                                        , cmbNhanVienID.SelectedValue.ToString()
                                        , cmbDVTC.SelectedValue.ToString()
                                        , txtMoTa.Text
                                        , spbKm.Text
                                        , spbTan.Text
                                        , spbGio.Text
                                        , spbm3.Text
                                        );
                    updateTongVHToPhuongTien();
                    updateSoLanBaoTri();
                    FrmVanHanh_Load(sender, e);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Thêm :" + ex);
                }
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
                DataTable dt = m_VanHanhBUS.selectNgayVHByNgayBatDauVH(cmbPhuongTienID.SelectedValue.ToString());
                string strNgayBatDauVH = dt.Rows[0][0].ToString();

                if (0 > iDatimeVH)
                {
                    MessageBox.Show("khong hop le");
                }
                else
                {
                    m_VanHanhBUS.update(
                                  txtVanHanhID.Text.Trim()
                                  , cmbPhuongTienID.SelectedValue.ToString()
                                  , dtpNgayVH.Text
                                  , spbVanHanh.Text
                                  , txtDonVi.Text
                                  , spbCaLamViec.Text
                                  , cmbNhanVienID.SelectedValue.ToString()
                                  , cmbDVTC.SelectedValue.ToString()
                                  , txtMoTa.Text
                                   , spbKm.Text
                                   , spbTan.Text
                                   , spbGio.Text
                                   , spbm3.Text

                  );
                    MessageBox.Show("Đã sửa mã " + txtVanHanhID.Text.Trim() + " thành công");
                    updateTongVHToPhuongTien();
                    updateSoLanBaoTri();
                    
                    FrmVanHanh_Load(sender, e);
                }

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
            // unlockControlEndLoadForm();

        }
        private void fillDataGridViewToControl()
        {
            try
            {
                foreach (DataGridViewRow row in dgvVanHanh.SelectedRows)
                {
                    dtpNgayVH.Text = row.Cells["NgayVanHanh"].Value.ToString();
                    txtVanHanhID.Text = row.Cells["VanHanhID"].Value.ToString();
                    txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
                    txtDonVi.Text = row.Cells["VanHanhDV"].Value.ToString();


                    cmbNhanVienID.SelectedValue = row.Cells["NhanVienID"].Value.ToString();
                    cmbDVTC.SelectedValue = row.Cells["DonViTCID"].Value.ToString();

                    cmbPhuongTienID.SelectedValue = row.Cells["PhuongTienID2"].Value.ToString();
                    cmbLoaiPT.SelectedValue = row.Cells["LoaiPTMa"].Value.ToString();
                    //cmbLoaiPT.SelectedValue = row.Cells["PhuongTienID2"].Value.ToString();

                    //spbVanHanh.Maximum = utils.ConvertStringToDecimal(row.Cells["VanHanh"].Value.ToString());
                    //spbCaLamViec.Maximum = utils.ConvertStringToDecimal(row.Cells["CaLamViec"].Value.ToString());


                    spbVanHanh.Value = utils.ConvertStringToDecimal(row.Cells["VanHanh"].Value.ToString());
                    spbCaLamViec.Value = utils.ConvertStringToDecimal(row.Cells["CaLamViec"].Value.ToString());
                    spbKm.Value = utils.ConvertStringToDecimal(row.Cells["KmVH"].Value.ToString());
                    spbTan.Value = utils.ConvertStringToDecimal(row.Cells["TanVH"].Value.ToString());
                    spbGio.Value = utils.ConvertStringToDecimal(row.Cells["GioVH"].Value.ToString());
                    spbm3.Value = utils.ConvertStringToDecimal(row.Cells["m3VH"].Value.ToString());



                }
            }
            catch (System.Exception ex)
            {

            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã: " + txtVanHanhID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bool ok =m_VanHanhBUS.delete1(txtVanHanhID.Text);
                    if(ok ==true)
                    {
                        MessageBox.Show("Đã xóa " + this.txtVanHanhID.Text + " thành công !");
                        FrmVanHanh_Load(sender, e);//trở về giao diện đầu     
                    }
                }
            }
            catch { }
           
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



        }

        private void spbKm_ValueChanged(object sender, EventArgs e)
        {
            LOAI_CONG_THUC loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
            EnableControlForVanHanh(loaiCongThuc);
            TinhVanHanh(loaiCongThuc);
        }

        private void spbTan_ValueChanged(object sender, EventArgs e)
        {

            LOAI_CONG_THUC loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
            EnableControlForVanHanh(loaiCongThuc);
            TinhVanHanh(loaiCongThuc);
        }
        public void updateSoLanBaoTri()
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
                m_BaoTriBUS.tinhSoLanBaoTri(fBDTX, fTieuTu, fTrungTu, fDataTu, fTongVH);
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


        private void cmbNhanVienID_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDonViTCbyNhanVien();
        }
        private void selectDonViTCbyNhanVien()
        {
            try
            {
                string strNhanVienID = cmbNhanVienID.SelectedValue.ToString();
                cmbDVTC.DataSource = m_VanHanhBUS.selectDonViTCbyNhanVien(strNhanVienID);
                cmbDVTC.DisplayMember = "DonViTCTen";
                cmbDVTC.ValueMember = "DonViTCID";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi rồi" + ex);
            }
        }
        private void TinhVanHanh(LOAI_CONG_THUC LoaiCongThuc)
        {
            switch (LoaiCongThuc)
            {

                case LOAI_CONG_THUC.M3_TAN:
                    spbKm.Enabled = false;
                    spbGio.Enabled = false;
                    spbVanHanh.Value = spbm3.Value * spbTan.Value;
                    txtDonVi.Text = "tan.m3";
                    break;
                case LOAI_CONG_THUC.GIO:
                    spbTan.Enabled = false;
                    spbKm.Enabled = false;
                    spbm3.Enabled = false;
                    spbVanHanh.Value = spbGio.Value;
                    txtDonVi.Text = "h";
                    break;
                case LOAI_CONG_THUC.KM_TAN:
                    spbGio.Enabled = false;
                    spbm3.Enabled = false;
                    spbVanHanh.Value = spbKm.Value * spbTan.Value;
                    txtDonVi.Text = "tan.km";
                    break;
                case LOAI_CONG_THUC.M3:
                    spbGio.Enabled = false;
                    spbTan.Enabled = false;
                    spbKm.Enabled = false;
                    spbVanHanh.Value = spbm3.Value;
                    txtDonVi.Text = "m3";
                    break;
                case LOAI_CONG_THUC.TAN:
                    spbm3.Enabled = false;
                    spbGio.Enabled = false;
                    spbKm.Enabled = false;
                    spbVanHanh.Value = spbTan.Value;
                    txtDonVi.Text = "tan";
                    break;
                default:
                    break;
            }
        }
        private void selectTenPTbyLoaiPT()
        {
            if (cmbLoaiPT == null)
            {
                return;
            }
            if (cmbLoaiPT.SelectedValue == null)
            {
                return;
            }
            try
            {
                string strLoaiPTMa = cmbLoaiPT.SelectedValue.ToString();
                cmbPhuongTienID.DataSource = m_VanHanhBUS.selectTenPTbyLoaiPT(strLoaiPTMa);
                cmbPhuongTienID.DisplayMember = "PhuongTienInfo";
                cmbPhuongTienID.ValueMember = "PhuongTienID2";
            }
            catch (System.Exception ex)
            {

            }

        }

        private void EnableControlForVanHanh(LOAI_CONG_THUC loaiCongThuc)
        {
            switch (loaiCongThuc)
            {

                case LOAI_CONG_THUC.M3:
                    spbm3.Enabled = true;
                    spbGio.Enabled = false;
                    spbKm.Enabled = false;
                    spbTan.Enabled = false;
                    spbVanHanh.Enabled = false;
                    break;
                case LOAI_CONG_THUC.GIO:
                    spbm3.Enabled = false;
                    spbGio.Enabled = true;
                    spbKm.Enabled = false;
                    spbTan.Enabled = false;
                    spbVanHanh.Enabled = false;
                    break;
                case LOAI_CONG_THUC.KM_TAN:
                    spbm3.Enabled = false;
                    spbGio.Enabled = false;
                    spbKm.Enabled = true;
                    spbTan.Enabled = true;
                    spbVanHanh.Enabled = false;
                    break;
                case LOAI_CONG_THUC.M3_TAN:
                    spbm3.Enabled = true;
                    spbGio.Enabled = false;
                    spbKm.Enabled = false;
                    spbTan.Enabled = true;
                    spbVanHanh.Enabled = false;
                    break;
                case LOAI_CONG_THUC.TAN:
                    spbm3.Enabled = false;
                    spbGio.Enabled = false;
                    spbKm.Enabled = false;
                    spbTan.Enabled = true;
                    spbVanHanh.Enabled = false;
                    break;

                default:
                    spbm3.Enabled = false;
                    spbGio.Enabled = false;
                    spbKm.Enabled = false;
                    spbTan.Enabled = true;
                    spbVanHanh.Enabled = false;
                    break;
            }
        }
        private void cmbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTenPTbyLoaiPT();

            LOAI_CONG_THUC loaiCongThuc;
            try
            {
                cmbCongThucVH.SelectedIndex = cmbLoaiPT.SelectedIndex;//hiển thị đồng thời khi chọn Loại phương tiện
                loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
                EnableControlForVanHanh(loaiCongThuc);
                TinhVanHanh(loaiCongThuc);

            }
            catch (System.Exception ex)
            {

            }

        }

        private void spbGio_ValueChanged(object sender, EventArgs e)
        {
            LOAI_CONG_THUC loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
            EnableControlForVanHanh(loaiCongThuc);
            TinhVanHanh(loaiCongThuc);
        }


        private void dtpNgayVH_ValueChanged(object sender, EventArgs e)
        {
            string strDatimeVH = dtpNgayVH.Value.ToString("yyyyMMdd");
            iDatimeVH = int.Parse(strDatimeVH);

        }

        private void FrmVanHanh_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void spbm3_ValueChanged(object sender, EventArgs e)
        {
            LOAI_CONG_THUC loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
            EnableControlForVanHanh(loaiCongThuc);
            TinhVanHanh(loaiCongThuc);
        }

        private void cmbCongThucVH_SelectedIndexChanged(object sender, EventArgs e)
        {
            LOAI_CONG_THUC loaiCongThuc = (LOAI_CONG_THUC)utils.getIntInString(cmbCongThucVH.Text.Trim());
            TinhVanHanh(loaiCongThuc);
        }

        //public bool checkVanHanhDuong(string )
        //{
        //    if(spbVanHanh.Value<0)
        //    {
        //        MessageBox.Show("Số liệu vận hành chưa đúng");
        //        return false;
        //    }
        //}
    }
}