using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
  public class LoaiNguoiDungInfo
    {
      public LoaiNguoiDungInfo()
      { 
      
      }
        private String m_MaLoaiND;
        public String MaLoaiND
        {
            get { return m_MaLoaiND; }
            set { m_MaLoaiND = value; }
        }
        private String m_TenLoaiND;
        public String TenLoaiND
        {
            get { return m_TenLoaiND; }
            set { m_TenLoaiND = value; }
        }

    }
}
