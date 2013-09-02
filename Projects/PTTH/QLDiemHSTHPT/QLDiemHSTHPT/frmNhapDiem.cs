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
using QLDiemHSTHPT.DataLayer;

namespace QLDiemHSTHPT
{
    public partial class frmNhapDiem : Office2007Form
    {
        NamHocCtrl m_NamHocCtrl = new NamHocCtrl();
        LopCtrl m_LopCtrl = new LopCtrl();
        HocKyCtrl m_HocKyCtrl = new HocKyCtrl();
        MonHocCtrl m_MonHocCtrl = new MonHocCtrl();
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        LoaiDiemCtrl m_LoaiDiemCtrl = new LoaiDiemCtrl();
        HocSinhCtrl m_HocSinhCtrl = new HocSinhCtrl();
        KQHKMonHocCtrl m_KQHocKyMonHocCtrl = new KQHKMonHocCtrl();
        KQHKTongHopCtrl m_KQHocKyTongHopCtrl = new KQHKTongHopCtrl();
        KQCNMonHocCtrl m_KQCaNamMonHocCtrl = new KQCNMonHocCtrl();
        KQCNTongHopCtrl m_KQCaNamTongHopCtrl = new KQCNTongHopCtrl();
        PhanCongCtrl m_PhanCongCtrl = new PhanCongCtrl();
        //MonHocCtrl m_MonHocCtrl = new MonHocCtrl();

        DiemData m_DiemData = new DiemData();
        QuyDinh quyDinh = new QuyDinh();
        int[,] STT = null;
        public frmNhapDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhapDiemChung_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNanhocCN);
            m_HocKyCtrl.HienThiComboBox(cmbHockyCN);
            if (cmbNanhocCN.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNanhocCN.SelectedValue.ToString(), cmbLopCN);
            m_MonHocCtrl.HienThiComboBox(cmbMonhocCN);
            String strLoaiTaiKhoan = Utilities.NguoiDung.LoaiND.MaLoaiND.Trim();
            //tai khoan hoc sinh thi an nut luu diem
            if (strLoaiTaiKhoan == "LND004")
            {
                bngluu.Visible = false;
            }
        }

        //kiem tra diem truoc khi luu
        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dgvNhapdiemchung.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String chuoiDiemChuaXuLy = row.Cells[loaiDiem].Value.ToString();
                    String diemDaXuLy = null;

                    int count = 0;
                    for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                    {
                        if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                            count++;
                        else
                        {
                            if (i == chuoiDiemChuaXuLy.Length - 1)
                            {
                                i++;
                                count++;
                            }

                            diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                            if (count != 0 && quyDinh.KiemTraDiem(diemDaXuLy) == false)
                            {
                                MessageBoxEx.Show("Điểm của học sinh " + row.Cells["HoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }

                            diemDaXuLy = null;
                            count = 0;
                        }
                    }
                }
            }
            return true;
        }


        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDSDiemChung();
            }
            catch (Exception)
            {
            }
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                HienThiDSDiemChung();
            }
            catch (Exception)
            { 
            }
        }
        private void HienThiDSDiemChung()
        {
            updateSTT_Diem();
            if (cmbNanhocCN.SelectedValue != null && cmbLopCN.SelectedValue != null && cmbHockyCN.SelectedValue != null && cmbMonhocCN.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dgvNhapdiemchung, bdgNhapdiemchung, cmbNanhocCN.SelectedValue.ToString(), cmbLopCN.SelectedValue.ToString(),txtMaHS_Or_hoTenHS.Text.Trim());

            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dgvNhapdiemchung.Rows)
            {
                countRowHocSinh++;

                String[] diemMieng = new String[20];
                String[] diem15Phut = new String[20];
                String[] diem1tiet = new String[20];
                String diemThi = "";
                String diemTL = "";


                int soDiemMieng = 0;
                int soDiem15Phut = 0;
                int soDiem1tiet = 0;

                DataTable m_DT = m_DiemData.LayDsDiemHocSinh(rowHocSinh.Cells["MaHocSinh"].Value.ToString(),
                                                      cmbMonhocCN.SelectedValue.ToString(),
                                                      cmbHockyCN.SelectedValue.ToString(),
                                                      cmbNanhocCN.SelectedValue.ToString(),
                                                      cmbLopCN.SelectedValue.ToString());

                int countRowDiem = 0;
                foreach (DataRow rowDiem in m_DT.Rows)
                {
                    countRowDiem++;

                    //STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());

                    if (rowDiem["MaLoaiDiem"].ToString() == "LD0001")
                        diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoaiDiem"].ToString() == "LD0002")
                        diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoaiDiem"].ToString() == "LD0003")
                        diem1tiet[soDiem1tiet++] = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoaiDiem"].ToString() == "LD0004")
                        diemThi = rowDiem["Diem"].ToString();

                    else if (rowDiem["MaLoaiDiem"].ToString() == "LD0005")
                        diemTL = rowDiem["Diem"].ToString();
                    //DTBHKMonHoc = float.Parse(rowDiem["DTBMonHocKy"].ToString());
                }

                rowHocSinh.Cells["DiemMieng"].Value = quyDinh.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["Diem15phut"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["Diem1tiet"].Value = quyDinh.ArrayToString(diem1tiet, soDiem1tiet);
                rowHocSinh.Cells["DiemThi"].Value = diemThi;
                rowHocSinh.Cells["DiemThiLai"].Value = diemTL;
                float tongDiemHeSo1 = 0;
                float tongDiemHeSo2 = 0;
                int soDiemHeSo1 = soDiemMieng + soDiem15Phut;
                int soDiemHeSo2 = soDiem1tiet;
                try
                {
                    for (int i = 0; i < soDiemMieng; i++)
                    {
                       // if (diemMieng[i] != null)
                            tongDiemHeSo1 += Convert.ToSingle(diemMieng[i].ToString().Trim());
                    }
                    for (int i = 0; i < soDiem15Phut; i++)
                    {
                        //if (diem15Phut[i] != null)
                            tongDiemHeSo1 += Convert.ToSingle(diem15Phut[i].ToString().Trim());
                    }
                    for (int i = 0; i < soDiem1tiet; i++)
                    {
                        if (diem1tiet[i] != null)
                            tongDiemHeSo2 += Convert.ToSingle(diem1tiet[i].ToString().Trim());
                    }
                    //DiemCtrl m_DiemCtrl = new DiemCtrl();
                    //String maHocSinh = rowHocSinh.Cells["MaHocSinh"].Value.ToString();
                    if (diemThi != "")
                    {
                        float diemTBMonHK = (float)Math.Round((tongDiemHeSo1 + 2 * tongDiemHeSo2 + 3 * Convert.ToSingle(diemThi)) / (soDiemHeSo1 + 2 * soDiemHeSo2 + 3),2);
                        rowHocSinh.Cells["DTBHKMonHoc"].Value = diemTBMonHK.ToString();
                    }
                }
                catch (Exception)
                { 
                }
            }
            STT = null;
        }
        private void updateSTT_Diem()
        {
            STT = new int[60, 200];
            dgvNhapdiemchung.EndEdit();
            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dgvNhapdiemchung.Rows)
            {
                countRowHocSinh++;
                DataTable m_DT = m_DiemData.LayDsDiemHocSinh(rowHocSinh.Cells["MaHocSinh"].Value.ToString(),
                                                      cmbMonhocCN.SelectedValue.ToString(),
                                                      cmbHockyCN.SelectedValue.ToString(),
                                                      cmbNanhocCN.SelectedValue.ToString(),
                                                      cmbLopCN.SelectedValue.ToString());

                int countRowDiem = 0;
                foreach (DataRow rowDiem in m_DT.Rows)
                {
                    countRowDiem++;

                    STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());
                }
            }
        }
        private void bngluu_Click_1(object sender, EventArgs e)
        {
            String strTenDangNhap = Utilities.NguoiDung.TenDangNhap.Trim();
            String strMaLop = cmbLopCN.SelectedValue.ToString().Trim();
            String strTenLop = cmbLopCN.Text.Trim();
            String strMaMonHoc = cmbMonhocCN.SelectedValue.ToString().Trim();
            String strTenMonHoc = cmbMonhocCN.Text.Trim();
            String strMaKhoaHoc = cmbNanhocCN.SelectedValue.ToString().Trim();
            bool OK = m_PhanCongCtrl.isDuocPhepSuaDiem(strTenDangNhap,
                                            strMaLop,
                                            strMaMonHoc,
                                            strMaKhoaHoc
                                            );
            //if (OK == false)
            //{
            //    MessageBoxEx.Show(@"Bạn không được phân công dạy lớp "
            //                        + strTenLop +
            //                        " môn " + strTenMonHoc +
            //                        " nên không có quyền cập nhật điểm"
            //        );
            //    //thoat khoi ham
            //    return;
            //}
            updateSTT_Diem();
            if (KiemTraDiemTruocKhiLuu("DiemMieng") == true &&
               KiemTraDiemTruocKhiLuu("Diem15phut") == true &&
               KiemTraDiemTruocKhiLuu("Diem1tiet") == true &&
               KiemTraDiemTruocKhiLuu("DiemThi") == true &&
               KiemTraDiemTruocKhiLuu("DiemThiLai") == true)
            {
                //Chỉnh sửa diểm
                if (btnCNdiem.Checked == true || STT != null)
                {
                    int rowcount = 0;
                    foreach (DataGridViewRow row in dgvNhapdiemchung.Rows)
                    {
                        rowcount++;

                        //kiem tra diem mieng
                        if (row.Cells["DiemMieng"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["DiemMieng"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["MaHocSinh"].Value.ToString(),
                                                           cmbMonhocCN.SelectedValue.ToString(),
                                                           cmbHockyCN.SelectedValue.ToString(),
                                                           cmbNanhocCN.SelectedValue.ToString(),
                                                           cmbLopCN.SelectedValue.ToString(),
                                                           "LD0001",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }

                        //Kiểm tra 15 phút
                        if (row.Cells["Diem15phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["Diem15phut"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["MaHocSinh"].Value.ToString(),
                                                           cmbMonhocCN.SelectedValue.ToString(),
                                                           cmbHockyCN.SelectedValue.ToString(),
                                                           cmbNanhocCN.SelectedValue.ToString(),
                                                           cmbLopCN.SelectedValue.ToString(),
                                                           "LD0002",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }

                        if (row.Cells["Diem1tiet"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["Diem1tiet"].Value.ToString();
                            String diemDaXuLy = null;

                            int count = 0;
                            for (int i = 0; i < chuoiDiemChuaXuLy.Length; i++)
                            {
                                if (chuoiDiemChuaXuLy[i] != ';' && i != chuoiDiemChuaXuLy.Length - 1)
                                    count++;
                                else
                                {
                                    if (i == chuoiDiemChuaXuLy.Length - 1)
                                    {
                                        i++;
                                        count++;
                                    }

                                    diemDaXuLy = chuoiDiemChuaXuLy.Substring(i - count, count);

                                    if (diemDaXuLy != null && diemDaXuLy != " " && quyDinh.KiemTraDiem(diemDaXuLy))
                                        m_DiemCtrl.LuuDiem(row.Cells["MaHocSinh"].Value.ToString(),
                                                           cmbMonhocCN.SelectedValue.ToString(),
                                                           cmbHockyCN.SelectedValue.ToString(),
                                                           cmbNanhocCN.SelectedValue.ToString(),
                                                           cmbLopCN.SelectedValue.ToString(),
                                                           "LD0003",
                                                           float.Parse(diemDaXuLy.ToString()));

                                    diemDaXuLy = null;
                                    count = 0;
                                }
                            }
                        }
                        //Thi học kỳ
                        if (row.Cells["DiemThi"].Value != null)
                        {
                            String diemThi = row.Cells["DiemThi"].Value.ToString();
                            if (quyDinh.KiemTraDiem(diemThi))
                                m_DiemCtrl.LuuDiem(row.Cells["MaHocSinh"].Value.ToString(),
                                                           cmbMonhocCN.SelectedValue.ToString(),
                                                           cmbHockyCN.SelectedValue.ToString(),
                                                           cmbNanhocCN.SelectedValue.ToString(),
                                                           cmbLopCN.SelectedValue.ToString(),
                                                           "LD0004",
                                                           float.Parse(diemThi.ToString()));
                        }
                        //thi lai
                        if (row.Cells["DiemThiLai"].Value != null)
                        {
                            String diemThi = row.Cells["DiemThiLai"].Value.ToString();
                            if (quyDinh.KiemTraDiem(diemThi))
                                m_DiemCtrl.LuuDiem(row.Cells["MaHocSinh"].Value.ToString(),
                                                           cmbMonhocCN.SelectedValue.ToString(),
                                                           cmbHockyCN.SelectedValue.ToString(),
                                                           cmbNanhocCN.SelectedValue.ToString(),
                                                           cmbLopCN.SelectedValue.ToString(),
                                                           "LD0005",
                                                           float.Parse(diemThi.ToString()));
                        }
                        //Lưu vào bảng kết quả
                        //if (rowcount <= dgvNhapdiemchung.Rows.Count)
                        //{
                            
                        //    float diemTBMonHK =0;
                        //    if(row.Cells["DTBHKMonHoc"].Value != null)
                        //         diemTBMonHK = float.Parse(row.Cells["DTBHKMonHoc"].Value.ToString());
                        //    diemTBMonHK = (float)Math.Round(diemTBMonHK, 2);
                        //    m_KQHocKyMonHocCtrl.LuuKetQua(row.Cells["MaHocSinh"].Value.ToString(),
                        //                                  cmbLopCN.SelectedValue.ToString(),
                        //                                  cmbMonhocCN.SelectedValue.ToString(),
                        //                                  cmbHockyCN.SelectedValue.ToString(),
                        //                                  cmbNanhocCN.SelectedValue.ToString(),diemTBMonHK);

                        //    m_KQCaNamMonHocCtrl.LuuKetQuaCaNamMonHoc(row.Cells["MaHocSinh"].Value.ToString(),
                        //                                  cmbLopCN.SelectedValue.ToString(),
                        //                                  cmbMonhocCN.SelectedValue.ToString(),
                        //                                  cmbNanhocCN.SelectedValue.ToString());

                        //    m_KQHocKyTongHopCtrl.LuuKetQua(row.Cells["MaHocSinh"].Value.ToString(),
                        //                                   cmbLopCN.SelectedValue.ToString(),
                        //                                   cmbHockyCN.SelectedValue.ToString(),
                        //                                   cmbNanhocCN.SelectedValue.ToString());

                        //    m_KQCaNamTongHopCtrl.LuuKetQua(row.Cells["MaHocSinh"].Value.ToString(),
                        //                                   cmbLopCN.SelectedValue.ToString(),
                        //                                   cmbNanhocCN.SelectedValue.ToString());
                             
                        //}
                        //Xóa các kết quả cũ
                        if (STT != null)
                        {
                            for (int i = 1; i < 60; i++)
                                for (int j = 1; j < 20; j++)
                                {
                                    int id = STT[i, j];
                                    if (id > 0)
                                        m_DiemCtrl.XoaDiem(id);
                                    else
                                        break;
                                }
                            STT = null;
                        }

                    }
                    
                    //MessageBoxEx.Show("Cập nhật thành công!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSDiemChung();
                    bngluu.Enabled = false;

                }
            }
        }

        private void dgvNhapdiemchung_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNamhoc_Click(object sender, EventArgs e)
        {
            frmKhoaHoc m_NamHoc = null;
            if (m_NamHoc == null || m_NamHoc.IsDisposed)
            {
                m_NamHoc = new frmKhoaHoc();
                m_NamHoc.MdiParent = frmMain.ActiveForm;
                m_NamHoc.Show();
            }
            else m_NamHoc.Activate();
           // m_NamHocCtrl.HienThiComboBox(cbmnamhoc);
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            frmLop m_Lop = null;
            if (m_Lop == null || m_Lop.IsDisposed)
            {
                m_Lop = new frmLop();
                m_Lop.MdiParent = frmMain.ActiveForm;
                m_Lop.Show();
            }
            else m_Lop.Activate();
            //m_LopCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop);
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            frmHocKy m_HK = null;
            if (m_HK == null || m_HK.IsDisposed)
            {
                m_HK = new frmHocKy();
                m_HK.MdiParent = frmMain.ActiveForm;
                m_HK.Show();
            }
            else m_HK.Activate();
           // m_HocKyCtrl.HienThiComboBox(cmbHocky);
        }

        private void btnMonhoc_Click(object sender, EventArgs e)
        {
            frmMonHoc m_MonHoc = null;
            if (m_MonHoc == null || m_MonHoc.IsDisposed)
            {
                m_MonHoc = new frmMonHoc();
                m_MonHoc.MdiParent = frmMain.ActiveForm;
                m_MonHoc.Show();
            }
            else m_MonHoc.Activate();
            //m_MonHocCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop.SelectedValue.ToString(), cmbMonhoc);
        }

        private void btnCNdiem_Click(object sender, EventArgs e)
        {

        }

        private void cbmnamhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbmnamhoc.SelectedValue != null)
             //   m_LopCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop);
            //cmblop.DataBindings.Clear();
        }

        private void cmblop_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if (cbmnamhoc.SelectedValue != null && cmblop.SelectedValue != null)
           //     m_MonHocCtrl.HienThiComboBox(cbmnamhoc.SelectedValue.ToString(), cmblop.SelectedValue.ToString(), cmbMonhoc);
            ///cmbMonhoc.DataBindings.Clear();
        }

        private void cmbNanhocCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNanhocCN.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNanhocCN.SelectedValue.ToString(), cmbLopCN);
            cmbLopCN.DataBindings.Clear();
        }

        private void cmbLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            //m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhocCN);
            cmbMonhocCN.DataBindings.Clear();
        }

        private void dgvNhapdiemchung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbMonhocCN_Click(object sender, EventArgs e)
        {
            if (cmbNanhocCN.SelectedValue != null && cmbLopCN.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbNanhocCN.SelectedValue.ToString(), cmbLopCN.SelectedValue.ToString(), cmbMonhocCN);
            cmbMonhocCN.DataBindings.Clear();
        }
        public void setEnableControl(bool status)
        {
            bngluu.Enabled = status;

   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSDiemChung();
        }

        private void dgvNhapdiemchung_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
            foreach (DataGridViewRow row in dgvNhapdiemchung.Rows)
            {
                String[] diemMieng = row.Cells["DiemMieng"].Value.ToString().Split(';');
            }
        }

        private void dgvNhapdiemchung_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           /* bngluu.Enabled = true;
            foreach (DataGridViewRow row in dgvXepLoaiHanhKiem.Rows)
            {
                String[] diemMieng = row.Cells["DiemMieng"].Value.ToString().Split(';');
            }*/
        }

    }
}