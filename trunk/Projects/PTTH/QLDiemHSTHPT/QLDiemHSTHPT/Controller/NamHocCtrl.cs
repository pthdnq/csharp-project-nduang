using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;


namespace QLDiemHSTHPT.Controller
{
   public class NamHocCtrl
    {

        NamHocData m_NamHocData = new NamHocData();
       public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_NamHocData.LayDSNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_NamHocData.LayDSNamHoc();
            cmbComlumn.DisplayMember = "TenNamHoc";
            cmbComlumn.ValueMember = "MaNamHoc";
            cmbComlumn.DataPropertyName = "MaNamHoc";
            cmbComlumn.HeaderText = "Năm Học";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_NamHocData.LayDSNamHoc();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_NamHocData.ThemDongMoi();
        }
        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.ThemNamHoc(m_Row);
        }

        public bool LuuNamHoc()
        {
            return m_NamHocData.LuuNamHoc();
        }
    }
}
