namespace HN36Pho
{
    partial class frmMainA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmMain = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.mnAdmin = new DevComponents.DotNetBar.RibbonTabItem();
            this.mnFuction = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnAddUser = new DevComponents.DotNetBar.ButtonItem();
            this.mnHelp = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel3 = new DevComponents.DotNetBar.RibbonPanel();
            this.btnEditUser = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelUser = new DevComponents.DotNetBar.ButtonItem();
            this.btnEdit = new DevComponents.DotNetBar.RibbonBar();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnSearchUser = new DevComponents.DotNetBar.ButtonItem();
            this.btnDel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.txtSearchUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.frmMain.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonBar1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.btnEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMain
            // 
            this.frmMain.CaptionVisible = true;
            this.frmMain.Controls.Add(this.ribbonPanel1);
            this.frmMain.Controls.Add(this.ribbonPanel2);
            this.frmMain.Controls.Add(this.ribbonPanel3);
            this.frmMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.frmMain.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mnAdmin,
            this.mnFuction,
            this.mnHelp});
            this.frmMain.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.frmMain.Location = new System.Drawing.Point(4, 1);
            this.frmMain.Name = "frmMain";
            this.frmMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.frmMain.Size = new System.Drawing.Size(689, 103);
            this.frmMain.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.frmMain.TabGroupHeight = 14;
            this.frmMain.TabIndex = 0;
            this.frmMain.TitleText = "Chương trình tra cứu tuyến phố hà nội";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(689, 44);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.Controls.Add(this.txtSearchUser);
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAddUser,
            this.btnEditUser,
            this.btnDelUser,
            this.btnSearchUser});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(686, 41);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            this.ribbonBar1.Text = "ribbonBar1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.btnEdit);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(689, 44);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // mnAdmin
            // 
            this.mnAdmin.Checked = true;
            this.mnAdmin.ImagePaddingHorizontal = 8;
            this.mnAdmin.Name = "mnAdmin";
            this.mnAdmin.Panel = this.ribbonPanel1;
            this.mnAdmin.Text = "Quản trị HT";
            // 
            // mnFuction
            // 
            this.mnFuction.ImagePaddingHorizontal = 8;
            this.mnFuction.Name = "mnFuction";
            this.mnFuction.Panel = this.ribbonPanel2;
            this.mnFuction.Text = "Chức năng";
            // 
            // btnAddUser
            // 
            this.btnAddUser.ImagePaddingHorizontal = 8;
            this.btnAddUser.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Text = "Thêm mới";
            // 
            // mnHelp
            // 
            this.mnHelp.ImagePaddingHorizontal = 8;
            this.mnHelp.Name = "mnHelp";
            this.mnHelp.Panel = this.ribbonPanel3;
            this.mnHelp.Text = "Trợ giúp";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel3.Location = new System.Drawing.Point(0, 57);
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel3.Size = new System.Drawing.Size(689, 44);
            this.ribbonPanel3.TabIndex = 3;
            this.ribbonPanel3.Visible = false;
            // 
            // btnEditUser
            // 
            this.btnEditUser.ImagePaddingHorizontal = 8;
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Text = "Sửa thông tin";
            // 
            // btnDelUser
            // 
            this.btnDelUser.ImagePaddingHorizontal = 8;
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Text = "Xóa tài khoản";
            // 
            // btnEdit
            // 
            this.btnEdit.AutoOverflowEnabled = true;
            this.btnEdit.Controls.Add(this.textBoxX1);
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.buttonItem1,
            this.btnDel,
            this.buttonItem2});
            this.btnEdit.Location = new System.Drawing.Point(3, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(686, 41);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "ribbonBar2";
            // 
            // btnAdd
            // 
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Text = "Thêm phố";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Sửa phố";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.ImagePaddingHorizontal = 8;
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Text = "Tìm kiếm";
            // 
            // btnDel
            // 
            this.btnDel.ImagePaddingHorizontal = 8;
            this.btnDel.Name = "btnDel";
            this.btnDel.Text = "Xóa phố";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ImagePaddingHorizontal = 8;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Tìm kiếm";
            // 
            // txtSearchUser
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.txtSearchUser.Location = new System.Drawing.Point(419, 8);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(246, 23);
            this.txtSearchUser.TabIndex = 0;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(388, 8);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(252, 25);
            this.textBoxX1.TabIndex = 0;
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(16, 212);
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(665, 152);
            this.dGView.TabIndex = 1;
            // 
            // frmMainA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 378);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.frmMain);
            this.Name = "frmMainA";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMainA_Load);
            this.frmMain.ResumeLayout(false);
            this.frmMain.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonBar1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.btnEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl frmMain;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonTabItem mnAdmin;
        private DevComponents.DotNetBar.RibbonTabItem mnFuction;
        private DevComponents.DotNetBar.ButtonItem btnAddUser;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel3;
        private DevComponents.DotNetBar.RibbonTabItem mnHelp;
        private DevComponents.DotNetBar.ButtonItem btnEditUser;
        private DevComponents.DotNetBar.ButtonItem btnDelUser;
        private DevComponents.DotNetBar.RibbonBar btnEdit;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnSearchUser;
        private DevComponents.DotNetBar.ButtonItem btnDel;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearchUser;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.DataGridView dGView;
    }
}