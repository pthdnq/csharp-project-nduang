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
        FrmDangNhap frmdn = new FrmDangNhap();
        FrmDangKy frmdk = new FrmDangKy();
        FrmDoiMatKhau frmdmk = new FrmDoiMatKhau();
        FrmPhuongTien phuongtien = new FrmPhuongTien();
        FrmVanHanh vanhanh = new FrmVanHanh();
        FrmBaoCaoVanHanh baoCaoVH = new FrmBaoCaoVanHanh();
        frmDonVi_QL DVQL = new frmDonVi_QL();
        FrmHelp help = new FrmHelp();
        FrmAboutUs thongtinct = new FrmAboutUs();
        FrmBaoCaoNhanVien baoCaoNhanVien = new FrmBaoCaoNhanVien();
        FrmBaoCaoThongTinPT baocaoInfoPT = new FrmBaoCaoThongTinPT();
        FrmDonVi_TC dvtc = new FrmDonVi_TC();
        FrmLoaiPT loaipt = new FrmLoaiPT();
        FrmNhanVien nv = new FrmNhanVien();
        FrmNguyenMau_PT nmpt = new FrmNguyenMau_PT();
        FrmTimKiem timkiem = new FrmTimKiem();
        private static string QUYEN_QUAN_LY = "quanly";
        private static string QUYEN_NHAN_VIEN= "nhanvien";
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
            
           // frmdn.ShowDiaLog();
           // frmdn.lbStatus.Text = "";
            //frmdn.resetControl();
            frmdn.txtUser.Text = "";
            frmdn.txtPass.Text = "";
            frmdn.ShowDialog();
            if(frmdn.m_isLogin == true)
            {
                unlockControl();
                if(frmdn.m_PhanQuyen == QUYEN_QUAN_LY)
                {
                    quyenQuanLy();
                }
                else if(frmdn.m_PhanQuyen == QUYEN_NHAN_VIEN)
                {
                    quyenNhanVien();
                }
                //else if(dk)
                //{
                    //TODO
                //}
                else
                {
                    MessageBox.Show("Tài khoải chưa đượcc cấp quyền truy cập");
                    lockControl();
                }

            }
            else
            {
                lockControl();
            }

        }
        private void quyenQuanLy()
        {
            
            nv.btThem.Enabled = true;
            nv.btSua.Enabled = true;

            dvtc.btThem.Visible = true;
            dvtc.btSua.Visible = true;
            dvtc.btXoa.Visible = true;
            dvtc.btLuu.Visible = true;
            mnDangKy.Enabled = true;
            mnPhuongTien.Enabled = true;
            mnDonViQuanLy.Enabled = true;
            mnQuanLyVanhHanh.Enabled = true;
            mnDanhSachNhanVien.Enabled = true;
            mnBaoCaoVanHanh.Enabled = true;
            mnQuanLyNhanVien.Enabled = true;
        }
        private void quyenNhanVien()
        {       
            dvtc.btThem.Visible = false;
            dvtc.btSua.Visible = false;
            dvtc.btXoa.Visible = false;
            dvtc.btLuu.Visible = false;
            mnDangKy.Enabled = false;
            mnPhuongTien.Enabled = false;
            mnDonViQuanLy.Enabled = false;
            mnQuanLyVanhHanh.Enabled = false;
            mnDanhSachNhanVien.Enabled = true;
            mnBaoCaoVanHanh.Enabled = true;
            mnQuanLyNhanVien.Enabled = false;
            
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdk == null || frmdk.IsDisposed)
            {
                frmdk = new FrmDangKy();
            }
            frmdk.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdmk == null || frmdmk.IsDisposed)
            {
                frmdmk = new FrmDoiMatKhau();
            }
            frmdmk.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void nguyênMẫuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (phuongtien == null || phuongtien.IsDisposed)
            {
                phuongtien = new FrmPhuongTien();
            }
            phuongtien.Show();

        }

        private void quảnLýĐơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DVQL == null || DVQL.IsDisposed)
            {
                DVQL = new frmDonVi_QL();
            }
            DVQL.Show();
        }

        //private void hạngMụcCôngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmNhienLieu nhlieu = new FrmNhienLieu();
        //    nhlieu.Show();
        //}

        private void loạiPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaipt == null || loaipt.IsDisposed)
            {
                loaipt = new FrmLoaiPT();
            }
            loaipt.Show();
        }

        private void đơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvtc == null || dvtc.IsDisposed)
            {
                dvtc = new FrmDonVi_TC();
            }
            dvtc.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nv == null || nv.IsDisposed)
            {
                nv = new FrmNhanVien();
            }
            nv.Show();
        }

        private void danhSáchCácPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nmpt == null || nmpt.IsDisposed)
            {
                nmpt = new FrmNguyenMau_PT();
            }
            nmpt.Show();
        }

        private void tìmKiếmPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timkiem == null || timkiem.IsDisposed)
            {
                timkiem = new FrmTimKiem();
            }
            
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
            if (vanhanh == null || vanhanh.IsDisposed)
            {
                vanhanh = new FrmVanHanh();
            }
            vanhanh.Show();
        }

       

        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            thongtinct.Show();
            
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            help.Show();


        }

        private void tìnhTrạngBảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baocaoInfoPT == null || baocaoInfoPT.IsDisposed)
            {
                baocaoInfoPT = new FrmBaoCaoThongTinPT();
            }
            baocaoInfoPT.Show();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baoCaoNhanVien == null || baoCaoNhanVien.IsDisposed)
            {
                baoCaoNhanVien = new FrmBaoCaoNhanVien();
            }
            baoCaoNhanVien.Show();
        }

        private void báoCáoVậnHànhPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baoCaoVH == null || baoCaoVH.IsDisposed)
            {
                baoCaoVH = new FrmBaoCaoVanHanh();
            }
            baoCaoVH.Show();
        }
    }
}
