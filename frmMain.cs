using Elvarnda_Cafe.Model;
using Elvarnda_Cafe.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elvarnda_Cafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        static frmMain _obj;
        public static frmMain instance
        {
            get { if (_obj == null) { _obj = new frmMain(); }return _obj; }
        }
        public  void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.Controls.Add(CenterPanel);
            f.TopLevel = false;
            f.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            lblUser.Text = MainClass.USER;
            _obj = this;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
            frmCategoryView frm =new frmCategoryView();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
            frmProductView frm =new frmProductView();
            frm.Show();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            AddControls(new frmTableView());
            frmTableView frm =new frmTableView();
            frm.Show();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            AddControls(new frmPOS());
            frmPOS frm= new frmPOS();
            frm.Show();
        }
    }
}
