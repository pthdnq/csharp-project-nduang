using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAcess;
using Component;
namespace GenerateData
{
    public class GenerateDataToTables
    {
        DonViQuanLyData m_DonViQuanLyData = new DonViQuanLyData();
        Utils utils = new Utils();
        public void generateDonViQuanLyData()
        {
            string DonViQLID
            , DonViQLTen
            , DonViQLToTruong
            , Sdt
            , Email;
            for (int i = 0; i < 100;i++ )
            {
                DonViQLID = "DVQL" + utils.convertIntToFormatedString(i);
                DonViQLTen = "Đơn vị quản lý số " + i.ToString();
                DonViQLToTruong = "Bằng Còi " + i.ToString();
                Sdt = (1638543534 + i).ToString();
                Email = "bangcoi2013_"+i.ToString()+"@"+"gmail.com";

                m_DonViQuanLyData.insert
                (
                    DonViQLID
                  , DonViQLTen
                  , DonViQLToTruong
                  , Sdt
                  , Email
                );
            }

        }
    }
}
