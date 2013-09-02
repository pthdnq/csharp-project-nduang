using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using QLDiemHSTHPT.DataLayer;
using System.Data;
using System.Collections;

namespace QLDiemHSTHPT.Controller
{
    public class HocLucCtrl
    {
        DiemCtrl m_DiemCtrl = new DiemCtrl();
        HocLucData m_HocLucData = new HocLucData();
        MonHocData m_MonHocData = new MonHocData();
        LopData m_LopData = new LopData();
        KQHKMonHocData m_KQHKMonHocData = new KQHKMonHocData(); 


        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = m_HocLucData.LayDsHocLuc();
            comboBox.DisplayMember = "TenHocLuc";
            comboBox.ValueMember = "MaHocLuc";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = m_HocLucData.LayDsHocLuc();
            cmbColumn.DisplayMember = "TenHocLuc";
            cmbColumn.ValueMember = "MaHocLuc";
            cmbColumn.DataPropertyName = "MaHocLuc";
            cmbColumn.HeaderText = "Học lực";
        }
        public void HienThi(DataGridViewX dGV, BindingNavigator bN)
        {
            BindingSource bS = new BindingSource();

            bS.DataSource = m_HocLucData.LayDsHocLuc();
            bN.BindingSource = bS;
            dGV.DataSource = bS;
        }
        public DataRow ThemDongMoi()
        {
            return m_HocLucData.ThemDongMoi();
        }

        public void ThemHocLuc(DataRow m_Row)
        {
            m_HocLucData.ThemHocLuc(m_Row);
        }
        public bool LuuHocLuc()
        {
            return m_HocLucData.LuuHocLuc();
        }
        public String XepLoaiHocLucMonHoc(float[] arrayDiemTBTungMon, float tongDiem)
        {
            String xepLoai = "";
            float diemTBMonNhoNhat = TimMin(arrayDiemTBTungMon);
            HocLucData m_HLData = new HocLucData();
            DataTable m_DT_DS_HocLuc = m_HLData.LayDsHocLuc();
            String[] maHocLuc = new String[m_DT_DS_HocLuc.Rows.Count];
            float[] diemCanDuoi = new float[m_DT_DS_HocLuc.Rows.Count];
            float[] diemKhongChe = new float[m_DT_DS_HocLuc.Rows.Count];

            int count = 0;
            foreach (DataRow row in m_DT_DS_HocLuc.Rows)
            {
                maHocLuc[count] = row["MaHocLuc"].ToString();
                diemCanDuoi[count] = float.Parse(row["DiemCanDuoi"].ToString());
                diemKhongChe[count] = float.Parse(row["diemKhongChe"].ToString());
                count++;
            }

            for (int i = 0; i < count - 1; i++)
            {
                if (tongDiem >= diemCanDuoi[i])
                {
                    xepLoai = maHocLuc[i];
                    if (diemTBMonNhoNhat <= diemKhongChe[i])
                        xepLoai = maHocLuc[i + 1];
                    break;
                }
            }

            if (xepLoai == "")
                xepLoai = maHocLuc[count - 1].ToString();
            return xepLoai;
        }

        public String XepLoaiHocLucHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            return XepLoaiHLHocKy(maHocSinh, maLop, maHocKy, maNamHoc);
        }

        public String XepLoaiHocLucCaNam(String maHocSinh, String maLop, String maNamHoc)
        {
            float tongDiem = 0;
            float tongDiemCacMon = 0;
            float diemTBTungMon = 0;
            int tongHeSoCacMon = 0;

            DataTable m_DT = m_MonHocData.LayDsMonHoc(maNamHoc, maLop);

            float[] arrayDiemTBTungMon = new float[m_DT.Rows.Count];

            int soMonHoc = 0;
            foreach (DataRow row in m_DT.Rows)
            {
                diemTBTungMon = m_DiemCtrl.DiemTrungBinhMonCaNam(maHocSinh, row["MaMonHoc"].ToString(), maNamHoc, maLop);
                arrayDiemTBTungMon[soMonHoc++] = diemTBTungMon;

                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(row["HeSoBanCoBan"].ToString());
                tongHeSoCacMon += Convert.ToInt32(row["HeSoBanCoBan"].ToString());
            }
            if (tongHeSoCacMon > 0)
                tongDiem = tongDiemCacMon / tongHeSoCacMon;
            else
                tongDiem = 0;

            return XepLoaiHocLucMonHoc(arrayDiemTBTungMon, tongDiem);
        }
        public float TimMin(float[] arrayNumber)
        {
            float Min = arrayNumber[0];//ban đầu gán cho phần tử đầu tiên là min
            //sau đó duyệt mảng các phân tử các, nếu phần tử khác bé hơn thì lấy giá trị của nó là min
            for (int i = 1; i < arrayNumber.Length; i++)
            {
                if (arrayNumber[i] < Min)
                    Min = arrayNumber[i];

            }
            return Min;
        }
        public String XepLoaiHLHocKy(String maHocSinh, String maLop, String maHocKy, String maNamHoc)
        {
            //Lấy ra mã ban theo mã lớp - BEGIN
            string strBan = "CHUA_PHAN_BAN";
            DataTable m_DT_BAN = m_LopData.TimTheoMa(maLop);
            foreach (DataRow row in m_DT_BAN.Rows)
            {
                strBan = row["MaBan"].ToString().Trim();
                break;
            }
            //Lấy ra mã ban theo mã lớp - END
            float diemTBChungCacMonHK = (float)Math.Round(m_DiemCtrl.DiemTrungBinhChungCacMonHocKy(maHocSinh, maLop, maHocKy, maNamHoc), 2);
            DataTable m_DiemTBHKMonHoc = m_KQHKMonHocData.LayDsKQHocKyMonHocTheoBan(maHocSinh, maLop, maHocKy, maNamHoc);
            HocLucData m_HLData = new HocLucData();
            DataTable m_DT_DS_HocLuc = m_HLData.LayDsHocLuc();
            foreach (DataRow row in m_DT_DS_HocLuc.Rows)
            {
                String maHocLuc = row["MaHocLuc"].ToString();
                float diemCanTren = float.Parse(row["DiemCanTren"].ToString());
                float diemCanDuoi = float.Parse(row["DiemCanDuoi"].ToString());
                float diemKhongChe = float.Parse(row["diemKhongChe"].ToString());
                if (diemTBChungCacMonHK >= diemCanDuoi && diemTBChungCacMonHK <= diemCanTren)
                //điểm nằm trong khoảng giới hạn
                {

                   // if (isThoaManDKKhac(strBan, diemCanDuoi, diemKhongChe, m_DiemTBHKMonHoc))

                        return maHocLuc;
                    //else
                       // continue;
                }
                else
                {
                    continue;
                }
                
            }
            return "";
        }
        public bool isThoaManDKKhac(String strPhanBan,float diemCanDuoi,float diemKhongChe, DataTable m_DiemTBHKMonHoc)
        {
            foreach (DataRow row_diemTBHKTungMon in m_DiemTBHKMonHoc.Rows)
            {
                float diemTBHocKyTungMon = float.Parse(row_diemTBHKTungMon["DTBMonHocKy"].ToString());
                
                
                if (diemTBHocKyTungMon < diemKhongChe)// có môn dưới điểm khống chế
                {
                    return false;
                }

            }
            int countMonHoc = 0;
            foreach (DataRow row_diemTBHKTungMon in m_DiemTBHKMonHoc.Rows)
            {

                float diemTBHocKyTungMon = float.Parse(row_diemTBHKTungMon["DTBMonHocKy"].ToString());          
                // Kiểm tra điểm trung bình học kỳ của các môn chuyên ban xem có thỏa mãn ko?

                if (strPhanBan == "B0001" || strPhanBan == "B0002")//nếu là chuyên ban tự nhiên hoặc xã hội thì 
                // kiểm tra các môn chuyên, tức các môn có hệ số 2.
                {
                     int heSoMonHoc = 0;
                    if (strPhanBan == "B0001")//nếu là ban tự nhiên thì lấy hệ số môn theo ban đó
                        heSoMonHoc = int.Parse(row_diemTBHKTungMon["HeSoBanKHTN"].ToString());
                    else
                        heSoMonHoc = int.Parse(row_diemTBHKTungMon["HeSoBanKHXHNV"].ToString());

                    if (heSoMonHoc == 2)
                    {
                        if (diemTBHocKyTungMon < diemCanDuoi)
                        {
                            return false;
                        }
                    }
                }
                else //Ban cơ bản
                {
                    int heSoMonHoc = int.Parse(row_diemTBHKTungMon["HeSoBanCoBan"].ToString());
                    countMonHoc++;
                    if (countMonHoc == 1 && heSoMonHoc ==2)
                    {
                        if (diemTBHocKyTungMon < diemCanDuoi)
                            continue;
                        else
                            return true;
                    }
                    if (countMonHoc == 2 && heSoMonHoc ==2)
                    {
                        if (diemTBHocKyTungMon < diemCanDuoi)
                            return false;
                        else
                            return true;
                    }
                }
            }
            return true;
        }

    }
}
