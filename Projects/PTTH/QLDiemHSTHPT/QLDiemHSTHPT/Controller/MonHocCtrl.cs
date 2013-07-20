using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;


namespace QLDiemHSTHPT.Controller
{
   public class MonHocCtrl
    {
        MonHocData m_MonHocData = new MonHocData();
        public void HienThiComboBox(ComboBox combobox)
        {
            combobox.DataSource = m_MonHocData.LayDsMonHoc();
            combobox.DisplayMember = "TenMonHoc";
            combobox.ValueMember = "MaMonHoc";
        }
       public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
       {
           MonHocData m_MHData = new MonHocData();
           comboBox.DataSource = m_MHData.LayDsMonHoc(namHoc, lop);
           comboBox.DisplayMember = "TenMonHoc";
           comboBox.ValueMember = "MaMonHoc";
       }
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbComlumn)
        {
            cmbComlumn.DataSource = m_MonHocData.LayDsMonHoc();
            cmbComlumn.DisplayMember = "TenMonHoc";
            cmbComlumn.ValueMember = "MaMonHoc";
            cmbComlumn.DataPropertyName = "MaMonHoc";
            cmbComlumn.HeaderText = "Môn Học";
        }

       public void HienThiDataGridViewComboBoxColumnGiaoVien(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_MonHocData.LayDsMonHoc();
           cmbColumn.DisplayMember = "TenMonHoc";
           cmbColumn.ValueMember = "MaMonHoc";
           cmbColumn.DataPropertyName = "MaMonHoc";
           cmbColumn.HeaderText = "Chuyên môn";
       }
        public void HienThi(DataGridViewX dgv, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = m_MonHocData.LayDsMonHoc();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
        }
        public DataRow ThemDongMoi()
        {
            return m_MonHocData.ThemDongMoi();
        }
       public void ThemMonHoc(DataRow m_Row)
        {
            m_MonHocData.ThemMonHoc(m_Row);
        }

       public bool LuuMonHoc()
        {
            return m_MonHocData.LuuMonHoc();
        }
    }
}
