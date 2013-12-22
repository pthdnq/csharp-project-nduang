using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;


namespace BusinessLogic
{
   public class PhuongTienBUS
    {
        Data da = new Data();
        PhuongTienData m_PhuongTienData = new PhuongTienData();
        public void insert(
           string AutoNum,
           string LoaiPTMa,
           string PhuongTienID,
           string NguyenMauID,
           string DonViQLID,
           string DonViTCID,
           string BienDK,
           string NgayVH,
           string LanBDTX,
           string LanTieuTu,
           string LanTrungTu,
           string LanDaiTu,
           string XuatXu,
           string TongVH
            )
        {
           // return;
            m_PhuongTienData.insert( 
           AutoNum,
           LoaiPTMa,
           PhuongTienID,
           NguyenMauID,
           DonViQLID,
           DonViTCID,
           BienDK,
           NgayVH,
           LanBDTX,
           LanTieuTu,
           LanTrungTu,
           LanDaiTu,
           XuatXu,
           TongVH);
        }



        public void update(
           string AutoNum,
           string LoaiPTMa,
           string PhuongTienID,
           string NguyenMauID,
           string DonViQLID,
           string DonViTCID,
           string BienDK,
           string NgayVH,
           string LanBDTX,
           string LanTieuTu,
           string LanTrungTu,
           string LanDaiTu,
           string XuatXu,
           string TongVH)
        {
           m_PhuongTienData.update
           (
           AutoNum,
           LoaiPTMa,
           PhuongTienID,
           NguyenMauID,
           DonViQLID,
           DonViTCID,
           BienDK,
           NgayVH,
           LanBDTX,
           LanTieuTu,
           LanTrungTu,
           LanDaiTu,
           XuatXu,
           TongVH
           );
        }
        public void delete1(string PhuongTienID)
        {
            m_PhuongTienData.delete1(PhuongTienID);
        }
        public DataTable selectNguyeMau()
        {
            return m_PhuongTienData.selectNguyeMau();
        }
        public DataTable selectLoaiPT()
        {
            return m_PhuongTienData.selectLoaiPT();
        }
        public DataTable selectDonViTC()
        {
            return m_PhuongTienData.selectDonViTC();
        }
        public DataTable selectDonViQL()
        {
            return m_PhuongTienData.selectDonViQL();
        }
       public DataTable select()
        {
            return m_PhuongTienData.select();
        }
       public DataTable selectPhuongTienData_LoaiPT()
       {
           return m_PhuongTienData.selectPhuongTienData_LoaiPT();
       }
       public DataTable selectPhuongTienData_LoaiPT_ByMaLoaiPT(string LoaiPTMa)
       {
           return m_PhuongTienData.selectPhuongTienData_LoaiPT_ByMaLoaiPT(LoaiPTMa);
       }
    }
}
