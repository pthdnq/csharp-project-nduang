using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class LoaiDiemCtrl
    {
        LoaiDiemData m_LoaiDiemData = new LoaiDiemData();        
        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            comboBox.DisplayMember = "TenLoaiDiem";
            comboBox.ValueMember = "MaLoaiDiem";
        }
        
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            cmbColumn.DisplayMember = "TenLoaiDiem";
            cmbColumn.ValueMember = "MaLoaiDiem";
            cmbColumn.DataPropertyName = "MaLoaiDiem";
            cmbColumn.HeaderText = "Loại điểm";
        }
        
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_LoaiDiemData.LayDsLoaiDiem();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        
        public DataRow ThemDongMoi()
        {
            return m_LoaiDiemData.ThemDongMoi();
        }

        public void ThemLoaiDiem(DataRow m_Row)
        {
            m_LoaiDiemData.ThemLoaiDiem(m_Row);
        }
       
        public bool LuuLoaiDiem()
        {
            return m_LoaiDiemData.LuuLoaiDiem();
        }
       
    }
}