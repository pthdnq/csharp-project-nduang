using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class NamHocInfo
    {
        private String m_MaNamHoc;
        public String MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }
        private String m_TenNamHoc;
        public String TenNamHoc
        {
            get { return m_TenNamHoc; }
            set { m_TenNamHoc = value; }
        }
    }
}
