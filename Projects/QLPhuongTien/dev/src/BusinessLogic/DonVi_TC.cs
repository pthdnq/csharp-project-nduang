using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;


namespace BusinessLogic
{
    public class DonVi_TC
    {
        Data da = new Data();
        public DataTable ShowDonVi_TC()
        {
            string sql = "select * from DonViTC";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm
        public void InsertDonVi_TC(string DonViTCID , string DonViTCTen, string DonViTCToTruong, string Sdt, string Email)
        {
           // int retval;
            string sql = "Insert  DonViTC  Values ('"+DonViTCID+"','" + DonViTCTen + "','" + DonViTCToTruong + "', " + Sdt + ",'" + Email + "')";
          //  retval = da.ExcuteNonQuery(sql);
           // return retval;
            da.ExcuteNonQuery(sql);
        }
        //Sửa
        public void UpdateDonVi_TC(string DonViTCID, string DonViTCTen, string DonViTCToTruong, string Sdt, string Email)
        {
            string sql = "Update DonViTC set  DonViTCTen = '" + DonViTCTen + "',DonViTCToTruong =  N'" + DonViTCToTruong + "',Sdt = " + Sdt + ", Email = '" + Email + "' where DonViTCID ='" + DonViTCID + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteDonVi_TC(string DonViTCID)
        {
            string sql = "Delete DonViTC where DonViTCID = '" + DonViTCID + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
