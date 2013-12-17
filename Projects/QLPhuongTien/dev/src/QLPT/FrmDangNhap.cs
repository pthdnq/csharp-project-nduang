using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLPT
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=(local);Initial Catalog=QuanLy_PT;Integrated Security=True");
        }
        public DataTable checkLog(string user, string pass)
        {
            string sql = " select * from DangNhap where UserName = '" + user + "' and Pass = '" + pass + "'";
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;


        }
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            this.txtUser.Focus();
            AcceptButton = btDangNhap;
            try
            {

                SqlConnection con = getConnect();
                this.Status.ForeColor = Color.Blue;
                this.Status.Text = "Kết nối Database thành công !";
            }
            catch
            {
                this.Status.ForeColor = Color.Red;
                this.Status.Text = "Kết nối Database thất bại!";
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text.Length == 0 || this.txtPass.Text.Length == 0)
            {
                this.lbStatus.ForeColor = Color.Red;
                lbStatus.Text = "Bạn chưa nhập User hoặc Pass";
            }
            else
            {
                DataTable dt = new DataTable();
                dt = checkLog(this.txtUser.Text, this.txtPass.Text);
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                   // MessageBox.Show("Đăng nhập thành công tài khoản : " + txtUser.Text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //  Form1 frm = new Form1();
                    // FrmQLPT frmQLPT = new FrmQLPT();
                    //frm.Show();
                }
                else
                {
                    this.lbStatus.ForeColor = Color.Red;
                    this.lbStatus.Text = "Tài khoản không tồn tại";
                    this.txtUser.Text = "";
                    this.txtPass.Text = "";
                    this.txtUser.Focus();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }
        internal void ShowDiaLog()
        {
            throw new NotImplementedException();
        }
    }
}
