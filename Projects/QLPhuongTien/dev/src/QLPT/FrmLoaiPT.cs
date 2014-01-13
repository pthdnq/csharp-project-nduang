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
    public partial class FrmLoaiPT : Form
    {
        public FrmLoaiPT()
        {
            InitializeComponent();
        }


        Data dt = new Data();
        Utils m_utils = new Utils();
        LoaiPTBUS m_LoaiPTBUS = new LoaiPTBUS();
        public void resetControl()
        {
            txtLoaiPT_Ten.Text = "";
            txtLoaiPT_Ma.Text = "";
            cmbCongThucVH.Text = "";
           
        }

        private void FrmLoaiPT_Load(object sender, EventArgs e)
        {
            resetControl();
            DataTable dat = new DataTable();
            dat = m_LoaiPTBUS.select();
            dataGridView1.DataSource = dat;

            try
            {
                this.cmbCongThucVH.DataSource = m_LoaiPTBUS.selectCongThucVH();
                this.cmbCongThucVH.DisplayMember = "TenCT";
                this.cmbCongThucVH.ValueMember = "CongThucVH_";


                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dataGridView1.Columns["CongThucVH_"];
                DataTable dt = m_LoaiPTBUS.selectCongThucVH();
                int count = dt.Rows.Count;
                comboBoxColumn.DataSource = m_LoaiPTBUS.selectCongThucVH();
                comboBoxColumn.DisplayMember = "TenCT";
                comboBoxColumn.ValueMember = "CongThucVH_";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }
        public bool validData()
        {

            if (this.txtLoaiPT_Ma.Text.Length == 0)
            {
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
                return false;
            }
            else if (this.txtLoaiPT_Ten.Text.Length == 0)
            {
                MessageBox.Show("Trường Tên Phương tiện không được bỏ trống !");
                return false;
            }
            else if (this.cmbCongThucVH.Text.Length == 0)
            {
                MessageBox.Show("Trường Công Thức Vận Hành không được bỏ trống !");
                return false;
            }
           
            return true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            resetControl();
            txtLoaiPT_Ma.Enabled = true;
            btLuu.Enabled = true;
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
                m_LoaiPTBUS.insert(txtLoaiPT_Ma.Text
                                        , txtLoaiPT_Ten.Text
                                        , cmbCongThucVH.Text
                                      
                                        );

                FrmLoaiPT_Load(sender, e);

            }
            catch (SqlException ex)
            {
                if (ex.ErrorCode == m_utils.ERR_MA_DANG_SU_DUNG)
                {
                    MessageBox.Show("Mã Loại PT [" + txtLoaiPT_Ma.Text + "] đã tồn tại ");
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (!ok)
                return;
            try
            {
                m_LoaiPTBUS.update(txtLoaiPT_Ma.Text.Trim()
                    , txtLoaiPT_Ten.Text.Trim()
                    ,cmbCongThucVH.SelectedValue.ToString()
                    
                    );
                FrmLoaiPT_Load(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi Sửa :" + ex);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    this.txtLoaiPT_Ma.Text = row.Cells["LoaiPTMa"].Value.ToString();
                    this.txtLoaiPT_Ten.Text = row.Cells["LoaiPTTen"].Value.ToString();
                    this.cmbCongThucVH.SelectedValue = row.Cells["CongThucVH_"].Value.ToString();


                }
            }
            catch (System.Exception ex)
            {
            	
            }
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btLuu.Enabled = false;

        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (ok == false)
                return;
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã Loại: " + txtLoaiPT_Ma.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                try
                {
                    m_LoaiPTBUS.delete1(txtLoaiPT_Ma.Text);
                    MessageBox.Show("Đã xóa " + this.txtLoaiPT_Ma.Text + " thành công !");
                    FrmLoaiPT_Load(sender, e);//trở về giao diện đầu     
                }
                catch (SqlException ex)
                {
                    Console.Write("Không xóa đc. Lỗi" + ex.ToString());
                    if (ex.ErrorCode == m_utils.ERR_MA_DANG_SU_DUNG)
                    {
                        MessageBox.Show("Mã [" + txtLoaiPT_Ma.Text + "] đang đươc sử dụng cho bảng khác nên không thể xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
   
    }
}
