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
  public class KQHKTongHopCtrl
    {
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        HocLucCtrl m_HocLucCtrl = new HocLucCtrl();
        KQHKTongHopData m_KQHocKyTongHopData = new KQHKTongHopData();

      public void LuuKetQua(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
      {
          float diemTBChungCacMonHK = (float)Math.Round(m_DiemCtrl.DiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, maHocKy, maNamHoc), 2);
          String hocLuc = m_HocLucCtrl.XepLoaiHocLucHocKy(maHocSinh, maLop, maHocKy, maNamHoc);

          m_KQHocKyTongHopData.XoaKetQua(maHocSinh, maLop, maHocKy, maNamHoc);
          m_KQHocKyTongHopData.LuuKetQua(maHocSinh, maLop, maHocKy, maNamHoc, hocLuc, "HK0001", diemTBChungCacMonHK);
      }

      public static IList<KQHKTongHopInfo> LayDsKQHocKyTongHop(String maLop, String maHocKy, String maNamHoc)
      {
          KQHKTongHopData m_KQHKTHData = new KQHKTongHopData();
          DataTable m_DT = m_KQHKTHData.LayDsKQHocKyTongHopForReport(maLop, maHocKy, maNamHoc);

          IList<KQHKTongHopInfo> dS = new List<KQHKTongHopInfo>();

          foreach (DataRow Row in m_DT.Rows)
          {
              KQHKTongHopInfo ketqua = new KQHKTongHopInfo();

              HocSinhInfo hs = new HocSinhInfo();
              hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
              hs.HoTen = Convert.ToString(Row["HoTen"]);

              LopInfo l = new LopInfo();
              l.MaLop = Convert.ToString(Row["MaLop"]);
              l.TenLop = Convert.ToString(Row["TenLop"]);

              HocKyInfo hk = new HocKyInfo();
              hk.MaHocKy = Convert.ToString(Row["MaHocKy"]);
              hk.TenHocKy = Convert.ToString(Row["TenHocKy"]);

              NamHocInfo nh = new NamHocInfo();
              nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
              nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

              HocLucInfo hl = new HocLucInfo();
              hl.MaHocLuc = Convert.ToString(Row["MaHocLuc"]);
              hl.TenHocLuc = Convert.ToString(Row["TenHocLuc"]);

              HanhKiemInfo hkiem = new HanhKiemInfo();
              hkiem.MaHanhKiem = Convert.ToString(Row["MaHanhKiem"]);
              hkiem.TenHanhKiem = Convert.ToString(Row["TenHanhKiem"]);

              ketqua.HocSinh = hs;
              ketqua.Lop = l;
              ketqua.HocKy = hk;
              ketqua.NamHoc = nh;
              ketqua.HocLuc = hl;
              ketqua.HanhKiem = hkiem;
              ketqua.DTBMonHocKy = Convert.ToSingle(Row["DTBMonHocKy"]);

              dS.Add(ketqua);
          }
          return dS;
      }
    }
}
