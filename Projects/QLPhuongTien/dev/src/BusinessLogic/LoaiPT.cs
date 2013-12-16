using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public class LoaiPT
    {
        Data da = new Data();
        public DataTable ShowLoaiPT()
        {
            string sql = "select * from LoaiPT";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;
        }
        //Thêm
        public void InsertLoaiPT(string LoaiPT_Ma,  string LoaiPT_Ten)
        {
            // int retval;
            string sql = "Insert LoaiPT Values ('" + LoaiPT_Ma + "', N'" + LoaiPT_Ten + "')";
            // retval =  da.ExcuteNonQuery(sql);
            // return retval; 
            da.ExcuteNonQuery(sql);
        }
        //Sửa
        public void UpdateLoaiPT(string LoaiPT_Ma,  string LoaiPT_Ten)
        {
            string sql = "Update NguyenMau_PT set  LoaiPT_Ten = N'" + LoaiPT_Ten + "' where LoaiPT_Ma = '" + LoaiPT_Ma + "' ";
            da.ExcuteNonQuery(sql);
        }
        //xóa
        public void DeleteLoaiPT(string LoaiPT_Ma)
        {
            string sql = "Delete LoaiPT where LoaiPT_Ma = '" + LoaiPT_Ma + "'";
            da.ExcuteNonQuery(sql);
        }
    }
}
