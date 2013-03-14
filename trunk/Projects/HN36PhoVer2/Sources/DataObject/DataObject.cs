using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
namespace DataObject
{
    public class DataObject
    {
        private void setStartUpPath(string strStartPath_)
        {
            DatabaseAccess dbAccess = new DatabaseAccess();
            dbAccess.setStartUpPath(strStartPath_);
        }
    }
}
