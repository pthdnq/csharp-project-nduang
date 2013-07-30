using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.SqlClient;

namespace QLDiemHSTHPT.Component
{
    public partial class frmConnection : Office2007Form
    {
        public frmConnection()
        {
            InitializeComponent();
        }

        private void frmConnection_Load(object sender, EventArgs e)
        {
            cmbAuthentication.SelectedIndex = 0;
        }

       private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
//             if (cmbAuthentication.SelectedIndex == 0)
//                 XML.XMLWriter("Connection.xml", txtserver.Text, cmbdatabase.Text, "true");
//             else
//                 XML.XMLWriter("Connection.xml", txtserver.Text, txtusername.Text, txtmatkhau.Text, cmbdatabase.Text, "false");

            this.DialogResult = DialogResult.OK;
        }

        private void btnTesconnection_Click(object sender, EventArgs e)
        {
            if (cmbAuthentication.SelectedIndex == 0)
           {
               cmbdatabase.Items.Clear();
               SqlConnection m_Connect = new SqlConnection("Data Source=" + txtserver.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Connect);
                SqlDataReader m_DReader;

                try
                {
                    m_Connect.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbdatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBoxEx.Show("Kết nối thành công!", "Succecced", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBoxEx.Show(sqlEx.Message, "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Connect.State == ConnectionState.Open)
                        m_Connect.Close();

                    m_Connect.Dispose();
                    m_Cmd.Dispose();
                }
            }
            if (cmbAuthentication.SelectedIndex == 1)
            {
                cmbdatabase.Items.Clear();
                SqlConnection m_Conn = new SqlConnection("Data Source=" + txtserver.Text + ";Initial Catalog=master;User Id=" + txtusername.Text + ";Password=" + txtmatkhau.Text + ";");
                SqlCommand m_Cmd = new SqlCommand("SP_DATABASES", m_Conn);
                SqlDataReader m_DReader;

                try
                {
                    m_Conn.Open();
                    m_DReader = m_Cmd.ExecuteReader();
                    while (m_DReader.Read())
                    {
                        cmbdatabase.Items.Add(m_DReader[0].ToString());
                    }
                    MessageBoxEx.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException sqlEx)
                {
                    MessageBoxEx.Show(sqlEx.Message, "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (m_Conn.State == ConnectionState.Open)
                        m_Conn.Close();

                    m_Conn.Dispose();
                    m_Cmd.Dispose();
                }
            }
        }
  
        private void cmbAuthentication_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         if (cmbAuthentication.SelectedIndex == 0)
            {
                txtusername.Enabled = false;
                txtmatkhau.Enabled = false;
            }
            else
            {
                txtusername.Enabled = true;
                txtmatkhau.Enabled = true;
            }
        }
    }
}