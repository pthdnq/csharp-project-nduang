using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Component
{
    class Connection
    {
        public string strConnection = @"Server=.\SQLExpress;
        AttachDbFilename=E:\Projects C#\Projects\QLPhuongTien\dev\src\QuanLy_PT.mdf;
        Database=QuanLy_PT;
        Trusted_Connection=Yes;";
        public SqlConnection getConnect()
        {
            return new SqlConnection(strConnection);
        }
    }
}
