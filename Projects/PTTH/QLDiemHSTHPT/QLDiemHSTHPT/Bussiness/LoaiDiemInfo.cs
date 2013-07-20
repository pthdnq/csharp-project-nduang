using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class LoaiDiemInfo
    {
        private String m_MaLoaiDiem;
        public String MaLoaiDiem
        {
            get { return m_MaLoaiDiem; }
            set { m_MaLoaiDiem = value; }
        }

        private String m_TenLoai;
        public String TenLoai
        {
            get { return m_TenLoai; }
            set { m_TenLoai = value; }
        }

        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
    }
}
