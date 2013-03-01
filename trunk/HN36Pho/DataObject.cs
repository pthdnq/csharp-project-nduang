using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace HN36Pho
{
    class DataObject
    {
        DataLayer DL =new DataLayer();
        public bool addObject(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public bool editObject(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public bool delObject(string sqlQuery)
        {
            return DL.updateData(sqlQuery);
        }
        public DataTable getDataObject(string sqlQuery)
        {
            DataTable dt=DL.getData(sqlQuery);
            return dt;
        }
    }
}
