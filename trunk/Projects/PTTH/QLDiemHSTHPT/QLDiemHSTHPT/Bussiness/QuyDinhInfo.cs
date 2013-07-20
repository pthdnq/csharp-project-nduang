using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemHSTHPT.Bussiness
{
  public class QuyDinhInfo
    {
    
      private int m_TuoiCanTren;
      public int TuoiCanTren
      {
          get { return m_TuoiCanTren; }
          set { m_TuoiCanTren = value; }
      }

      private int m_TuoiCanDuoi;
      public int TuoiCanDuoi
      {
          get { return m_TuoiCanDuoi; }
          set { m_TuoiCanDuoi = value; }
      }
      private int m_SiSoCanTren;
      public int SiSoCanTren
      {
          get { return m_SiSoCanTren; }
          set { m_SiSoCanTren = value; }
      }

      private int m_SiSoCanDuoi;
      public int SiSoCanDuoi
      {
          get { return m_SiSoCanDuoi; }
          set { m_SiSoCanDuoi = value; }
      }

      private int m_ThangDiem;
      public int ThangDiem
      {
          get { return m_ThangDiem; }
          set { m_ThangDiem = value; }
      }

    }
}
