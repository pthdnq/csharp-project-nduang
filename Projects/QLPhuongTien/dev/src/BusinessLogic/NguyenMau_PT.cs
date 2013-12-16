using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class NguyenMau_PT
    {
        Data da = new Data();
        public DataTable ShowNguyenMau_PT()
        {
            string sql = "select * from NguyenMauPT";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm

        public void InsertNguyenMau_PT(string NguyenMauID, string NguyenMauTen, string NhanHieu, string NangLuc, string DonVi, string BDTX, string TieuTu, string TrungTu, string DaiTu, string NguyenMauChiTiet)
        {
          // int retval;
          //  string sql = "Insert NguyenMauPT Values ('" + NguyenMauID + "',N'" + NguyenMauTen + "', N'" + NhanHieu + "'," + NangLuc + ",'" + DonVi + "'," + BDTX + "," + TieuTu + "," + TrungTu + "," + DaiTu + ",'" + NguyeMauChiTiet + "')";
            string sql = "insert into NguyenMauPT (NguyenMauID ,NguyenMauTen , NhanHieu , NangLuc , DonVi ,BDTX , TieuTu ,TrungTu ,DaiTu ,NguyenMauChiTiet )  Values ('" + NguyenMauID + "',N'" + NguyenMauTen + "', N'" + NhanHieu + "'," + NangLuc + ",'" + DonVi + "'," + BDTX + "," + TieuTu + "," + TrungTu + "," + DaiTu + ",'" + NguyenMauChiTiet + "')";
            // retval =  da.ExcuteNonQuery(sql);
          // return retval; 
             da.ExcuteNonQuery(sql);
        }
        //Sửa
        public void UpdateNguyenMau_PT(string NguyenMauID, string NguyenMauTen, string NhanHieu, string NangLuc, string DonVi, string BDTX, string TieuTu, string TrungTu, string DaiTu, string NguyeMauChiTiet)
        {
            string sql = "Update NguyenMauPT set  NguyenMauTen = '" + NguyenMauTen + "',NhanHieu ='" + NhanHieu + "', NangLuc ='" + NangLuc + "',DonVi ='" + DonVi + "',BDTX =" + BDTX + ",TieuTu =" + TieuTu + ", TrungTu = " + TrungTu + ",DaiTu = " + DaiTu + " , NguyenMauChiTiet = '" + NguyeMauChiTiet + "' where NguyenMauID = '" + NguyenMauID + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteNguyenMau_PT(string NguyenMauID)
        {
            string sql = "Delete NguyenMauPT where NguyenMauID = '" + NguyenMauID + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
