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
    public partial class FrmNguyenMau_PT : Form
    {
        public FrmNguyenMau_PT()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        NguyenMauPTBUS m_NguyenMauPTBUS = new NguyenMauPTBUS();
        Utils utils = new Utils();

        public void resetControl()
        {
            txtNguyenMau_ID.Text = "";
            cmbLoaiPT.Text = "";
            spbDaiTu.Value = 0;
            txtNguyenMauChiTiet.Text = "";
            spbBDTX.Value = 0;
            spbDaiTu.Value = 0;
            spbTrungTu.Value = 0;
            spbTieuTu.Value = 0;
            txtNhanHieu.Text = "";
            txtDonVi.Text = "";
            spbNangLuc.Text = "";
        }
        public bool validData()
        {
            if (this.cmbLoaiPT.Text.Length == 0)
            {
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
                return false;
            }
            else if (this.txtNhanHieu.Text.Length == 0)
            {
                MessageBox.Show("Trường nhãn hiệu  không được bỏ trống !");
                return false;
            }
            else  if (this.txtDonVi.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị không được bỏ trống !");
                return false;
            }
            return true;

        }


        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvNguyenMau.RowCount; i++)
            {
                dgvNguyenMau.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }

        }



        private void FrmNguyenMau_PT_Load_1(object sender, EventArgs e)
        {

            resetControl();
            try
            {
                DataTable dat = new DataTable();
                dat = m_NguyenMauPTBUS.select();
                dgvNguyenMau.DataSource = dat;
                cmbLoaiPT.DataSource = m_NguyenMauPTBUS.selectLoaiPT();
                cmbLoaiPT.DisplayMember = "LoaiPTTen";
                cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvNguyenMau.Columns["LoaiPTMa"];
                comboBoxColumn.DataSource = m_NguyenMauPTBUS.selectLoaiPT();
                comboBoxColumn.DisplayMember = "LoaiPTTen";
                comboBoxColumn.ValueMember = "LoaiPTMa";
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //themmoi = true;
            txtNguyenMau_ID.Enabled = false;
            btSua.Enabled = false;
            cmbLoaiPT.Enabled = true;
            btLuu.Enabled = true;
            btXoa.Enabled = false;
            resetControl();
        }
        private string  generateIDNguyenMau()
        {
            int IDMax = utils.getMaxIDAuto("NguyenMauPT", "NguyenMauID");
            IDMax++;
            string strIDMax = utils.convertIntToFormatedString(IDMax);
            return cmbLoaiPT.SelectedValue.ToString() + strIDMax;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (ok == false)
                return;
            try
            {
               m_NguyenMauPTBUS.update(
                    txtNguyenMau_ID.Text.Trim(),
                    cmbLoaiPT.SelectedValue.ToString(),
                    txtNhanHieu.Text,
                    utils.ConvertDecimalToFloat(spbNangLuc.Value),
                    txtDonVi.Text.Trim(),
                    utils.ConvertDecimalToFloat(spbBDTX.Value),
                    utils.ConvertDecimalToFloat(spbTieuTu.Value),
                    utils.ConvertDecimalToFloat(spbTrungTu.Value),
                    utils.ConvertDecimalToFloat(spbDaiTu.Value),
                    txtNguyenMauChiTiet.Text.Trim()
                    );
               FrmNguyenMau_PT_Load_1(sender, e);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi Sửa :" + ex);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (ok == false)
                return;
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với ID " + txtNguyenMau_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    m_NguyenMauPTBUS.delete1(this.txtNguyenMau_ID.Text);
                    
                    FrmNguyenMau_PT_Load_1(sender, e);//trở về giao diện đầu     
                }
            }
            catch (SqlException ex)
            {
                
                if(ex.ErrorCode == utils.ERR_MA_DANG_SU_DUNG)
                {
                    MessageBox.Show("Không thể xóa Mã :" + this.txtNguyenMau_ID.Text + " vì đang sử dụng trong bảng PhuongTien");
                }
            }

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (ok == false && txtNguyenMau_ID.Text.Trim() != "")
                return;
            
            try
            {
                    String newIDNguyenMau= generateIDNguyenMau();
                    m_NguyenMauPTBUS.insert(
                    newIDNguyenMau, 
                    cmbLoaiPT.SelectedValue.ToString(), 
                    txtNhanHieu.Text, 
                    utils.ConvertDecimalToFloat(spbNangLuc.Value), 
                    txtDonVi.Text.Trim(),
                    utils.ConvertDecimalToFloat(spbBDTX.Value),
                    utils.ConvertDecimalToFloat(spbTieuTu.Value),
                    utils.ConvertDecimalToFloat(spbTrungTu.Value),
                    utils.ConvertDecimalToFloat(spbDaiTu.Value), 
                    txtNguyenMauChiTiet.Text.Trim()

                    );
                //if (layID > 0)
                //{
                //    txtNguyenMau_ID.Text = layID.ToString();
                //}
                FrmNguyenMau_PT_Load_1(sender, e);
                MessageBox.Show("Đã thêm " + txtNguyenMau_ID.Text + " thành công !");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm :" + ex);
            }


        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }



        private void dgvNguyenMau_Click(object sender, EventArgs e)
        {
            FillDataFromDataGridViewToControls();
        }

        public void FillDataFromDataGridViewToControls()
        {
            try
            {
                foreach (DataGridViewRow row in dgvNguyenMau.SelectedRows)
                {
                    
                    txtNguyenMau_ID.Text = row.Cells["NguyenMauID"].Value.ToString();
                    cmbLoaiPT.SelectedValue = row.Cells["LoaiPTMa"].Value.ToString();
                    txtNhanHieu.Text = row.Cells["NhanHieu"].Value.ToString();
                    txtDonVi.Text = row.Cells["DonVi"].Value.ToString();

                    //spbBDTX.Maximum = utils.ConvertStringToDecimal(row.Cells["BDTX"].Value.ToString());
                    //spbTieuTu.Maximum = utils.ConvertStringToDecimal(row.Cells["TieuTu"].Value.ToString());
                    //spbTrungTu.Maximum = utils.ConvertStringToDecimal(row.Cells["TrungTu"].Value.ToString());
                    //spbDaiTu.Maximum = utils.ConvertStringToDecimal(row.Cells["DaiTu"].Value.ToString());
                   // spbNangLuc.Maximum = utils.ConvertStringToDecimal(row.Cells["NangLuc"].Value.ToString());

                    spbBDTX.Value = utils.ConvertStringToDecimal(row.Cells["BDTX"].Value.ToString());
                    spbTieuTu.Value = utils.ConvertStringToDecimal(row.Cells["TieuTu"].Value.ToString());
                    spbTrungTu.Value = utils.ConvertStringToDecimal(row.Cells["TrungTu"].Value.ToString());
                    spbDaiTu.Value = utils.ConvertStringToDecimal(row.Cells["DaiTu"].Value.ToString());
                    spbNangLuc.Value = utils.ConvertStringToDecimal(row.Cells["NangLuc"].Value.ToString());

                    txtNguyenMauChiTiet.Text = row.Cells["NguyenMauChiTiet"].Value.ToString();
                    btSua.Enabled = true;
                    txtNguyenMau_ID.Enabled = false;
                    cmbLoaiPT.Enabled = false;
                    btXoa.Enabled = true;
                }
            }
            catch { }
          
        }

        private void FrmNguyenMau_PT_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

    }
}
