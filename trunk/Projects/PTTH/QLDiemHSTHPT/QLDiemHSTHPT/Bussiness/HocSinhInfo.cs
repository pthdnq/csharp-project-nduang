using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class HocSinhInfo
    {
        private String m_MaHocSinh;
        public String MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_NoiSinh;
        public String NoiSinh
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }

        private DanTocInfo m_DanToc;
        public DanTocInfo DanToc
        {
            get { return m_DanToc; }
            set { m_DanToc = value; }
        }

        private TonGiaoInfo m_TonGiao;
        public TonGiaoInfo TonGiao
        {
            get { return m_TonGiao; }
            set { m_TonGiao = value; }
        }

        private String m_HoTenCha;
        public String HoTenCha
        {
            get { return m_HoTenCha; }
            set { m_HoTenCha = value; }
        }

        private NgheNghiepInfo m_NgheNghiepCha;
        public NgheNghiepInfo NgheNghiepCha
        {
            get { return m_NgheNghiepCha; }
            set { m_NgheNghiepCha = value; }
        }

        private String m_HoTenMe;
        public String HoTenMe
        {
            get { return m_HoTenMe; }
            set { m_HoTenMe = value; }
        }

        private NgheNghiepInfo m_NgheNghiepMe;
        public NgheNghiepInfo NgheNghiepMe
        {
            get { return m_NgheNghiepMe; }
            set { m_NgheNghiepMe = value; }
        }
    }
}
