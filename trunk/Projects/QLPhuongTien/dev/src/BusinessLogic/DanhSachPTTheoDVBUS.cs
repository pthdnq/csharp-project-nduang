using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;



namespace BusinessLogic
{
    public class DanhSachPTTheoDVBUS
    {
        DanhSachPTTheoDVData m_DanhSachPTTheoDVData = new DanhSachPTTheoDVData();
        
        public DataTable selectDVTC()
        {
            return m_DanhSachPTTheoDVData.selectDVTC();
        }

        public DataTable selectDVQL()
        {
            return m_DanhSachPTTheoDVData.selectDVQL();
        }

         public DataTable selectPTForDonViTC(string DonViTCID)
        {
            return m_DanhSachPTTheoDVData.selectPTForDonViTC(DonViTCID);
        }

         public DataTable selectPTForDonViQL(string DonViQLID)
         {
             return m_DanhSachPTTheoDVData.selectPTForDonViQL(DonViQLID);
         }
        public DataTable selectAllPT()
        {
            return m_DanhSachPTTheoDVData.selectAllPT();
        }
        public DataTable selectLoaiPTandTenNguyenMauForComboboxDgv()
        {
            return m_DanhSachPTTheoDVData.selectLoaiPTandTenNguyenMauForComboboxDgv();
        }
        public DataTable selectNguyenMau()
        {
            return m_DanhSachPTTheoDVData.selectNguyenMau();
        }
        public DataTable selectLoaiPT()
        {
            return m_DanhSachPTTheoDVData.selectLoaiPT();
        }
    }
}
