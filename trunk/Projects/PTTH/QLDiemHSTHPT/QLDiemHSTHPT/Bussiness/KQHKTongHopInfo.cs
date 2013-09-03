using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class KQHKTongHopInfo
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
       private HocLucInfo m_HocLuc;
       public HocLucInfo HocLuc
       {
           get { return m_HocLuc; }
           set { m_HocLuc = value; }
       }
       private HanhKiemInfo m_HanhKiem;
       public HanhKiemInfo HanhKiem
       {
           get { return m_HanhKiem; }
           set { m_HanhKiem = value; }
       }
       private float m_DTBMonHocKy;
       public float DTBMonHocKy
       {
           get { return m_DTBMonHocKy; }
           set { m_DTBMonHocKy = value; }
       }
       private String m_DanhHieuHS;
       public String DanhHieuHS
       {
           get { return m_DanhHieuHS; }
           set { m_DanhHieuHS = value; }       
       }

    
   
   }
}
