using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;


namespace QLDiemHSTHPT.Controller
{
   public class DiemCtrl
    {
        DiemData m_DiemData = new DiemData();
        HocKyData m_HocKyData = new HocKyData();
        MonHocData m_MonHocData = new MonHocData();
        LopData m_LopData = new LopData();

       public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, String diemSo)
       {
           m_DiemData.LuuDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, maLoaiDiem, diemSo);
       }

       //OK
       public float getDiemTrungBinhMonHocKy(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           DiemData m_DiemData_ = new DiemData();
           float TBMHK = m_DiemData_.getDiemTrungBinhMonHocKy(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
           return TBMHK;
       }
       //OK
       public float tinhDiemTrungBinhChungCacMonHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
       {
           float tongDiemCacMon = 0;
           float diemTBTungMon = 0;
           int tongHeSoCacMon = 0;
           //Lấy ra mã ban theo mã lớp - BEGIN
           string strBan = "CHUA_PHAN_BAN";
           DataTable m_DT_BAN = m_LopData.TimTheoMa(maLop);
           foreach (DataRow row in m_DT_BAN.Rows)
           {
               strBan = row["MaBan"].ToString().Trim();
               break;
           }
           //Lấy ra mã ban theo mã lớp - END

           //Tính điểm TBCMHK theo từng phân ban - BEGIN
           DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);
           foreach (DataRow row in m_DT.Rows)
           {
               diemTBTungMon = getDiemTrungBinhMonHocKy(maHocSinh, row["MaMonHoc"].ToString(), maHocKy, maNamHoc, maLop);
               if (strBan == "B0001")//ban KHTN
               {
                   tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSoBanKHTN"].ToString());
                   tongHeSoCacMon += Convert.ToInt32(row["HeSoBanKHTN"].ToString());
               }
               else if (strBan == "B0002")//Ban XHNV
               {
                   tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSoBanKHXHNV"].ToString());
                   tongHeSoCacMon += Convert.ToInt32(row["HeSoBanKHXHNV"].ToString());
               }
               else//ban CB
               {
                   tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSoBanCoBan"].ToString());
                   tongHeSoCacMon += Convert.ToInt32(row["HeSoBanCoBan"].ToString());
               }
           }
           if (tongHeSoCacMon > 0)
               return tongDiemCacMon / tongHeSoCacMon;
           else
               return 0;
           //Tính điểm TBCMHK theo từng phân - END
       }
       //OK
       public float tinhDiemTrungBinhChungCacMonCaNam(String maHocSinh, String maLop, String maNamHoc)
       {
           float TBCMHK1 = tinhDiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, "HK1", maNamHoc);
           float TBCMHK2 = tinhDiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, "HK2", maNamHoc);
           float TBCMCN = (TBCMHK1 + 2 * TBCMHK2) / 3;
           return TBCMCN;
       }
       public float DiemThiLai(String maHocSinh, String maMonHoc, String maNamHoc, String maLop)
       {
           DataTable m_DT = m_DiemData.LayDsDiemHocSinhTL(maHocSinh, maMonHoc, maNamHoc, maLop);

           float tongDiem = 0;
           int tongHeSo = 0;

           foreach (DataRow row in m_DT.Rows)
           {
               if (row["MaLoaiDiem"].ToString() == "LD0005")
               {
                   if (row["Diem"].ToString() != "")
                   {
                       tongDiem += Convert.ToSingle(row["Diem"].ToString()) * Convert.ToInt32(row["HeSo"].ToString());
                       tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
                   }
               }
           }
           if (tongHeSo > 0)
               return tongDiem / tongHeSo;
           else
               return 0;
       }
   
       //OK
       public float DiemTrungBinhMonCaNam(String maHocSinh, String maMonHoc, String maNamHoc, String maLop)
       {
           DataTable m_DT = new DataTable();
           m_DT = m_HocKyData.LayDsHocKy();

           float tongDiem = 0;
           int tongHeSo = 0;

           foreach (DataRow row in m_DT.Rows)
           {
               tongDiem += getDiemTrungBinhMonHocKy(maHocSinh, maMonHoc, row["MaHocKy"].ToString(), maNamHoc, maLop) * Convert.ToInt32(row["HeSo"].ToString());
               tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
           }

           if (tongHeSo > 0)
               return tongDiem / tongHeSo;
           else
               return 0;
       }
       public float tinhTongMang(string[] mang)
       { 
           float tong = 0;
           for (int i = 0; i < mang.Length; i++)
           {
               tong += float.Parse(mang[i]);
           }
           return tong;
       }
       public float tinhDiemTrungBinhMon(float[] diemMieng, float[] diem15Phut, float[] diem1Tiet, float diemThi )
       {
           float tongDiemHeSo1 = 0;
           float tongDiemHeSo2 = 0;

           int soDiemMieng = diemMieng.Length;
           int soDiem15Phut = diem15Phut.Length;
           int soDiemHeSo1 = soDiemMieng + soDiem15Phut;
           int soDiemHeSo2 = diem1Tiet.Length;
           for (int i = 0; i < diemMieng.Length; i++)
           {
               tongDiemHeSo1 += diemMieng[i];
           }
           for (int i = 0; i < diem15Phut.Length; i++)
           {
               tongDiemHeSo1 += diem15Phut[i];
           }
           for (int i = 0; i < diem1Tiet.Length; i++)
           {
               tongDiemHeSo2 += diem1Tiet[i];
           }
           float diemTBMonHK = (float)Math.Round((tongDiemHeSo1 + 2 * tongDiemHeSo2 + 3 * diemThi) / (soDiemHeSo1 + 2 * soDiemHeSo2 + 3), 2);
           return diemTBMonHK;
       }
   }
}
