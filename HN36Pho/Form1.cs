using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HN36Pho
{
    public partial class frmMainA : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMainA()
        {
            InitializeComponent();
        }

        private void frmMainA_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\ProjectsC++&C#\C#\HN36Pho\HN36Pho\Database\HN36Pho.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from account",conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dGView.DataSource = dt;
        }
    }
}
