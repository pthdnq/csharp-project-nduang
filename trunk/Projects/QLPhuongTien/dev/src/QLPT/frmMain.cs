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
        FrmDanhSachPTTheoDonVi dspttheodv = new FrmDanhSachPTTheoDonVi();
        FrmXoaTaiKhoan xoataikhoan = new FrmXoaTaiKhoan();
        private static string QUYEN_QUAN_LY_CHUNG = "quanlychung";
        private static string QUYEN_NHAN_VIEN= "nhanvien";
        private static string QUYEN_QUAN_LY_PT = "quanlyPT";
        private static string QUYEN_QUAN_LY_VH = "quanlyVH";
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
                this.lbStatus.ForeColor = Color.Green;
                lbStatus.Text = "Tài khoản đang đăng nhập: " + frmdn.txtUser.Text + " - quyền: " + frmdn.m_PhanQuyen;
                if(frmdn.m_PhanQuyen == QUYEN_QUAN_LY_CHUNG)
                {
                    quyenQuanLyChung();
                }
                else if(frmdn.m_PhanQuyen == QUYEN_NHAN_VIEN)
                {
                    quyenNhanVien();
                }
                else if(frmdn.m_PhanQuyen == QUYEN_QUAN_LY_PT)
                {
                    quyenQuanLyPT();
                }
                else if(frmdn.m_PhanQuyen == QUYEN_QUAN_LY_VH)
                {
                    quyenQuanLyVH();
                }
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
        private void quyenQuanLyPT()
        {
            mnDangKy.Enabled = false;

            mnPhuongTien.Enabled = true;
            mnDonViQuanLy.Enabled = true;
            mnQuanLyVanhHanh.Enabled = false;
            mnDanhSachNhanVien.Enabled = true;

            DVQL.btLuu.Visible = false;
            DVQL.btSua.Visible = false;
            DVQL.btXoa.Visible = false;

            mnBaoCaoVanHanh.Enabled = false;
            mnQuanLyNhanVien.Enabled = false;
            mnDVTC.Enabled = false;
            mnXoaTaiKhoan.Enabled = false;
        }
        private void quyenQuanLyVH()
        {
            mnDangKy.Enabled = false;

            mnPhuongTien.Enabled = false;
            mnDonViQuanLy.Enabled = false;
            mnQuanLyVanhHanh.Enabled = true;
            mnDanhSachNhanVien.Enabled = true;

            dvtc.btLuu.Visible = false;
            dvtc.btSua.Visible = false;
            dvtc.btXoa.Visible = false;

            mnBaoCaoVanHanh.Enabled = true;
            mnQuanLyNhanVien.Enabled = false;
            mnDVTC.Enabled = true;
            mnXoaTaiKhoan.Enabled = false;
        }
        private void quyenQuanLyChung()
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
            mnXoaTaiKhoan.Enabled = true;

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
            mnBaoCaoVanHanh.Enabled = false;
            mnBaoCaoPT.Enabled = false;
            mnXoaTaiKhoan.Enabled = false;
            
        }
        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdk == null || frmdk.IsDisposed)
            {
                frmdk = new FrmDangKy();
            }
            frmdk.ShowDialog();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmdmk == null || frmdmk.IsDisposed)
            {
                frmdmk = new FrmDoiMatKhau();
            }
            frmdmk.ShowDialog();
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
            phuongtien.ShowDialog();

        }

        private void quảnLýĐơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DVQL == null || DVQL.IsDisposed)
            {
                DVQL = new frmDonVi_QL();
            }
            DVQL.ShowDialog();
        }

        //private void hạngMụcCôngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    FrmNhienLieu nhlieu = new FrmNhienLieu();
        //    nhlieu.ShowDialog();
        //}

        private void loạiPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaipt == null || loaipt.IsDisposed)
            {
                loaipt = new FrmLoaiPT();
            }
            loaipt.ShowDialog();
        }

        private void đơnVịThiCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvtc == null || dvtc.IsDisposed)
            {
                dvtc = new FrmDonVi_TC();
            }
            dvtc.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nv == null || nv.IsDisposed)
            {
                nv = new FrmNhanVien();
            }
            nv.ShowDialog();
        }

        private void danhSáchCácPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nmpt == null || nmpt.IsDisposed)
            {
                nmpt = new FrmNguyenMau_PT();
            }
            nmpt.ShowDialog();
        }

        private void tìmKiếmPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timkiem == null || timkiem.IsDisposed)
            {
                timkiem = new FrmTimKiem();
            }
            
            timkiem.ShowDialog();
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
            mnXoaTaiKhoan.Enabled = false;

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
            vanhanh.ShowDialog();
        }

       

        private void thôngTinChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            thongtinct.ShowDialog();
            
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            help.ShowDialog();


        }

        private void tìnhTrạngBảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baocaoInfoPT == null || baocaoInfoPT.IsDisposed)
            {
                baocaoInfoPT = new FrmBaoCaoThongTinPT();
            }
            baocaoInfoPT.ShowDialog();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baoCaoNhanVien == null || baoCaoNhanVien.IsDisposed)
            {
                baoCaoNhanVien = new FrmBaoCaoNhanVien();
            }
            baoCaoNhanVien.ShowDialog();
        }

        private void báoCáoVậnHànhPhươngTiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (baoCaoVH == null || baoCaoVH.IsDisposed)
            {
                baoCaoVH = new FrmBaoCaoVanHanh();
            }
            baoCaoVH.ShowDialog();
        }

        private void tìmKiếmTheoĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dspttheodv == null || dspttheodv.IsDisposed)
            {
                dspttheodv = new FrmDanhSachPTTheoDonVi();
            }
            dspttheodv.ShowDialog();
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xoataikhoan == null || xoataikhoan.IsDisposed)
            {
                xoataikhoan = new FrmXoaTaiKhoan();
            }
            xoataikhoan.ShowDialog();
        }
    }
}
