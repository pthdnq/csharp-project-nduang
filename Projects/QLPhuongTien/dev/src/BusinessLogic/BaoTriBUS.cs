using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
   public class BaoTriBUS
    {
       public int LanBDTX = 0;
       public int LanTieuTu = 0;
       public int LanTrungTu = 0;
       public int LanDaiTu = 0;
       
       public void tinhSoLanBaoTri(float BDTX,float TieuTu,float TrungTu,float DaiTu,float TongVH)
       {
           LanDaiTu =(int)(TongVH / DaiTu);
           float du1 = TongVH - LanDaiTu * DaiTu;
           LanTrungTu = (int)(du1 / TrungTu);
           float du2 = du1 - LanTrungTu * TrungTu;
           LanTieuTu = (int)(du2 / TieuTu);
           float du3 = du2 - LanTieuTu * TieuTu;
           LanBDTX = (int)(du3 / BDTX);
       }
    }
}
