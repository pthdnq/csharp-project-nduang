using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class KQCNMonHocInfo
    {
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

       private NamHocInfo m_NamHoc;
       public NamHocInfo NamHoc
       {
           get { return m_NamHoc; }
           set { m_NamHoc = value; }
       }
       private float m_DiemThiLai;
       public float DiemThiLai1
       {
           get { return m_DiemThiLai; }
           set { m_DiemThiLai = value; }
       }
       private float m_DTBCaNam;
       public float DTBCaNam
       {
           get { return m_DTBCaNam; }
           set { m_DTBCaNam = value; }
       }
    }
}
