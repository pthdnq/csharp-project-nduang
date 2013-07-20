using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
   public class TonGiaoData
    {
        DataService m_TonGiaoData = new DataService();
        public DataTable LayDSTonGiao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TONGIAO");
            m_TonGiaoData.Load(cmd);
            return m_TonGiaoData;
        }
        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.NewRow();
        }
        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.Rows.Add(m_Row);
        }
        public bool LuuTonGiao()
        {
            return m_TonGiaoData.ExecuteNoneQuery() > 0;
        }
    }
}
