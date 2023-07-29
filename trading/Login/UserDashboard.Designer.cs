namespace trading
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewStockUser = new System.Windows.Forms.Button();
            this.MyDetails = new System.Windows.Forms.Button();
            this.UserPurchase = new System.Windows.Forms.Button();
            this.UserSales = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ViewPurchase = new System.Windows.Forms.Button();
            this.ViewSales = new System.Windows.Forms.Button();
            this.TotalViewBtn = new System.Windows.Forms.Button();
            this.UserLogoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ViewStockUser
            // 
            this.ViewStockUser.Image = ((System.Drawing.Image)(resources.GetObject("ViewStockUser.Image")));
            this.ViewStockUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewStockUser.Location = new System.Drawing.Point(166, 213);
            this.ViewStockUser.Name = "ViewStockUser";
            this.ViewStockUser.Size = new System.Drawing.Size(129, 33);
            this.ViewStockUser.TabIndex = 3;
            this.ViewStockUser.Text = "View Stocks";
            this.ViewStockUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewStockUser.UseVisualStyleBackColor = true;
            this.ViewStockUser.Click += new System.EventHandler(this.btnstockview_Click);
            // 
            // MyDetails
            // 
            this.MyDetails.Image = ((System.Drawing.Image)(resources.GetObject("MyDetails.Image")));
            this.MyDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyDetails.Location = new System.Drawing.Point(166, 252);
            this.MyDetails.Name = "MyDetails";
            this.MyDetails.Size = new System.Drawing.Size(129, 33);
            this.MyDetails.TabIndex = 4;
            this.MyDetails.Text = "My Details";
            this.MyDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyDetails.UseVisualStyleBackColor = true;
            this.MyDetails.Click += new System.EventHandler(this.MyDetails_Click);
            // 
            // UserPurchase
            // 
            this.UserPurchase.Image = ((System.Drawing.Image)(resources.GetObject("UserPurchase.Image")));
            this.UserPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserPurchase.Location = new System.Drawing.Point(2, 174);
            this.UserPurchase.Name = "UserPurchase";
            this.UserPurchase.Size = new System.Drawing.Size(129, 33);
            this.UserPurchase.TabIndex = 4;
            this.UserPurchase.Text = "Purchase ";
            this.UserPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserPurchase.UseVisualStyleBackColor = true;
            this.UserPurchase.Click += new System.EventHandler(this.userPurchase_Click);
            // 
            // UserSales
            // 
            this.UserSales.Image = ((System.Drawing.Image)(resources.GetObject("UserSales.Image")));
            this.UserSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserSales.Location = new System.Drawing.Point(2, 213);
            this.UserSales.Name = "UserSales";
            this.UserSales.Size = new System.Drawing.Size(129, 33);
            this.UserSales.TabIndex = 4;
            this.UserSales.Text = "Sales";
            this.UserSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserSales.UseVisualStyleBackColor = true;
            this.UserSales.Click += new System.EventHandler(this.userSales_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(2, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(192, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // ViewPurchase
            // 
            this.ViewPurchase.Image = ((System.Drawing.Image)(resources.GetObject("ViewPurchase.Image")));
            this.ViewPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewPurchase.Location = new System.Drawing.Point(2, 252);
            this.ViewPurchase.Name = "ViewPurchase";
            this.ViewPurchase.Size = new System.Drawing.Size(129, 33);
            this.ViewPurchase.TabIndex = 18;
            this.ViewPurchase.Text = "Purchase Details";
            this.ViewPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewPurchase.UseVisualStyleBackColor = true;
            this.ViewPurchase.Click += new System.EventHandler(this.ViewPurchase_Click);
            // 
            // ViewSales
            // 
            this.ViewSales.Image = global::trading.Properties.Resources.icons8_total_sales_25;
            this.ViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewSales.Location = new System.Drawing.Point(2, 291);
            this.ViewSales.Name = "ViewSales";
            this.ViewSales.Size = new System.Drawing.Size(129, 33);
            this.ViewSales.TabIndex = 19;
            this.ViewSales.Text = "Sales Details";
            this.ViewSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewSales.UseVisualStyleBackColor = true;
            this.ViewSales.Click += new System.EventHandler(this.ViewSales_Click);
            // 
            // TotalViewBtn
            // 
            this.TotalViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("TotalViewBtn.Image")));
            this.TotalViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TotalViewBtn.Location = new System.Drawing.Point(166, 291);
            this.TotalViewBtn.Name = "TotalViewBtn";
            this.TotalViewBtn.Size = new System.Drawing.Size(129, 33);
            this.TotalViewBtn.TabIndex = 20;
            this.TotalViewBtn.Text = "Portfolio";
            this.TotalViewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalViewBtn.UseVisualStyleBackColor = true;
            this.TotalViewBtn.Click += new System.EventHandler(this.TotalViewBtn_Click);
            // 
            // UserLogoutBtn
            // 
            this.UserLogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserLogoutBtn.Image")));
            this.UserLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLogoutBtn.Location = new System.Drawing.Point(646, 2);
            this.UserLogoutBtn.Name = "UserLogoutBtn";
            this.UserLogoutBtn.Size = new System.Drawing.Size(71, 24);
            this.UserLogoutBtn.TabIndex = 21;
            this.UserLogoutBtn.Text = "Log Out";
            this.UserLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserLogoutBtn.UseVisualStyleBackColor = true;
            this.UserLogoutBtn.Click += new System.EventHandler(this.UserLogoutBtn_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 336);
            this.Controls.Add(this.UserLogoutBtn);
            this.Controls.Add(this.TotalViewBtn);
            this.Controls.Add(this.ViewSales);
            this.Controls.Add(this.ViewPurchase);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UserSales);
            this.Controls.Add(this.UserPurchase);
            this.Controls.Add(this.MyDetails);
            this.Controls.Add(this.ViewStockUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button ViewStockUser;
        private Button MyDetails;
        private Button UserPurchase;
        private Button UserSales;
        private PictureBox pictureBox2;
        private DateTimePicker dateTimePicker1;
        private Button ViewPurchase;
        private Button ViewSales;
        private Button TotalViewBtn;
        private Button UserLogoutBtn;
    }
}