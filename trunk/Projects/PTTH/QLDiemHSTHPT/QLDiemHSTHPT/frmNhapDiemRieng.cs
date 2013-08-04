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
using QLDiemHSTHPT.Bussiness;
namespace QLDiemHSTHPT
{
    public partial class frmNhapDiemRieng : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        QuyDinh quyDinh = new QuyDinh();
        public frmNhapDiemRieng()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhapDiemRieng_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cbmnamhoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocky);
            m_LoaiDiemCtrl.HienThiComboBox(cmbloaidiem);
            if (cbmnamhoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop);
            if (cbmnamhoc.SelectedValue != null && cmblop.SelectedValue != null)
            {
                m_MonHocCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop.SelectedValue.ToString(), cmbMonhoc);
                m_HocSinhCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop.SelectedValue.ToString(), cmbHocsinh);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lvdiem.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lvdiem.Items.Remove(item);
                }
            }
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            int numberOfRow = lvdiem.Items.Count;
            for (int i = 0; i < numberOfRow; i++)
            {
                ListViewItem item = lvdiem.Items[i];
                DiemInfo diem = new DiemInfo();
                diem = (DiemInfo)item.Tag;
                m_DiemCtrl.LuuDiem(diem.HocSinh.MaHocSinh, diem.MonHoc.MaMonHoc, diem.HocKy.MaHocKy, diem.NamHoc.MaNamHoc, diem.Lop.MaLop, diem.LoaiDiem.MaLoaiDiem, diem.Diem);
            }
            lvdiem.Items.Clear();

            MessageBoxEx.Show("Đã lưu vào bảng điểm!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            if (quyDinh.KiemTraDiem(txtdiem.Text) == false || txtdiem.Text == "")
            {
                MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem item = new ListViewItem();

                item.Text = cmbHocsinh.SelectedValue.ToString();
                item.SubItems.Add(cmbHocsinh.Text);
                item.SubItems.Add(cmbHocky.Text);
                item.SubItems.Add(cmbMonhoc.Text);
                item.SubItems.Add(cmbloaidiem.Text);
                item.SubItems.Add(txtdiem.Text);

                DiemInfo diem = new DiemInfo();
                diem.HocSinh.MaHocSinh = cmbHocsinh.SelectedValue.ToString();
                diem.MonHoc.MaMonHoc = cmbMonhoc.SelectedValue.ToString();
                diem.HocKy.MaHocKy = cmbHocky.SelectedValue.ToString();
                diem.NamHoc.MaNamHoc = cbmnamhoc.SelectedValue.ToString();
                diem.Lop.MaLop = cmblop.SelectedValue.ToString();
                diem.LoaiDiem.MaLoaiDiem = cmbloaidiem.SelectedValue.ToString();
                diem.Diem = Convert.ToSingle(txtdiem.Text);

                item.Tag = diem;
                lvdiem.Items.Add(item);
            }
        }

       
        
        private void txtdiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quyDinh.KiemTraDiem(txtdiem.Text) == false || txtdiem.Text == "")
                {
                    MessageBoxEx.Show("Giá trị điểm không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ListViewItem item = new ListViewItem();

                    item.Text = cmbHocsinh.SelectedValue.ToString();
                    item.SubItems.Add(cmbHocsinh.Text);
                    item.SubItems.Add(cmbHocky.Text);
                    item.SubItems.Add(cmbMonhoc.Text);
                    item.SubItems.Add(cmbloaidiem.Text);
                    item.SubItems.Add(txtdiem.Text);

                    DiemInfo diem = new DiemInfo();
                    diem.HocSinh.MaHocSinh = cmbHocsinh.SelectedValue.ToString();
                    diem.MonHoc.MaMonHoc = cmbMonhoc.SelectedValue.ToString();
                    diem.HocKy.MaHocKy = cmbHocky.SelectedValue.ToString();
                    diem.NamHoc.MaNamHoc = cbmnamhoc.SelectedValue.ToString();
                    diem.Lop.MaLop = cmblop.SelectedValue.ToString();
                    diem.LoaiDiem.MaLoaiDiem = cmbloaidiem.SelectedValue.ToString();
                    diem.Diem = Convert.ToSingle(txtdiem.Text);
                    item.Tag = diem;
                    lvdiem.Items.Add(item);
                }
            }
        }

        private void txtdiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbloaidiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        frmXemDiem m_XD = null;
        private void btnXemdiem_Click(object sender, EventArgs e)
        {
            
            if (m_XD == null || m_XD.IsDisposed)
            {
                m_XD = new frmXemDiem();
                m_XD.MdiParent = frmMain.ActiveForm;
                m_XD.Show();
            }
            else m_XD.Activate();
        }
    }
}