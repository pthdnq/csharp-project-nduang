using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class HanhKiemData
    {
        DataService m_HanhKiemData = new DataService();
        public DataTable LayDSHanhKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HANHKIEM");
            m_HanhKiemData.Load(cmd);
            return m_HanhKiemData;
        }
        public DataRow ThemDongMoi()
        {
            return m_HanhKiemData.NewRow();
        }
        public void ThemHanhKiem(DataRow m_Row)
        {
            m_HanhKiemData.Rows.Add(m_Row);
        }
        public bool LuuHanhKiem()
        {
            return m_HanhKiemData.ExecuteNoneQuery() > 0;
        }
    }
}
