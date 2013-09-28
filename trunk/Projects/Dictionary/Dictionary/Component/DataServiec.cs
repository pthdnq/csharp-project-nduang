using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace QLDiemHSTHPT
{
    public partial class Component1 : DataTable
    {
        public Component1()
        {

        }
        private static SqlConnection m_Connection;
        public static String m_ConnectString = "";
        private SqlCommand m_Command;
        private SqlDataAdapter m_DataAdapter;

    }
}