using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class PhanCongData
    {
       DataService m_PhanCongData = new DataService();

       public DataTable LayDsPhanCong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHANCONG");
            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhanCongData.NewRow();
        }

        public void ThemPhanCong(DataRow m_Row)
        {
            m_PhanCongData.Rows.Add(m_Row);
        }

        public bool LuuPhanCong()
        {
            return m_PhanCongData.ExecuteNoneQuery() > 0;
        }

        public void LuuPhanCong(String maNamHoc, String maLop, String maMonHoc, String maGiaoVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PHANCONG VALUES(@maNamHoc, @maLop, @maMonHoc, @maGiaoVien)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value   = maGiaoVien;

            m_PhanCongData.Load(cmd);
        }

        public DataTable TimTheoTenLop(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.STT, P.MaNamHoc, P.MaLop, P.MaMonHoc, P.MaGiaoVien FROM PHANCONG P, LOP L WHERE P.MaLop = L.MaLop AND L.TenLop LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }

        public DataTable TimTheoTenGV(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT P.STT, P.MaNamHoc, P.MaLop, P.MaMonHoc, P.MaGiaoVien FROM PHANCONG P, GIAOVIEN G WHERE P.MaGiaoVien = G.MaGiaoVien AND G.TenGiaoVien LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_PhanCongData.Load(cmd);
            return m_PhanCongData;
        }
       public bool isDuocPhepSuaDiem(String MaGiaoVien, String MaLop, String MaMonHoc, String MaKhoaHoc)
       {
           SqlCommand cmd = new SqlCommand(@"select *  from PHANCONG
                                                inner join NGUOIDUNG
                                                on PHANCONG.MaGiaoVien = NGUOIDUNG.TenDangNhap

                                                where PHANCONG.MaLop = @MaLop
                                                and PHANCONG.MaMonHoc = @MaMonHoc
                                                and PHANCONG.MaGiaoVien = @MaGiaoVien
                                                and PHANCONG.MaNamHoc = @MaNamHoc
                                            ");
           cmd.Parameters.Add("MaLop", SqlDbType.VarChar).Value = MaLop;
           cmd.Parameters.Add("MaMonHoc", SqlDbType.VarChar).Value = MaMonHoc;
           cmd.Parameters.Add("MaGiaoVien", SqlDbType.VarChar).Value = MaGiaoVien;
           cmd.Parameters.Add("MaNamHoc", SqlDbType.VarChar).Value = MaKhoaHoc;
           m_PhanCongData.Load(cmd);
           if (m_PhanCongData.Rows.Count > 0)
               return true;
           else
               return false;
       }
    }
    }
