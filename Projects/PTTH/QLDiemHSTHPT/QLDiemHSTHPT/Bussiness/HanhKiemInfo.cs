using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class HanhKiemInfo
    {
        private String m_MaHanhkiem;
        public String MaHanhKiem
        {
            get { return m_MaHanhkiem; }
            set { m_MaHanhkiem = value; }
        }
        private String m_TenHanhKiem;
        public String TenHanhKiem
        {
            get { return m_TenHanhKiem; }
            set { m_TenHanhKiem = value; }
        }
    }
}
