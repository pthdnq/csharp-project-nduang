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

namespace QLPT
{
    public partial class FrmDonVi_QL : Form
    {
        public FrmDonVi_QL()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        DonViQL DVQL = new DonViQL();
        //   string ID;
         bool themmoi;
        public void setnull()
        {
            txtDonViQL_ID.Text = "";
            txtDonViQL_ten.Text = "";
            txtDonViQL_ToTruong.Text = "";
            txtEmail.Text = "";
            txtSdt.Text = "";
        }


        private void FrmDonVi_QL_Load(object sender, EventArgs e)
        {
            setnull();
            DataTable dat = new DataTable();
            dat = DVQL.ShowDonVi_QuanLy();
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
            txtDonViQL_ID.Enabled = false;
            themmoi = true;
            setnull();
            btSua.Enabled = false;

            dt.moketnoi();
            string sql = @"set rowcount 1 select DonViQLID from DonViQuanLy order by DonViQLID Desc ";
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DonViQuanLy");
            string returnMaximumDonViQLId = ds.Tables["DonViQuanLy"].Rows[0][0].ToString();
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumDonViQLId.Replace("DVQL", ""));
            }
            catch { }
            txtDonViQL_ID.Text = "DVQL" + dt.LaySTT(maximumNum + 1);

          
            dt.dongketnoi();

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            themmoi = true;
            if (this.txtDonViQL_ten.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtDonViQL_ToTruong.Text.Length == 0)
                    MessageBox.Show("Trường Tổ trưởng không được bỏ trống !");
                else
                    if (this.txtEmail.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                        if (this.txtSdt.Text.Length == 0)
                            MessageBox.Show("Trường Sdt không được bỏ trống !");
                        else
                            try
                            {
                                DVQL.InsertDonVi_QuanLy(txtDonViQL_ID.Text, txtDonViQL_ten.Text, txtDonViQL_ToTruong.Text,txtSdt.Text, txtEmail.Text);
                                //if (layID > 0)
                                //{
                                //    txtDonViQL_ID.Text = layID.ToString();
                                //}
                               
                                MessageBox.Show("Đã thêm " + txtDonViQL_ten.Text + " thành công !");
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
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {

            themmoi = false;
            if (this.txtDonViQL_ten.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtDonViQL_ToTruong.Text.Length == 0)
                    MessageBox.Show("Trường Tổ trưởng không được bỏ trống !");
                else
                    if (this.txtEmail.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                        if (this.txtSdt.Text.Length == 0)
                            MessageBox.Show("Trường Sdt không được bỏ trống !");
                        else
                            try
                            {
                                DVQL.UpdateDonVi_QuanLy(txtDonViQL_ID.Text, txtDonViQL_ten.Text, txtDonViQL_ToTruong.Text, txtSdt.Text, txtEmail.Text);
                                MessageBox.Show("Đã sửa  ID :" + txtDonViQL_ID.Text + " thành công ");
                                FrmDonVi_QL_Load(sender, e);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi Sửa :" + ex);
                            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.txtDonViQL_ID.Text.Length == 0)
            {
                this.txtDonViQL_ID.ForeColor = Color.Red;
                MessageBox.Show("Bạn cần chọn Mã Xe để xóa");
            }
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với ID " + txtDonViQL_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    DVQL.DeleteDonVi_QuanLy(this.txtDonViQL_ID.Text);
                    MessageBox.Show("Đã xóa ID " + this.txtDonViQL_ID.Text + " thành công !");
                    FrmDonVi_QL_Load(sender, e);//trở về giao diện đầu     
                }
        }

    }
}
