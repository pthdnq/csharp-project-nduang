using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.Show();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangKy frmdk = new FrmDangKy();
            frmdk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau frmdmk = new FrmDoiMatKhau();
            frmdmk.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void nguyênMẫuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguyenMau_PT nmpt = new FrmNguyenMau_PT();
            nmpt.Show();

        }

        private void quảnLýĐơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonVi_QL DVQL = new FrmDonVi_QL();
            DVQL.Show();
        }

        //private void hạngMụcCôngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmNhienLieu nhlieu = new FrmNhienLieu();
        //    nhlieu.Show();
        //}

        private void loạiPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoaiPT loaipt = new FrmLoaiPT();
            loaipt.Show();
        }

        private void đơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDonVi_TC dvtc = new FrmDonVi_TC();
            dvtc.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.Show();
        }

        private void danhSáchCácPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhuongTien phuongtien = new FrmPhuongTien();
            phuongtien.Show();
        }

        private void tìmKiếmPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem timkiem = new FrmTimKiem();
            timkiem.Show();
        }
    }
}
