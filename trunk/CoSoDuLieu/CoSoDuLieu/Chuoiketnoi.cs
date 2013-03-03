using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CoSoDuLieu
{
     class Chuoiketnoi
    {
        public static void Main()
        {
            string connectionString = @"Data Source=QUANGTHO-PC\SQLEXPRESS;Initial Catalog=E:\PROJECTSC++&C#\C#\HN36PHO\HN36PHO\DATABASE\HN36PHO.MDF;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
        }


    }
}
