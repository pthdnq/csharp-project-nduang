using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class DonViQuanLyBUS
    {
        Data da = new Data();
        public DataTable ShowDonVi_QuanLy()
        {
            string sql = "select * from DonViQuanLy";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm
        public void insert(string DonViQLID , string DonViQLTen, string DonViQLToTruong, string Sdt, string Email)
        {
            //int retval;
            string sql = "Insert  DonViQuanLy  Values ('"+DonViQLID+"',N'" + DonViQLTen + "',N'" + DonViQLToTruong + "',' " + Sdt + "','" + Email + "')";
           // retval = da.ExcuteNonQuery(sql);
            //return retval;
            da.ExcuteNonQuery(sql);
        }
        //Sửa
        public void UpdateDonVi_QuanLy(string DonViQLID, string DonViQLTen, string DonViQLToTruong, string Sdt, string Email)
        {
            string sql = "Update DonViQuanLy set  DonViQLTen = N'" + DonViQLTen + "',DonViQLToTruong = N'" + DonViQLToTruong + "',Sdt = " + Sdt + ", Email = '" + Email + "' where DonViQLID ='" + DonViQLID + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteDonVi_QuanLy(string DonViQLID)
        {
            string sql = "Delete DonVi_QuanLy where DonViQLID = '" + DonViQLID + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
