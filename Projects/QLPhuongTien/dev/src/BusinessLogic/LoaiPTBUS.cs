using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using System.Data;


namespace BusinessLogic
{
    public class LoaiPTBUS
    {
        Data data = new Data();
        LoaiPTData m_LoaiPTData = new LoaiPTData();
        public void insert(string LoaiPTMa
            , string LoaiPTTen
            , string CongThucVH
            )
        {
            m_LoaiPTData.insert(LoaiPTMa
                , LoaiPTTen
                , CongThucVH
               );
        }
        public void update(string LoaiPTMa
            , string LoaiPTTen
            , string CongThucVH
            )
        {
            m_LoaiPTData.update(LoaiPTMa
                , LoaiPTTen
                , CongThucVH
                );
        }
        public void delete1(string LoaiPTMa)
        {
            m_LoaiPTData.delete1(LoaiPTMa);
        }
        public DataTable select()
        {
            return m_LoaiPTData.select();
        }
        public bool exist(string LoaiPTMa)
        {
            return m_LoaiPTData.exist(LoaiPTMa);
        }
        public DataTable selectCongThucVH()
        {
            DataTable dt = m_LoaiPTData.selectCongThucVH();
            int count = dt.Rows.Count;
            return m_LoaiPTData.selectCongThucVH();
        }
    }
}
