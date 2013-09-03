using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT.DataLayer;
using QLDiemHSTHPT.Bussiness;
using DevComponents.DotNetBar.Controls;

namespace QLDiemHSTHPT.Controller
{
   public class KQCNTongHopCtrl
    {
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        KQCNTongHopData m_KQCaNamTongHopData = new KQCNTongHopData();

       public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc)
       {
           float diemTBChungCacMonCN = (float)Math.Round(m_DiemCtrl.tinhDiemTrungBinhChungCacMonCaNam(maHocSinh, maLop, maNamHoc), 2);
           String hocLuc = m_HocLucCtrl.XepLoaiHocLucCaNam(maHocSinh, maLop, maNamHoc);
           String ketQua = "";
           switch (hocLuc)
           {
               case "HL0001":
               case "HL0002":
               case "HL0003": ketQua = "KQ0001";  break;
               case "HL0005": ketQua = "KQ0002"; break;
               case "HL0004": ketQua = "KQ0003"; break;
              
           }

               
           m_KQCaNamTongHopData.XoaKetQua(maHocSinh, maLop, maNamHoc);
           m_KQCaNamTongHopData.LuuKetQua(maHocSinh, maLop, maNamHoc, hocLuc, "HK0001", diemTBChungCacMonCN, ketQua);
       }

       public static IList<KQCNTongHopInfo> LayDsKQCaNamTongHop(String maLop, String maNamHoc)
       {
           KQCNTongHopData m_KQCNTHData = new KQCNTongHopData();
           DataTable m_DT = m_KQCNTHData.LayDsKQCaNamTongHopForReport(maLop, maNamHoc);

           IList<KQCNTongHopInfo> dS = new List<KQCNTongHopInfo>();

           foreach (DataRow Row in m_DT.Rows)
           {
               KQCNTongHopInfo ketqua = new KQCNTongHopInfo();

               HocSinhInfo hs = new HocSinhInfo();
               hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
               hs.HoTen = Convert.ToString(Row["HoTen"]);

               LopInfo l = new LopInfo();
               l.MaLop = Convert.ToString(Row["MaLop"]);
               l.TenLop = Convert.ToString(Row["TenLop"]);

               NamHocInfo nh = new NamHocInfo();
               nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
               nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

               HocLucInfo hl = new HocLucInfo();
               hl.MaHocLuc = Convert.ToString(Row["MaHocLuc"]);
               hl.TenHocLuc = Convert.ToString(Row["TenHocLuc"]);

               HanhKiemInfo hkiem = new HanhKiemInfo();
               hkiem.MaHanhKiem = Convert.ToString(Row["MaHanhKiem"]);
               hkiem.TenHanhKiem = Convert.ToString(Row["TenHanhKiem"]);

               KetQuaInfo kq = new KetQuaInfo();
               kq.MaKetQua = Convert.ToString(Row["MaKetQua"]);
               kq.TenKetQua = Convert.ToString(Row["TenKetQua"]);

               ketqua.HocSinh = hs;
               ketqua.Lop = l;
               ketqua.NamHoc = nh;
               ketqua.HocLuc = hl;
               ketqua.HanhKiem = hkiem;
               ketqua.KetQua = kq;
               ketqua.DTBCaNam = Convert.ToSingle(Row["DTBCaNam"]);

               dS.Add(ketqua);
           }
           return dS;
       }
    }
}
