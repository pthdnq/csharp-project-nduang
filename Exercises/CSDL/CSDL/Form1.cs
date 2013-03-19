﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\vs\HN36\HN36Pho\HN36Pho\bin\Debug\Database\HN36Pho.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
               
                conn.Open();
                //Console.WriteLine("connectionString opened !");
                MessageBox.Show("kết nối thành công");
            }
            catch (SqlException sqle)
            {
                
                //Console.WriteLine("Error: " + sqle.Message);
                MessageBox.Show("kết nối thất bại");
            }
            finally
            {
                
                conn.Close();
                //Console.WriteLine("connectionString closed !");
            }
        }

      
    }
}


