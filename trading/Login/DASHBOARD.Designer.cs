namespace trading
{
    partial class DASHBOARD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
            this.ViewStockBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserDetails = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.Newstock = new System.Windows.Forms.Button();
            this.UpdateRate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LabelForOrg = new System.Windows.Forms.Label();
            this.labelForAddress = new System.Windows.Forms.Label();
            this.labelForBranch = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ResetPageBtn = new System.Windows.Forms.Button();
            this.AdminLogoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewStockBtn
            // 
            this.ViewStockBtn.Image = ((System.Drawing.Image)(resources.GetObject("ViewStockBtn.Image")));
            this.ViewStockBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewStockBtn.Location = new System.Drawing.Point(122, 236);
            this.ViewStockBtn.Name = "ViewStockBtn";
            this.ViewStockBtn.Size = new System.Drawing.Size(120, 37);
            this.ViewStockBtn.TabIndex = 0;
            this.ViewStockBtn.Text = "View Stocks";
            this.ViewStockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ViewStockBtn.UseVisualStyleBackColor = true;
            this.ViewStockBtn.Click += new System.EventHandler(this.btnstockview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserDetails
            // 
            this.UserDetails.BackColor = System.Drawing.Color.White;
            this.UserDetails.Image = ((System.Drawing.Image)(resources.GetObject("UserDetails.Image")));
            this.UserDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserDetails.Location = new System.Drawing.Point(4, 279);
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Size = new System.Drawing.Size(108, 38);
            this.UserDetails.TabIndex = 3;
            this.UserDetails.Text = "User Details";
            this.UserDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UserDetails.UseVisualStyleBackColor = false;
            this.UserDetails.Click += new System.EventHandler(this.userdetails_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.White;
            this.AddUser.Image = ((System.Drawing.Image)(resources.GetObject("AddUser.Image")));
            this.AddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUser.Location = new System.Drawing.Point(4, 193);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(108, 37);
            this.AddUser.TabIndex = 4;
            this.AddUser.Text = "Add User";
            this.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // Newstock
            // 
            this.Newstock.Image = ((System.Drawing.Image)(resources.GetObject("Newstock.Image")));
            this.Newstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newstock.Location = new System.Drawing.Point(122, 193);
            this.Newstock.Name = "Newstock";
            this.Newstock.Size = new System.Drawing.Size(120, 37);
            this.Newstock.TabIndex = 5;
            this.Newstock.Text = "Add Stock";
            this.Newstock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Newstock.UseVisualStyleBackColor = true;
            this.Newstock.Click += new System.EventHandler(this.Newstock_Click);
            // 
            // UpdateRate
            // 
            this.UpdateRate.Image = ((System.Drawing.Image)(resources.GetObject("UpdateRate.Image")));
            this.UpdateRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateRate.Location = new System.Drawing.Point(4, 236);
            this.UpdateRate.Name = "UpdateRate";
            this.UpdateRate.Size = new System.Drawing.Size(108, 37);
            this.UpdateRate.TabIndex = 8;
            this.UpdateRate.Text = "Update Rate";
            this.UpdateRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateRate.UseVisualStyleBackColor = true;
            this.UpdateRate.Click += new System.EventHandler(this.UpdateRate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Organization Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(302, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // LabelForOrg
            // 
            this.LabelForOrg.AutoSize = true;
            this.LabelForOrg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelForOrg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelForOrg.ForeColor = System.Drawing.Color.DarkGreen;
            this.LabelForOrg.Image = ((System.Drawing.Image)(resources.GetObject("LabelForOrg.Image")));
            this.LabelForOrg.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LabelForOrg.Location = new System.Drawing.Point(40, 46);
            this.LabelForOrg.Name = "LabelForOrg";
            this.LabelForOrg.Size = new System.Drawing.Size(112, 21);
            this.LabelForOrg.TabIndex = 16;
            this.LabelForOrg.Text = "Test Company";
            this.LabelForOrg.Click += new System.EventHandler(this.LabelForOrg_Click);
            // 
            // labelForAddress
            // 
            this.labelForAddress.AutoSize = true;
            this.labelForAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelForAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForAddress.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelForAddress.Image = ((System.Drawing.Image)(resources.GetObject("labelForAddress.Image")));
            this.labelForAddress.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelForAddress.Location = new System.Drawing.Point(40, 85);
            this.labelForAddress.Name = "labelForAddress";
            this.labelForAddress.Size = new System.Drawing.Size(135, 21);
            this.labelForAddress.TabIndex = 16;
            this.labelForAddress.Text = "Birtamod-1,Jhapa";
            // 
            // labelForBranch
            // 
            this.labelForBranch.AutoSize = true;
            this.labelForBranch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelForBranch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelForBranch.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelForBranch.Image = ((System.Drawing.Image)(resources.GetObject("labelForBranch.Image")));
            this.labelForBranch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelForBranch.Location = new System.Drawing.Point(40, 124);
            this.labelForBranch.Name = "labelForBranch";
            this.labelForBranch.Size = new System.Drawing.Size(100, 21);
            this.labelForBranch.TabIndex = 16;
            this.labelForBranch.Text = "Main Branch";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(4, 46);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(4, 86);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(4, 125);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // ResetPageBtn
            // 
            this.ResetPageBtn.Image = global::trading.Properties.Resources.icons8_reset_241;
            this.ResetPageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetPageBtn.Location = new System.Drawing.Point(122, 280);
            this.ResetPageBtn.Name = "ResetPageBtn";
            this.ResetPageBtn.Size = new System.Drawing.Size(120, 37);
            this.ResetPageBtn.TabIndex = 18;
            this.ResetPageBtn.Text = "Reset Password";
            this.ResetPageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ResetPageBtn.UseVisualStyleBackColor = true;
            this.ResetPageBtn.Click += new System.EventHandler(this.ResetPageBtn_Click);
            // 
            // AdminLogoutBtn
            // 
            this.AdminLogoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminLogoutBtn.Image")));
            this.AdminLogoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminLogoutBtn.Location = new System.Drawing.Point(561, 5);
            this.AdminLogoutBtn.Name = "AdminLogoutBtn";
            this.AdminLogoutBtn.Size = new System.Drawing.Size(71, 24);
            this.AdminLogoutBtn.TabIndex = 19;
            this.AdminLogoutBtn.Text = "Log Out";
            this.AdminLogoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminLogoutBtn.UseVisualStyleBackColor = true;
            this.AdminLogoutBtn.Click += new System.EventHandler(this.AdminLogoutBtn_Click);
            // 
            // DASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(644, 362);
            this.Controls.Add(this.AdminLogoutBtn);
            this.Controls.Add(this.ResetPageBtn);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelForBranch);
            this.Controls.Add(this.labelForAddress);
            this.Controls.Add(this.LabelForOrg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpdateRate);
            this.Controls.Add(this.Newstock);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ViewStockBtn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DASHBOARD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.DASHBOARD_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ViewStockBtn;
        private PictureBox pictureBox1;
        private Button UserDetails;
        private Button AddUser;
        private Button Newstock;
        private Button UpdateRate;
        private Label label1;
        private PictureBox pictureBox2;
        private Label LabelForOrg;
        private Label labelForAddress;
        private Label labelForBranch;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Button ResetPageBtn;
        private Button AdminLogoutBtn;
    }
}