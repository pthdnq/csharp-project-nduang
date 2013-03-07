using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlTypes;

namespace DataGreadView
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            cnn.ConnectionString = @"Data Source=PC2002010102KWW\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            DataTable dt = new DataTable();
            string sql = " seclect * from account";
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            ad.Fill(dt);
            cnn.Close();


        }
    }
}


        
           
