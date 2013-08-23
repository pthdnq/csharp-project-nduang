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

       public void LuuDiem(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop, String maLoaiDiem, float diemSo)
       {
           m_DiemData.LuuDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop, maLoaiDiem, diemSo);
       }

       public void XoaDiem(int stt)
       {
           m_DiemData.XoaDiem(stt);
       }

       public void HienThiDanhSachXemDiem(ListViewEx lVXemDiem, String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           lVXemDiem.Items.Clear();

           DataTable m_DT = m_DiemData.LayDsDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

           foreach (DataRow row in m_DT.Rows)
           {
               ListViewItem item = new ListViewItem();

               item.Text = row["STT"].ToString();
               item.SubItems.Add(row["MaHocSinh"].ToString());
               item.SubItems.Add(row["HoTen"].ToString());
               item.SubItems.Add(row["TenMonHoc"].ToString());
               item.SubItems.Add(row["TenLoaiDiem"].ToString());
               item.SubItems.Add(row["Diem"].ToString());

               lVXemDiem.Items.Add(item);
           }
       }

      
       public float DiemTrungBinhKiemTra(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           DataTable m_DT = m_DiemData.LayDsDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

           float tongDiem = 0;
           int tongHeSo = 0;

           foreach (DataRow row in m_DT.Rows)
           {
               if (row["MaLoaiDiem"].ToString() != "LD0004" && row["MaLoaiDiem"].ToString() != "LD0005")
               {
                   tongDiem += Convert.ToSingle(row["Diem"].ToString()) * Convert.ToInt32(row["HeSo"].ToString());
                   tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
               }
           }

           if (tongHeSo > 0)
               return tongDiem / tongHeSo;
           else
               return 0;
       }
       //OK
       public float DiemTrungBinhMonHocKy(String maHocSinh, String maMonHoc, String maHocKy, String maNamHoc, String maLop)
       {
           DataTable m_DT = m_DiemData.LayDsDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
           float tongDiemHS1 = 0;
           float tongDiemHS2 = 0;
           float DiemHS3 = 0;
           int soDiemHS1 = 0;
           int soDiemHS2 = 0;
           //int soDiemHS3 = 0;
           float tongDiem = 0;
           int tongHeSo = 0;

           foreach (DataRow row in m_DT.Rows)
           {
               //diem he so 1
               if (row["MaLoaiDiem"].ToString() == "LD0001" || row["MaLoaiDiem"].ToString() == "LD0002" )
               {
                   tongDiemHS1 += Convert.ToSingle(row["Diem"].ToString());
                   soDiemHS1++;
               }
                   //diem he so 2
               else if (row["MaLoaiDiem"].ToString() == "LD0003")
               {
                   tongDiemHS2 += Convert.ToSingle(row["Diem"].ToString());
                   soDiemHS2++;
               }
                   //diem he so 3
               else if (row["MaLoaiDiem"].ToString() == "LD0004")
               {
                   DiemHS3 = Convert.ToSingle(row["Diem"].ToString());
                   //soDiemHS3++;
               }
           }

           float TBMHK = (tongDiemHS1 + 2 * tongDiemHS2 + 3 * DiemHS3) / (soDiemHS1 + soDiemHS2 + 3);
           return TBMHK;
       }
       //OK
       public float DiemTrungBinhChungCacMonHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
       {
           float tongDiemCacMon = 0;
           float diemTBTungMon = 0;
           int tongHeSoCacMon = 0;
           string strBan = "CHUA_PHAN_BAN";
           DataTable m_DT_BAN = m_LopData.TimTheoMa(maLop);

           DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);
           foreach (DataRow row in m_DT_BAN.Rows)
           {
               strBan = row["MaBan"].ToString().Trim();
               break;
           }

           foreach (DataRow row in m_DT.Rows)
           {
               diemTBTungMon = DiemTrungBinhMonHocKy(maHocSinh, row["MaMonHoc"].ToString(), maHocKy, maNamHoc, maLop);
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
       }
       
       public float DiemTrungBinhChungCacMonCaNam(String maHocSinh, String maLop, String maNamHoc)
       {
           float TBCMHK1 = DiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, "HK1", maNamHoc);
           float TBCMHK2 = DiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, "HK2", maNamHoc);
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
                   tongDiem += Convert.ToSingle(row["Diem"].ToString()) * Convert.ToInt32(row["HeSo"].ToString());
                   tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
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
               tongDiem += DiemTrungBinhMonHocKy(maHocSinh, maMonHoc, row["MaHocKy"].ToString(), maNamHoc, maLop) * Convert.ToInt32(row["HeSo"].ToString());
               tongHeSo += Convert.ToInt32(row["HeSo"].ToString());
           }

           if (tongHeSo > 0)
               return tongDiem / tongHeSo;
           else
               return 0;
       }
    }
}
