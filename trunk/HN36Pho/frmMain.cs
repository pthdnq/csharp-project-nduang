using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace HN36Pho
{
    public partial class frmMainA : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMainA()
        {
            InitializeComponent();
            setEnableControl(false, 0);
            setEnableControl(false, 1);
            txtLevel.Enabled = false;
        }

        private void frmMainA_Load(object sender, EventArgs e)
        {
            setRoleUser();
            string sqlQuery = "";
            sqlQuery = "select * from pho";
            showData(sqlQuery, dGViewPho);
            if (m_iLevel == 0)
            {
                sqlQuery = "select * from account";
            }
            else
            {
                sqlQuery = "select * from account where online=1";
            }

            // sqlQuery = "select * from account";
            showData(sqlQuery, dGViewUser);
            loadDataToComboBox("Pho");
            loadDataToComboBox("account");

            //tabQuanTriHT.Visible = false;

        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            DataObject pho = new DataObject();
            string sqlQuery = "";
            string condition = txtSearchUser.Text;

            if (condition == "")
            {
                sqlQuery = "select * from account";
            }
            else
            {
                sqlQuery = "select * from account where Username=N'" + condition + "'";
            }

            showData(sqlQuery, dGViewUser);
        }
        private void showData(string sqlQuery, DataGridView dgView)
        {
            DataObject dataObject = new DataObject();
            DataTable dt = dataObject.getDataObject(sqlQuery);

            dgView.DataSource = dt;
        }
        private void dGViewUser_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            setEnableControl(false, 0);
            fillDataToControl("dGViewUser", e);
        }

        private void txtLevelID_TextChanged(object sender, EventArgs e)
        {
            DataObject pho = new DataObject();
            string sqlQuery = "select Function_Level from level";
            DataTable dt = pho.getDataObject(sqlQuery);
            // txtLevel.Text = dt.Rows[0].
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout frmabout = new frmAbout();
            frmabout.ShowDialog();
        }

        private void txtSearchPho_InputTextChanged(object sender)
        {
            int index = cboUser.SelectedIndex;
            searchPho(index);
        }
        public void fillDataToControl(string dgView, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                if (dgView == "dGViewUser")
                {
                    txtIDUser.Text = dGViewUser.Rows[dong].Cells[0].Value.ToString();
                    txtFullname.Text = dGViewUser.Rows[dong].Cells[1].Value.ToString();
                    txtAccount.Text = dGViewUser.Rows[dong].Cells[2].Value.ToString();
                    txtPass.Text = dGViewUser.Rows[dong].Cells[3].Value.ToString();
                    txtLevelID.Text = dGViewUser.Rows[dong].Cells[4].Value.ToString();
                }
                else
                {
                    txtIDPho.Text = dGViewPho.Rows[dong].Cells[0].Value.ToString();
                    txtTenPho.Text = dGViewPho.Rows[dong].Cells[1].Value.ToString();
                    txtTenPhap.Text = dGViewPho.Rows[dong].Cells[2].Value.ToString();
                    txtLichSu.Text = dGViewPho.Rows[dong].Cells[3].Value.ToString();
                    txtDiTich.Text = dGViewPho.Rows[dong].Cells[4].Value.ToString();
                    txtGiaoThong.Text = dGViewPho.Rows[dong].Cells[5].Value.ToString();
                    txtDoDai.Text = dGViewPho.Rows[dong].Cells[6].Value.ToString();
                    txtToaDoDau.Text = dGViewPho.Rows[dong].Cells[7].Value.ToString();
                    txtToaDoCuoi.Text = dGViewPho.Rows[dong].Cells[8].Value.ToString();
                    txtTuyenBus.Text = dGViewPho.Rows[dong].Cells[9].Value.ToString();
                    //load anh len picBox
                    string strImgName = dGViewPho.Rows[dong].Cells[10].Value.ToString().Trim();
                    // picBox.ImageLocation = Application.StartupPath+@"\Images\"+strImgName;
                    string strFullnameImg = Application.StartupPath + @"\Images\" + strImgName;
                    if (strImgName != "")
                    {
                        picBox.Image = Image.FromFile(strFullnameImg);
                    }
                    else
                    {
                        picBox.Image = null;
                    }
                }
            }
            catch (System.Exception ex)
            {

            }
        }


        private void dGViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEnableControl(false, 0);
            fillDataToControl("dGViewUser", e);
        }

        private void dGViewPho_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //fillDataToControl("dGViewPho", e);
        }

        private void dGViewPho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setEnableControl(false, 1);
            fillDataToControl("dGViewPho", e);
        }
        private void clearTextControl(int iTabControl, int iModeInsertOrUpdate)
        {
            if (iTabControl == 0)
            {
                //
                if (iModeInsertOrUpdate == 0)
                {
                    txtIDUser.Text = "";
                }
                txtFullname.Text = "";
                txtAccount.Text = "";
                txtPass.Text = "";
                txtLevelID.Text = "";

            }
            else
            {
                if (iModeInsertOrUpdate == 0)
                {
                    txtIDPho.Text = "";
                }
                //txtIDPho.Text = "";
                txtTenPho.Text = "";
                txtTenPhap.Text = "";
                txtLichSu.Text = "";
                txtDiTich.Text = "";
                txtGiaoThong.Text = "";
                txtDoDai.Text = "";
                txtToaDoDau.Text = "";
                txtToaDoCuoi.Text = "";
                txtTuyenBus.Text = "";
                //string strImgName = dGViewPho.Rows[dong].Cells[9].Value.ToString();
                picBox.Image = null;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            clearTextControl(0, 0);
            isInsert = true;
            isUpdate = false;
            setEnableControl(true, 0);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataObject dataObject = new DataObject();
            string sqlQuery = "";
            if (isInsert == true)
            {

                sqlQuery = "insert into account(Fullname,Username,Pass,Level) values(N'" + txtFullname.Text + "',N'" + txtAccount.Text + "',N'" + txtPass.Text + "',N'" + txtLevelID.Text + "')";
                bool ok = dataObject.addObject(sqlQuery);
                if (ok)
                {
                    isInsert = false;
                    if (m_iLevel == 0)
                    {
                        showData("select * from account", dGViewUser);
                    }
                    else
                    {
                        showData("select * from account where online=1", dGViewUser);
                    }
                    setEnableControl(false, 0);
                    // MessageBox.Show("Lưu dữ liệu thành công");
                    return;

                }
                else
                {
                    MessageBox.Show("Lưu dữ liệu thất bại");
                }
                isInsert = true;
                isUpdate = false;
            }
            if (isUpdate && txtIDUser.Text.Trim() != "")
            {
                sqlQuery = @"update account set Fullname=N'" + txtFullname.Text + "',Username=N'" + txtAccount.Text + "',Pass=N'" + txtPass.Text + "',Level=N'" + txtLevelID.Text + "' where id=N'" + txtIDUser.Text + "'";
                bool ok = dataObject.addObject(sqlQuery);
                if (ok)
                {
                    isUpdate = false;
                    showData("select * from account", dGViewUser);
                    setEnableControl(false, 0);
                    // MessageBox.Show("Lưu dữ liệu thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu dữ liệu thất bại");
                }
                isInsert = false;
                isUpdate = true;
            }
        }
        private void setEnableControl(bool status, int indexTab)
        {
            if (indexTab == 0)//tab quan tri he thong
            {
                //txtIDUser.Enabled = status;
                txtFullname.Enabled = status;
                txtAccount.Enabled = status;
                txtPass.Enabled = status;
                txtLevelID.Enabled = status;
                if (txtLevelID.Text.Trim() != "0")
                    txtLevelID.Enabled = false;
                // txtLevel.Enabled = status;
            }
            else//tab chuc nang
            {
                // txtIDPho.Enabled = status;
                txtTenPho.Enabled = status;
                txtTenPhap.Enabled = status;
                txtDiTich.Enabled = status;
                txtGiaoThong.Enabled = status;
                txtDoDai.Enabled = status;
                txtToaDoDau.Enabled = status;
                txtToaDoCuoi.Enabled = status;
                txtTuyenBus.Enabled = status;
                txtLichSu.Enabled = status;
                btnImg.Enabled = status;
            }
        }

        private void btnDelUser1_Click(object sender, EventArgs e)
        {
            DataObject dataObject = new DataObject();
            if (txtIDUser.Text.Trim() != "")
            {
                string sqlQuery = @"delete from account where id=N'" + txtIDUser.Text + "'";
                bool ok = dataObject.delObject(sqlQuery);
                if (ok)
                {
                    isUpdate = false;
                    showData("select * from account", dGViewUser);
                    setEnableControl(false, 0);
                    //MessageBox.Show("Xóa dữ liệu thành công");
                    clearTextControl(0, 0);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại");
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //clearTextControl(0, 1);
            if (txtIDUser.Text.Trim() != "")
                setEnableControl(true, 0);
            isInsert = false;
            isUpdate = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableControl(false, 0);
        }

        private void btnAddPho_Click(object sender, EventArgs e)
        {
            clearTextControl(1, 0);
            isInsert = true;
            isUpdate = false;
            setEnableControl(true, 1);
        }

        private void btnCancelPho_Click(object sender, EventArgs e)
        {
            setEnableControl(false, 1);
        }

        private void btnOKPho_Click(object sender, EventArgs e)
        {
            DataObject dataObject = new DataObject();
            string sqlQuery = "";
            if (isInsert == true)
            {
                sqlQuery = @"insert into Pho
                                        (
                                        Ten_pho, 
                                        Ten_tieng_phap, 
                                        Lich_su, 
                                        di_tich, 
                                        giao_thong, 
                                        Do_dai, 
                                        td_dau, 
                                        td_cuoi, 
                                        tuyen_xe_bus, 
                                        hinh_anh
                                        )
                           values" + @"
                                        (
                                        N'" + txtTenPho.Text.Trim() + "'," + @"
                                        N'" + txtTenPhap.Text.Trim() + "'," + @"
                                        N'" + txtLichSu.Text.Trim() + "'," + @"
                                        N'" + txtDiTich.Text.Trim() + "'," + @"
                                        N'" + txtGiaoThong.Text.Trim() + "'," + @"
                                        N'" + txtDoDai.Text.Trim() + "'," + @"
                                        N'" + txtToaDoDau.Text.Trim() + "'," + @"
                                        N'" + txtToaDoCuoi.Text.Trim() + "'," + @"
                                        N'" + txtTuyenBus.Text.Trim() + "'," + @"
                                        N'" + imgName + "'" + @"
                                        )";
                //hinh anh xu li sau



                bool ok = dataObject.addObject(sqlQuery);
                if (ok)
                {
                    isInsert = false;
                    showData("select * from Pho", dGViewPho);
                    setEnableControl(false, 1);
                    // MessageBox.Show("Lưu dữ liệu thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu dữ liệu thất bại");
                }
                isInsert = true;
                isUpdate = false;
            }
            if (isUpdate && txtIDPho.Text.Trim() != "")
            {
                sqlQuery = @"update Pho set 
                                Ten_pho=N'" + txtTenPho.Text.Trim() + "'," + @"
                                Ten_tieng_phap=N'" + txtTenPhap.Text.Trim() + "'," + @"
                                Lich_su=N'" + txtLichSu.Text.Trim() + "'," + @"
                                di_tich=N'" + txtDiTich.Text.Trim() + "'," + @" 
                                giao_thong=N'" + txtGiaoThong.Text.Trim() + "'," + @" 
                                Do_dai= N'" + txtDoDai.Text.Trim() + "'," + @"
                                td_dau=N'" + txtToaDoDau.Text.Trim() + "'," + @"
                                td_cuoi=N'" + txtToaDoCuoi.Text.Trim() + "'," + @"
                                tuyen_xe_bus= N'" + txtTuyenBus.Text.Trim() + "'," + @"
                                hinh_anh=N'" + imgName + "'" + @"
                            where 
                                ID_Pho=N'" + txtIDPho.Text.Trim() + "'";

                bool ok = dataObject.addObject(sqlQuery);
                if (ok)
                {
                    //                     isUpdate = false;
                    showData("select * from Pho", dGViewPho);
                    setEnableControl(false, 1);
                    //                    // MessageBox.Show("Lưu dữ liệu thành công");
                    return;
                }
                else
                {
                    MessageBox.Show("Lưu dữ liệu thất bại");
                }
                isInsert = false;
                isUpdate = true;
            }
        }

        private void btnEditPho_Click(object sender, EventArgs e)
        {
            //clearTextControl(0, 1);
            if (txtIDPho.Text.Trim() != "")
                setEnableControl(true, 1);
            isInsert = false;
            isUpdate = true;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            //fdg.ShowDialog();
            imgName = "";
            string ImageName = "";
            if (fdg.ShowDialog() == DialogResult.OK)
            {

                picBox.Image = new Bitmap(fdg.FileName);
                string tmp = System.IO.Path.GetFileName(fdg.FileName);
                // txtTenAnh.Text = tmp;
                //tạo đối tượng fileinfo để lấy thông tin file
                FileInfo fl = new FileInfo(fdg.FileName);
                //Lấy tên ảnh tự động bằng mã sinh viên+ định dạng ban đầu của ảnh
                //ten_anh = txtMaSV.Text + fl.Extension;

                //lấy đường dẫn đầy đủ của file ảnh lên texbox
                // txtAnh.Text = fl.FullName;
                // ImageName
                ImageName = fl.Name;
                imgName = ImageName;

                ///
            }
            //them tạo thư mục Image chứa ảnh
            string dr = "Images";
            string appPath = Application.StartupPath;
            if (Directory.Exists(Path.Combine(appPath, dr)) == false)
                Directory.CreateDirectory(Path.Combine(appPath, dr));
            if (fdg.FileName != "")
            {
                string fileName = ImageName;

                string destFile = Path.Combine(dr, fileName);
                try
                {
                    destFile = Path.Combine(appPath, destFile);
                    System.IO.File.Copy(fdg.FileName, destFile, true);// chép đè file ảnh nếu trùng tên ảnh khi sửa thông tin sinh viên
                }
                catch (Exception)
                {
                    //DialogResult rt = MessageBox.Show("Không muốn dùng ảnh khác!\n Ấn OK để up lại ảnh khác", "Lỗi khi tải ảnh", MessageBoxButtons.OKCancel);
                    //if (rt == DialogResult.OK) return;
                    // chon.FileName = "noimage.jpg";
                }
            }
        }
        private void btnDelPho_Click(object sender, EventArgs e)
        {
            DataObject dataObject = new DataObject();
            if (txtIDPho.Text.Trim() != "")
            {
                string sqlQuery = @"delete from Pho where id_pho=N'" + txtIDPho.Text.Trim() + "'";
                bool ok = dataObject.delObject(sqlQuery);
                if (ok)
                {
                    isUpdate = false;
                    showData("select * from Pho", dGViewPho);
                    setEnableControl(false, 1);
                    //MessageBox.Show("Xóa dữ liệu thành công");
                    clearTextControl(1, 0);
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại");
                }
            }
        }
        private void setRoleUser()
        {
            int iLevel = 3;
            DataObject dataObject = new DataObject();
            string sqlQuery = @"select * from account where online=1";
            DataTable dt = dataObject.getDataObject(sqlQuery);
            if (dt.Rows.Count > 0)
            {

                // dgViewRole.Visible = false;
                //DataGridView dgViewRole = new DataGridView();
                dgViewRole.Visible = false;
                dgViewRole.DataSource = dt;
                string strTmp = dgViewRole.Rows[0].Cells[4].Value.ToString();
                iLevel = int.Parse(strTmp);
                m_iLevel = iLevel;
            }
            switch (iLevel)
            {
                case 0://Toan quyen, super admin quan tri tai khoan va noi dung
                    break;
                case 1: //quan tri noi dung
                    btnNewUser.Visible = false;
                    btnDelUser1.Visible = false;
                    btnSearchUser.Visible = false;
                    // btnOK.Visible = false;
                    // btnCancel.Visible = false;
                    txtSearchUser.Visible = false;
                    cboUser.Visible = false;
                    break;
                case 2://user- chi xem, ko thay doi noi dung dc,ko xem quan tri user dc
                default:
                    tabQuanTriHT.Visible = false;
                    btnAddPho.Visible = false;
                    btnEditPho.Visible = false;
                    btnDelPho.Visible = false;
                    btnOKPho.Visible = false;
                    btnCancelPho.Visible = false;
                    btnImg.Visible = false;
                    break;

            }
        }

        private void loadDataToComboBox(string tblName)
        {
            if (tblName == "account")
            {
               // DataObject dataObject = new DataObject();
               // dataObject.getDataObject("select ID, ")
                cboUser.Items.Add("ID");
                cboUser.Items.Add("Fullname");
                cboUser.Items.Add("Username");
               // cboSearchPho.Items.Add("Pass");
                cboUser.Items.Add("Level");
            }
            else
            {
                cboSearchPho.Items.Add("ID");
                cboSearchPho.Items.Add("Ten_pho");
                cboSearchPho.Items.Add("Ten_tieng_phap");
                cboSearchPho.Items.Add("Lich_su");
                cboSearchPho.Items.Add("Di_tich");
                cboSearchPho.Items.Add("Giao_thong");
                cboSearchPho.Items.Add("Tuyen_xe_bus");
                //cboSearchPho.Items.
            }
        }
        private bool isInsert = false;
        private bool isUpdate = false;
        private string imgName = "";
        private int m_iLevel = 3;
        private void searchPho(int index)
        {
            DataObject pho = new DataObject();
            string sqlQuery = "";
            string condition = txtSearchPho.ControlText.Trim();
            if (condition == "")
            {
                sqlQuery = "select * from pho";
            }
            else
            {
                if (index==-1)
                {
                    sqlQuery = @"select * from pho where ID_Pho like N'%" + condition + "%'";
                }
                else
                {
                    string field = cboSearchPho.Items[index].ToString();
                    sqlQuery = @"select * from pho where " + field + "like N'%" + condition + "%'";
                }

            }

            showData(sqlQuery, dGViewPho);
        }
        private void searchUser(int index)
        {
            DataObject pho = new DataObject();
            string sqlQuery = "";
            string condition = txtSearchUser.ControlText.Trim();
            if (condition == "")
            {
                sqlQuery = "select * from account";
            }
            else
            {
                if (index==-1)
                {
                    sqlQuery = @"select * from account where ID like N'%" + condition + "%'";
                }
                if(index>=0)
                {
                    string field = cboUser.Items[index].ToString();
                  // string field= cboUser.Items[cboUser.SelectedIndex].ToString();
                   sqlQuery = @"select * from account where " + field + " like N'%" + condition + "%'";
                }
            }

            showData(sqlQuery, dGViewUser);
        }
        private void cboSearchPho_ExpandChange(object sender, EventArgs e)
        {
           // searchPho();
        }

        private void txtSearchUser_InputTextChanged(object sender)
        {
            int index = cboUser.SelectedIndex;
            searchUser(index);
        }

        private void cboUser_ExpandChange(object sender, EventArgs e)
        {
            //searchUser();
        }

        private void cboUser_TextChanged(object sender, EventArgs e)
        {
            //searchUser();
        }

        private void cboSearchPho_VisibleChanged(object sender, EventArgs e)
        {
            //int index = cboSearchPho.SelectedIndex;
            //searchPho(index);
        }

        private void cboUser_VisibleChanged(object sender, EventArgs e)
        {
           // searchUser();
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cboUser.SelectedIndex;
            searchUser(i);
        }

        private void cboSearchPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboSearchPho.SelectedIndex;
            searchPho(index);
            //searchPho();
        }
    }
}
