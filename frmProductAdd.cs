using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elvarnda_Cafe.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            string qry = "Select catID 'id' ,catName 'name' from category";
            MainClass.CBFill(qry, cbCat);

            if(cID>0)
            {
                cbCat.SelectedValue = cID;
            }

            if(id>0)
            {
                ForUpdateLoadData();
            }
        }
        string filepath;
        byte[] imageByteArray;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jbg,.png)|* .png; *.jbg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image= new Bitmap(ofd.FileName);
            }
        }
        public override void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "Insert into products Values(@Name ,@price ,@cat ,@img)";
            }
            else
            {
                qry = "Update products Set pName = @Name ,pPrice = @price ,CategoryID = @cat ,pImage = @img where pID = @id ";
            }

            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@Price",txtPrice.Text);
            ht.Add("@cat",Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@img", imageByteArray);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfuly..");
                id = 0;
                cID = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = 0;
                cbCat.SelectedIndex = -1;
                txtImage.Image = Elvarnda_Cafe.Properties.Resources.pro;
                txtName.Focus();
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = @"Seledt * from products where pid =" + id + "";
            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtName.Text= dt.Rows[0]["pName"].ToString();
                txtPrice.Text = dt.Rows[0]["pPrice"].ToString();

                Byte[] imageArray = (byte[])(dt.Rows[0]["pImage"]);
                txtImage.Image =Image.FromStream(new MemoryStream(imageArray));
            }
        }
    }
}
