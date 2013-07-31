using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;
//using System.Data.Odbc;
using System.Windows.Forms;
using System.Data.OleDb;


namespace QLDiemHSTHPT.Component
{
    partial class DataServiceIOExcel
    {
        public DataServiceIOExcel()
        {

        }

        private OleDbConnection m_Connection;

        public OleDbConnection Connection
        {
            get { return m_Connection; }
            set { m_Connection = value; }
        }

        private OleDbDataAdapter m_DataAdapter;

        public OleDbDataAdapter DataAdapter
        {
            get { return m_DataAdapter; }
            set { m_DataAdapter = value; }
        }

        private OleDbCommand m_Command;

        public OleDbCommand Command
        {
            get { return m_Command; }
            set { m_Command = value; }
        }

        public void Connect(string path)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                //Create connection string to Excel work book
                string extension = "";
                string excelConnectionString = "";
                if(path.Contains(".xls"))
                {
                    extension = ".xls";
                }
                if (extension == ".xls")
                {
                    excelConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path +
                                                          ";Extended Properties=Excel 8.0;Persist Security Info=False";
                }
                else
                {
                    excelConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path +
                                                         ";Extended Properties=Excel 12.0;Persist Security Info=False";
                }

                try
                {
                    m_Connection = new OleDbConnection(excelConnectionString);
                    m_Connection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Kết nối cơ sở dữ liệu không thành công.", "Thông báo");
                }
            }
        }

        public DataTable Load(OleDbCommand command, string path)
        {
            this.Connect(path);

            m_Command = command;
            m_Command.Connection = m_Connection;

            m_DataAdapter = new OleDbDataAdapter(m_Command);


            DataSet dataSet = new DataSet();

            m_DataAdapter.Fill(dataSet, "[Sheet1$]");

            DataTable dtb = dataSet.Tables["[Sheet1$]"];
            m_Connection.Close();
            return dtb;


        }
    }
}
