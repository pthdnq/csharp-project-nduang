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
    public class KQCNMonHocCtrl
    {
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        KQCNMonHocData m_KQCaNamMonHocData = new KQCNMonHocData();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            float diemTBMonCN = (float)Math.Round(m_DiemCtrl.DiemTrungBinhMonCaNam(maHocSinh, maMonHoc, maNamHoc, maLop), 2);
            float diemThiLai = (float)Math.Round(m_DiemCtrl.DiemThiLai(maHocSinh, maMonHoc, maNamHoc, maLop), 2); 

            m_KQCaNamMonHocData.XoaKetQua(maHocSinh, maLop, maMonHoc, maNamHoc);
            m_KQCaNamMonHocData.LuuKetQua(maHocSinh, maLop, maMonHoc, maNamHoc, diemThiLai, diemTBMonCN);
        }

        public static IList<KQCNMonHocInfo> LayDsKQCaNamMonHoc(String maLop, String maMonHoc, String maNamHoc)
        {
            KQCNMonHocData m_KQCNMHData = new KQCNMonHocData();
            DataTable m_DT = m_KQCNMHData.LayDsKQCaNamMonHocForReport(maLop, maMonHoc, maNamHoc);

            IList<KQCNMonHocInfo> dS = new List<KQCNMonHocInfo>();

            foreach (DataRow Row in m_DT.Rows)
            {
                KQCNMonHocInfo ketqua = new KQCNMonHocInfo();

                HocSinhInfo hs = new HocSinhInfo();
                hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hs.HoTen = Convert.ToString(Row["HoTen"]);

                LopInfo l = new LopInfo();
                l.MaLop = Convert.ToString(Row["MaLop"]);
                l.TenLop = Convert.ToString(Row["TenLop"]);

                MonHocInfo mh = new MonHocInfo();
                mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);

                NamHocInfo nh = new NamHocInfo();
                nh.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                nh.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                ketqua.HocSinh = hs;
                ketqua.Lop = l;
                ketqua.MonHoc = mh;
                ketqua.NamHoc = nh;
                ketqua.DiemThiLai1 = Convert.ToSingle(Row["DiemThiLai"]);
                ketqua.DTBCaNam = Convert.ToSingle(Row["DTBCaNam"]);

                dS.Add(ketqua);
            }
            return dS;
        }
    }
}
