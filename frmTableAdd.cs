using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elvarnda_Cafe.Model
{
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public override void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into tables Values(@Name)";
            }
            else
            {
                qry = "Update tables Set tName = @Name where tID = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfuly..");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
