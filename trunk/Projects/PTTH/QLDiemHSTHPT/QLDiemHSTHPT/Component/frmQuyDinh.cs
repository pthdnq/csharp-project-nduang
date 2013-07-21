using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;



namespace QLDiemHSTHPT.Component
{
    public partial class frmQuyDinh : Office2007Form
    {
        QuyDinhCtrl m_QuyDinhCtrl = new QuyDinhCtrl();
        public frmQuyDinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            m_QuyDinhCtrl.HienThi(itiSStoithieu, itiSStoida, itiDoTuoiCanDuoi, itiDoTuoiCanTren, checkTD10, checkTD100);
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.CanSelect)
            {
                if (itiSStoithieu.Value <= 10 || itiSStoida.Value >= 60)
                    MessageBoxEx.Show("Sỉ số phải nằm trong khoảng giới hạn 10 - 60!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhSiSo(itiSStoithieu.Value, itiSStoida.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về sỉ số!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSStoithieu, itiSStoida, itiDoTuoiCanDuoi, itiDoTuoiCanTren, checkTD10, checkTD100);
                }
            }
            else if (tabControlPanelDoTuoi.CanSelect)
            {
                if (itiDoTuoiCanDuoi.Value <= 10 || itiDoTuoiCanTren.Value >= 50)
                    MessageBoxEx.Show("Độ tuổi phải nằm trong khoảng giới hạn 10 - 50!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhDoTuoi(itiDoTuoiCanDuoi.Value, itiDoTuoiCanTren.Value);
                    MessageBoxEx.Show("Cập nhật thành công quy định về độ tuổi!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // m_QuyDinhCtrl.HienThi(itiSStoithieu, itiSStoida, itiDoTuoiCanDuoi, itiDoTuoiCanTren, checkTD10, checkTD100);
                }
            }

            else if (tabControlPanelThangdiem.CanSelect)
            {
                if (checkTD10.Checked == true)
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(10);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSStoithieu, itiSStoida, itiDoTuoiCanDuoi, itiDoTuoiCanTren, checkTD10, checkTD100);
                }
                else
                {
                    m_QuyDinhCtrl.CapNhatQuyDinhThangDiem(100);
                    MessageBoxEx.Show("Cập nhật thành công quy định về thang điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_QuyDinhCtrl.HienThi(itiSStoithieu, itiSStoida, itiDoTuoiCanDuoi, itiDoTuoiCanTren, checkTD10, checkTD100);
                }
            }
        }
        public void setCurrentTab(TabItem tabItem)
        {
            this.tabControl1.SelectedTab = tabItem;
        }
    }
}
