using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class DonVi_QuanLy
    {
        Data da = new Data();
        public DataTable ShowDonVi_QuanLy()
        {
            string sql = "select * from DonVi_QuanLy";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm
        public int InsertDonVi_QuanLy(string DonViQL_Ten, string DonViQL_ToTruong, string Sdt, string Email)
        {
            int retval;
            string sql = "Insert Into DonVi_QuanLy (DonViQL_Ten, DonViQL_ToTruong, Sdt, Email) Values (N'" + DonViQL_Ten + "',N'" + DonViQL_ToTruong + "', '" + Sdt + "','" + Email + "')";
            retval = da.ExcuteNonQuery(sql);
            return retval;
        }
        //Sửa
        public void UpdateDonVi_QuanLy(string NguyenMau_ID, string DonViQL_Ten, string DonViQL_ToTruong, string Sdt, string Email)
        {
            string sql = "Update DonVi_QuanLy set  DonViQL_Ten = N'" + DonViQL_Ten + "',DonViQL_ToTruong = N'" + DonViQL_ToTruong + "',Sdt = '" + Sdt + "', Email = '" + Email + "' where NguyenMau_ID = " + NguyenMau_ID + " ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteDonVi_QuanLy(string NguyenMau_ID)
        {
            string sql = "Delete DonVi_QuanLy where NguyenMau_ID = '" + NguyenMau_ID + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
