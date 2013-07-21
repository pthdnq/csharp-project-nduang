using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
    public class HanhKiemCtrl
    {
        HanhKiemData m_HanhKiemData = new HanhKiemData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_HanhKiemData.LayDSHanhKiem();
            combobox.DisplayMember = "TenHanhKiem";
            combobox.ValueMember = "MaHanhKiem";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_HanhKiemData.LayDSHanhKiem();
            cmbComlumn.DisplayMember = "TenHanhKiem";
            cmbComlumn.ValueMember = "MaHanhKiem";
            cmbComlumn.DataPropertyName = "MaHanhKiem";
            cmbComlumn.HeaderText = "Hạnh Kiểm";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_HanhKiemData.LayDSHanhKiem();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_HanhKiemData.ThemDongMoi();
        }
        public void ThemHanhKiem(DataRow m_Row)
        {
            m_HanhKiemData.ThemHanhKiem(m_Row);
        }

        public bool LuuHanhKiem()
        {
            return m_HanhKiemData.LuuHanhKiem();
        }
    }
}
