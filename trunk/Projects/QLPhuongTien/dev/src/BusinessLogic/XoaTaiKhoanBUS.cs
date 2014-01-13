using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
   public class XoaTaiKhoanBUS
    {
       XoaTaiKhoanData m_XoaTaiKhoanData = new XoaTaiKhoanData();
       public bool deleteUserName(string UserName)
       {
          return m_XoaTaiKhoanData.deleteUserName(UserName);
       }

       public DataTable selectTaiKhoan()
       {
           return m_XoaTaiKhoanData.selectTaiKhoan();
       }
    }
}
