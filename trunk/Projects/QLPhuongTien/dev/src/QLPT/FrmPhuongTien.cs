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
    public partial class FrmPhuongTien : Form
    {
        public FrmPhuongTien()
        {
            InitializeComponent();
        }
     //   Data dt = new Data();
        PhuongTien phuongtien = new PhuongTien();
        string values3;
        string values1;
        string values2;
        string values4; 

        Data dt = new Data();
        public void setnull()
        {
            txtPhuongTienID.Text = "";
            //txtNguyenMauTen.Text = "";
            //txtNhanHieu.Text = "";
            //txtNangLuc.Text = "";
            //txtDonVi.Text = "";
            txtTongVH.Text = "";
            txtXuaXu.Text = "";
            txtBienDK.Text = "";
            txtLanBDTX.Text = "";
            txtLanTieuTu.Text = "";
            txtLanTrungTu.Text = "";
            txtLanDaiTu.Text = "";
            //dateEdit1.Text = "";
            //txtNguyenMauChiTiet.Text = "";
            cmbDVQL.Text = "";
            cmbDVTC.Text = "";
            cmbLoaiPT.Text = "";


        }
        public void HienthiGrv()
        {
            string sql1 = "SELECT PhuongTien.PhuongTienID as [Mã PT],NguyenMauPT.NguyenMauID as [Mã Nguyên mẫu]  ,NguyenMauPT.NguyenMauTen as [Loại nguyên mẫu],  PhuongTien.BienDK as [Biển ĐK],NguyenMauPT.NguyenMauTen as [Loại PT] , NguyenMauPT.NhanHieu as [Nhãn hiệu] ,"+
                "NguyenMauPT.NangLuc as [Năng lực], NguyenMauPT.DonVi as [đơn vị] , PhuongTien.XuatXu as [Xuất xứ] , DonViTC.DonViTCTen [Đơn vị TC] , DonViQuanLy.DonViQLTen as [Đơn vị QL] ,"+
                "PhuongTien.TongVH as [Tổng vận hành] , PhuongTien.LanBDTX as [số lần BDTX],PhuongTien.LanTieuTu as [Số lần tiểu tu], PhuongTien.LanTrungTu as [Số lần Trung tu], "+
                "PhuongTien.LanDaiTu as [Số lần Đại tu],PhuongTien.NgayVH as [Ngày vận hành], NguyenMauPT.NguyenMauChiTiet as [Chi tiết] FROM PhuongTien " +
                "INNER JOIN DonViTC on DonViTC.DonVITCID = PhuongTien.DonViTCID " +
                "INNER JOIN DonViQuanLy on DonViQuanLy.DonViQLID = PhuongTien.DonViQLID " +
                "INNER JOIN NguyenMauPT on PhuongTien.NguyenMauID = NguyenMauPT.NguyenMauID ";
            //DataTable dtb = new DataTable();
            //dtb = dt.getTable(sql);
            //return dtb;
            dt.moketnoi();
            SqlCommand cmd = new SqlCommand(sql1);
            SqlDataAdapter da1 = new SqlDataAdapter(sql1, dt.sqlConn);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "PhuongTien");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds1.Tables[0];
            dt.dongketnoi();
        }
        private void FrmPhuongTien_Load(object sender, EventArgs e)
        {
            setnull();
            HienthiGrv();
            try
            {
                string sql = @"Select * from LoaiPT";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "LoaiPT");
                DataTable dtb = ds.Tables["LoaiPT"];
                // cmbDVTC.SelectedIndex = -1;
                dt.dongketnoi();
                this.cmbLoaiPT.DataSource = dtb;
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";
                //if (cmbDVTC.ValueMember != null)
                //    values3 = ds.Tables[0].Rows[cmbDVTC.SelectedIndex][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }

            try
            {
                string sql = @"Select NguyenMauID, "+
                                 "(CAST(LoaiPTTen AS nvarchar) + ' ' +CAST(NhanHieu AS nvarchar) + ' ' +  CAST(NangLuc AS nvarchar)+ ' ' +  CAST(DonVi AS nvarchar))as TenPhuongTien," +
                                "LoaiPTTen from NguyenMauPT INNER JOIN LoaiPT ON NguyenMauPT.NguyenMauTen = LoaiPT.LoaiPTMa";
                //string sql = @"select * From NguyenMauPT";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "NguyenMauPT");
                DataTable dtb = ds.Tables["NguyenMauPT"];
               // cmbDVTC.SelectedIndex = -1;
                dt.dongketnoi();
                this.cmbNguyenMau.DataSource = dtb;
                this.cmbNguyenMau.DisplayMember = "TenPhuongTien";
                this.cmbNguyenMau.ValueMember = "NguyenMauID";
                cmbNguyenMau.Text = "";
                //if (cmbNguyenMau.ValueMember != null)
                //    values4 = ds.Tables[0].Rows[cmbNguyenMau.SelectedIndex][0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }


            try
            {
                string sql = @"Select * from DonViTC";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DonViTC");
                DataTable dtb = ds.Tables["DonViTC"];
               // cmbDVTC.SelectedIndex = -1;
                dt.dongketnoi();
                this.cmbDVTC.DataSource = dtb;
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
                cmbDVTC.Text = "";
                if (cmbDVTC.ValueMember != null)
                    values1 = ds.Tables[0].Rows[cmbDVTC.SelectedIndex][0].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }

            try
            {
                string sql = @"Select * from DonViQuanLy";
                dt.moketnoi();
                SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
                DataSet ds = new DataSet();
                da.Fill(ds, "DonViQuanLy");
                DataTable dtb = ds.Tables["DonViQuanLy"];
               // cmbDVQL.SelectedIndex = -1;
                dt.dongketnoi();
                this.cmbDVQL.DataSource = dtb;
                this.cmbDVQL.DisplayMember = "DonViQLTen";
                this.cmbDVQL.ValueMember = "DonViQLID";
                cmbDVQL.Text = "";
                if (cmbDVQL.ValueMember != null)
                    values2 = ds.Tables[0].Rows[cmbDVQL.SelectedIndex][0].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void cmbDVTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDVTC.ValueMember != null)
            {
                values1 = cmbDVTC.SelectedValue.ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
           
            setnull();
            dt.moketnoi();
           

            

            // txtPhuongTienID.Text = ;
            //btThem.Enabled = false;
        }

        private void cmbDVQL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDVQL.ValueMember != null)
            {
                values2 = cmbDVQL.SelectedValue.ToString();
            }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

            //string sql2 = "select LoaiPTMa From LoaiPT";
            //SqlDataAdapter da2 = new SqlDataAdapter(sql2, dt.sqlConn);
            //DataSet ds2 = new DataSet();
            //da2.Fill(ds2, "LoaiPT");
            
           // string getLoaiPTMa = string.Empty;

            dt.moketnoi();
            string sql = @"set rowcount 1 select AutoNum from PhuongTien order by AutoNum Desc ";
            SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            DataSet ds = new DataSet();
            da.Fill(ds, "PhuongTien");
            int maximumNum = 0;
            try
            {
                maximumNum = Convert.ToInt32(ds.Tables["PhuongTien"].Rows[0][0].ToString());
            }
            catch { }

            txtPhuongTienID.Text = Convert.ToString(cmbLoaiPT.SelectedValue)+ (maximumNum + 1);
            dt.dongketnoi();

            

            if (this.txtBienDK.Text.Length == 0)
                MessageBox.Show("Trường Tên NV không được bỏ trống !");
            else
                if (this.txtXuaXu.Text.Length == 0)
                    MessageBox.Show("Trường Sdt Nhân Viên không được bỏ trống !");
                else
                    if (this.cmbDVTC.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                        if (this.cmbDVQL.Text.Length == 0)
                            MessageBox.Show("Trường Địa chỉ không được bỏ trống !");
                        else

                            if (this.txtTongVH.Text.Length == 0)
                                MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                            else
                                try
                                {
                                    int ngay =0 ;//Convert.ToInt32(this.dateEdit1.Text.Split('/')[0]);
                                    int thang =0; //Convert.ToInt32(this.dateEdit1.Text.Split('/')[1]);
                                    int nam = 0;// Convert.ToInt32(this.dateEdit1.Text.Split('/')[2]);
                                    string inputDate = (new DateTime(nam, thang, ngay)).ToString("dd/MM/yyyy");
                                    // PhuongTienID,  DonVIQLID, DonViTCID, BienDK, NgayVH , LanBDTX , LanTieuTu , LanTrungTu ,LanDaiTu, XuatXu, TongVH
                                    phuongtien.InsertPhuongTien(txtPhuongTienID.Text, cmbLoaiPT.SelectedValue.ToString(), cmbNguyenMau.SelectedValue.ToString(), cmbDVTC.SelectedValue.ToString(), cmbDVQL.SelectedValue.ToString(), txtBienDK.Text, inputDate, txtLanBDTX.Text, txtLanTieuTu.Text, txtLanTrungTu.Text, txtLanDaiTu.Text, txtXuaXu.Text, txtTongVH.Text);
                                   
                                    MessageBox.Show("Đã thêm " + txtPhuongTienID.Text + " thành công !");
                                    FrmPhuongTien_Load(sender, e);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Lỗi 11" + ex);
                                }


        }
        private void btSua_Click(object sender, EventArgs e)
        {

            if (this.txtBienDK.Text.Length == 0)
                MessageBox.Show("Trường Tên NV không được bỏ trống !");
            else
                if (this.txtXuaXu.Text.Length == 0)
                    MessageBox.Show("Trường Sdt Nhân Viên không được bỏ trống !");
                else
                    if (this.cmbDVTC.Text.Length == 0)
                        MessageBox.Show("Trường Email không được bỏ trống !");
                    else
                        if (this.cmbDVQL.Text.Length == 0)
                            MessageBox.Show("Trường Địa chỉ không được bỏ trống !");
                        else

                            if (this.txtTongVH.Text.Length == 0)
                                MessageBox.Show("Trường Chi tiết không được bỏ trống !");
                            else
            try
            {
                dt.moketnoi();
                phuongtien.UpdatePhuongTien(txtPhuongTienID.Text, cmbLoaiPT.SelectedValue.ToString(), cmbDVQL.SelectedValue.ToString(), cmbDVTC.SelectedValue.ToString(), txtBienDK.Text, dtpNgayVH.Text.Trim(), txtLanBDTX.Text, txtLanTieuTu.Text, txtLanTrungTu.Text, txtLanDaiTu.Text, txtXuaXu.Text, txtTongVH.Text);
              
                MessageBox.Show("Đã sửa  " + txtPhuongTienID.Text + " thành công !");
                FrmPhuongTien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi 12 :" +ex);
            }
           

        }
     //   private string NgayVH;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.txtPhuongTienID.Text = row.Cells[1].Value.ToString();
                this.cmbLoaiPT.Text = row.Cells[2].Value.ToString();
                //this.txtNhanHieu.Text = row.Cells[4].Value.ToString();
                //this.txtNangLuc.Text = row.Cells[5].Value.ToString();
                //this.txtDonVi.Text = row.Cells[6].Value.ToString();
                this.txtXuaXu.Text = row.Cells[9].Value.ToString();
                this.txtBienDK.Text = row.Cells[4].Value.ToString();
                this.txtLanBDTX.Text = row.Cells[13].Value.ToString();
                //this.txtLanBDTX.Text = row.Cells[6].Value.ToString();
                this.txtLanTrungTu.Text = row.Cells[15].Value.ToString();
                this.txtLanDaiTu.Text = row.Cells[16].Value.ToString();
                //this.txtNguyenMauChiTiet.Text = row.Cells[15].Value.ToString();
                this.cmbDVQL.Text = row.Cells[11].Value.ToString();
                this.cmbDVTC.Text = row.Cells[10].Value.ToString();
                this.txtTongVH.Text = row.Cells[12].Value.ToString();
                this.txtLanTieuTu.Text = row.Cells[14].Value.ToString();
                //this.dateEdit1.Text = Convert.ToDateTime(row.Cells[17].Value).ToString("mm/dd/yyyy");
               // this.dateEdit1.Text = Convert.ToDateTime(row.Cells[17].Value).ToString("dd/MM/yyyy");
                   // row.Cells[11].Value.ToString("dd/MM/yyyy");
               

                btSua.Enabled = true;

            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbLoaiPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiPT.ValueMember != null)
            {
                values3 = cmbLoaiPT.SelectedValue.ToString();
            }
            //try
            //{
            //    // string sql = @"Select * from SANPHAM where SANPHAM.MaLoaiSP = '" + values1 + "'";
            //    string sql = @"Select * from PhuongTien where PhuongTien.MaLoaiPT = '" + values3 + "'";
            //    dt.moketnoi();
            //    SqlDataAdapter da = new SqlDataAdapter(sql, dt.sqlConn);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds, "PhuongTien");
            //    DataTable dtb = ds.Tables["NguyenMauPT"];
            //    // cmbDVTC.SelectedIndex = -1;
            //    dt.dongketnoi();
            //    this.cmbNguyenMau.DataSource = dtb;
            //    this.cmbNguyenMau.DisplayMember = "NguyenMauTen";
            //    this.cmbNguyenMau.ValueMember = "NguyenMauID";
            //    cmbNguyenMau.Text = "";
            //    //if (cmbNguyenMau.ValueMember != null)
            //    //    values4 = ds.Tables[0].Rows[cmbNguyenMau.SelectedIndex][0].ToString();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi:" + ex);
            //}
        }

        private void cmbNguyenMau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNguyenMau.ValueMember != null)
            {
                values4 = cmbNguyenMau.SelectedValue.ToString();
            }

        }

        private void txtTongVH_Click(object sender, EventArgs e)
        {
            txtTongVH.Text = "";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (this.txtPhuongTienID.Text.Length == 0)
            {
                this.txtPhuongTienID.ForeColor = Color.Red;
                MessageBox.Show("Bạn cần chọn Mã Xe để xóa");
            }
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với Mã Xe " + txtPhuongTienID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    phuongtien.DeletePhuongTien(this.txtPhuongTienID.Text);
                    MessageBox.Show("Đã xóa Mã lớp " + this.txtPhuongTienID.Text + " thành công !");
                    FrmPhuongTien_Load(sender, e);//trở về giao diện đầu     
                }
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    NgayVH = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        //}
    }
}
