using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elvarnda_Cafe.Model
{
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void Totall()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                tot += double.Parse(item.Cells["dgvtotal"].Value.ToString());

                //tot += int.Parse(item.Cells["dgvQty"].Value.ToString())
                //    * double.Parse(item.Cells["dgvPrice"].Value.ToString());
            }

            lblTotal.Text= tot.ToString();
        }
        private void LoadData()
        {
            string qry = @"select MainID ,TableName ,status ,orderType ,total 
                            from tblMain  ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvtable);
            lb.Items.Add(dgvstatus);
            lb.Items.Add(dgvtype);
            lb.Items.Add(dgvtotal);

            MainClass.LoadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvEdit")
            {
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                Totall();
               
                this.Close();


            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvprint")
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            guna2DataGridView1 = null;
            Totall();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
