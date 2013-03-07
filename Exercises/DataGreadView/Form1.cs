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
         
        public Form1()
        {
            InitializeComponent();
           
        }

       private void button1_Click(object sender, EventArgs e)
       {
           SqlConnection cnn = new SqlConnection();
           string strAppStart = Application.StartupPath;
           cnn.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + strAppStart + @"\Database\QLSV.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
           
           try
           {
               cnn.Open();
               //MessageBox.Show("thanh cong");//thanh cong ko hien ra, neu loi thi hien thi cho nguoi ta biet
           }
           catch (SqlException)
           {
               MessageBox.Show("that bai");
               return;
           }
            
            string sql = " select * from account";
            SqlDataAdapter ad = new SqlDataAdapter(sql, cnn);
            DataTable t = new DataTable();
            ad.Fill(t);
            dtgv.DataSource = t;
            cnn.Close();
       }
       
    }
}


        
           
