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
    public partial class FrmNhanVien : Form
    {
        Data dt = new Data();
        string values2;
        NhanVien nv = new NhanVien();
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public void setnull()
        {
            txtNhanVien_ID.Text = "";
            txtNhanVien_Ten.Text = "";
            txtNhanVien_Sdt.Text = "";
            txtNhanVien_Email.Text = "";
            txtNhanVien_DC.Text = "";
            txtNhanVien_Sdt.Text = "";
           cmbDVTC.Text = "";
            
        }

        public void hienthi()
        {
            string sql = "select NhanVienID as [Mã NV],NhanVienTen as [Tên NV],NhanVienSdt as [Sdt],NhanVienEmail as [Email],NhanVienDC as [Địa chỉ], DonViTC.DonViTCTen as [Tên đơn vị] From NhanVien INNER JOIN DonViTC ON NhanVien.DonViTCID = DonViTC.DonViTCID ";
            dt.moketnoi();
            SqlCommand cmd = new SqlCommand(sql);
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "NhanVien");
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = ds.Tables[0];
            dt.dongketnoi();

        }
        
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            setnull();
            //DataTable dat = new DataTable();
            //dat = nv.ShowNhanVien();
            //dataGridView1.DataSource = dat;

            hienthi();
            try
            {
                string sql1 = @"Select * from DonViTC";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql1, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DonViTC");
                DataTable dtb = ds.Tables["DonViTC"];
              //  cmbDVTC.SelectedIndex = 1;
                dt.dongketnoi();
                this.cmbDVTC.DataSource = dtb;
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
                cmbDVTC.Text = "";
            //    if (cmbDVTC.ValueMember != null)
            //      //  values2 = ds.Tables[0].Rows[cmbDVTC.SelectedIndex][0].ToString();




            //    // cmbMaNCC.Items.Clear();

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

        private void btThem_Click(object sender, EventArgs e)
        {
            txtNhanVien_ID.Enabled = false;
            setnull();
            dt.moketnoi();
            string sql = @"set rowcount 1 select NhanVienID from NhanVien order by NhanVienID Desc ";
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "NhanVien");

            string returnMaximumNhanVienId = ds.Tables["NhanVien"].Rows[0][0].ToString();
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumNhanVienId.Replace("NV", ""));
            }
            catch { }


            txtNhanVien_ID.Text = "NV" + dt.LaySTT(maximumNum + 1);
            dt.dongketnoi();
           
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
           
            if (this.txtNhanVien_Ten.Text.Length == 0)
                MessageBox.Show("Trường Tên NV không được bỏ trống !");
            else
                if (this.txtNhanVien_Sdt.Text.Length == 0)
                    MessageBox.Show("Trường Sdt Nhân Viên không được bỏ trống !");
                else
                    if (this.txtNhanVien_Email.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                if (this.txtNhanVien_DC.Text.Length == 0)
                    MessageBox.Show("Trường Địa chỉ không được bỏ trống !");
                else
                  
                        if (this.cmbDVTC.Text.Length == 0)
                            MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                        else
                             
                                    try
                                    {

                                      nv.InsertNhanVien(txtNhanVien_ID.Text, txtNhanVien_Ten.Text,txtNhanVien_Sdt.Text, txtNhanVien_Email.Text, txtNhanVien_DC.Text,cmbDVTC.SelectedValue.ToString());
                                        //if (layID > 0)
                                        //{
                                        //    txtNhanVien_ID.Text = layID.ToString();
                                        //}
                                      FrmNhanVien_Load(sender, e);
                                        MessageBox.Show("Đã thêm " + txtNhanVien_ID.Text + " thành công !");

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("Lỗi Thêm :" + ex);
                                    }
            
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (this.txtNhanVien_Ten.Text.Length == 0)
                MessageBox.Show("Trường Tên NV không được bỏ trống !");
            else
                if (this.txtNhanVien_Sdt.Text.Length == 0)
                    MessageBox.Show("Trường Sdt Nhân Viên không được bỏ trống !");
                else
                    if (this.txtNhanVien_Email.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                        if (this.txtNhanVien_DC.Text.Length == 0)
                            MessageBox.Show("Trường Địa chỉ không được bỏ trống !");
                        else

                            if (this.cmbDVTC.Text.Length == 0)
                                MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                            else
                                    try
                                    {
                                        nv.UpdateNhanVien(txtNhanVien_ID.Text, txtNhanVien_Ten.Text, txtNhanVien_Sdt.Text, txtNhanVien_Email.Text, txtNhanVien_DC.Text, cmbDVTC.Text);
                                        MessageBox.Show("Đã sửa  ID :" + txtNhanVien_ID.Text + " thành công ");
                                        FrmNhanVien_Load(sender, e);
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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
            {
                this.txtNhanVien_ID.Text = row.Cells[1].Value.ToString();
                this.txtNhanVien_Ten.Text = row.Cells[2].Value.ToString();
                this.txtNhanVien_DC.Text = row.Cells[5].Value.ToString();               
                this.txtNhanVien_Sdt.Text = row.Cells[3].Value.ToString();
                this.txtNhanVien_Email.Text = row.Cells[4].Value.ToString();
                this.cmbDVTC.Text = row.Cells[6].Value.ToString();
                btSua.Enabled = true;
            }
        }

        private void cmbDVTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDVTC.ValueMember != null)
            {
                values2 = cmbDVTC.SelectedValue.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }

    }
}
