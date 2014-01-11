using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;

namespace BusinessLogic
{
   public class DangKyBUS
    {
       Data data = new Data();
       DangKyData m_DangKyData = new DangKyData();
       public void insert(string UserName, string Pass, string PhanQuyen)
       {
           m_DangKyData.insert(UserName, Pass, PhanQuyen);
       }
    }
}
