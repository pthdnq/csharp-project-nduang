using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;


namespace BusinessLogic
{
   public class TimKiemBUS
    {
       Data da = new Data();
       TimKiemData m_TimKiemData = new TimKiemData();
       PhuongTienBUS m_PhuongTienBUS = new PhuongTienBUS();
      // NguyenMauPTBUS m_NguyenMauPTBUS = new NguyenMauPTBUS();
       public DataTable timKiemFormMain(string PhuongTienID, string NhanHieu, string NangLuc)
       {
           return m_TimKiemData.timKiemonFormMain(PhuongTienID, NhanHieu, NangLuc);
       }
       public DataTable selectNhanHieu()
       {
           return m_TimKiemData.selectNhanHieu();
       }
       public DataTable selectLoaiPT()
       {
           return m_TimKiemData.selectLoaiPT();
       }
       public DataTable selectNangLucByLoaiPT(string LoaiPTMa)
       {
           return m_TimKiemData.selectNangLucByLoaiPT(LoaiPTMa);
       }
    }
}
