using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class KhoiLopCtrl
    {
        KhoiLopData m_KhoiLopData = new KhoiLopData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_KhoiLopData.LayDSKhoiLop();
            combobox.DisplayMember = "TenKhoiLop";
            combobox.ValueMember = "MaKhoiLop";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_KhoiLopData.LayDSKhoiLop();
            cmbComlumn.DisplayMember = "TenKhoiLop";
            cmbComlumn.ValueMember = "MaKhoiLop";
            cmbComlumn.DataPropertyName = "MaKhoiLop";
            cmbComlumn.HeaderText = "Khối Lớp";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_KhoiLopData.LayDSKhoiLop();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.ThemDongMoi();
        }
        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.ThemKhoiLop(m_Row);
        }

        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.LuuKhoiLop();
        }
    }
}
