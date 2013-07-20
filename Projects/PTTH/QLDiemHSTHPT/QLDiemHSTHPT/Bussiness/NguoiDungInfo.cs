using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
   public class NguoiDungInfo
    {
       private String m_MaND;
       public String MaND
       {
           get { return m_MaND; }
           set { m_MaND = value; }
       }
       private LoaiNguoiDungInfo m_LoaiND;
       public LoaiNguoiDungInfo LoaiND
       {
           get { return m_LoaiND; }
           set { m_LoaiND = value; }
       }
       private String m_TenND;
       public String TenND
       {
           get { return m_TenND; }
           set { m_TenND = value; }
       }
       private String m_TenDangNhap;
       public String TenDangNhap
       {
           get { return m_TenDangNhap; }
           set { m_TenDangNhap = value; }
       }
       private String m_MatKhau;
       public String MatKhau
       {
           get { return m_MatKhau; }
           set { m_MatKhau = value; }
       }
       
    }
}
