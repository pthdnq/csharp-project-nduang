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
using System.Threading;

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
        Tool quyDinh = new Tool();
        //MonHocCtrl m_MonHocCtrl = new MonHocCtrl();

        DiemData m_DiemData = new DiemData();

        String strMaLop = "";
        String strTenLop = "";
        String strMaMonHoc ="";
        String strTenMonHoc = "";
        String strMaKhoaHoc = "";
        String strMaHocKy = "";
        int[,] STT = null;
        public void CapNhatDuLieuTrenGiaoDien()
        {
            
            strMaLop = cmbLop.SelectedValue.ToString().Trim();
            strTenLop = cmbLop.Text.Trim();
            strMaMonHoc = cmbMonhoc.SelectedValue.ToString().Trim();
            strTenMonHoc = cmbMonhoc.Text.Trim();
            strMaKhoaHoc = cmbKhoaHoc.SelectedValue.ToString().Trim();
            strMaHocKy = cmbHocky.SelectedValue.ToString().Trim();
        }
        public frmNhapDiem()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmNhapDiemChung_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbKhoaHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocky);
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);
            m_MonHocCtrl.HienThiComboBox(cmbMonhoc);
            String strLoaiTaiKhoan = Utilities.NguoiDung.LoaiND.MaLoaiND.Trim();
            //tai khoan hoc sinh thi an nut luu diem
            if (strLoaiTaiKhoan != "LND002")
            {
                bngluu.Visible = false;
            }
            CapNhatDuLieuTrenGiaoDien();
           // HienThiDSDiem();
        }

        //kiem tra diem truoc khi luu
        public Boolean KiemTraDiemTruocKhiLuu(String loaiDiem)
        {
            foreach (DataGridViewRow row in dgvNhapdiem.Rows)
            {
                if (row.Cells[loaiDiem].Value != null)
                {
                    String chuoiDiemChuaXuLy = row.Cells[loaiDiem].Value.ToString();
                    if (chuoiDiemChuaXuLy != "")
                    {
                        String[] chuoiDiem = chuoiDiemChuaXuLy.Split(';');
                        for (int i = 0; i < chuoiDiem.Length; i++)
                        {
                            if (quyDinh.KiemTraDiem(chuoiDiem[i]) == false)
                                MessageBoxEx.Show("Điểm của học sinh " + row.Cells["HoTen"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    
                }

            }
            return true;
        }

        private void HienThiDSDiem()
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null && cmbHocky.SelectedValue != null && cmbMonhoc.SelectedValue != null)
                m_HocSinhCtrl.HienThiDsHocSinhTheoLop(dgvNhapdiem, bdgNhapdiemchung, cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(),txtMaHS_Or_hoTenHS.Text.Trim());

            int countRowHocSinh = 0;
            foreach (DataGridViewRow rowHocSinh in dgvNhapdiem.Rows)
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
                String maHS = rowHocSinh.Cells["MaHocSinh"].Value.ToString().Trim();

                DataTable m_DT = m_DiemData.LayDsDiemHocSinh(maHS, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop);

                int countRowDiem = 0;
                foreach (DataRow rowDiem in m_DT.Rows)
                {
                    countRowDiem++;
                    String maLoaiDiem =rowDiem["MaLoaiDiem"].ToString().Trim();
                    String diem = rowDiem["Diem"].ToString().Trim();

                    if (maLoaiDiem == "LD0001")
                        diemMieng[soDiemMieng++] = diem;

                    else if (maLoaiDiem == "LD0002")
                        diem15Phut[soDiem15Phut++] = diem;

                    else if (maLoaiDiem == "LD0003")
                        diem1tiet[soDiem1tiet++] = diem;

                    else if (maLoaiDiem == "LD0004")
                        diemThi = diem;

                    else if (maLoaiDiem == "LD0005")
                        diemTL = diem;
                    //DTBHKMonHoc = float.Parse(rowDiem["DTBMonHocKy"].ToString());
                }

                rowHocSinh.Cells["DiemMieng"].Value = quyDinh.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["Diem15phut"].Value = quyDinh.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["Diem1tiet"].Value = quyDinh.ArrayToString(diem1tiet, soDiem1tiet);
                rowHocSinh.Cells["DiemThi"].Value = diemThi;
                rowHocSinh.Cells["DiemThiLai"].Value = diemTL;
            }
        }

        private void bngluu_Click_1(object sender, EventArgs e)
        {
            CapNhatDuLieuTrenGiaoDien();
            LuuDuLieuDiem();
            HienThiDSDiem();
        }
        private void LuuDuLieuDiem()
        {
            
            dgvNhapdiem.EndEdit();
            String strTenDangNhap = Utilities.NguoiDung.TenDangNhap.Trim();
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
                    foreach (DataGridViewRow row in dgvNhapdiem.Rows)
                    {
                        rowcount++;
                        float[] DiemMieng = null;
                        float[] Diem15Phut = null;
                        float[] Diem1Tiet = null;
                        float DiemThi = 0;
                        float DiemThiLai = 0;
                        String maHocSinh = row.Cells["MaHocSinh"].Value.ToString();
                        //kiem tra diem mieng
                        if (row.Cells["DiemMieng"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["DiemMieng"].Value.ToString();
                            if (chuoiDiemChuaXuLy != "")
                            {
                                float[] mangDiem = quyDinh.StringToFloatArray(chuoiDiemChuaXuLy);
                                DiemMieng = mangDiem;
                                //lưu mảng điểm miệng xuống cở sở dữ liệu
                            }
                            LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0001", chuoiDiemChuaXuLy);

                        }

                        //Kiểm tra 15 phút
                        if (row.Cells["Diem15phut"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["Diem15phut"].Value.ToString();

                            if (chuoiDiemChuaXuLy != "")
                            {
                                float[] mangDiem = quyDinh.StringToFloatArray(chuoiDiemChuaXuLy);
                                Diem15Phut = mangDiem;
                                //lưu chuỗi điểm 15p xuống cở sở dữ liệu
                            }
                            LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0002", chuoiDiemChuaXuLy);


                        }

                        if (row.Cells["Diem1tiet"].Value != null)
                        {
                            String chuoiDiemChuaXuLy = row.Cells["Diem1tiet"].Value.ToString();
                            if (chuoiDiemChuaXuLy != "")
                            {
                                float[] mangDiem = quyDinh.StringToFloatArray(chuoiDiemChuaXuLy);
                                Diem1Tiet = mangDiem;
                                //lưu tất cả điểm 1 tiết xuống cở sở dữ liệu
                            }
                            LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0003", chuoiDiemChuaXuLy);


                        }
                        //Thi học kỳ
                        if (row.Cells["DiemThi"].Value != null)
                        {
                            String diemThi = row.Cells["DiemThi"].Value.ToString();
                            if (diemThi != "")//nếu có điểm thì kiểm tra điểm có hợp lệ không
                            {//nếu không có điểm thì lưu điểm rỗng( không phải số 0)
                                if (quyDinh.KiemTraDiem(diemThi))
                                {
                                    float diem = float.Parse(diemThi);
                                    DiemThi = diem;
                                }
                            }
                            LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0004", diemThi);
                        }

                        //thi lai
                        if (row.Cells["DiemThiLai"].Value != null)
                        {
                            String diemThi = row.Cells["DiemThiLai"].Value.ToString();
                            if (diemThi != "")
                            {
                                if (quyDinh.KiemTraDiem(diemThi))
                                {
                                    float diem = float.Parse(diemThi);
                                    DiemThiLai = diem;
                                    LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0005", diemThi);
                                }
                            }
                        }
                        //Lưu vào bảng kết quả
                        if (rowcount <= dgvNhapdiem.Rows.Count)
                        {
                            String maHS = row.Cells["MaHocSinh"].Value.ToString().Trim();
                            String tenHS = row.Cells["HoTen"].Value.ToString().Trim();
                            float diemTBMonHK = 0;
                            try
                            {
                                //tính và lưu điểm xuống cơ sở dữ liệu
                                diemTBMonHK = m_DiemCtrl.tinhDiemTrungBinhMon(DiemMieng, Diem15Phut, Diem1Tiet, DiemThi);
                                if (diemTBMonHK >= 5 && DiemThiLai != 0)
                                {
                                    MessageBoxEx.Show(@"Điểm trung bình môn này của học sinh" +tenHS+    
                                        "đã vượt qua 5,bạn không được nhập điểm thi lại!!!!");
                                    LuuDiemThanhPhan(maHocSinh, strMaMonHoc, strMaHocKy, strMaKhoaHoc, strMaLop, "LD0005", "");
                                }
                                else if (diemTBMonHK < 5 && DiemThiLai != 0)
                                { //tính lại điểm TBMonHK
                                    diemTBMonHK = m_DiemCtrl.tinhDiemTrungBinhMon(DiemMieng, Diem15Phut, Diem1Tiet, DiemThiLai);
                                }
                                m_KQHocKyMonHocCtrl.LuuKetQua(maHS, strMaLop, strMaMonHoc, strMaHocKy, strMaKhoaHoc, diemTBMonHK);
                            }
                            catch (Exception)
                            {
                            }



                            m_KQHocKyTongHopCtrl.CapNhatDiemDTBCacMonHocVaHocLucHocKy(maHS,
                                                           strMaLop,
                                                           strMaHocKy,
                                                           strMaKhoaHoc);
                            m_KQCaNamMonHocCtrl.LuuKetQuaCaNamMonHoc(maHS,
                                                                      strMaLop,
                                                                      strMaMonHoc,
                                                                      strMaKhoaHoc);

                            m_KQCaNamTongHopCtrl.LuuKetQua(maHS,
                                                           strMaLop,
                                                           strMaKhoaHoc);

                        }
                    }
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

        private void cmbNanhocCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLopCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhoc);
            cmbMonhoc.DataBindings.Clear();
        }

        private void cmbMonhocCN_Click(object sender, EventArgs e)
        {
            if (cmbKhoaHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                m_MonHocCtrl.HienThiComboBox(cmbKhoaHoc.SelectedValue.ToString(), cmbLop.SelectedValue.ToString(), cmbMonhoc);
            cmbMonhoc.DataBindings.Clear();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSDiem();
        }

        private void dgvNhapdiemchung_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            bngluu.Enabled = true;
        }
        //Hàm này có nhiệm vụ lưu các điểm thành phần như: 
        //điểm 15 phút, miệng, 1 tiết, thi học kỳ, thi lại
        private void LuuDiemThanhPhan(
                                        String maHocSinh,//mã học sinh
                                        String maMonHoc,//mã môn học
                                        String maHocKy,//mã học kỳ
                                        String maNamHoc,//mã năm học
                                        String maLop,//mã lớp học
                                        String maLoaiDiem,//mã điểm miệng
                                        String diem //giá trị điểm dang "3;6;7.5" là chứa 3 điểm số
                                     )
        {
            m_DiemCtrl.LuuDiem  (
                                maHocSinh,//mã học sinh
                                maMonHoc,//mã môn học
                                maHocKy,//mã học kỳ
                                maNamHoc,//mã năm học
                                maLop,//mã lớp học
                                maLoaiDiem,//mã điểm miệng
                                diem //giá trị điểm
                                );
        }
        private float TinhDiemTrungBinhMon(float[] diemMieng, float[] diem15Phut, float[] diem1Tiet, float diemThi, float diemThiLai)
        { 
                float tongDiemHeSo1 =0;
                float tongDiemHeSo2 = 0;
                
                int soDiemMieng = diemMieng.Length;
                int soDiem15Phut = diem15Phut.Length;
                int soDiemHeSo1 = soDiemMieng + soDiem15Phut;
                int soDiemHeSo2 = diem1Tiet.Length;
                for(int i =0 ;i< diemMieng.Length ;i++ )
                {
                    tongDiemHeSo1 += diemMieng[i];
                }
                for(int i =0 ;i< diem15Phut.Length ;i++ )
                {
                    tongDiemHeSo1 += diem15Phut[i];
                }
                for(int i =0 ;i< diem1Tiet.Length ;i++ )
                {
                    tongDiemHeSo2 += diem1Tiet[i];
                }
                float diemTBMonHK = (float)Math.Round((tongDiemHeSo1 + 2 * tongDiemHeSo2 + 3 * diemThi) / (soDiemHeSo1 + 2 * soDiemHeSo2 + 3), 2);
                return diemTBMonHK;
        }

        private void cmbMonhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
                CapNhatDuLieuTrenGiaoDien();
        }

        private void btnHienthiDS_Click(object sender, EventArgs e)
        {
            CapNhatDuLieuTrenGiaoDien();
            HienThiDSDiem();
        }
    }
}