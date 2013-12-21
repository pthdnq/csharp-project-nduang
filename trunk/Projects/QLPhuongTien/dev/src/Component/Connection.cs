using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Component
{
    class Connection
    {
        public string strConnection = @"Data Source=(local);Initial Catalog=QuanLy_PT;Integrated Security=True";
        public SqlConnection getConnect()
        {
            return new SqlConnection(strConnection);
        }
    }
}
