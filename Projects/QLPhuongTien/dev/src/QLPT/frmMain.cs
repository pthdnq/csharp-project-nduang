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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lockControl();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmdn = new FrmDangNhap();
            frmdn.Show();
            if(frmdn.m_isLogin == true)
            {
                unlockControl();
            }
            else
            {
                lockControl();
            }

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
            frmDonVi_QL DVQL = new frmDonVi_QL();
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
        public void lockControl()
        {
            mnBaoTri.Enabled = false;
            mnQuanLy.Enabled = false;
            mnTimKiem.Enabled = false;
            mnDangKy.Enabled = false;
            mnDangXuat.Enabled = false;
            mnDoiMatKhau.Enabled = false;

        }
        public void unlockControl()
        {
            mnBaoTri.Enabled = true;
            mnQuanLy.Enabled = true;
            mnTimKiem.Enabled = true;
            mnDangKy.Enabled = true;
            mnDangXuat.Enabled = true;
            mnDoiMatKhau.Enabled = true;

        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            lockControl();
        }
    }
}
