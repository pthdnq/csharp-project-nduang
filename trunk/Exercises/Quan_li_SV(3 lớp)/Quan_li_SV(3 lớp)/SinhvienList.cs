using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Quan_li_SV_3_lớp_
{
    class SinhvienList
    {
        ArrayList listView1 = new ArrayList();
        ArrayList ListViewItem = new ArrayList();
        ArrayList Items=new ArrayList();
         public void themSV(int masv, string ten, int diem)
        {
            Sinh_Vien SV_=new Sinh_Vien();
            SV_.setMaSV(masv);
            SV_.setHoten(ten);
            SV_.setDiem(diem);
        }
         public void xoaDL()
         {
             if (listView1.SelectedItems.Count == 0)
             {
                 MessageBox.Show("Chọn hàng cần xóa ^-^ :d ");
             }
             else
             {
                 foreach (ListViewItem item in listView1.SelectedItems)
                 {
                     listView1.Items.Remove(item);
                     xoaText();
                 }
             }
         }
         public void hienThiList()
         {
           for (int i = 0; i < listView1.Count; i++)
             {
                 Sinh_Vien sv = new Sinh_Vien();
                 sv = (Sinh_Vien)listView1[i];
                 
             }
         }

    }
}
