namespace Elvarnda_Cafe
{
    partial class frmMain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.CenterPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategory = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnTables = new Guna.UI2.WinForms.Guna2Button();
            this.btnPOS = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnPOS);
            this.guna2Panel1.Controls.Add(this.btnTables);
            this.guna2Panel1.Controls.Add(this.btnProduct);
            this.guna2Panel1.Controls.Add(this.btnCategory);
            this.guna2Panel1.Controls.Add(this.btnHome);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(206, 526);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.lblUser);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel2.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.Location = new System.Drawing.Point(206, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(782, 51);
            this.guna2Panel2.TabIndex = 1;
            // 
            // CenterPanel
            // 
            this.CenterPanel.CustomizableEdges.BottomRight = false;
            this.CenterPanel.CustomizableEdges.TopRight = false;
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(206, 51);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(782, 475);
            this.CenterPanel.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CustomClick = true;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(725, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(45, 29);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(623, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(674, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.guna2PictureBox1.Image = global::Elvarnda_Cafe.Properties.Resources.photo_2024_04_23_12_11_52;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(43, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(87, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Varanda Coffe\r\nCafe & Resturant\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUser.Location = new System.Drawing.Point(15, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(52, 21);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "label1";
            // 
            // btnHome
            // 
            this.btnHome.AutoRoundedCorners = true;
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnHome.BorderRadius = 21;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Elvarnda_Cafe.Properties.Resources.home_2;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnHome.Location = new System.Drawing.Point(26, 175);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(180, 45);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(20, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnCategory
            // 
            this.btnCategory.AutoRoundedCorners = true;
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnCategory.BorderRadius = 21;
            this.btnCategory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnCategory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategory.FillColor = System.Drawing.Color.Transparent;
            this.btnCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Elvarnda_Cafe.Properties.Resources.category_black_filled_icon_style_free_vector;
            this.btnCategory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnCategory.Location = new System.Drawing.Point(26, 226);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(180, 45);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "Categories";
            this.btnCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCategory.TextOffset = new System.Drawing.Point(20, 0);
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoRoundedCorners = true;
            this.btnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnProduct.BorderRadius = 21;
            this.btnProduct.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnProduct.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = global::Elvarnda_Cafe.Properties.Resources.pro;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnProduct.Location = new System.Drawing.Point(26, 277);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(180, 45);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.TextOffset = new System.Drawing.Point(20, 0);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnTables
            // 
            this.btnTables.AutoRoundedCorners = true;
            this.btnTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnTables.BorderRadius = 21;
            this.btnTables.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTables.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnTables.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTables.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTables.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTables.FillColor = System.Drawing.Color.Transparent;
            this.btnTables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Image = global::Elvarnda_Cafe.Properties.Resources.tabel1;
            this.btnTables.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTables.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTables.Location = new System.Drawing.Point(26, 328);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(180, 45);
            this.btnTables.TabIndex = 2;
            this.btnTables.Text = "Tables";
            this.btnTables.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTables.TextOffset = new System.Drawing.Point(20, 0);
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.AutoRoundedCorners = true;
            this.btnPOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnPOS.BorderRadius = 21;
            this.btnPOS.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPOS.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnPOS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPOS.FillColor = System.Drawing.Color.Transparent;
            this.btnPOS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Image = global::Elvarnda_Cafe.Properties.Resources.images__2_;
            this.btnPOS.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPOS.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnPOS.Location = new System.Drawing.Point(26, 379);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(180, 45);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPOS.TextOffset = new System.Drawing.Point(20, 0);
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 526);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel CenterPanel;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnPOS;
        private Guna.UI2.WinForms.Guna2Button btnTables;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnCategory;
    }
}