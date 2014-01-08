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
           // frmdn.ShowDiaLog();
            frmdn.ShowDialog();
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
            FrmPhuongTien phuongtien = new FrmPhuongTien();
            phuongtien.Show();

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
            FrmNguyenMau_PT nmpt = new FrmNguyenMau_PT();
            nmpt.Show();
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
            mnDangNhap.Enabled = true;

        }
        public void unlockControl()
        {
            mnBaoTri.Enabled = true;
            mnQuanLy.Enabled = true;
            mnTimKiem.Enabled = true;
            mnDangKy.Enabled = true;
            mnDangXuat.Enabled = true;
            mnDoiMatKhau.Enabled = true;

            mnDangNhap.Enabled = false;
        }

        private void mnDangXuat_Click(object sender, EventArgs e)
        {
            lockControl();
        }

        private void quảnLýVậnHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVanHanh vanhanh = new FrmVanHanh();
            vanhanh.Show();
        }

       

        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutUs thongtinct = new FrmAboutUs();
            thongtinct.Show();
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp help = new FrmHelp();
            help.Show();


        }

        private void tìnhTrạngBảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoThongTinPT baocaoInfoPT = new FrmBaoCaoThongTinPT();
            baocaoInfoPT.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoNhanVien baoCaoNhanVien = new FrmBaoCaoNhanVien();
            baoCaoNhanVien.Show();
        }

        private void báoCáoVậnHànhPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCaoVanHanh baoCaoVH = new FrmBaoCaoVanHanh();
            baoCaoVH.Show();
        }
    }
}
