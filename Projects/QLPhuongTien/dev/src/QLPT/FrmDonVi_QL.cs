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
using GenerateData;

namespace QLPT
{
    public partial class frmDonVi_QL : Form
    {
        public frmDonVi_QL()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        Utils utils = new Utils();
        DonViQuanLyBUS m_DonViQuanLyBUS = new DonViQuanLyBUS();
        public void resetControl()
        {
            txtDonViQL_ID.Text = "";
            txtDonViQL_ten.Text = "";
            txtDonViQL_ToTruong.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
        }

        private void FrmDonVi_QL_Load(object sender, EventArgs e)
        {
            GenerateDataToTables generateData = new GenerateDataToTables();
            try
            {
              //  generateData.generateDonViQuanLyData();
            }
            catch
            {

            }

            DataTable dat = new DataTable();
            dat = m_DonViQuanLyBUS.selectDonViQL();
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
            txtDonViQL_ID.Enabled = false;
            resetControl();
            btSua.Enabled = false;
            string returnMaximumDonViQLId = utils.getIDAuto("DonViQuanLy","DonViQLID");//= getIDNumberAuto
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumDonViQLId.Replace("DVQL", ""));
            }
            catch { }
            txtDonViQL_ID.Text = "DVQL" + dt.LaySTT(maximumNum + 1);

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
                m_DonViQuanLyBUS.insert(txtDonViQL_ID.Text
                                        , txtDonViQL_ten.Text
                                        , txtDonViQL_ToTruong.Text
                                        , txtSdt.Text, txtEmail.Text);

                FrmDonVi_QL_Load(sender, e);

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                this.txtDonViQL_ID.Text = row.Cells[1].Value.ToString();
                this.txtDonViQL_ten.Text = row.Cells[2].Value.ToString();
                this.txtDonViQL_ToTruong.Text = row.Cells[3].Value.ToString();
                this.txtSdt.Text = row.Cells[4].Value.ToString();
                this.txtEmail.Text = row.Cells[5].Value.ToString();
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {

            bool ok = validData();
            if (!ok)
                return;
            try
            {
                m_DonViQuanLyBUS.update(txtDonViQL_ID.Text, txtDonViQL_ten.Text, txtDonViQL_ToTruong.Text, txtSdt.Text, txtEmail.Text);
                FrmDonVi_QL_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Sửa :" + ex);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtDonViQL_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    m_DonViQuanLyBUS.delete1(txtDonViQL_ID.Text);
                    MessageBox.Show("Đã xóa " + this.txtDonViQL_ID.Text + " thành công !");
                    FrmDonVi_QL_Load(sender, e);//trở về giao diện đầu     
                }
        }
        public bool validData()
        {
            if (this.txtDonViQL_ten.Text.Length == 0)
            {
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
                return false;
            }
            else if (this.txtDonViQL_ToTruong.Text.Length == 0)
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
