using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.Bussiness;
using QLDiemHSTHPT.DataLayer;
using System.Data.OleDb;

using System.Data;

namespace QLDiemHSTHPT.Controller
{
   public class GiaoVienCtrl
    {
       GiaoVienData m_GiaoVienData = new GiaoVienData();

       public void HienThiComboBox(ComboBox comboBox)
       {
           comboBox.DataSource = m_GiaoVienData.LayDsGiaoVien();
           comboBox.DisplayMember = "TenGiaoVien";
           comboBox.ValueMember = "MaGiaoVien";
       }

       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_GiaoVienData.LayDsGiaoVien();
           cmbColumn.DisplayMember = "TenGiaoVien";
           cmbColumn.ValueMember = "MaGiaoVien";
           cmbColumn.DataPropertyName = "MaGiaoVien";
           cmbColumn.HeaderText = "Giáo viên";
       }

      
       public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaGiaoVien,
                            TextBoxX txtTenGiaoVien,
                            TextBoxX txtDiaChi,
                            TextBoxX txtDienThoai,
                            ComboBoxEx cmbMonHoc)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_GiaoVienData.LayDsGiaoVien();

           txtMaGiaoVien.DataBindings.Clear();
           txtMaGiaoVien.DataBindings.Add("Text", bS, "MaGiaoVien");

           txtTenGiaoVien.DataBindings.Clear();
           txtTenGiaoVien.DataBindings.Add("Text", bS, "TenGiaoVien");

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bS, "DiaChi");

           txtDienThoai.DataBindings.Clear();
           txtDienThoai.DataBindings.Add("Text", bS, "DienThoai");

           cmbMonHoc.DataBindings.Clear();
           cmbMonHoc.DataBindings.Add("SelectedValue", bS, "MaMonHoc");

           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }

       public DataRow ThemDongMoi()
       {
           return m_GiaoVienData.ThemDongMoi();
       }


       public void ThemGiaoVien(DataRow m_Row)
       {
           m_GiaoVienData.ThemGiaoVien(m_Row);
       }

       public bool LuuGiaoVien()
       {
           return m_GiaoVienData.LuuGiaoVien();
       }

       public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon,bool gioitinh)
       {
           m_GiaoVienData.LuuGiaoVien(maGiaoVien, tenGiaoVien, diaChi, dienThoai, chuyenMon ,gioitinh);
       }

       public static IList<GiaoVienInfo> LayDsGiaoVien()
       {
           GiaoVienData m_GVData = new GiaoVienData();
           DataTable m_DT = m_GVData.LayDsGiaoVienForReport();

           IList<GiaoVienInfo> dS = new List<GiaoVienInfo>();

           foreach (DataRow Row in m_DT.Rows)
           {
              
               MonHocInfo mh = new MonHocInfo();
               mh.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
               mh.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);
               mh.SoTiet = Convert.ToInt32(Row["SoTiet"]);
               mh.HeSo = Convert.ToInt32(Row["HeSo"]);

               GiaoVienInfo gv = new GiaoVienInfo();
               gv.MaGiaoVien = Convert.ToString(Row["MaGiaoVien"]);
               gv.TenGiaoVien = Convert.ToString(Row["TenGiaoVien"]);
               gv.DiaChi = Convert.ToString(Row["DiaChi"]);
               gv.DienThoai = Convert.ToString(Row["DienThoai"]);
               gv.MonHoc = mh;
               dS.Add(gv);
           }
           return dS;
       }

       public void TimKiemGiaoVien(TextBoxX txtHoTen,
                                  ComboBoxEx cmbTheoDChi,
                                  TextBoxX txtDiaChi,
                                  ComboBoxEx cmbTheoCMon,
                                  ComboBoxEx cmbCMon,
                                  DataGridViewX dGV,
                                  BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_GiaoVienData.TimKiemGiaoVien(txtHoTen.Text, cmbTheoDChi.Text, txtDiaChi.Text, cmbTheoCMon.Text, cmbCMon.Text);
           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }

        public void TimTheoMa(String m_MaGiaoVien)
        {
            m_GiaoVienData.TimTheoMa(m_MaGiaoVien);
        }
        
        public void TimTheoTen(String m_TenGiaoVien)
        {
            m_GiaoVienData.TimTheoTen(m_TenGiaoVien);
        }

       public void Import(string path, DataGridView dgv)
       {
           DataTable dtbGiaoVienExcel = m_GiaoVienData.LayDSGiaoVienExcel(path);
           DataTable GiaoVienTable = m_GiaoVienData.LayDsGiaoVien();

           int rowSuccess = 0;
           for (int i = 0; i < dtbGiaoVienExcel.Rows.Count; i++)
           {
               bool t = false;
               for (int j = 0; j < GiaoVienTable.Rows.Count; j++)
               {
                   if (dtbGiaoVienExcel.Rows[i][0].ToString() != GiaoVienTable.Rows[j][0].ToString())
                   {
                       t = true;
                   }
                   else
                   {
                       t = false;
                       j = GiaoVienTable.Rows.Count;
                   }
               }
               if (t)
               {
                   DataRow rowthem = GiaoVienTable.NewRow();
                   rowthem[0] = dtbGiaoVienExcel.Rows[i][0].ToString();
                   rowthem[1] = dtbGiaoVienExcel.Rows[i][1].ToString();
                   rowthem[2] = dtbGiaoVienExcel.Rows[i][2].ToString();
                   rowthem[3] = dtbGiaoVienExcel.Rows[i][3].ToString();
                   rowthem[4] = dtbGiaoVienExcel.Rows[i][4].ToString();
                                      

                   GiaoVienTable.Rows.Add(rowthem);

                   rowSuccess++;
               }
           }
           MessageBox.Show("Số dòng đã được thêm: " + rowSuccess.ToString() + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
    }
}
