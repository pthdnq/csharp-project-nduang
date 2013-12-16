using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;


namespace BusinessLogic
{
    
    public class PhuongTien
    {
        Data da = new Data();
        //public DataTable ShowPhuongTien()
        //{
        //    string sql = "SELECT PhuongTien.PhuongTienID,PhuongTien.BienDK,NguyenMauPT.NguyenMauTen , NguyenMauPT.NhanHieu , NguyenMauPT.NangLuc , NguyenMauPT.DonVi , PhuongTien.XuatXu , DonViTC.DonViTCTen , DonViQuanLy.DonViQLTen , PhuongTien.TongVH , PhuongTien.LanBDTX ,PhuongTien.LanTieuTu , PhuongTien.LanTrungTu , PhuongTien.LanDaiTu , NguyenMauPT.NguyenMauChiTiet FROM PhuongTien"+
        //        "INNER JOIN DonViTC on DonViTC.DonVITCID = PhuongTien.DonViTCID"+
        //        "INNER JOIN DonViQuanLy on DonViQuanLy.DonViQLID = PhuongTien.DonViQLID"+
        //        "INNER JOIN NguyenMauPT on PhuongTien.NguyenMauID = NguyenMauPT.NguyenMauID";
        //    DataTable dt = new DataTable();
        //    dt = da.getTable(sql);
        //    return dt;
        //}

        public void InsertPhuongTien(string PhuongTienID, string MaLoaiPT ,string NguyenMauID , string DonViTCID, string DonVIQLID, string BienDK, string NgayVH, string LanBDTX, string LanTieuTu, string LanTrungTu, string LanDaiTu, string XuatXu, string TongVH)
        {
            // int retval;
            string sql = "Insert into PhuongTien  (PhuongTienID, MaLoaiPT ,NguyenMauID ,  DonViTCID, DonVIQLID, BienDK, NgayVH , LanBDTX , LanTieuTu , LanTrungTu ,LanDaiTu, XuatXu, TongVH )  Values ('" + PhuongTienID + "','"+MaLoaiPT+"','"+NguyenMauID+"', N'" + DonViTCID + "', '" + DonVIQLID + "','" + BienDK + "','" + NgayVH + "'," + LanBDTX + " , " + LanTieuTu + ", " + LanTrungTu + ", " + LanDaiTu + " , '" + XuatXu + "' , " + TongVH + ")";
            // retval =  da.ExcuteNonQuery(sql);
            // return retval; 
            da.ExcuteNonQuery(sql);
        }
        public void UpdatePhuongTien(string PhuongTienID, string NguyenMauID, string DonVIQLID, string DonViTCID, string BienDK, string NgayVH, string LanBDTX, string LanTieuTu, string LanTrungTu, string LanDaiTu, string XuatXu, string TongVH)
        {
            string sql = "Update PhuongTien set  NguyenMauID = '" + NguyenMauID + "', DonVIQLID = '" + DonVIQLID + "',DonViTCID = '" + DonViTCID + "',BienDK ='" + BienDK + "', NgayVH = N'" + NgayVH + "',LanBDTX = " + LanBDTX + "  ,LanTieuTu  = " + LanTieuTu + ",LanTrungTu = " + LanTrungTu + ",LanDaiTu = " + LanDaiTu + ",XuatXu = '" + XuatXu + "', TongVH = " + TongVH + " where PhuongTienID = '" + PhuongTienID + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeletePhuongTien(string PhuongTienID)
        {
            string sql = "Delete PhuongTien where PhuongTienID = '" + PhuongTienID + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
