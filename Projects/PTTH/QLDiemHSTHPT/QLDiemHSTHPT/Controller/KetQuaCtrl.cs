using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;
namespace QLDiemHSTHPT.Controller
{
    public class KetQuaCtrl
    {
        KetQuaData m_KetQuaData = new KetQuaData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_KetQuaData.LayDSKetQua();
            combobox.DisplayMember = "TenKetQua";
            combobox.ValueMember = "MaKetQua";
        }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_KetQuaData.LayDSKetQua();
            cmbComlumn.DisplayMember = "TenKetQua";
            cmbComlumn.ValueMember = "MaKetQua";
            cmbComlumn.DataPropertyName = "MaKetQua";
            cmbComlumn.HeaderText = "Kết Quả";
        }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_KetQuaData.LayDSKetQua();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_KetQuaData.ThemDongMoi();
        }
        public void ThemKetQua(DataRow m_Row)
        {
            m_KetQuaData.ThemKetQua(m_Row);
        }

        public bool LuuKetQua()
        {
            return m_KetQuaData.LuuKetQua();
        }
    }
}
