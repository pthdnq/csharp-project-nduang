using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class HocKyCtrl
    {
        HocKyData m_HocKyData = new HocKyData();
       
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocKyData.LayDsHocKy();
            comboBox.DisplayMember = "TenHocKy";
            comboBox.ValueMember = "MaHocKy";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocKyData.LayDsHocKy();
            cmbColumn.DisplayMember = "TenHocKy";
            cmbColumn.ValueMember = "MaHocKy";
            cmbColumn.DataPropertyName = "MaHocKyLuc";
            cmbColumn.HeaderText = "Học kỳ";
        }
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocKyData.LayDsHocKy();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_HocKyData.ThemDongMoi();
        }

        public void ThemHocKy(DataRow m_Row)
        {
            m_HocKyData.ThemHocKy(m_Row);
        }
        public bool LuuHocKy()
        {
            return m_HocKyData.LuuHocKy();
        }
    }
}
