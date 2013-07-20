using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class HocKyInfo
    {
        private String m_MaHocKy;
        public String MaHocKy
        {
            get { return m_MaHocKy; }
            set { m_MaHocKy = value; }
        }

        private String m_TenHocKy;
        public String TenHocKy
        {
            get { return m_TenHocKy; }
            set { m_TenHocKy = value; }
        }

        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
    }
}
