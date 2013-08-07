using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
    class PhanBanCtrl
    {
        PhanBanData m_PhanBanData = new PhanBanData();
        public void HienThiComboBox(ComboBox combobox)
        { 
           combobox.DataSource = m_PhanBanData.LayDSBan();
           combobox.DisplayMember = "TenBan";
           combobox.ValueMember = "MaBan";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
           cmbComlumn.DataSource = m_PhanBanData.LayDSBan();
           cmbComlumn.DisplayMember = "TenBan";
           cmbComlumn.ValueMember = "MaBan";
           cmbComlumn.DataPropertyName = "MaBan";
           cmbComlumn.HeaderText = "Tên Ban";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
           BindingSource bs = new BindingSource();
           bs.DataSource = m_PhanBanData.LayDSBan();
           bn.BindingSource = bs;
           dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
           return m_PhanBanData.ThemDongMoi();
        }
        public void ThemBanMoi(DataRow m_Row)
        {
            m_PhanBanData.ThemBan(m_Row);
        }

        public bool LuuBan()
        {
            return m_PhanBanData.LuuBan();
        }

        }
}
