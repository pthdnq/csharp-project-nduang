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
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        TimKiemBUS m_TimKiemBUS = new TimKiemBUS();
        PhuongTienBUS m_PhuongTienBUS = new PhuongTienBUS();
        NguyenMauPTBUS m_NguyenMauPTBUS = new NguyenMauPTBUS();
        public void resetControl()
        {
            txtNhanHieu.Text = "";
            txtNangLuc.Text = "";

        }
        public void ShowComboxForLoaiPTCol()
        {
            try
            {
                //Loại PT
                this.cmbLoaiPT.DataSource = m_TimKiemBUS.selectLoaiPT();
                this.cmbLoaiPT.DisplayMember = "LoaiPTTen";
                this.cmbLoaiPT.ValueMember = "LoaiPTMa";
                cmbLoaiPT.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex);
            }
        }
        //private void timKiemNhanHieu()
        //{
        //    BindingSource bs = new BindingSource();
        //    bs.DataSource = dgvTimKiem.DataSource;
        //    //bs.Filter = dgvNhanVien.Columns["NhanVienTen"].HeaderText.ToString() + " LIKE '%" + txtTimKiem.Text + "%'";
        //    bs.Filter = "NhanHieu like '*" + txtNhanHieu.Text.Trim() + "*'";
        //    dgvTimKiem.DataSource = bs;
        //    dgvTimKiem.Refresh();
        //}
        //private void timKiemNangLuc()
        //{
        //    BindingSource bs = new BindingSource();
        //    bs.DataSource = dgvTimKiem.DataSource;
        //    bs.Filter = "NangLuc like '*" + txtNangLuc.Text.Trim() + "*'";
        //    dgvTimKiem.DataSource = bs;
        //    dgvTimKiem.Refresh();
        //}
        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            
          ShowComboxForLoaiPTCol();
          timKiemThongTinPT("", "", "100000");
        }

        private void txtNhanHieu_TextChanged(object sender, EventArgs e)
        {
            //timKiemNhanHieu();
        }

        private void txtNangLuc_TextChanged(object sender, EventArgs e)
        {
           // timKiemNangLuc();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            timKiemThongTinPT(
                cmbLoaiPT.SelectedValue.ToString()
                ,txtNhanHieu.Text.Trim()
                , txtNangLuc.Text.Trim()
                );
        }
         private void timKiemThongTinPT(string LoaiPTMa, string NhanHieu, string NangLuc)
         {
           if(cmbLoaiPT.SelectedValue != null)
           {
            try
            {
                DataTable dt = m_TimKiemBUS.timKiemFormMain(
                      LoaiPTMa
                    , NhanHieu
                    , NangLuc);
                dgvTimKiem.DataSource = dt;
                dgvTimKiem.Refresh();
            }
            catch (Exception ex)
            {
                
            }
                }
            else
            {
                MessageBox.Show("Chưa chọn Loại Phương tiện");
            }
        }

         private void btThoat_Click(object sender, EventArgs e)
         {

             if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
             {
                 this.Close();
             }
         }

         private void FrmTimKiem_FormClosing(object sender, FormClosingEventArgs e)
         {

         }
    }
}
