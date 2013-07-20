using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class KQHKMonHocInfo
    {
       public KQHKMonHocInfo()
       { 
       
       }
       private HocSinhInfo m_HocSinh;
       public HocSinhInfo HocSinh
       {
           get { return m_HocSinh; }
           set { m_HocSinh = value; }       
       }

       private LopInfo m_Lop;
       public LopInfo Lop
       {
           get { return m_Lop; }
           set { m_Lop = value; }
       }
       private MonHocInfo m_MonHoc;
       public MonHocInfo MonHoc
       {
           get { return m_MonHoc; }
           set { m_MonHoc = value; }
       }
       private HocKyInfo m_HocKy;
       public HocKyInfo HocKy
       {
           get { return m_HocKy; }
           set { m_HocKy = value; }
       }
       private NamHocInfo m_NamHoc;
       public NamHocInfo NamHoc
       {
           get { return m_NamHoc; }
           set { m_NamHoc = value; }
       }
       private float m_DTBKiemTra;
       public float DTBKiemTra
       {
           get { return m_DTBKiemTra; }
           set { m_DTBKiemTra = value; }
       }
       private float m_DTBMonHocKy;
       public float DTBMonHocKy
       {
           get { return m_DTBMonHocKy; }
           set { m_DTBMonHocKy = value; }
       }
    }
}
