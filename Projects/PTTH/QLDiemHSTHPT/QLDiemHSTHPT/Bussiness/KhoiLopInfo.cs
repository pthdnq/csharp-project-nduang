using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class KhoiLopInfo
    {
        private String m_MaKhoiLop;
        public String MaKhoiLop
        {
            get { return m_MaKhoiLop; }
            set { m_MaKhoiLop = value; }
        }
        private String m_TenKhoiLop;
        public String TenKhoiLop
        {
            get { return m_TenKhoiLop; }
            set { m_TenKhoiLop = value; }
        }
    }
}
