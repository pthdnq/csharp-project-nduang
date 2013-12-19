using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
    public    class NhanVienBUS
    {

        Data da = new Data();
        NhanVienData m_NhanVienData = new NhanVienData();
      //  DonViTCData m_DonViTCDaTa = new DonViTCData();
        //public DataTable ShowNhanVien()
        //{
        //    string sql = "select * from NhanVien";
        //    DataTable dt = new DataTable();
        //    dt = da.getTable(sql);
        //    return dt;
        //}
       
        public void insert(string NhanVienID, string NhanVienTen, string Sdt, string Email, string DC, string DonViTCID)
        {
            m_NhanVienData.insert(NhanVienID, NhanVienTen, Sdt, Email, DC, DonViTCID);
        }
        public void update(string NhanVienID, string NhanVienTen, string Sdt, string Email, string DC, string DonViTCID)
        {
            m_NhanVienData.update(NhanVienID, NhanVienTen, Sdt, Email, DC, DonViTCID);
        }
        public void delete1(string NhanVienID)
        {
            m_NhanVienData.delete1(NhanVienID);
        }
        public DataTable selectDonViTC()
        {
            return m_NhanVienData.selectDonViTC();
        }
        public DataTable select()
        {
            return m_NhanVienData.select();
        }
    }

}
