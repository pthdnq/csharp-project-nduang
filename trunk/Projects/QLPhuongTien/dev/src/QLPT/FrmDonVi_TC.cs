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
    public partial class FrmDonVi_TC : Form
    {
        public FrmDonVi_TC()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        DonVi_TC dvtc = new DonVi_TC();
        public void setnull()
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
            setnull();
            DataTable dat = new DataTable();
            dat = dvtc.ShowDonVi_TC();
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

            txtDonViTC_ID.Enabled = false;
            setnull();
            btSua.Enabled = false;

            dt.moketnoi();
            string sql = @"set rowcount 1 select DonViTCID from DonViTC order by DonViTCID Desc ";
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "DonViTC");
            string returnMaximumDonViTCId = ds.Tables["DonViTC"].Rows[0][0].ToString();
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumDonViTCId.Replace("DVTC", ""));
            }
            catch { }
            txtDonViTC_ID.Text = "DVTC" + dt.LaySTT(maximumNum + 1);


            dt.dongketnoi();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // themmoi = false;
            if (this.txtDonViTC_Ten.Text.Length == 0)
                MessageBox.Show("Trường Tên Đơn Vị Thi Công không được bỏ trống !");
            else
                if (this.txtDonViTC_ToTruong.Text.Length == 0)
                    MessageBox.Show("Trường Tổ trưởng thi công không được bỏ trống !");
                else
                    if (this.txtSdt.Text.Length == 0)
                        MessageBox.Show("Trường Số điện thoại không được bỏ trống !");
                    else

                        if (this.txtEmail.Text.Length == 0)
                            MessageBox.Show("Trường Email không được bỏ trống !");
                        else


                            try
                            {
                                dvtc.UpdateDonVi_TC(txtDonViTC_ID.Text, txtDonViTC_Ten.Text, txtDonViTC_ToTruong.Text,txtSdt.Text , txtEmail.Text );
                                MessageBox.Show("Đã sửa  ID :" + txtDonViTC_ID.Text + " thành công ");
                                FrmDonVi_TC_Load(sender, e);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi :" + ex);
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
            if (this.txtDonViTC_ID.Text.Length == 0)
            {
                this.txtDonViTC_ID.ForeColor = Color.Red;
                MessageBox.Show("Bạn cần chọn Mã Xe để xóa");
            }
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với ID " + txtDonViTC_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    dvtc.DeleteDonVi_TC(this.txtDonViTC_ID.Text);
                    MessageBox.Show("Đã xóa Mã DV : " + this.txtDonViTC_ID.Text + " thành công !");
                    FrmDonVi_TC_Load(sender, e);//trở về giao diện đầu     
                }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (this.txtDonViTC_Ten.Text.Length == 0)
                MessageBox.Show("Trường Tên Đơn Vị Thi Công không được bỏ trống !");
            else
                if (this.txtDonViTC_ToTruong.Text.Length == 0)
                    MessageBox.Show("Trường Tổ trưởng thi công không được bỏ trống !");
                else
                    if (this.txtSdt.Text.Length == 0)
                        MessageBox.Show("Trường Số điện thoại không được bỏ trống !");
                    else

                        if (this.txtEmail.Text.Length == 0)
                            MessageBox.Show("Trường Email không được bỏ trống !");
                        else
                            try
                            {

                                dvtc.InsertDonVi_TC(txtDonViTC_ID.Text, txtDonViTC_Ten.Text, txtDonViTC_ToTruong.Text, txtSdt.Text, txtEmail.Text);
                                //if (layID > 0)
                                //{
                                //    txtDonViTC_ID.Text = layID.ToString();
                                //}
                                FrmDonVi_TC_Load(sender, e);
                                MessageBox.Show("Đã thêm Mã DV : " + txtDonViTC_ID.Text + " thành công !");

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
            }
        }
    }
}
