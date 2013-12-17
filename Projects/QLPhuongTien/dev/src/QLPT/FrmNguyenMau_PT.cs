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
    public partial class FrmNguyenMau_PT : Form
    {
        public FrmNguyenMau_PT()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        NguyenMau_PT NguyenMau = new NguyenMau_PT();
        //   string ID;
        //   bool themmoi;
        string values2;
        public void setnull()
        {
            txtNguyenMau_ID.Text = "";
            cmbLoaiPT.Text = "";
            txtDaiTu.Text = "";
            txtNguyenMau_ChiTiet.Text = "";
            txtBDTX.Text = "";
            txtDaiTu.Text = "";
            txtTieuTu.Text = "";
            txtTrungTu.Text = "";
        }

        public void hienThi()
        {
            string sql = "Select NguyenMauPT.NguyenMauID as [Mã NM] , LoaiPT.LoaiPTTen as [Loại NM], NguyenMauPT.NhanHieu as [Nhãn hiệu],"+
                "NguyenMauPT.NangLuc as [Năng lực], NguyenMauPT.DonVi as [Đơn vị tính], NguyenMauPT.BDTX as [BDTX], NguyenMauPT.TieuTu as [Tiểu tu], NguyenMauPT.TrungTu as [Trung tu], NguyenMauPT.DaiTu as [Đại tu], NguyenMauPT.NguyenMauChiTiet as [Chi tiết]"+
                "From NguyenMauPT INNER JOIN LoaiPT ON NguyenMauPT.NguyenMauTen = LoaiPT.LoaiPTMa";
            dt.moketnoi();
            SqlCommand cmd = new SqlCommand(sql);
            SqlDataAdapter da1 = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da1.Fill(ds, "NguyenMauPT");
            dgvNguyenMau.DataSource = null;
            dgvNguyenMau.DataSource = ds.Tables[0];
            dt.dongketnoi();
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
            hienThi();
            setnull();
            //DataTable dat = new DataTable();
            //dat = NguyenMau.ShowNguyenMau_PT();
            //dataGridView1.DataSource = dat;
            // KHÔNG DÙNG COMBOBOX 
            try
            {
                string sql1 = @"Select * from LoaiPT";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql1, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "LoaiPT");
                DataTable dtb = ds.Tables["LoaiPT"];
                // cmbLoaiPT.SelectedIndex = -1;
                dt.dongketnoi();
                this.cmbLoaiPT.DataSource = dtb;
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";
                  //  if (cmbLoaiPT.ValueMember != null)
                  //values2 = ds.Tables[0].Rows[cmbLoaiPT.SelectedIndex][0].ToString();

                //    // cmbMaNCC.Items.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }

            //string[] donvi = {"Tấn" , "Km" , "m3" , "h"};
            //cmbDonViTinh.DataSource = donvi;
            //dataGridView1.data
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            //themmoi = true;
            txtNguyenMau_ID.Enabled = false;
            btSua.Enabled = false;
            setnull();
            dt.moketnoi();
            string sql = @"set rowcount 1 select NguyenMauID from NguyenMauPT order by NguyenMauID Desc";
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "NguyenMauPT");
            string returnMaximumNguyenMauPTId = ds.Tables["NguyenMauPT"].Rows[0][0].ToString();
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(returnMaximumNguyenMauPTId.Replace("NM", ""));
            }
            catch { }
            txtNguyenMau_ID.Text = "NM" + dt.LaySTT(maximumNum + 1);
            dt.dongketnoi();

            dt.dongketnoi();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // themmoi = false;
            if (this.cmbLoaiPT.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtNhanHieu.Text.Length == 0)
                    MessageBox.Show("Trường nhãn hiệu  không được bỏ trống !");
                else
                    if (this.txtNangLuc.Text.Length == 0)
                        MessageBox.Show("Trường Năng lực không được bỏ trống !");
                    else
                        if (this.txtDonVi.Text.Length == 0)
                            MessageBox.Show("Trường Đơn vị không được bỏ trống !");
                        else
                            if (this.txtBDTX.Text.Length == 0)
                                MessageBox.Show("Trường BDTX không được bỏ trống !");
                            else
                                if (this.txtTieuTu.Text.Length == 0)
                                    MessageBox.Show("Trường Tiểu tu tính không được bỏ trống !");
                                else
                                    if (this.txtNguyenMau_ChiTiet.Text.Length == 0)
                                        MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                                    else
                                        if (this.txtTrungTu.Text.Length == 0)
                                            MessageBox.Show("Trường Trung tu không được bỏ trống !");
                                        else
                                            if (this.txtDaiTu.Text.Length == 0)
                                                MessageBox.Show("Trường Đại tu không được bỏ trống !");
                                            else

                                                try
                                                {
                                                    NguyenMau.UpdateNguyenMau_PT(txtNguyenMau_ID.Text, cmbLoaiPT.SelectedValue.ToString() , txtNhanHieu.Text, txtNangLuc.Text, txtDonVi.Text, txtBDTX.Text, txtTieuTu.Text, txtTrungTu.Text, txtDaiTu.Text, txtNguyenMau_ChiTiet.Text);
                                                    MessageBox.Show("Đã sửa  ID :" + txtNguyenMau_ID.Text + " thành công ");
                                                    FrmNguyenMau_PT_Load_1(sender, e);
                                                }
                                                catch (Exception ex)
                                                {
                                                    MessageBox.Show("Lỗi :" + ex);
                                                }


        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.txtNguyenMau_ID.Text.Length == 0)
            {
                this.txtNguyenMau_ID.ForeColor = Color.Red;
                MessageBox.Show("Bạn cần chọn Mã Xe để xóa");
            }
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với ID " + txtNguyenMau_ID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    NguyenMau.DeleteNguyenMau_PT(this.txtNguyenMau_ID.Text);
                    MessageBox.Show("Đã xóa ID " + this.txtNguyenMau_ID.Text + " thành công !");
                    FrmNguyenMau_PT_Load_1(sender, e);//trở về giao diện đầu     
                }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (this.cmbLoaiPT.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtNhanHieu.Text.Length == 0)
                    MessageBox.Show("Trường nhãn hiệu  không được bỏ trống !");
                else
                    if (this.txtNangLuc.Text.Length == 0)
                        MessageBox.Show("Trường Năng lực không được bỏ trống !");
                    else
                        if (this.txtDonVi.Text.Length == 0)
                            MessageBox.Show("Trường Đơn vị không được bỏ trống !");
                        else
                            if (this.txtBDTX.Text.Length == 0)
                                MessageBox.Show("Trường BDTX không được bỏ trống !");
                            else
                                if (this.txtTieuTu.Text.Length == 0)
                                    MessageBox.Show("Trường Tiểu tu tính không được bỏ trống !");
                                else
                                    if (this.txtNguyenMau_ChiTiet.Text.Length == 0)
                                        MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                                    else
                                        if (this.txtTrungTu.Text.Length == 0)
                                            MessageBox.Show("Trường Trung tu không được bỏ trống !");
                                        else
                                            if (this.txtDaiTu.Text.Length == 0)
                                                MessageBox.Show("Trường Đại tu không được bỏ trống !");
                                            else
                                    try
                                    {

                                        NguyenMau.InsertNguyenMau_PT(txtNguyenMau_ID.Text, cmbLoaiPT.SelectedValue.ToString(), txtNhanHieu.Text, txtNangLuc.Text, txtDonVi.Text, txtBDTX.Text, txtTieuTu.Text, txtTrungTu.Text, txtDaiTu.Text, txtNguyenMau_ChiTiet.Text);
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



        //private void dataGridView1_Click(object sender, EventArgs e)
        //{
        //   foreach (DataGridViewRow row in dataGridView1.SelectedRows) 
        //   {               
        //    this.txtNguyenMau_ID.Text =row.Cells[1].Value.ToString();
        //    this.cmbLoaiPT.Text = row.Cells[2].Value.ToString();
        //    this.txtBDTX.Text = row.Cells[3].Value.ToString();
        //    this.txtTieuTu.Text = row.Cells[4].Value.ToString();
        //    this.txtTrungTu.Text = row.Cells[5].Value.ToString();
        //    this.txtDaiTu.Text = row.Cells[6].Value.ToString();
        //    this.txtNguyenMau_ChiTiet.Text = row.Cells[7].Value.ToString();
        //    btSua.Enabled = true;             
        //   }
        //}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNguyenMau.SelectedRows)
            {
                this.txtNguyenMau_ID.Text = row.Cells[1].Value.ToString();
                this.cmbLoaiPT.Text = row.Cells[2].Value.ToString();
                this.txtBDTX.Text = row.Cells[6].Value.ToString();
                this.txtTieuTu.Text = row.Cells[7].Value.ToString();
                this.txtTrungTu.Text = row.Cells[8].Value.ToString();
                this.txtDaiTu.Text = row.Cells[9].Value.ToString();
                this.txtNguyenMau_ChiTiet.Text = row.Cells[10].Value.ToString();
                this.txtNhanHieu.Text = row.Cells[3].Value.ToString();
                this.txtNangLuc.Text = row.Cells[4].Value.ToString();
                this.txtDonVi.Text = row.Cells[5].Value.ToString();
                btSua.Enabled = true;
            }
        }

        private void cmbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiPT.ValueMember != null)
            {
                values2 = cmbLoaiPT.SelectedValue.ToString();
            }
        }


    }
}
