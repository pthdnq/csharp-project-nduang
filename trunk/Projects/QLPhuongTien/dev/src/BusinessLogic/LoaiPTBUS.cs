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
        public void insert(string LoaiPTMa, string LoaiPTTen)
        {
            m_LoaiPTData.insert(LoaiPTMa, LoaiPTTen);
        }
        public void update(string LoaiPTMa, string LoaiPTTen)
        {
            m_LoaiPTData.update(LoaiPTMa, LoaiPTTen);
        }
        public void delete1(string LoaiPTMa)
        {
            m_LoaiPTData.delete1(LoaiPTMa);
        }
        public DataTable select()
        {
            return m_LoaiPTData.select();
        }
    }
}
