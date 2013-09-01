using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.DataLayer;

namespace QLDiemHSTHPT
{
    public partial class frmXemDiem : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        public frmXemDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lvdiem.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    int stt = Convert.ToInt32(item.SubItems[0].Text);
                    m_DiemCtrl.XoaDiem(stt);
                    lvdiem.Items.Remove(item);
                }
            }
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setEnableControl(bool status)
        {
            btnxoa.Enabled = status;

        }
    }
}