using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace QLPT
{
    public partial class FrmDanhSachPTTheoDonVi : Form
    {
        DanhSachPTTheoDVBUS m_DanhSachPTTheoDVBUS = new DanhSachPTTheoDVBUS();
        public FrmDanhSachPTTheoDonVi()
        {
            InitializeComponent();
        }

        private void cmbDonViQL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillDVToCombobox()
        {
            cmbDonViQL.DataSource = m_DanhSachPTTheoDVBUS.selectDVQL();
            cmbDonViQL.DisplayMember = "DonViQLTen";
            cmbDonViQL.ValueMember = "DonViQlID";

            cmbDonViTC.DataSource = m_DanhSachPTTheoDVBUS.selectDVTC();
            cmbDonViTC.DisplayMember = "DonViTCTen";
            cmbDonViTC.ValueMember = "DonViTCID";
        }

        private void FrmDanhSachPTTheoDonVi_Load(object sender, EventArgs e)
        {
            fillDVToCombobox();
            fillNameComboboxForcolumdgv();
        }

        private void btDSTheoDVQL_Click(object sender, EventArgs e)
        {
            DataTable dt = m_DanhSachPTTheoDVBUS.selectPTForDonViQL(cmbDonViQL.SelectedValue.ToString().Trim());
            dgvDanhSachPT.DataSource = dt;
        }

        private void btDSTheoDVTC_Click(object sender, EventArgs e)
        {
            dgvDanhSachPT.DataSource = m_DanhSachPTTheoDVBUS.selectPTForDonViTC(cmbDonViTC.SelectedValue.ToString().Trim());
        }
        
        public void fillNameComboboxForcolumdgv()
        {
            //Loại PT
            
            //Loại nguyên mẫu
            DataGridViewComboBoxColumn comboBoxColumnDonVITCID = (DataGridViewComboBoxColumn)dgvDanhSachPT.Columns["NguyenMauID"];
            comboBoxColumnDonVITCID.DataSource = m_DanhSachPTTheoDVBUS.selectNguyenMau();
            comboBoxColumnDonVITCID.DisplayMember = "NguyenMauTen";
            comboBoxColumnDonVITCID.ValueMember = "NguyenMauID";
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
