using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class PhanLopInfo
    {
       private NamHocInfo m_NamHoc;
       public NamHocInfo NamHoc
       {
           get { return m_NamHoc; }
           set { m_NamHoc = value; }
       }
       private LopInfo m_Lop;
       public LopInfo Lop
       {
           get { return m_Lop; }
           set { m_Lop = value; }
       }
       private KhoiLopInfo m_KhoiLop;
       public KhoiLopInfo KhoiLop
       {
           get { return m_KhoiLop; }
           set { m_KhoiLop = value; }
       }
       private HocSinhInfo m_HocSinh;
       public HocSinhInfo HocSinh
       {
           get { return m_HocSinh; }
           set { m_HocSinh = value; }
       }
    }
}
