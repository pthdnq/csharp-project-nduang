using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class HocLucInfo
    {
        private String m_MaHocLuc;
        public String MaHocLuc
        {
            get { return m_MaHocLuc; }
            set { m_MaHocLuc = value; }
        }

        private String m_TenHocLuc;
        public String TenHocLuc
        {
            get { return m_TenHocLuc; }
            set { m_TenHocLuc = value; }
        }

        private float m_DiemCanDuoi;
        public float DiemCanDuoi
        {
            get { return m_DiemCanDuoi; }
            set { m_DiemCanDuoi = value; }
        }

        private float m_DiemCanTren;
        public float DiemCanTren
        {
            get { return m_DiemCanTren; }
            set { m_DiemCanTren = value; }
        }

        private float m_DiemKhong;
        public float DiemKhong
        {
            get { return m_DiemKhong; }
            set { m_DiemKhong = value; }
        }
    }
}