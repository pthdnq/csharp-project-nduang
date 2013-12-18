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
        DonViQuanLyData m_DonViQuanLyData = new DonViQuanLyData();
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
            m_DonViQuanLyData.insert(DonViQLID, DonViQLTen, DonViQLToTruong, Sdt, Email); 
        }
        //Sửa
        public void update(string strDonViQLID, string strDonViQLTen, string strDonViQLToTruong, string strSdt, string strEmail)
        {
            m_DonViQuanLyData.update(strDonViQLID, strDonViQLTen,  strDonViQLToTruong,  strSdt,  strEmail);
        }
        //xóa
        public void delete1(string strDonViQLID)
        {
            m_DonViQuanLyData.delete1(strDonViQLID);
        }
    }
}
