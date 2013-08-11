using System;
using System.Collections;
using System.Collections.Generic;
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
    public partial class frmPhanLop : Office2007Form
    {
        NamHocCtrl m_NamHocCuCtrl = new NamHocCtrl();
        NamHocCtrl m_NamHocMoiCtrl = new NamHocCtrl();
        KhoiLopCtrl m_KhoiLopCuCtrl = new KhoiLopCtrl();
        KhoiLopCtrl m_KhoiLopMoiCtrl = new KhoiLopCtrl();
        LopCtrl m_LopCuCtrl = new LopCtrl();
        LopCtrl m_LopMoiCtrl = new LopCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        HocKyData m_HocSinhData = new HocKyData();
        public frmPhanLop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            //m_NamHocCuCtrl.HienThiComboBox(cmbNamhoccu);
            //m_NamHocMoiCtrl.HienThiComboBox(cmbnamhocmoi);
            //m_KhoiLopCuCtrl.HienThiComboBox(cmbKhoilopcu);
        }

        private void btnChuyenlop_Click(object sender, EventArgs e)
        {

            IEnumerator ie = lvLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                //Trạng thái học sinh đã được chuyển lớp hay chưa?
                bool state = false;

                foreach (ListViewItem item in lvLopMoi.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBoxEx.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cmbLopmoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                DataTable dT = new DataTable();
                if (cmbnamhocmoi.SelectedValue != null && cmbKhoilopMoi.SelectedValue != null && cmbLopmoi.SelectedValue != null)
                {
                    dT = m_HocSinhCtrl.HienThiDsHocSinhTheoLop(cmbLopmoi.SelectedValue.ToString());
                   
                }

                foreach (DataRow row in dT.Rows)
                {
                    if (olditem.SubItems[0].Text.ToString() == row["MaHocSinh"].ToString())
                    {
                        MessageBoxEx.Show("Học sinh " + row["HoTen"].ToString() + " hiện đang học trong lớp " + row["TenLop"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;

                    }
                    
                }

                newitem.SubItems.Add(olditem.SubItems[1].Text);
                newitem.Tag = olditem.Tag;

                lvLopMoi.Items.Add(newitem);
                lvLopMoi.Items[lvLopMoi.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
                lvLopCu.Items.Remove(olditem);
               

            Cont:
                if (state == true)
                    break;
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lvLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lvLopMoi.Items.Remove(item);
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cmbNamhoccu.SelectedValue != null &&
                cmbKhoilopcu.SelectedValue != null &&
                cmbLopcu.SelectedValue != null &&
                cmbnamhocmoi.SelectedValue != null &&
                cmbKhoilopMoi.SelectedValue != null &&
                cmbLopmoi.SelectedValue != null)
            {
                m_HocSinhCtrl.XoaHSKhoiBangPhanLop(cmbNamhoccu.SelectedValue.ToString(),
                                   cmbKhoilopcu.SelectedValue.ToString(),
                                   cmbLopcu.SelectedValue.ToString(),
                                   lvLopMoi);
                m_HocSinhCtrl.LuuHSVaoBangPhanLop(cmbnamhocmoi.SelectedValue.ToString(),
                          cmbKhoilopMoi.SelectedValue.ToString(),
                          cmbLopmoi.SelectedValue.ToString(),
                          lvLopMoi);

                MessageBoxEx.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBoxEx.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //HTQuang begin 30/07/2013
        private void cmbNamhoccu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNamhoccu.SelectedValue != null)
            {
                m_NamHocMoiCtrl.HienThiComboBox(cmbNamhoccu.SelectedValue.ToString(), cmbnamhocmoi);
                //cmbKhoilopcu.DataBindings.Clear();
                //cmbLopcu.DataBindings.Clear();
                //HocSinhCtrl.TimTheoTen(lvLopCu, txtTimkiem.Text);
            }
        }
        //HTQuang end 30/07/2013

        private void cmbnamhocmoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoilopMoi.DataBindings.Clear();
            cmbLopmoi.DataBindings.Clear();
            if (cmbLopmoi.SelectedValue != null
                && cmbnamhocmoi.SelectedValue != null
                && cmbKhoilopMoi.SelectedValue != null)
            {
                HocSinhCtrl.HienThiDsHocSinhTheoLop(
                    cmbnamhocmoi.SelectedValue.ToString(),
                    cmbKhoilopMoi.SelectedValue.ToString(),
                    cmbLopmoi.SelectedValue.ToString(),
                    lvLopMoi);
            }
        }

        private void cmbKhoilopcu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null)
            {
                m_LopCuCtrl.HienThiComboBox(cmbKhoilopcu.SelectedValue.ToString(), cmbNamhoccu.SelectedValue.ToString(), cmbLopcu);
                m_KhoiLopMoiCtrl.HienThiComboBox(cmbKhoilopcu.SelectedValue.ToString(), cmbKhoilopMoi);
                cmbLopcu.DataBindings.Clear();
                lvLopCu.Items.Clear();
            }

        }

        private void cmbKhoilopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnamhocmoi.SelectedValue != null && cmbKhoilopMoi.SelectedValue != null)
            {
                m_LopMoiCtrl.HienThiComboBox(cmbKhoilopMoi.SelectedValue.ToString(), cmbnamhocmoi.SelectedValue.ToString(), cmbLopmoi);

                cmbLopmoi.DataBindings.Clear();
                lvLopMoi.Items.Clear();
            }
            if (cmbLopmoi.SelectedValue != null
                    && cmbnamhocmoi.SelectedValue != null
                    && cmbKhoilopMoi.SelectedValue != null)
            {
                HocSinhCtrl.HienThiDsHocSinhTheoLop(
                    cmbnamhocmoi.SelectedValue.ToString(),
                    cmbKhoilopMoi.SelectedValue.ToString(),
                    cmbLopmoi.SelectedValue.ToString(),
                    lvLopMoi);
            }
        }


        private void cmbLopmoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopmoi.SelectedValue != null
                && cmbnamhocmoi.SelectedValue != null
                && cmbKhoilopMoi.SelectedValue != null)
            {
                HocSinhCtrl.HienThiDsHocSinhTheoLop(
                    cmbnamhocmoi.SelectedValue.ToString(), 
                    cmbKhoilopMoi.SelectedValue.ToString(), 
                    cmbLopmoi.SelectedValue.ToString(), 
                    lvLopMoi);
            }
        }

        private void btnTimKiemTen_Click(object sender, EventArgs e)
        {
            {
                //if (txtTimkiem.Text == "")
                //    MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
//            HocSinhCtrl.TimTheoTen(lvLopCu, txtTimkiem.Text);
            if (cmbLopcu.SelectedValue != null && cmbNamhoccu.SelectedValue != null && cmbKhoilopcu.SelectedValue != null)
            {
                HocSinhCtrl.HienThiDsHocSinhTheoLop(cmbNamhoccu.SelectedValue.ToString(), cmbKhoilopcu.SelectedValue.ToString(), cmbLopcu.SelectedValue.ToString(), lvLopCu);
            }

        }



        private void btnTimKiemMa_Click(object sender, EventArgs e)
        {
            {
                //if (txtTimkiem.Text == "")
                //    MessageBoxEx.Show("Chưa nhập nội dung cần tìm kiếm vào khung!", "LỖI TÌM KIẾM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HocSinhCtrl.TimTheoMa(lvLopCu, txtTimkiem.Text);
            //m_HocSinhCtrl.HienThiDsHocSinhChuaPL(lvLopCu);
        }

        private void cmbNamhoccu_Click(object sender, EventArgs e)
        {
            m_NamHocCuCtrl.HienThiComboBox(cmbNamhoccu);

        }

        private void cmbKhoilopcu_Click(object sender, EventArgs e)
        {
            if (cmbNamhoccu.SelectedValue != null)
            {
                m_KhoiLopCuCtrl.HienThiComboBox(cmbKhoilopcu);
            }
        }

        private void cmbLopcu_Click(object sender, EventArgs e)
        {
            if (cmbLopmoi.SelectedValue != null
                    && cmbnamhocmoi.SelectedValue != null
                    && cmbKhoilopMoi.SelectedValue != null)
            {
                HocSinhCtrl.HienThiDsHocSinhTheoLop(
                    cmbnamhocmoi.SelectedValue.ToString(),
                    cmbKhoilopMoi.SelectedValue.ToString(),
                    cmbLopmoi.SelectedValue.ToString(),
                    lvLopMoi);
            }
        }

        private void btnChoPhanLop_Click(object sender, EventArgs e)
        {
            //m_HocSinhCtrl.HienThiDsHocSinhChuaPL(lvLopCu);
            HocSinhCtrl.HienThiDsHocSinhChuaPL(lvLopCu);
        }

    }
}