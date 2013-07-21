using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.Controller;

namespace QLDiemHSTHPT
{
    public partial class frmMain : Office2007Form
    {
        NguoiDungCtrl m_NguoiDungCtrl = new NguoiDungCtrl();
        frmTonGiao m_TonGiao = null;
        frmDanToc m_DanToc = null;
        frmConnection m_Connection = null;
        frmHanhKiem m_HanhKiem = null;
        frmHocLuc m_HocLuc = null;
        frmHocKy m_HocKy = null;
        frmKetQua m_KetQua = null;
        frmKhoiLop m_KhoiLop = null;
        frmNamHoc m_NamHoc = null;
        frmNgheNghiep m_NgheNghiep = null;
        frmMonHoc m_MonHoc = null;
        frmNguoiDung m_NguoiDung = null;
        frmDangNhap m_FormDangNhap = null;
        frmDoiMatKhau m_FormDoiMatKhau = null;

        public frmMain()
        {
            InitializeComponent();
           // frmFlash f = new frmFlash();
           // f.Show();
           // System.Threading.Thread.Sleep(2000);
            //f.Close();
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            if (DataService.OpenConnection())
            {
                MacDinh();
                DangNhap();
                //this.Cursor = Thaydoichuot.Create(System.IO.Path.Combine(Application.StartupPath, "harrow.cur"));

            }
            else
            {
                MacDinh();
                ReConnection();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReConnection()
        {
            MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBoxEx.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                return;
        }
         private void btnthoatkhoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

              

        private void bntdantoc_Click_1(object sender, EventArgs e)
        {
            if (m_DanToc == null || m_DanToc.IsDisposed)
            {
                m_DanToc = new frmDanToc();
                m_DanToc.MdiParent = frmMain.ActiveForm;
                m_DanToc.Show();
            }
            else m_DanToc.Activate();
        }

       

        private void dânTộcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_DanToc == null || m_DanToc.IsDisposed)
            {
                m_DanToc = new frmDanToc();
                m_DanToc.MdiParent = frmMain.ActiveForm;
                m_DanToc.Show();
            }
            else m_DanToc.Activate();
        }

        private void tônGiáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_TonGiao == null || m_TonGiao.IsDisposed)
            {
                m_TonGiao = new frmTonGiao();
                m_TonGiao.MdiParent = frmMain.ActiveForm;
                m_TonGiao.Show();
            }
            else m_TonGiao.Activate();
        }

        private void hạnhKiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_HanhKiem == null || m_HanhKiem.IsDisposed)
            {
                m_HanhKiem = new frmHanhKiem();
                m_HanhKiem.MdiParent = frmMain.ActiveForm;
                m_HanhKiem.Show();
            }
            else m_HanhKiem.Activate();
        }

        private void họcLựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_HocLuc == null || m_HocLuc.IsDisposed)
            {
                m_HocLuc = new frmHocLuc();
                m_HocLuc.MdiParent = frmMain.ActiveForm;
                m_HocLuc.Show();
            }
            else m_HocLuc.Activate();
        }

        private void họcKỳToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_HocKy == null || m_HocKy.IsDisposed)
            {
                m_HocKy = new frmHocKy();
                m_HocKy.MdiParent = frmMain.ActiveForm;
                m_HocKy.Show();
            }
            else m_HocKy.Activate();
        }

        private void kếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_KetQua == null || m_KetQua.IsDisposed)
            {
                m_KetQua = new frmKetQua();
                m_KetQua.MdiParent = frmMain.ActiveForm;
                m_KetQua.Show();
            }
            else m_KetQua.Activate();
        }

        /*private void btnnamhoc_Click(object sender, EventArgs e)
        {
            if (m_NamHoc == null || m_NamHoc.IsDisposed)
            {
                m_NamHoc = new frmNamHoc();
                m_NamHoc.MdiParent = frmMain.ActiveForm;
                m_NamHoc.Show();
            }
            else m_NamHoc.Activate();
        }

        private void btnhocky_Click(object sender, EventArgs e)
        {
            if (m_HocKy == null || m_HocKy.IsDisposed)
            {
                m_HocKy = new frmHocKy();
                m_HocKy.MdiParent = frmMain.ActiveForm;
                m_HocKy.Show();
            }
            else m_HocKy.Activate();
        }*/

        private void khốiLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_KhoiLop == null || m_KhoiLop.IsDisposed)
            {
                m_KhoiLop = new frmKhoiLop();
                m_KhoiLop.MdiParent = frmMain.ActiveForm;
                m_KhoiLop.Show();
            }
            else m_KhoiLop.Activate();
        }

        private void nămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_NamHoc == null || m_NamHoc.IsDisposed)
            {
                m_NamHoc = new frmNamHoc();
                m_NamHoc.MdiParent = frmMain.ActiveForm;
                m_NamHoc.Show();
            }
            else m_NamHoc.Activate();
        }

        private void nghềNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_NgheNghiep == null || m_NgheNghiep.IsDisposed)
            {
                m_NgheNghiep = new frmNgheNghiep();
                m_NgheNghiep.MdiParent = frmMain.ActiveForm;
                m_NgheNghiep.Show();
            }
            else m_NgheNghiep.Activate();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_MonHoc == null || m_MonHoc.IsDisposed)
            {
                m_MonHoc = new frmMonHoc();
                m_MonHoc.MdiParent = frmMain.ActiveForm;
                m_MonHoc.Show();
            }
            else m_MonHoc.Activate();
        }
        frmLoaiNguoiDung lnd = null;
        private void btnTTPM_Click(object sender, EventArgs e)
        {
            if (lnd == null || lnd.IsDisposed)
            {
                lnd = new frmLoaiNguoiDung();
                lnd.MdiParent = frmMain.ActiveForm;
                lnd.Show();
            }
            else lnd.Activate();
        }

       

        public void DangNhap()
        {
        Cont:
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();

            if (m_FormDangNhap.ShowDialog() == DialogResult.OK)
            {
                if (m_FormDangNhap.txtdangnhap.Text == "")
                {
                    m_FormDangNhap.lblMatKhauLoi.Text = "";
                    m_FormDangNhap.lblDangNhapLoi.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FormDangNhap.txtmatkhau.Text == "")
                {
                    m_FormDangNhap.lblDangNhapLoi.Text = "";
                    m_FormDangNhap.lblMatKhauLoi.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }

                int ketQua = m_NguoiDungCtrl.DangNhap(m_FormDangNhap.txtdangnhap.Text, m_FormDangNhap.txtmatkhau.Text);

                switch (ketQua)
                {
                    case 0:
                        m_FormDangNhap.lblMatKhauLoi.Text = "";
                        m_FormDangNhap.lblDangNhapLoi.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FormDangNhap.lblDangNhapLoi.Text = "";
                        m_FormDangNhap.lblMatKhauLoi.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        lblND.Text = Utilities.NguoiDung.TenND;
                        Permissions(Utilities.NguoiDung.LoaiND.MaLoaiND);
                        break;
                }
            }
            else
                return;
        }
       
        
        public void DoiMatKhau()
        {
        Cont:
            if (m_FormDoiMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FormDoiMatKhau.txtMKcu.Text == "")
                {
                    m_FormDoiMatKhau.lblMKculoi.Text = "Chưa nhập mật khẩu hiện tại!";
                    m_FormDoiMatKhau.lblMKmoiloi.Text = "";
                    m_FormDoiMatKhau.lblxacnhanMKloi.Text = "";
                    goto Cont;
                }

                if (m_FormDoiMatKhau.txtmatkhaumoi.Text == "")
                {
                    m_FormDoiMatKhau.lblMKculoi.Text = "";
                    m_FormDoiMatKhau.lblMKmoiloi.Text = "Chưa nhập mật khẩu mới!";
                    m_FormDoiMatKhau.lblxacnhanMKloi.Text = "";
                    goto Cont;
                }

                if (m_FormDoiMatKhau.txtxacnhan.Text == "")
                {
                    m_FormDoiMatKhau.lblMKculoi.Text = "";
                    m_FormDoiMatKhau.lblMKmoiloi.Text = "";
                    m_FormDoiMatKhau.lblxacnhanMKloi.Text = "Chưa nhập xác nhận mật khẩu!";
                    goto Cont;
                }

                String m_TenDN = m_FormDangNhap.txtdangnhap.Text;
                String m_MatKhau = m_FormDangNhap.txtmatkhau.Text;

                String m_MatKhauCu = m_FormDoiMatKhau.txtMKcu.Text;
                String m_MatKhauMoi = m_FormDoiMatKhau.txtmatkhaumoi.Text;
                String m_XacNhanMK = m_FormDoiMatKhau.txtxacnhan.Text;

                if (m_MatKhau!= m_MatKhauCu)
                {
                    m_FormDoiMatKhau.lblMKculoi.Text = "Nhập sai mật khẩu cũ!";
                    m_FormDoiMatKhau.lblMKmoiloi.Text = "";
                    m_FormDoiMatKhau.lblxacnhanMKloi.Text = "";
                    goto Cont;
                }
                else if (m_MatKhauMoi != m_XacNhanMK)
                {
                    m_FormDoiMatKhau.lblMKculoi.Text = "";
                    m_FormDoiMatKhau.lblMKmoiloi.Text = "";
                    m_FormDoiMatKhau.lblxacnhanMKloi.Text = "Nhập xác nhận không khớp!";
                    goto Cont;
                }
                else
                {
                    m_NguoiDungCtrl.DoiMatKhau(m_TenDN, m_MatKhauMoi);
                    MessageBoxEx.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                return;
        }


        private void buttondangnhap_Click(object sender, EventArgs e)
        {
            if (m_FormDangNhap == null || m_FormDangNhap.IsDisposed)
                m_FormDangNhap = new frmDangNhap();

            m_FormDangNhap.txtdangnhap.Text = "";
            m_FormDangNhap.txtmatkhau.Text = "";
            m_FormDangNhap.lblDangNhapLoi.Text = "";
            m_FormDangNhap.lblMatKhauLoi.Text = "";

            DangNhap();
        }

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            lblND.Text = "Không có người đăng nhập";
            MacDinh();
            Form[] chill = this.MdiChildren;
            foreach (Form frm in chill)
            {
                if (frm != null) frm.Close();
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonItem30_Click(object sender, EventArgs e)
        {
            if (m_NguoiDung == null || m_NguoiDung.IsDisposed)
            {
                m_NguoiDung = new frmNguoiDung();
                m_NguoiDung.MdiParent = frmMain.ActiveForm;
                m_NguoiDung.Show();
            }
            else m_NguoiDung.Activate();
        }

        private void buttonItem31_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + Utilities.DatabaseName + " TO DISK = '" + backupDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void buttonItem32_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("USE master RESTORE DATABASE " + Utilities.DatabaseName + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'");
                DataService data = new DataService();
                data.Load(cmd);
                MessageBoxEx.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {

        }

        frmGiaoVien m_GiaoVien = null;
        private void toolStripMenuItem61_Click(object sender, EventArgs e)
        {
            if (m_GiaoVien == null || m_GiaoVien.IsDisposed)
            {
                m_GiaoVien = new frmGiaoVien();
                m_GiaoVien.MdiParent = frmMain.ActiveForm;
                m_GiaoVien.Show();
            }
            else m_GiaoVien.Activate();
        }

        frmLop m_Lop = null;
        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {
            if (m_Lop == null || m_Lop.IsDisposed)
            {
                m_Lop = new frmLop();
                m_Lop.MdiParent = frmMain.ActiveForm;
                m_Lop.Show();
            }
            else m_Lop.Activate();
        }

        frmQuyDinh m_QuyDinh = null;
        private void toolStripMenuItem78_Click(object sender, EventArgs e)
        {
            if (m_QuyDinh == null || m_QuyDinh.IsDisposed)
            {
                m_QuyDinh = new frmQuyDinh();
                m_QuyDinh.MdiParent = frmMain.ActiveForm;
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabDotuoi);
                m_QuyDinh.Show();

            }
            else
            {
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabDotuoi);
                m_QuyDinh.Activate();
            }
        }
        private void toolStripMenuItem79_Click(object sender, EventArgs e)
        {
            if (m_QuyDinh == null || m_QuyDinh.IsDisposed)
            {
                m_QuyDinh = new frmQuyDinh();
                m_QuyDinh.MdiParent = frmMain.ActiveForm;
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabthangdiem);
                m_QuyDinh.Show();

            }
            else
            {
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabthangdiem);
                m_QuyDinh.Activate();
            }
        }

        private void toolStripMenuItem80_Click(object sender, EventArgs e)
        {
            if (m_QuyDinh == null || m_QuyDinh.IsDisposed)
            {
                m_QuyDinh = new frmQuyDinh();
                m_QuyDinh.MdiParent = frmMain.ActiveForm;
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabSiSo);
                m_QuyDinh.Show();
                //m_QuyDinh.tabDotuoi
                //m_QuyDinh.tabDotuoi.Name.
                //m_QuyDinh.Focus();
                //m_QuyDinh.tabDotuoi.IsSelected = true;

            }
            else
            {
                m_QuyDinh.setCurrentTab(m_QuyDinh.tabSiSo);
                m_QuyDinh.Activate();
            }
        }
        frmHocSinh m_HocSinh = null;
        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {
            if (m_HocSinh == null || m_HocSinh.IsDisposed)
            {
                m_HocSinh = new frmHocSinh();
                m_HocSinh.MdiParent = frmMain.ActiveForm;
                m_HocSinh.Show();
            }
            else m_HocSinh.Activate();
        }
        private void buttonHocSinh_Click(object sender, EventArgs e)
        {
            if (m_HocSinh == null || m_HocSinh.IsDisposed)
            {
                m_HocSinh = new frmHocSinh();
                m_HocSinh.MdiParent = frmMain.ActiveForm;
                m_HocSinh.Show();
            }
            else
                m_HocSinh.Activate();
        }
        private void buttonGV_Click(object sender, EventArgs e)
        {
            if (m_GiaoVien == null || m_GiaoVien.IsDisposed)
            {
                m_GiaoVien = new frmGiaoVien();
                m_GiaoVien.MdiParent = frmMain.ActiveForm;
                m_GiaoVien.Show();
            }
            else
                m_GiaoVien.Activate();
        }

        frmPhanCong m_PhanCong = null;
        private void buttonPCong_Click(object sender, EventArgs e)
        {
            if (m_PhanCong == null || m_PhanCong.IsDisposed)
            {
                m_PhanCong = new frmPhanCong();
                m_PhanCong.MdiParent = frmPhanCong.ActiveForm;
                m_PhanCong.Show();
            }
            else
                m_PhanCong.Activate();
        }
        /*private void toolStripMenuItem62_Click(object sender, EventArgs e)
        {
            if (m_PhanCong == null || m_PhanCong.IsDisposed)
            {
                m_PhanCong = new frmPhanCong();
                m_PhanCong.MdiParent = frmMain.ActiveForm;
                m_PhanCong.Show();
            }
            else m_PhanCong.Activate();
        }*/

        public void Permissions(String m_Per)
        {
            switch (m_Per)
            {
                case "LND001": BGH(); break;
                case "LND002": GiaoVien(); break;
                case "LND003": GiaoVu(); break;
                default: MacDinh(); break;
            }
        }
        //giao dien mac dinh
        public void MacDinh()
        {
            buttondangnhap.Enabled = true;
            buttonthoat.Enabled = true;
            buttonItem33.Enabled = true;
            toolStripMenuItem84.Enabled = true;
            toolStripMenuItem83.Enabled = true;
           


            buttondangxuat.Enabled = false;
            buttonItem29.Enabled = false;
            buttonItem30.Enabled = false;
            buttonItem31.Enabled = false;
            buttonItem32.Enabled = false;

            buttonHocSinh.Enabled = false;
            buttonGV.Enabled = false;
            buttonPCong.Enabled = false;
            buttonPLop.Enabled = false;
            buttonTCHS.Enabled = false;
            buttonTCGV.Enabled = false;
            toolStripMenuItem46.Enabled = false;
            toolStripMenuItem63.Enabled = false;
            toolStripMenuItem77.Enabled = false;
        }

        public void BGH()
        {
            //False
            buttondangnhap.Enabled = false;
            //True
            buttondangxuat.Enabled = true;
            buttonItem29.Enabled = true;
            buttonthoat.Enabled = true;
            buttonItem33.Enabled = true;
            buttonItem30.Enabled = true;
            buttonItem31.Enabled = true;
            buttonItem32.Enabled = true;
            
            buttonHocSinh.Enabled = true;
            buttonGV.Enabled = true;
            buttonPCong.Enabled = true;
            buttonPLop.Enabled = true;
            buttonTCHS.Enabled = true;
            buttonTCGV.Enabled = true;
            toolStripMenuItem46.Enabled = true;
            toolStripMenuItem63.Enabled = true;
            toolStripMenuItem77.Enabled = true;
        }

        public void GiaoVien()
        {
            ////True
            buttondangxuat.Enabled = true;
            buttonItem29.Enabled = true;
            buttonthoat.Enabled = true;
            buttonItem33.Enabled = true;
          
            toolStripMenuItem52.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem63.Enabled = true;
            toolStripMenuItem81.Enabled = true;
            buttonTCHS.Enabled = true;
            buttonTCGV.Enabled = true;

            //False
            buttondangnhap.Enabled = false;
            buttonItem30.Enabled = true;
            buttonItem31.Enabled = true;
            buttonItem32.Enabled = true;
            buttonHocSinh.Enabled = false;
            buttonGV.Enabled = false;
            buttonPCong.Enabled = false;
            buttonPLop.Enabled = false;
            toolStripMenuItem47.Enabled = false;
            toolStripMenuItem48.Enabled = false;
            toolStripMenuItem49.Enabled = false;
            toolStripMenuItem50.Enabled = false;
            toolStripMenuItem51.Enabled = false;
            toolStripMenuItem53.Enabled = false;
            toolStripMenuItem54.Enabled = false;
            toolStripMenuItem55.Enabled = false;
            toolStripMenuItem58.Enabled = false;
            toolStripMenuItem59.Enabled = false;
            toolStripMenuItem60.Enabled = false;
            toolStripMenuItem77.Enabled = false;
        }

        public void GiaoVu()
        {
            ////True
            buttondangxuat.Enabled = true;
            buttonthoat.Enabled = true;
            buttonItem33.Enabled = true;
        

            toolStripMenuItem47.Enabled = true;
            toolStripMenuItem48.Enabled = true;
            toolStripMenuItem49.Enabled = true;
            toolStripMenuItem50.Enabled = true;
            toolStripMenuItem1.Enabled = true;
            toolStripMenuItem53.Enabled = true;
            toolStripMenuItem54.Enabled = true;
            toolStripMenuItem55.Enabled = true;
            toolStripMenuItem58.Enabled = true;
            toolStripMenuItem59.Enabled = true;
            toolStripMenuItem60.Enabled = true;
            toolStripMenuItem63.Enabled = true;
            toolStripMenuItem81.Enabled = true;
            toolStripMenuItem46.Enabled = true;

            //False
            buttondangnhap.Enabled = false;
            buttonItem30.Enabled = false;
            buttonItem31.Enabled = false;
            buttonItem32.Enabled = false;
            buttonGV.Enabled = false;
            buttonPCong.Enabled = false;
           
        }
        frmPhanLop m_PhanLop = null;
        private void buttonPLop_Click(object sender, EventArgs e)
        {
            if (m_PhanLop == null || m_PhanLop.IsDisposed)
            {
                m_PhanLop = new frmPhanLop();
                m_PhanLop.MdiParent = frmPhanLop.ActiveForm;
                m_PhanLop.Show();
            }
            else
                m_PhanLop.Activate();
        }
        /*private void toolStripMenuItem57_Click(object sender, EventArgs e)
        {
            if (m_PhanLop == null || m_PhanLop.IsDisposed)
            {
                m_PhanLop = new frmPhanLop();
                m_PhanLop.MdiParent = frmMain.ActiveForm;
                m_PhanLop.Show();
            }
            else m_PhanLop.Activate();
        }*/

        frmNhapDiemRieng m_Rieng = null;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (m_Rieng == null || m_Rieng.IsDisposed)
            {
                m_Rieng = new frmNhapDiemRieng();
                m_Rieng.MdiParent = frmMain.ActiveForm;
                m_Rieng.Show();
            }
            else m_Rieng.Activate();
        }

        frmTimKiemGV TKGV = null;
        private void buttonTCGV_Click(object sender, EventArgs e)
        {
            if (TKGV == null || TKGV.IsDisposed)
            {
                TKGV = new frmTimKiemGV();
                TKGV.MdiParent = frmMain.ActiveForm;
                TKGV.Show();
            }
            else
                TKGV.Activate();
        }
        frmTimKiemHS TKHS = null;
        private void buttonTCHS_Click(object sender, EventArgs e)
        {
            if (TKHS == null || TKHS.IsDisposed)
            {
                TKHS = new frmTimKiemHS();
                TKHS.MdiParent = frmMain.ActiveForm;
                TKHS.Show();
            }
            else
                TKHS.Activate();
        }
        frmNhapDiemChung m_DiemChung = null;
        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {
            if (m_DiemChung == null || m_DiemChung.IsDisposed)
            {
                m_DiemChung = new frmNhapDiemChung();
                m_DiemChung.MdiParent = frmMain.ActiveForm;
                m_DiemChung.Show();
            }
            else m_DiemChung.Activate();
        }
        frmAbout m_TTPM = null;
        private void toolStripMenuItem83_Click(object sender, EventArgs e)
        {
            if (m_TTPM == null || m_TTPM.IsDisposed)
            {
                m_TTPM = new frmAbout();
                m_TTPM.MdiParent = frmMain.ActiveForm;
                m_TTPM.Show();
            }
            else m_TTPM.Activate();
        }

        frptDanhSachGiaoVien m_DSGV = null;
        private void toolStripMenuItem71_Click(object sender, EventArgs e)
        {
            if (m_DSGV == null || m_DSGV.IsDisposed)
            {
                m_DSGV = new frptDanhSachGiaoVien();
                m_DSGV.MdiParent = frmMain.ActiveForm;
                m_DSGV.Show();
            }
            else m_DSGV.Activate();
        }

        frptDanhSachHocSinh m_DSHS = null;
        private void toolStripMenuItem72_Click(object sender, EventArgs e)
        {
            if (m_DSHS == null || m_DSHS.IsDisposed)
            {
                m_DSHS = new frptDanhSachHocSinh();
                m_DSHS.MdiParent = frmMain.ActiveForm;
                m_DSHS.Show();
            }
            else m_DSHS.Activate();
        }

        frptDanhSachLop m_DSLop = null;
        private void toolStripMenuItem73_Click(object sender, EventArgs e)
        {
            if (m_DSLop == null || m_DSLop.IsDisposed)
            {
                m_DSLop = new frptDanhSachLop();
                m_DSLop.MdiParent = frmMain.ActiveForm;
                m_DSLop.Show();
            }
            else m_DSLop.Activate();
        }

        frptKetQuaHocKy_MonHoc m_KQHKMH = null;
        private void toolStripMenuItem65_Click(object sender, EventArgs e)
        {
            if (m_KQHKMH == null || m_KQHKMH.IsDisposed)
            {
                m_KQHKMH = new frptKetQuaHocKy_MonHoc();
                m_KQHKMH.MdiParent = frmMain.ActiveForm;
                m_KQHKMH.Show();
            }
            else m_KQHKMH.Activate();
        }

        frptKetQuaCaNam_MonHoc m_KQCNMH = null;
        private void toolStripMenuItem68_Click(object sender, EventArgs e)
        {
            if (m_KQCNMH== null || m_KQCNMH.IsDisposed)
            {
                m_KQCNMH = new frptKetQuaCaNam_MonHoc();
                m_KQCNMH.MdiParent = frmMain.ActiveForm;
                m_KQCNMH.Show();
            }
            else m_KQCNMH.Activate();
        }

        frptKetQuaHocKy_TongHop m_KQHKLop = null;
        private void toolStripMenuItem66_Click(object sender, EventArgs e)
        {
            if (m_KQHKLop == null || m_KQHKLop.IsDisposed)
            {
                m_KQHKLop = new frptKetQuaHocKy_TongHop();
                m_KQHKLop.MdiParent = frmMain.ActiveForm;
                m_KQHKLop.Show();
            }
            else
                m_KQHKLop.Activate();
        }
        frptKetQuaCaNam_TongHop m_KQCNLop = null;
        private void toolStripMenuItem69_Click(object sender, EventArgs e)
        {
            if (m_KQCNLop == null || m_KQCNLop.IsDisposed)
            {
                m_KQCNLop = new frptKetQuaCaNam_TongHop();
                m_KQCNLop.MdiParent = frmMain.ActiveForm;
                m_KQCNLop.Show();
            }
            else
                m_KQCNLop.Activate();
        }

        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QuanLy.chm", " ");
        }

        frmConnection m_KN = null;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (m_KN == null || m_KN.IsDisposed)
            {
                m_KN = new frmConnection();
                m_KN.MdiParent = frmMain.ActiveForm;
                m_KN.Show();
            }
            else m_KN.Activate();
        }
    }
}