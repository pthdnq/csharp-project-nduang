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

        public frmMain()
        {
            InitializeComponent();
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            if (DataService.OpenConnection())
            {
                //MacDinh();
                //DangNhap();
                //this.Cursor = Thaydoichuot.Create(System.IO.Path.Combine(Application.StartupPath, "harrow.cur"));
                        frmDictionary m_Dictionary = null;
                        if (m_Dictionary == null || m_Dictionary.IsDisposed)
                        {
                            m_Dictionary = new frmDictionary();
                            m_Dictionary.MdiParent = frmDictionary.ActiveForm;
                            m_Dictionary.Show();
                        }
                        else
                            m_Dictionary.Activate();

            }
            else
            {
                MessageBoxEx.Show("Kết nối dữ liệu thất bại!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void btnthoatkhoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }          

        private void buttondangxuat_Click(object sender, EventArgs e)
        {
            lblND.Text = "Không có người đăng nhập";
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

        private void buttonItem33_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            if (m_HocSinh == null || m_HocSinh.IsDisposed)
            {
                m_HocSinh = new frmSetting();
                m_HocSinh.MdiParent = frmMain.ActiveForm;
                m_HocSinh.MaximizeBox = false;
                m_HocSinh.Show();
            }
            else m_HocSinh.Activate();
        }



        frmSetting m_HocSinh = null;
        private void toolStripMenuItem56_Click(object sender, EventArgs e)
        {
            if (m_HocSinh == null || m_HocSinh.IsDisposed)
            {
                m_HocSinh = new frmSetting();
                m_HocSinh.MdiParent = frmMain.ActiveForm;
                m_HocSinh.Show();
            }
            else m_HocSinh.Activate();
        }
        private void buttonHocSinh_Click(object sender, EventArgs e)
        {
            if (m_HocSinh == null || m_HocSinh.IsDisposed)
            {
                m_HocSinh = new frmSetting();
                m_HocSinh.MdiParent = frmMain.ActiveForm;
                m_HocSinh.Show();
            }
            else
                m_HocSinh.Activate();
        }
        frmDictionary m_PhanLop = null;
        private void buttonPLop_Click(object sender, EventArgs e)
        {
            if (m_PhanLop == null || m_PhanLop.IsDisposed)
            {
                m_PhanLop = new frmDictionary();
                m_PhanLop.MdiParent = frmDictionary.ActiveForm;
                m_PhanLop.Show();
            }
            else
                m_PhanLop.Activate();
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

        private void toolStripMenuItem84_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "QuanLy.chm", " ");
        }

        frmSetting m_Setting = null;
        private void toolStripMenuItem63_Click(object sender, EventArgs e)
        {
            if (m_Setting == null || m_Setting.IsDisposed)
            {
                m_Setting = new frmSetting();
                m_Setting.MdiParent = frmSetting.ActiveForm;
                m_Setting.Show();
            }
            else m_Setting.Activate();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {

        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}