using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class NgheNghiepInfo
    {
       private String m_MaNgheNghiep;
        public String MaNgheNghiep
        {
            get { return m_MaNgheNghiep; }
            set { m_MaNgheNghiep = value; }
        }
        private String m_TenNgheNghiep;
        public String TenNgheNghiep
        {
            get { return m_TenNgheNghiep; }
            set { m_TenNgheNghiep = value; }
        }
    }
}
