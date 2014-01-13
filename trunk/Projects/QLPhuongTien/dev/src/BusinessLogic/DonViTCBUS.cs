using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
  public  class DonViTCBUS
    {
        Data da = new Data();
        DonViTCData m_DonViTCData = new DonViTCData();
        //public DataTable ShowDonViTC()
        //{
        //    string sql = "select * from DonViTC";
        //    DataTable dt = new DataTable();
        //    dt = da.getTable(sql);
        //    return dt;
        //}
      
      
        //Thêm
        public void insert(string DonViTCID, string DonViTCTen,  string Sdt, string Email)
        {
            m_DonViTCData.insert(DonViTCID, DonViTCTen,  Sdt, Email);
        }
        //Sửa
        public void update(string strDonViTCID, string strDonViTCTen, string strSdt, string strEmail)
        {
            m_DonViTCData.update(strDonViTCID, strDonViTCTen, strSdt, strEmail);
        }
        //xóa
        public void delete1(string strDonViTCID)
        {
            m_DonViTCData.delete1(strDonViTCID);
        }
        public DataTable selectDonViTC()
        {
            return m_DonViTCData.select();
        }
      
    }
}
