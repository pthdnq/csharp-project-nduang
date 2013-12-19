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
    public partial class FrmDonVi_TC : Form
    {
        public FrmDonVi_TC()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        Utils utils = new Utils();
        DonViTCBUS m_DonViTCBUS = new DonViTCBUS();
       // DonVi_TC dvtc = new DonVi_TC();
        public void resetControl()
        {
            txtDonViTC_ID.Text = "";
            txtDonViTC_Ten.Text = "";
            txtDonViTC_ToTruong.Text = "";
            txtSdt.Text = "";
            txtEmail.Text = "";
            txtDonViTC_ToTruong.Text = "";

        }
        private void FrmDonVi_TC_Load(object sender, EventArgs e)
        {
            resetControl();
            DataTable dat = new DataTable();
            dat = m_DonViTCBUS.selectDonViTC();
            dataGridView1.DataSource = dat;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {


            btLuu.Enabled = true;
            btLuu.Enabled = true;
            txtDonViTC_ID.Enabled = false;
            resetControl();
            btSua.Enabled = false;
            string returnMaximumDonViTCId = utils.getIDAuto("DonViTC", "DonViTCID");//= getIDNumberAuto
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumDonViTCId.Replace("DVTC", ""));
            }
            catch { }
            txtDonViTC_ID.Text = "DVTC" + dt.LaySTT(maximumNum + 1);

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            bool ok = validData();
            if (!ok)
                return;
            try
            {
                m_DonViTCBUS.update(txtDonViTC_ID.Text, txtDonViTC_Ten.Text, txtDonViTC_ToTruong.Text, txtSdt.Text, txtEmail.Text);
                FrmDonVi_TC_Load(sender, e);
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtDonViTC_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                m_DonViTCBUS.delete1(txtDonViTC_ID.Text);
                MessageBox.Show("Đã xóa " + this.txtDonViTC_ID.Text + " thành công !");
                FrmDonVi_TC_Load(sender, e);//trở về giao diện đầu     
            }
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
                m_DonViTCBUS.insert(txtDonViTC_ID.Text
                                        , txtDonViTC_Ten.Text
                                        , txtDonViTC_ToTruong.Text
                                        , txtSdt.Text
                                        , txtEmail.Text);

                FrmDonVi_TC_Load(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Thêm :" + ex);
            }

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.txtDonViTC_ID.Text = row.Cells[1].Value.ToString();
                this.txtDonViTC_Ten.Text = row.Cells[2].Value.ToString();
                this.txtEmail.Text = row.Cells[5].Value.ToString();
                this.txtDonViTC_ToTruong.Text = row.Cells[3].Value.ToString();
                this.txtSdt.Text = row.Cells[4].Value.ToString();           
                btSua.Enabled = true;
                btXoa.Enabled = true;
                btLuu.Enabled = false;
            }
        }
        public bool validData()
        {
            if (this.txtDonViTC_Ten.Text.Length == 0)
            {
                MessageBox.Show("Trường Tên Đơn vị TC không được bỏ trống !");
                return false;
            }
            else if (this.txtDonViTC_ToTruong.Text.Length == 0)
            {
                MessageBox.Show("Trường Tổ trưởng không được bỏ trống !");
                return false;
            }
            else if (this.txtEmail.Text.Length == 0)
            {
                MessageBox.Show("Trường Email không được bỏ trống !");
                return false;
            }
            else if (this.txtSdt.Text.Length == 0)
            {
                MessageBox.Show("Trường Sdt không được bỏ trống !");
                return false;
            }
            return true;

        }
    }
}
