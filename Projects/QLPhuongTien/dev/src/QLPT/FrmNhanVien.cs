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
using Component;
using System.Data.SqlClient;


namespace QLPT
{
    public partial class FrmNhanVien : Form
    {
       
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        Utils utils = new Utils();
        NhanVienBUS m_NhanVienBUS = new NhanVienBUS();
        DonViTCBUS m_DonViTCBUS = new DonViTCBUS();
      //  string values1; 
        public void resetControl()
        {
            txtNhanVien_ID.Text = "";
            txtNhanVien_Ten.Text = "";
            txtNhanVien_Sdt.Text = "";
            txtNhanVien_Email.Text = "";
            txtNhanVien_DC.Text = "";
            txtNhanVien_Sdt.Text = "";
           cmbDVTC.Text = "";
            
        }       
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            resetControl();
            DataTable dat = new DataTable();
            dat = m_NhanVienBUS.select();
            dgvNhanVien.DataSource = dat;
            try
            {
                this.cmbDVTC.DataSource = m_NhanVienBUS.selectDonViTC();
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
               

               DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvNhanVien.Columns["DonViTCID"];
               comboBoxColumn.DataSource = m_DonViTCBUS.selectDonViTC();
               comboBoxColumn.DisplayMember = "DonViTCTen";
               comboBoxColumn.ValueMember = "DonViTCID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }

            try
            {
                this.cmbTenTruyCap.DataSource = m_NhanVienBUS.selectUserNametoNhanVien();
                this.cmbTenTruyCap.DisplayMember = "UserName";
                this.cmbTenTruyCap.ValueMember = "UserName";
                

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvNhanVien.Columns["UserName"];
                comboBoxColumn.DataSource = m_NhanVienBUS.select();
                comboBoxColumn.DisplayMember = "UserName";
                comboBoxColumn.ValueMember = "UserName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                dgvNhanVien.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }

        }
         public bool validData()
        {

            //if (this.txtNhanVien_Ten.Text.Length == 0)
            //{
            //    MessageBox.Show("Trường Mã Nhân Viên không được bỏ trống !");
            //    return false;
            //}
            //else 
                if (this.txtNhanVien_Sdt.Text.Length == 0)
            {
                MessageBox.Show("Trường SDT Nhân Viên không được bỏ trống !");
                return false;
            }
            else if (this.txtNhanVien_Email.Text.Length == 0)
            {
                MessageBox.Show("Trường Email không được bỏ trống !");
                return false;
            }
            else if (this.txtNhanVien_Sdt.Text.Length == 0)
            {
                MessageBox.Show("Trường Sdt không được bỏ trống !");
                return false;
            }
            else if (this.txtNhanVien_DC.Text.Length == 0)
            {
                MessageBox.Show("Trường Địa chỉ không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVTC.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị TC không được bỏ trống !");
                return false;
            }
            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            btLuu.Enabled = true;
            resetControl();
            btSua.Enabled = false;
            string returnMaximumNhanVienID = utils.getIDAuto("NhanVien", "NhanVienID");//= getIDNumberAuto
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumNhanVienID.Replace("NV", ""));
            }
            catch { }
            txtNhanVien_ID.Text = "NV" + dt.LaySTT(maximumNum + 1);
           
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            bool Ok = validData();
            
            if (Ok == false)
            {
                return;
            }
            Ok = validUserName();

            if (Ok == false)
            {
                return;
            }
            try
            {
                m_NhanVienBUS.insert(txtNhanVien_ID.Text
                                        , txtNhanVien_Ten.Text
                                        , txtNhanVien_Sdt.Text
                                        , txtNhanVien_Email.Text
                                        , txtNhanVien_DC.Text                                     
                                         , cmbDVTC.SelectedValue.ToString()
                                         ,cmbTenTruyCap.SelectedValue.ToString()
                                        );

                FrmNhanVien_Load(sender, e);

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
            try
            {
             m_NhanVienBUS.update(txtNhanVien_ID.Text 
                 , txtNhanVien_Ten.Text
                 , txtNhanVien_Sdt.Text
                 ,  txtNhanVien_Email.Text
                 ,  txtNhanVien_DC.Text
                 , cmbDVTC.SelectedValue.ToString()
                 , cmbTenTruyCap.SelectedValue.ToString()
                 );
             FrmNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa :" + ex);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
            {
                this.txtNhanVien_ID.Text = row.Cells[1].Value.ToString();
                this.txtNhanVien_Ten.Text = row.Cells[2].Value.ToString();
                this.txtNhanVien_DC.Text = row.Cells[5].Value.ToString();               
                this.txtNhanVien_Sdt.Text = row.Cells[3].Value.ToString();
                this.txtNhanVien_Email.Text = row.Cells[4].Value.ToString();
                this.cmbDVTC.SelectedValue = row.Cells["DonViTCID"].Value.ToString();
                this.cmbTenTruyCap.SelectedValue = row.Cells["UserName"].Value.ToString();

                btSua.Enabled = true;
                btXoa.Enabled = true;
                btLuu.Enabled = false; 
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtNhanVien_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                m_NhanVienBUS.delete1(txtNhanVien_ID.Text);
                MessageBox.Show("Đã xóa " + this.txtNhanVien_ID.Text + " thành công !");
                FrmNhanVien_Load(sender, e);//trở về giao diện đầu     
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timKiem();
        }
        private void timKiem()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvNhanVien.DataSource;
            //bs.Filter = dgvNhanVien.Columns["NhanVienTen"].HeaderText.ToString() + " LIKE '%" + txtTimKiem.Text + "%'";
            bs.Filter = "NhanVienTen like '*" + txtTimKiem.Text.Trim() + "*'";
            dgvNhanVien.DataSource = bs;
            dgvNhanVien.Refresh();
        }

        private void cmbTenTruyCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validUserName();
        }
        public bool validUserName()
        {
            for (int i = 0; i < dgvNhanVien.RowCount; i++)
            {
                string UserName = dgvNhanVien.Rows[i].Cells["UserName"].Value.ToString();
                if (cmbTenTruyCap.Text.Trim() == UserName)
                {
                    MessageBox.Show("Tài khoản đã được sử dụng cho nhân vien khác");
                    return false;
                }

            }
            return true;
        }

        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
  
       

    }
}
