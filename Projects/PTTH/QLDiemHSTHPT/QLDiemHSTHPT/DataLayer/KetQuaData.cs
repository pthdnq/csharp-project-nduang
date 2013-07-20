using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.DataLayer
{
    public class KetQuaData
    {
        DataService m_KetQuaData = new DataService();
        public DataTable LayDSKetQua()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KETQUA");
            m_KetQuaData.Load(cmd);
            return m_KetQuaData;
        }
        public DataRow ThemDongMoi()
        {
            return m_KetQuaData.NewRow();
        }
        public void ThemKetQua(DataRow m_Row)
        {
            m_KetQuaData.Rows.Add(m_Row);
        }
        public bool LuuKetQua()
        {
            return m_KetQuaData.ExecuteNoneQuery() > 0;
        }
       
    }
}
