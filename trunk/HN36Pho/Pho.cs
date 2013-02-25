using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HN36Pho
{
    class Pho
    {
        DataLayer DL =new DataLayer();
        public bool addPho(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public bool editPho(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public bool delPho(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public DataTable getDataPho(string sqlQuery)
        {
            DataTable dt=DL.getData(sqlQuery);
            return dt;
        }
    }
}
