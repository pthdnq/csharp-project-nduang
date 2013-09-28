using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QLDiemHSTHPT.Controller;
using QLDiemHSTHPT.Component;
using QLDiemHSTHPT;


namespace QLDiemHSTHPT
{
    public partial class frmSetting : Office2007Form
    {
        DictionaryCtrl m_DictionaryCtrl = new DictionaryCtrl();
        QuyDinh m_QuyDinh = new QuyDinh();
        public frmSetting()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {

            m_DictionaryCtrl.ShowData(dgvDictionary, bdgDictionary);
        }

        private void bngThemmoi_Click(object sender, EventArgs e)
        {
            DataRow m_Row = m_DictionaryCtrl.NewRow();
            m_Row["ID_Word"] = "WD" + m_QuyDinh.LaySTT(dgvDictionary.Rows.Count + 1);
            m_Row["Word"] = "";
            m_Row["Meaning"] = "";
            m_DictionaryCtrl.AddRow(m_Row);

            bdgDictionary.BindingSource.MoveLast();
        }

        private void bngXoa_Click(object sender, EventArgs e)
        {
            if (dgvDictionary.RowCount == 0)
                bngXoa.Enabled = false;

            else if (MessageBoxEx.Show("Bạn có chắc chắn xóa dòng này không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bdgDictionary.BindingSource.RemoveCurrent();
            }
        }

        public Boolean KiemTraTruocKhiLuu(String cellString)
        {
            foreach (DataGridViewRow row in dgvDictionary.Rows)
            {
                if (row.Cells[cellString].Value != null)
                {
                    String str = row.Cells[cellString].Value.ToString();
                    if (str == "")
                    {
                        MessageBoxEx.Show("Thông tin của từ " + row.Cells["Word"].Value.ToString() + " không hợp lệ!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            return true;
        }

        private void bngluu_Click(object sender, EventArgs e)
        {
            dgvDictionary.EndEdit();
            if (KiemTraTruocKhiLuu("ID_Word") == true &&
                KiemTraTruocKhiLuu("Word") == true &&
                KiemTraTruocKhiLuu("Meaning") == true)
            {
                bindingNavigatorPositionItem.Focus();
                m_DictionaryCtrl.LuuHocSinh();

            }

        }

        private void bngthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m_DictionaryCtrl.ShowData(dgvDictionary, bdgDictionary);
        }

        void SearchDictionary()
        {
            if (chbSearchByWord.Checked == true)
            {
                m_DictionaryCtrl.SearchByWord(txtSearchText.Text);
            }
            else
            {
                m_DictionaryCtrl.SearchByMeaning(txtSearchText.Text);
            }
        }
        private void buttonX6_Click(object sender, EventArgs e)
        {
            SearchDictionary();
        }
    }


}