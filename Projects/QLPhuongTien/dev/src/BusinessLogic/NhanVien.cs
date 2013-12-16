using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class NhanVien
    {
        Data da = new Data();
        public DataTable ShowNhanVien()
        {
            string sql = "select * from NhanVien";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm
        public void InsertNhanVien(string NhanVienID, string NhanVienTen, string NhanVienSdt, string NhanVienEmail, string NhanVienDC, string DonViTCID)
        {
            // int retval;
            string sql = "Insert into NhanVien ( NhanVienID,NhanVienTen, NhanVienSdt, NhanVienEmail, NhanVienDC , DonViTCID )  Values ('" + NhanVienID + "',N'" + NhanVienTen + "', '" + NhanVienSdt + "','" + NhanVienEmail + "',N'" + NhanVienDC + "','" + DonViTCID + "')";
            // retval =  da.ExcuteNonQuery(sql);
            // return retval; 
            da.ExcuteNonQuery(sql);
        }
        //Sửa
        public void UpdateNhanVien(string NhanVienID, string NhanVienTen, string NhanVienSdt, string NhanVienEmail, string NhanVienDC, string DonViTCID)
        {
            string sql = "Update NhanVien set  NhanVienTen = '" + NhanVienTen + "',NhanVienSdt =" + NhanVienSdt + ",NhanVienEmail ='" + NhanVienEmail + "', NhanVienDC = N'" + NhanVienDC + "',DonViTCID = '" + DonViTCID + "'  where NhanVienID = '" + NhanVienID + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteNhanVien(string NhanVienID)
        {
            string sql = "Delete NhanVien where NhanVienID = '" + NhanVienID + "'";
            da.ExcuteNonQuery(sql);
        }
        public void LuuNhanVien()
        {
            da.LuuNhanVien();
        }
    }
}
