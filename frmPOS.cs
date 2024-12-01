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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Elvarnda_Cafe.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType;

        bool f =false;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle=BorderStyle.FixedSingle;
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProduct();
        }
        private void AddCategory()
        {
            string qry = "Select * from Category";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            CategoryPanel.Controls.Clear();

            if(dt.Rows.Count > 0 )
            {
                foreach (DataRow row in dt.Rows)
                { 
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50,55,89);
                    b.Size = new Size(134,45);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();

                    b.Click += new EventHandler(_Click);
                    CategoryPanel.Controls.Add(b);
                }
            }
        }

        private void _Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PCategory.ToString().ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string Id,string proID,string name,string cat,string price,Image pimage)
        {
            var w = new ucProduct()
            {
                PName = name,
                PPrice = int.Parse(price),
                PCategory = cat,
                id = int.Parse(proID),
                PImage = pimage,

                
            };
            GetTotal();
            ProductPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {

                var wdg = (ucProduct)ss;

                foreach(DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    { 
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString())+1;
                        item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) *
                                                        double.Parse(item.Cells["dgvPrice"].Value.ToString());
                        GetTotal();
                        return;
                    }

                    
                }
                guna2DataGridView1.Rows.Add(new object[] { 0,0, wdg.id, wdg.PName, 1, wdg.PPrice, wdg.PPrice });
                GetTotal();
            };
        }

        private void LoadProduct()
        {
            string qry = "Select * from products innar join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, MainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                Byte[] imagearray = (byte[])item["pImage"];
                byte[] imagebytearray = imagearray;

                AddItems("0",item["pID"].ToString(), item["pName"].ToString(), item["catName"].ToString(),
                    item["pPrice"].ToString(), Image.FromStream(new MemoryStream(imagearray)));

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach(var  item in ProductPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.PName.ToLower().Contains(txtSearch.Text.Trim().ToLower());
            }
        }

        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void GetTotal()
        {
            double tot = 0;
            lblTotal.Text = "";
            foreach(DataGridViewRow item in guna2DataGridView1.Rows)
            {
                //tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());

                tot += int.Parse(item.Cells["dgvQty"].Value.ToString())
                    * double.Parse(item.Cells["dgvPrice"].Value.ToString());
            }

            lblTotal.Text = tot.ToString();
        }


        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblTable.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            lblTotal.Text = "00";
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblTable.Visible = false;
            OrderType = "Delivery";
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            
            lblTable.Text = "";
            lblTable.Visible = false;
            OrderType = "Take Away";

            f = true;
        }

        private void btnDine_Click(object sender, EventArgs e)
        {
            OrderType = "Din IN";
            SelectTable frm = new SelectTable();
            MainClass.BlurBackground(frm);
            if(frm.TableName!="")
            {
                lblTable.Text=frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible=false;
            }

            f = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!f)
            {
                MessageBox.Show("Please Select Order Type");
                return;
            }

            string qry1 = "";
            string qry2 = "";

            int detailID = 0;
                
            if(MainID==0)
            {
                qry1 = @"Insert into tblMain Values(@aDate,@aTime,@TableName,@status,@orderType,@total,@received,@change);
                            Select SCOPE_IDENTITY()";
            }
            else
            {
                qry1 = @"Update tblMain Set status = @status ,orderType = @orderType, total = @total , received = @received , change = @change where MainID = @ID)";
            }


            SqlCommand cmd = new SqlCommand(qry1,MainClass.con);
            cmd.Parameters.AddWithValue ("@ID", MainID);
            cmd.Parameters.AddWithValue("@aDate",Convert.ToDateTime (DateTime.Now.Date));
            cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@TableName", lblTable.Text);
            cmd.Parameters.AddWithValue("@status", "pending");
            cmd.Parameters.AddWithValue("@orderType", OrderType);
            cmd.Parameters.AddWithValue("@total", Convert.ToDouble(lblTotal.Text));
            cmd.Parameters.AddWithValue("@received", Convert.ToDouble(0));
            cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

            if(MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
            if(MainID==0) { MainID=Convert.ToInt32(cmd.ExecuteScalar()); } else { cmd.ExecuteNonQuery(); }
            if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

            foreach(DataGridViewRow row in  guna2DataGridView1.Rows)
            {
                detailID = Convert.ToInt32(row.Cells["dgvid"].Value);

                if(detailID == 0)
                {
                    qry2 = @" Insert into tblDetails Values (@MainID ,@proID ,@qty ,@price ,@amount)";

                }
                else
                {
                    qry2 = @"Update tblDetails Set proID = @proID , qty  = @qty  , price = @price , amount = @amount
                            where DetailID = @ID)";
                }

                SqlCommand cmd2 = new SqlCommand(qry2, MainClass.con);
                cmd2.Parameters.AddWithValue("@ID", detailID);
                cmd2.Parameters.AddWithValue("@MainID", MainID);
                cmd2.Parameters.AddWithValue("@proID", Convert.ToInt32 (row.Cells["dgvproID"].Value));
                cmd2.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                cmd2.Parameters.AddWithValue("@price", Convert.ToDouble(row.Cells["dgvPrice"].Value));
                cmd2.Parameters.AddWithValue("@amount", Convert.ToDouble(row.Cells["dgvAmount"].Value));

                if (MainClass.con.State == ConnectionState.Closed) { MainClass.con.Open(); }
                 cmd2.ExecuteNonQuery(); 
                if (MainClass.con.State == ConnectionState.Open) { MainClass.con.Close(); }

                guna2MessageDialog1.Show("Svaed Successfuly");
                MainID = 0;
                detailID= 0;
                guna2DataGridView1.Rows.Clear();

                lblTable.Text = "";
                lblTable.Visible = false;
                lblTotal.Text = "00";
            }
        }
        public int id = 0;
        private void BtnBill_Click(object sender, EventArgs e)
        {
            frmBillList frm =new frmBillList();
            MainClass.BlurBackground(frm);

            if(frm.MainID > 0)
            {
                id= frm.MainID;
                LoadEntries();   
            }
        }

        private void LoadEntries()
        {
            string qry = @"select * from tblMain m
                inner join tblDetails d on
                           m.MainID = d.MainID 
                inner join products p on
                           p.pID = d.proID  
                where m.MainID = " + id + "";

            SqlCommand cmd = new SqlCommand(qry,MainClass.con);
            DataTable dt =new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            //if (dt.Rows[0]["orderType"].ToString() == "Take away")
            //{
            //    btnTake.Checked = true;
            //    lblTable.Visible=false;
            //}
            //else
            //{
            //    btnDine.Checked = true;
            //    lblTable.Visible=true;
            //}
           

            guna2DataGridView1.Rows.Clear();

            foreach(DataRow item in dt.Rows) 
            {
                lblTable.Text = item["TableName"].ToString();
                string detailid = item["DetailID"].ToString();
                string proName = item["pName"].ToString();
                string proid = item["proID"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = {0, detailid, id,proName, qty, price, amount };
                guna2DataGridView1.Rows.Add(obj);
            }
            GetTotal();
        }

        private void guna2DataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            frmCheckOut frm = new frmCheckOut();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(lblTotal.Text);
            MainClass.BlurBackground(frm);
            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblTable.Visible = false;
            lblTotal.Text = "00";

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHold_Click(object sender, EventArgs e)
        {

        }
    }
}
