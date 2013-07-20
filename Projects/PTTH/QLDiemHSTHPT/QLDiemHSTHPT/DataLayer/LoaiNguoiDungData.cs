using System;
using System.Collections.Generic;
using System.Text;
using QLDiemHSTHPT.Component;
using System.Data;
using System.Data.SqlClient;
namespace QLDiemHSTHPT.DataLayer
{
   public class LoaiNguoiDungData
    {
        DataService m_LoaiNguoiDungData = new DataService();
        public DataTable LayDSLoaiNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAINGUOIDUNG");
            m_LoaiNguoiDungData.Load(cmd);
            return m_LoaiNguoiDungData;
        }
        public DataRow ThemDongMoi()
        {
            return m_LoaiNguoiDungData.NewRow();
        }
       public void ThemLoaiNguoiDung(DataRow m_Row)
        {
            m_LoaiNguoiDungData.Rows.Add(m_Row);
        }
       public bool LuuLoaiNguoiDung()
        {
            return m_LoaiNguoiDungData.ExecuteNoneQuery() > 0;
        }
    }
}
