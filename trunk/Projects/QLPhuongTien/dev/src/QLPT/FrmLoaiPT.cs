using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using DataAcess;
using System.Data.SqlClient;


namespace QLPT
{
    public partial class FrmLoaiPT : Form
    {
        public FrmLoaiPT()
        {
            InitializeComponent();
        }
        Data dt = new Data();
        LoaiPT loaipt = new LoaiPT();
        public void setnull()
        {
            txtLoaiPT_Ten.Text = "";
            txtLoaiPT_Ma.Text = "";            
        }

        private void FrmLoaiPT_Load(object sender, EventArgs e)
        {
             setnull();
            DataTable dat = new DataTable();
            dat = loaipt.ShowLoaiPT();
            dataGridView1.DataSource = dat;
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;//hiển thị số thứ tự
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            setnull();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (this.txtLoaiPT_Ma.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtLoaiPT_Ten.Text.Length == 0)
                    MessageBox.Show("Trường Tên Loại  không được bỏ trống !");
                else
                    try
                    {
                        loaipt.InsertLoaiPT(txtLoaiPT_Ma.Text, txtLoaiPT_Ten.Text);
                        MessageBox.Show("Đã Thêm Mã :" + txtLoaiPT_Ma.Text + " thành công ");
                        FrmLoaiPT_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mã : "+txtLoaiPT_Ma.Text+" đã tồn tại" +ex);
                        this.txtLoaiPT_Ma.Focus();
                       // MessageBox.Show("Lỗi Thêm  :" + ex);
                    }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (this.txtLoaiPT_Ma.Text.Length == 0)
                MessageBox.Show("Trường Mã Phương tiện không được bỏ trống !");
            else
                if (this.txtLoaiPT_Ten.Text.Length == 0)
                    MessageBox.Show("Trường Tên Loại  không được bỏ trống !");
                else
                    try
                    {
                        loaipt.UpdateLoaiPT(txtLoaiPT_Ma.Text, txtLoaiPT_Ten.Text);
                        MessageBox.Show("Đã sửa Mã :" + txtLoaiPT_Ma.Text + " thành công ");
                        FrmLoaiPT_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi Sửa:" + ex);
                    }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                this.txtLoaiPT_Ma.Text = row.Cells[1].Value.ToString();
                this.txtLoaiPT_Ten.Text = row.Cells[2].Value.ToString();
               
                btSua.Enabled = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (this.txtLoaiPT_Ma.Text.Length == 0)
            {
                this.txtLoaiPT_Ma.ForeColor = Color.Red;
                MessageBox.Show("Bạn cần chọn Mã Xe để xóa");
            }
            else
                if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn xóa với ID " + txtLoaiPT_Ma.Text + "  hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    loaipt.DeleteLoaiPT(this.txtLoaiPT_Ma.Text);
                    MessageBox.Show("Đã xóa ID " + this.txtLoaiPT_Ma.Text + " thành công !");
                    FrmLoaiPT_Load(sender, e);//trở về giao diện đầu     
                }
        }
    }
}
