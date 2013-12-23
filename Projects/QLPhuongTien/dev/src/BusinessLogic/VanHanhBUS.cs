using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
   
    
   public class VanHanhBUS
    {
       Data da = new Data();
       VanHanhData m_VanHanhData = new VanHanhData();
       public void insert(
            string VanHanhID,
            string PhuongTienID,
            string NgayVanHanh,
            string VanHanh,
            string VanHanhDV,
            string CaLamViec,
            string NhanVienID,
            string DonViTCID,
            string MoTa
         )
       {
           // return;
           m_VanHanhData.insert(
               VanHanhID,
               PhuongTienID,
               NgayVanHanh,
               VanHanh,
               VanHanhDV,
               CaLamViec,
               NhanVienID,
               DonViTCID,
               MoTa);
       
       }
       public void update(
            string VanHanhID,
            string PhuongTienID,
            string NgayVanHanh,
            string VanHanh,
            string VanHanhDV,
            string CaLamViec,
            string NhanVienID,
            string DonViTCID,
            string MoTa)
       {
           m_VanHanhData.update
           (
               VanHanhID,
               PhuongTienID,
               NgayVanHanh,
               VanHanh,
               VanHanhDV,
               CaLamViec,
               NhanVienID,
               DonViTCID,
               MoTa
           );
       }
       public void delete1(string VanHanhID)
       {
           m_VanHanhData.delete1(VanHanhID);
       }
       public DataTable selectVanHanh()
       {
           return m_VanHanhData.select();
       }
       public DataTable selectNhanVien()
       {
           return m_VanHanhData.selectNhanVien();
       }
       public DataTable selectDonViTC()
       {
           return m_VanHanhData.selectDonViTC();
       }
       public DataTable selectPhuongTien()
       {
           return m_VanHanhData.selectPhuongTien();
       }
       public DataTable selectVanHanh_TenPhuongTien()
       {
           return m_VanHanhData.selectVanHanh_TenPhuongTien();
       }
       public DataTable getTongVanHanh()
       {
           return m_VanHanhData.getTongVanHanh();
       }
       public DataTable update_TongVHToPhuongTien(string PhuongTienID, string TongVH)
       {
           return m_VanHanhData.update_TongVHToPhuongTien(PhuongTienID, TongVH);
       }
       public DataTable getMocBaoTriForPhuongTien()
       {
           return m_VanHanhData.getMocBaoTriForPhuongTien();
       }
       public DataTable update_LanBaoTri(
          string PhuongTienID,
          string LanBDTX,
          string LanTieuTu,
          string LanTrungTu,
          string LanDaiTu)
       {

           return m_VanHanhData.update_LanBaoTri(
                          PhuongTienID,
                          LanBDTX,
                          LanTieuTu,
                          LanTrungTu,
                          LanDaiTu
               );
       }
    }
}
