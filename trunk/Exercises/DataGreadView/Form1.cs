﻿using System;
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
       
        public Form1()
        {
            InitializeComponent();
           
        }

       private void button1_Click(object sender, EventArgs e)
       {
           SqlConnection cnn = new SqlConnection();
           cnn.ConnectionString = @"Data Source=PC2002010102KWW\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True";
           try
           {
               cnn.Open();
               //MessageBox.Show("thanh cong");//thanh cong ko hien ra, neu loi thi hien thi cho nguoi ta biet
           }
           catch (SqlException)
           {
               MessageBox.Show("that bai");
           }
            
          string sql = " select * from account";
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataTable t = new DataTable();
        ad.Fill(t);
           dtgv.DataSource = t;
           cnn.Close();
       }
       public string getConnectionString()
       {
           string conn = "";
           string strAppStart = Application.StartupPath;
           conn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\HN36Pho.mdf;Integrated Security=True;Connect Timeout=3;User Instance=True";
           return conn;
       }
    }
}


        
           
