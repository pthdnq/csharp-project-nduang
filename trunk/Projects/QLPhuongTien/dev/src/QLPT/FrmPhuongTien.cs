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
    public partial class FrmPhuongTien : Form
    {
        public FrmPhuongTien()
        {
            InitializeComponent();
        }
     //   Data dt = new Data();
        Data dt = new Data();
        Utils utils = new Utils();
        PhuongTienBUS m_PhuongTienBUS = new PhuongTienBUS();
        public void resetControl()
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
        //public void HienthiGrv()
        //{
        //    string sql1 = "SELECT PhuongTien.PhuongTienID as [Mã PT],NguyenMauPT.NguyenMauID as [Mã Nguyên mẫu]  ,NguyenMauPT.NguyenMauTen as [Loại nguyên mẫu],  PhuongTien.BienDK as [Biển ĐK],NguyenMauPT.NguyenMauTen as [Loại PT] , NguyenMauPT.NhanHieu as [Nhãn hiệu] ,"+
        //        "NguyenMauPT.NangLuc as [Năng lực], NguyenMauPT.DonVi as [đơn vị] , PhuongTien.XuatXu as [Xuất xứ] , DonViTC.DonViTCTen [Đơn vị TC] , DonViQuanLy.DonViQLTen as [Đơn vị QL] ,"+
        //        "PhuongTien.TongVH as [Tổng vận hành] , PhuongTien.LanBDTX as [số lần BDTX],PhuongTien.LanTieuTu as [Số lần tiểu tu], PhuongTien.LanTrungTu as [Số lần Trung tu], "+
        //        "PhuongTien.LanDaiTu as [Số lần Đại tu],PhuongTien.NgayVH as [Ngày vận hành], NguyenMauPT.NguyenMauChiTiet as [Chi tiết] FROM PhuongTien " +
        //        "INNER JOIN DonViTC on DonViTC.DonVITCID = PhuongTien.DonViTCID " +
        //        "INNER JOIN DonViQuanLy on DonViQuanLy.DonViQLID = PhuongTien.DonViQLID " +
        //        "INNER JOIN NguyenMauPT on PhuongTien.NguyenMauID = NguyenMauPT.NguyenMauID ";
        //    //DataTable dtb = new DataTable();
        //    //dtb = dt.getTable(sql);
        //    //return dtb;
        //    dt.moketnoi();
        //    SqlCommand cmd = new SqlCommand(sql1);
        //    SqlDataAdapter da1 = new SqlDataAdapter(sql1, dt.sqlConn);
        //    DataSet ds1 = new DataSet();
        //    da1.Fill(ds1, "PhuongTien");
        //    dgvPhuongTien.DataSource = null;
        //    dgvPhuongTien.DataSource = ds1.Tables[0];
        //    dt.dongketnoi();
        //}
        public void ShowComboxForLoaiPTCol()
        {
            try
            {
                //Loại PT
                this.cmbLoaiPT.DataSource = m_PhuongTienBUS.selectLoaiPT();
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["LoaiPTMa"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectLoaiPT();
                comboBoxColumn.DisplayMember = "LoaiPTTen";
                comboBoxColumn.ValueMember = "LoaiPTMa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        public void ShowComboxForNguyenMauCol()
        {

            try
            {
                // Loại Nguyên Mẫu
                this.cmbNguyenMau.DataSource = m_PhuongTienBUS.selectPhuongTienData_LoaiPT();
                this.cmbNguyenMau.DisplayMember = "NguyenMauTen";
                this.cmbNguyenMau.ValueMember = "NguyenMauID";
                cmbNguyenMau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }  
        public void ShowComboxForDVTCCol()
        {
            try
            {
                //Đơn vị TC
                this.cmbDVTC.DataSource = m_PhuongTienBUS.selectDonViTC();
                this.cmbDVTC.DisplayMember = "DonViTCTen";
                this.cmbDVTC.ValueMember = "DonViTCID";
                cmbDVTC.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["DonViTCID"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectDonViTC();
                comboBoxColumn.DisplayMember = "DonViTCTen";
                comboBoxColumn.ValueMember = "DonViTCID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        public void ShowComboxForDVQLCol()
        {

            try
            {
                // Đơn VỊ QL
                this.cmbDVQL.DataSource = m_PhuongTienBUS.selectDonViQL();
                this.cmbDVQL.DisplayMember = "DonViQLTen";
                this.cmbDVQL.ValueMember = "DonVIQLID";
                cmbDVQL.Text = "";

                DataGridViewComboBoxColumn comboBoxColumn = (DataGridViewComboBoxColumn)dgvPhuongTien.Columns["DonVIQLID"];
                comboBoxColumn.DataSource = m_PhuongTienBUS.selectDonViQL();
                comboBoxColumn.DisplayMember = "DonViQLTen";
                comboBoxColumn.ValueMember = "DonVIQLID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        private void FrmPhuongTien_Load(object sender, EventArgs e)
        {
           // resetControl();
            DataTable dat = new DataTable();
            dat = m_PhuongTienBUS.select();
            dgvPhuongTien.DataSource = dat;

            ShowComboxForLoaiPTCol();

            ShowComboxForNguyenMauCol();
            ShowComboxForDVTCCol();
            ShowComboxForDVQLCol();     
        }

        public bool validData()
        {
             if (this.txtAutoNum.Text.Length == 0)
            {
                MessageBox.Show("Trường AutoNum không được bỏ trống !");
                return false;
            }
             if (this.txtPhuongTienID.Text.Length == 0)
             {
                 MessageBox.Show("Trường Mã PT không được bỏ trống !");
                 return false;
             }
            if (this.cmbLoaiPT.Text.Length == 0)
            {
                MessageBox.Show("Trường Loại PT không được bỏ trống !");
                return false;
            }
            else if (this.cmbNguyenMau.Text.Length == 0)
            {
                MessageBox.Show("Trường Loại Nguyên mẫu không được bỏ trống !");
                return false;
            }
            else if (this.txtBienDK.Text.Length == 0)
            {
                MessageBox.Show("Trường Biển ĐK không được bỏ trống !");
                return false;
            }
            else if (this.txtXuaXu.Text.Length == 0)
            {
                MessageBox.Show("Trường Xuất xứ không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVTC.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị TC không được bỏ trống !");
                return false;
            }
            else if (this.cmbDVQL.Text.Length == 0)
            {
                MessageBox.Show("Trường Đơn vị QL không được bỏ trống !");
                return false;
            }
            else if (this.dtpNgayVH.Text.Length == 0)
            {
                MessageBox.Show("Trường Ngày VH không được bỏ trống !");
                return false;
            }
            return true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

      

        private void btThem_Click(object sender, EventArgs e)
        {
            resetControl();
            dt.moketnoi();
            txtTongVH.Text = "0";
            txtLanBDTX.Text = "0";
            txtLanTieuTu.Text = "0";
            txtLanTrungTu.Text = "0";
            txtLanDaiTu.Text = "0";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            txtPhuongTienID.Text = generatePhuongTien();

            bool Ok = validData();
            if (Ok == false)
            {
                return;
            }
            try
            {
            m_PhuongTienBUS.insert( 
           txtAutoNum.Text ,
           cmbLoaiPT.SelectedValue.ToString(),
           txtPhuongTienID.Text,
           cmbNguyenMau.SelectedValue.ToString(),
           cmbDVQL.SelectedValue.ToString(),
           cmbDVTC.SelectedValue.ToString(),
           txtBienDK.Text,
           dtpNgayVH.Text,
           txtLanBDTX.Text,
           txtLanTieuTu.Text,
           txtLanTrungTu.Text,
           txtLanDaiTu.Text,
           txtXuaXu.Text,
           txtTongVH.Text
          
                      );


                FrmPhuongTien_Load(sender, e);

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
                m_PhuongTienBUS.update(
               txtAutoNum.Text,
               cmbLoaiPT.SelectedValue.ToString(),
               txtPhuongTienID.Text,
               cmbNguyenMau.SelectedValue.ToString(),
               cmbDVQL.SelectedValue.ToString(),
               cmbDVTC.SelectedValue.ToString(),
               txtBienDK.Text,
               dtpNgayVH.Text,
               txtLanBDTX.Text,
               txtLanTieuTu.Text,
               txtLanTrungTu.Text,
               txtLanDaiTu.Text,
               txtXuaXu.Text,
               txtTongVH.Text
                          );
                FrmPhuongTien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa :" + ex);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPhuongTien.SelectedRows)
            {
               
                cmbLoaiPT.SelectedValue = row.Cells["LoaiPTMa"].Value.ToString();
                cmbDVQL.SelectedValue = row.Cells["DonVIQLID"].Value.ToString();
                cmbDVTC.SelectedValue = row.Cells["DonViTCID"].Value.ToString();
                cmbNguyenMau.SelectedValue = row.Cells["NguyenMauID"].Value.ToString();

                txtAutoNum.Text = row.Cells["AutoNum"].Value.ToString();
                txtPhuongTienID.Text = row.Cells["PhuongTienID"].Value.ToString();
                txtXuaXu.Text = row.Cells["XuatXu"].Value.ToString();
                txtBienDK.Text = row.Cells["BienDK"].Value.ToString();
                txtLanBDTX.Text = row.Cells["LanBDTX"].Value.ToString();
                txtLanTrungTu.Text = row.Cells["LanTrungTu"].Value.ToString();
                txtLanDaiTu.Text = row.Cells["LanDaiTu"].Value.ToString();
                txtTongVH.Text = row.Cells["TongVH"].Value.ToString();
                txtLanTieuTu.Text = row.Cells["LanTieuTu"].Value.ToString();
                
                btSua.Enabled = true;

            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvPhuongTien.RowCount; i++)
            {
                dgvPhuongTien.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa Mã DV : " + txtPhuongTienID.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                m_PhuongTienBUS.delete1(txtPhuongTienID.Text);
                FrmPhuongTien_Load(sender, e);//trở về giao diện đầu     
            }
        }
        private string generatePhuongTien()
        {
            int IDMax = utils.getMaxIDAuto("PhuongTien", "AutoNum");
            IDMax++; 
            string strIDMax = utils.convertIntToFormatedString(IDMax);
            txtAutoNum.Text = strIDMax;
            return cmbLoaiPT.SelectedValue.ToString() + strIDMax;
        }
    }
}
