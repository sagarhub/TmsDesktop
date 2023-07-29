namespace trading
{
    partial class PurchaeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SavePurchasebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HighRatePR = new System.Windows.Forms.NumericUpDown();
            this.LowRatePR = new System.Windows.Forms.NumericUpDown();
            this.PurchaseRate = new System.Windows.Forms.NumericUpDown();
            this.PurchaseQuantity = new System.Windows.Forms.NumericUpDown();
            this.PurchaseAmount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PurchaseDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.HighRatePR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRatePR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // CompanyBox
            // 
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(16, 80);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(151, 23);
            this.CompanyBox.TabIndex = 1;
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.companybox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Low Rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // SavePurchasebtn
            // 
            this.SavePurchasebtn.BackColor = System.Drawing.Color.White;
            this.SavePurchasebtn.FlatAppearance.BorderSize = 0;
            this.SavePurchasebtn.Image = global::trading.Properties.Resources.icons8_checkmark_24__1_;
            this.SavePurchasebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SavePurchasebtn.Location = new System.Drawing.Point(246, 200);
            this.SavePurchasebtn.Name = "SavePurchasebtn";
            this.SavePurchasebtn.Size = new System.Drawing.Size(82, 32);
            this.SavePurchasebtn.TabIndex = 8;
            this.SavePurchasebtn.Text = "Save";
            this.SavePurchasebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SavePurchasebtn.UseVisualStyleBackColor = false;
            this.SavePurchasebtn.Click += new System.EventHandler(this.purchasebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "High rate";
            // 
            // HighRatePR
            // 
            this.HighRatePR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighRatePR.Location = new System.Drawing.Point(218, 81);
            this.HighRatePR.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HighRatePR.Name = "HighRatePR";
            this.HighRatePR.ReadOnly = true;
            this.HighRatePR.Size = new System.Drawing.Size(131, 23);
            this.HighRatePR.TabIndex = 12;
            // 
            // LowRatePR
            // 
            this.LowRatePR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowRatePR.Location = new System.Drawing.Point(392, 81);
            this.LowRatePR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LowRatePR.Name = "LowRatePR";
            this.LowRatePR.ReadOnly = true;
            this.LowRatePR.Size = new System.Drawing.Size(131, 23);
            this.LowRatePR.TabIndex = 13;
            // 
            // PurchaseRate
            // 
            this.PurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseRate.Location = new System.Drawing.Point(17, 143);
            this.PurchaseRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PurchaseRate.Name = "PurchaseRate";
            this.PurchaseRate.Size = new System.Drawing.Size(150, 23);
            this.PurchaseRate.TabIndex = 14;
            // 
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseQuantity.Location = new System.Drawing.Point(218, 142);
            this.PurchaseQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.Size = new System.Drawing.Size(131, 23);
            this.PurchaseQuantity.TabIndex = 15;
            // 
            // PurchaseAmount
            // 
            this.PurchaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseAmount.Location = new System.Drawing.Point(392, 143);
            this.PurchaseAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.PurchaseAmount.Name = "PurchaseAmount";
            this.PurchaseAmount.ReadOnly = true;
            this.PurchaseAmount.Size = new System.Drawing.Size(131, 23);
            this.PurchaseAmount.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(178, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "New Purchase";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-4, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 1);
            this.panel1.TabIndex = 18;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.Enabled = false;
            this.PurchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PurchaseDate.Location = new System.Drawing.Point(12, 203);
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.Size = new System.Drawing.Size(80, 23);
            this.PurchaseDate.TabIndex = 19;
            // 
            // PurchaeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(542, 257);
            this.Controls.Add(this.PurchaseDate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PurchaseAmount);
            this.Controls.Add(this.PurchaseQuantity);
            this.Controls.Add(this.PurchaseRate);
            this.Controls.Add(this.LowRatePR);
            this.Controls.Add(this.HighRatePR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SavePurchasebtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PurchaeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaeForm";
            this.Load += new System.EventHandler(this.PurchaeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighRatePR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRatePR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox CompanyBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button SavePurchasebtn;
        private Label label5;
        private Label label6;
        private NumericUpDown HighRatePR;
        private NumericUpDown LowRatePR;
        private NumericUpDown PurchaseRate;
        private NumericUpDown PurchaseQuantity;
        private NumericUpDown PurchaseAmount;
        private Label label7;
        private Panel panel1;
        private DateTimePicker PurchaseDate;
    }
}