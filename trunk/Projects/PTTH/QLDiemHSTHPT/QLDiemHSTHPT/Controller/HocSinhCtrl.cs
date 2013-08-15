using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;
using QLDiemHSTHPT.Bussiness;
using DevComponents.Editors.DateTimeAdv;


namespace QLDiemHSTHPT.Controller
{
   public class HocSinhCtrl
    {
       HocSinhData m_HocSinhData = new HocSinhData();

       public void HienThiComboBox(ComboBoxEx comboBox)
       {
           comboBox.DataSource = m_HocSinhData.LayDsHocSinh();
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       //nhap diem
       public void HienThiComboBox(String namHoc, String lop, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiComboBox(String namHoc, String lop,String maHS, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoMa(namHoc, lop,maHS);
           comboBox.DisplayMember = "HoTen";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiComboBoxMaHS(String namHoc, String lop, ComboBoxEx comboBox)
       {
           HocSinhData m_HSData = new HocSinhData();
           comboBox.DataSource = m_HSData.LayDsHocSinhTheoLop(namHoc, lop);
           comboBox.DisplayMember = "MaHocSinh";
           comboBox.ValueMember = "MaHocSinh";
       }

       public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
       {
           cmbColumn.DataSource = m_HocSinhData.LayDsHocSinh();
           cmbColumn.DisplayMember = "HoTen";
           cmbColumn.ValueMember = "MaHocSinh";
           cmbColumn.DataPropertyName = "MaHocSinh";
           cmbColumn.HeaderText = "Học sinh";
       }



       public void HienThi(DataGridViewX dGV,
                            BindingNavigator bN,
                            TextBoxX txtMaHocSinh,
                            TextBoxX txtTenHocSinh,
                            TextBoxX txtGioiTinh,
                            CheckBoxX ckbGTinhNam,
                            CheckBoxX ckbGTinhNu,
                            DateTimeInput dtpNgaySinh,
                            TextBoxX txtNoiSinh,
                            ComboBoxEx cmbDanToc,
                            ComboBoxEx cmbTonGiao,
                            TextBoxX txtHoTenCha,
                            ComboBoxEx cmbNgheNghiepCha,
                            TextBoxX txtHoTenMe,
                            ComboBoxEx cmbNgheNghiepMe, 
                            ComboBoxEx cmbNamHoc,
                            ComboBoxEx cmbKhoiLop,
                            ComboBoxEx cmbLop)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_HocSinhData.LayDsHocSinh();

           DataTable dT = m_HocSinhData.LayDsHocSinh();
           bool gioiTinh = Convert.ToBoolean(dT.Rows[0]["GioiTinh"]);

           if (gioiTinh)
               ckbGTinhNu.Checked = true;
           else
               ckbGTinhNam.Checked = true;

           txtMaHocSinh.DataBindings.Clear();
           txtMaHocSinh.DataBindings.Add("Text", bS, "MaHocSinh");

           txtTenHocSinh.DataBindings.Clear();
           txtTenHocSinh.DataBindings.Add("Text", bS, "HoTen");

           txtGioiTinh.DataBindings.Clear();
           txtGioiTinh.DataBindings.Add("Text", bS, "GioiTinh");

           dtpNgaySinh.DataBindings.Clear();
           dtpNgaySinh.DataBindings.Add("Value", bS, "NgaySinh");

           txtNoiSinh.DataBindings.Clear();
           txtNoiSinh.DataBindings.Add("Text", bS, "NoiSinh");

           cmbDanToc.DataBindings.Clear();
           cmbDanToc.DataBindings.Add("SelectedValue", bS, "MaDanToc");

           cmbTonGiao.DataBindings.Clear();
           cmbTonGiao.DataBindings.Add("SelectedValue", bS, "MaTonGiao");

           txtHoTenCha.DataBindings.Clear();
           txtHoTenCha.DataBindings.Add("Text", bS, "HoTenCha");

           cmbNgheNghiepCha.DataBindings.Clear();
           cmbNgheNghiepCha.DataBindings.Add("SelectedValue", bS, "MaNgheNghiepCha");

           txtHoTenMe.DataBindings.Clear();
           txtHoTenMe.DataBindings.Add("Text", bS, "HoTenMe");

           cmbNgheNghiepMe.DataBindings.Clear();
           cmbNgheNghiepMe.DataBindings.Add("SelectedValue", bS, "MaNgheNghiepMe");

           cmbNamHoc.DataBindings.Clear();
           cmbNamHoc.DataBindings.Add("SelectedValue", bS, "MaNamHoc");

           cmbKhoiLop.DataBindings.Clear();
           cmbKhoiLop.DataBindings.Add("SelectedValue", bS, "MaKhoiLop");

           cmbLop.DataBindings.Clear();
           cmbLop.DataBindings.Add("SelectedValue", bS, "MaLop");

           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }

       //nhap diem
       public void HienThiDsHocSinhTheoLop(DataGridViewX dGV, BindingNavigator bN, String namHoc, String lop)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_HocSinhData.LayDsHocSinhTheoLop(namHoc, lop);

           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }





       //phan lop
       public DataTable HienThiDsHocSinhTheoNamHoc(String namHoc)
       {
           return m_HocSinhData.LayDsHocSinhTheoNamHoc(namHoc);
       }

       public DataTable HienThiDsHocSinhTheoLop(String lop)
       {
           return m_HocSinhData.LayDsHocSinhTheoLop(lop);
       }

       public void XoaHSKhoiBangPhanLop(String namHocCu, String khoiLopCu, String lopCu, ListViewEx hocSinh)
       {
           foreach (ListViewItem item in hocSinh.Items)
           {
               m_HocSinhData.XoaHSKhoiBangPhanLop(namHocCu, khoiLopCu, lopCu, item.SubItems[0].Text.ToString());
           }
       }

       public void LuuHSVaoBangPhanLop(String namHocMoi, String khoiLopMoi, String lopMoi, ListViewEx hocSinh)
       {
           foreach (ListViewItem item in hocSinh.Items)
           {
               m_HocSinhData.LuuHSVaoBangPhanLop(namHocMoi, khoiLopMoi, lopMoi, item.SubItems[0].Text.ToString());
           }
       }

       //report
       public static IList<HocSinhInfo> LayDsHocSinh()
       {
           HocSinhData m_HSData = new HocSinhData();
           DataTable m_DT = m_HSData.LayDsHocSinhForReport();

           IList<HocSinhInfo> dS = new List<HocSinhInfo>();

           foreach (DataRow Row in m_DT.Rows)
           {
               HocSinhInfo hs = new HocSinhInfo();

               NgheNghiepInfo nn = new NgheNghiepInfo();
               nn.MaNgheNghiep = Convert.ToString(Row["MaNgheNghiep"]);
               nn.TenNgheNghiep = Convert.ToString(Row["TenNgheNghiep"]);

               DanTocInfo dt = new DanTocInfo();
               dt.MaDanToc = Convert.ToString(Row["MaDanToc"]);
               dt.TenDanToc = Convert.ToString(Row["TenDanToc"]);

               TonGiaoInfo tg = new TonGiaoInfo();
               tg.MaTonGiao = Convert.ToString(Row["MaTonGiao"]);
               tg.TenTonGiao = Convert.ToString(Row["TenTonGiao"]);

               hs.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
               hs.HoTen = Convert.ToString(Row["HoTen"]);
               hs.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
               hs.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
               hs.NoiSinh = Convert.ToString(Row["NoiSinh"]);
               hs.DanToc = dt;
               hs.TonGiao = tg;
               hs.HoTenCha = Convert.ToString(Row["HoTenCha"]);
               hs.NgheNghiepCha = nn;
               hs.HoTenMe = Convert.ToString(Row["HoTenMe"]);
               hs.NgheNghiepMe = nn;

               dS.Add(hs);
           }
           return dS;
       }

       public DataRow ThemDongMoi()
       {
           return m_HocSinhData.ThemDongMoi();
       }

       public void ThemHocSinh(DataRow m_Row)
       {
           m_HocSinhData.ThemHocSinh(m_Row);
       }

       public bool LuuHocSinh()
       {
           return m_HocSinhData.LuuHocSinh();
       }

       public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe,String maNamHoc,String maKhoiLop,String maLop)
       {
           m_HocSinhData.LuuHocSinh(maHocSinh, hoTen, gioiTinh, ngaySinh, noiSinh, maDanToc, maTonGiao, hoTenCha, maNgheCha, hoTenMe, maNgheMe, maNamHoc, maKhoiLop, maLop);
       }

      
       public void TimKiemHocSinh(TextBoxX txtHoTen,
                                   ComboBoxEx cmbTheoNSinh,
                                   TextBoxX txtNoiSinh,
                                   ComboBoxEx cmbTheoDToc,
                                   ComboBoxEx cmbDanToc,
                                   ComboBoxEx cmbTheoTGiao,
                                   ComboBoxEx cmbTonGiao,
                                   DataGridViewX dGV,
                                   BindingNavigator bN)
       {
           BindingSource bS = new BindingSource();
           bS.DataSource = m_HocSinhData.TimKiemHocSinh(txtHoTen.Text, cmbTheoNSinh.Text, txtNoiSinh.Text, cmbTheoDToc.Text, cmbDanToc.Text, cmbTheoTGiao.Text, cmbTonGiao.Text);

           bN.BindingSource = bS;
           dGV.DataSource = bS;
       }
       public static void TimTheoMa(ListViewEx lvw, String m_MaHocSinh)
       {
           HocSinhData data = new HocSinhData();
           DataTable table= data.TimTheoMa(m_MaHocSinh);
           lvw.Items.Clear();
           foreach (DataRow row in table.Rows)
           {
               ListViewItem item = new ListViewItem(row["MAHOCSINH"].ToString());
               item.SubItems.Add(row["HOTEN"].ToString());
               lvw.Items.Add(item);
           }

       }

       //hien thi ds trong phan lop
       public static void HienThiDsHocSinhTheoLop(String namHoc, String khoiLop, String lop, ListViewEx lV)
       {
           HocSinhData data = new HocSinhData();
           DataTable m_DT = data.LayDsHocSinhTheoLop(namHoc, khoiLop, lop);
           int i = m_DT.Rows.Count;
           lV.Items.Clear();
           foreach (DataRow Row in m_DT.Rows)
           {
               ListViewItem item = new ListViewItem();
               item.Text = Row["MaHocSinh"].ToString();
               item.SubItems.Add(Row["HoTen"].ToString());

               lV.Items.Add(item);
           }
       }

       public static void HienThiDsHocSinhChuaPL(ListViewEx lV)
       {
           HocSinhData data = new HocSinhData();
           DataTable m_DT = data.TimHSChuaPL();
           lV.Items.Clear();
           foreach (DataRow Row in m_DT.Rows)
           {
               ListViewItem item = new ListViewItem(Row["MAHOCSINH"].ToString());
               item.SubItems.Add(Row["HOTEN"].ToString());

               lV.Items.Add(item);
           }

       }

       public static void TimTheoTen(ListViewEx lvw, String m_TenHocSinh)
       {
          HocSinhData data = new HocSinhData();
           DataTable table = data.TimTheoTen(m_TenHocSinh);
           lvw.Items.Clear();
           foreach (DataRow row in table.Rows)
           {
               ListViewItem item = new ListViewItem(row["MAHOCSINH"].ToString());
               item.SubItems.Add(row["HOTEN"].ToString());
               //item.SubItems.Add(row["LOP"].ToString());
               lvw.Items.Add(item);
           }

       }

       public void TimTheoMa(String m_MaHocSinh)
       {
           m_HocSinhData.TimTheoMa(m_MaHocSinh);
       }

       public void TimTheoTen(String m_TenHocSinh)
       {
           m_HocSinhData.TimTheoTen(m_TenHocSinh);
       }

       public void Import(string path, DataGridView dgv)
       {
           DataTable dtbHocSinhExcel = m_HocSinhData.LayDSHocSinhExcel(path);
           DataTable HocSinhTable = m_HocSinhData.LayDsHocSinh();

           int rowSuccess = 0;
           for (int i = 0; i < dtbHocSinhExcel.Rows.Count; i++)
           {
               bool t = false;
               for (int j = 0; j < HocSinhTable.Rows.Count; j++)
               {
                   if (dtbHocSinhExcel.Rows[i][0].ToString() != HocSinhTable.Rows[j][0].ToString())
                   {
                       t = true;
                   }
                   else
                   {
                       t = false;
                       j = HocSinhTable.Rows.Count;
                   }
               }
               if (t)
               {
                   DataRow rowthem = HocSinhTable.NewRow();
                   rowthem[0] = dtbHocSinhExcel.Rows[i][0].ToString();
                   rowthem[1] = dtbHocSinhExcel.Rows[i][1].ToString();
                   if (dtbHocSinhExcel.Rows[i][2].ToString().Trim() == "TRUE")

                       rowthem[2] = Convert.ToBoolean(dtbHocSinhExcel.Rows[i][2]);
                             else
                      rowthem[2] = Convert.ToBoolean(dtbHocSinhExcel.Rows[i][2]);

                   //rowthem[2] = dtbHocSinhExcel.Rows[i][2].ToString();
                   rowthem[3] = dtbHocSinhExcel.Rows[i][3].ToString();
                   rowthem[4] = dtbHocSinhExcel.Rows[i][4].ToString();
                   rowthem[5] = dtbHocSinhExcel.Rows[i][5].ToString();
                   rowthem[6] = dtbHocSinhExcel.Rows[i][6].ToString();
                   rowthem[7] = dtbHocSinhExcel.Rows[i][7].ToString();
                   rowthem[8] = dtbHocSinhExcel.Rows[i][8].ToString();
                   rowthem[9] = dtbHocSinhExcel.Rows[i][9].ToString();
                   rowthem[10] = dtbHocSinhExcel.Rows[i][10].ToString(); 

                   HocSinhTable.Rows.Add(rowthem);

                   rowSuccess++;
               }
           }
           MessageBox.Show("Số dòng đã được thêm: " + rowSuccess.ToString() + " dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
       }

    }
         
}
