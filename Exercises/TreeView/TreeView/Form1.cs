using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(treeView1.SelectedNode.Text=="Lập trình console")
            {
                label1.Text = "Anh vừa click vào mục Console rùi đó nha...!";
            }
            if (treeView1.SelectedNode.Text=="Control")
            {
                label1.Text = "Anh vừa click vào mục Control rùi đó nha...!";
            }
        }
    }
}
