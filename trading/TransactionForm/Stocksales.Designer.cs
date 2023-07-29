namespace trading
{
    partial class Stocksales
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
            this.SalesAmount = new System.Windows.Forms.NumericUpDown();
            this.SalesQuantity = new System.Windows.Forms.NumericUpDown();
            this.SalesRate = new System.Windows.Forms.NumericUpDown();
            this.LowRateSL = new System.Windows.Forms.NumericUpDown();
            this.HighRateSL = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveSalesBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompanyBoxSL = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SalesAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighRateSL)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesAmount
            // 
            this.SalesAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesAmount.Location = new System.Drawing.Point(425, 154);
            this.SalesAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.SalesAmount.Name = "SalesAmount";
            this.SalesAmount.ReadOnly = true;
            this.SalesAmount.Size = new System.Drawing.Size(135, 23);
            this.SalesAmount.TabIndex = 29;
            this.SalesAmount.ValueChanged += new System.EventHandler(this.SalesAmount_ValueChanged);
            // 
            // SalesQuantity
            // 
            this.SalesQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesQuantity.Location = new System.Drawing.Point(233, 155);
            this.SalesQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SalesQuantity.Name = "SalesQuantity";
            this.SalesQuantity.Size = new System.Drawing.Size(146, 23);
            this.SalesQuantity.TabIndex = 28;
            // 
            // SalesRate
            // 
            this.SalesRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesRate.Location = new System.Drawing.Point(12, 155);
            this.SalesRate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.SalesRate.Name = "SalesRate";
            this.SalesRate.Size = new System.Drawing.Size(174, 23);
            this.SalesRate.TabIndex = 27;
            // 
            // LowRateSL
            // 
            this.LowRateSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowRateSL.Location = new System.Drawing.Point(425, 83);
            this.LowRateSL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.LowRateSL.Name = "LowRateSL";
            this.LowRateSL.ReadOnly = true;
            this.LowRateSL.Size = new System.Drawing.Size(135, 23);
            this.LowRateSL.TabIndex = 26;
            // 
            // HighRateSL
            // 
            this.HighRateSL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighRateSL.Location = new System.Drawing.Point(233, 82);
            this.HighRateSL.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HighRateSL.Name = "HighRateSL";
            this.HighRateSL.ReadOnly = true;
            this.HighRateSL.Size = new System.Drawing.Size(146, 23);
            this.HighRateSL.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "High rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            // 
            // SaveSalesBtn
            // 
            this.SaveSalesBtn.Image = global::trading.Properties.Resources.icons8_checkmark_24__1_;
            this.SaveSalesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveSalesBtn.Location = new System.Drawing.Point(250, 204);
            this.SaveSalesBtn.Name = "SaveSalesBtn";
            this.SaveSalesBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SaveSalesBtn.Size = new System.Drawing.Size(87, 34);
            this.SaveSalesBtn.TabIndex = 22;
            this.SaveSalesBtn.Text = "Save";
            this.SaveSalesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveSalesBtn.UseVisualStyleBackColor = true;
            this.SaveSalesBtn.Click += new System.EventHandler(this.salesbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Low Rate";
            // 
            // CompanyBoxSL
            // 
            this.CompanyBoxSL.FormattingEnabled = true;
            this.CompanyBoxSL.Location = new System.Drawing.Point(12, 82);
            this.CompanyBoxSL.Name = "CompanyBoxSL";
            this.CompanyBoxSL.Size = new System.Drawing.Size(174, 23);
            this.CompanyBoxSL.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(219, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 40);
            this.label7.TabIndex = 30;
            this.label7.Text = "New Sales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 1);
            this.panel1.TabIndex = 31;
            // 
            // SalesDatePicker
            // 
            this.SalesDatePicker.Enabled = false;
            this.SalesDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SalesDatePicker.Location = new System.Drawing.Point(11, 208);
            this.SalesDatePicker.Name = "SalesDatePicker";
            this.SalesDatePicker.Size = new System.Drawing.Size(84, 23);
            this.SalesDatePicker.TabIndex = 32;
            // 
            // Stocksales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 263);
            this.Controls.Add(this.SalesDatePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalesAmount);
            this.Controls.Add(this.SalesQuantity);
            this.Controls.Add(this.SalesRate);
            this.Controls.Add(this.LowRateSL);
            this.Controls.Add(this.HighRateSL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SaveSalesBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CompanyBoxSL);
            this.Controls.Add(this.label1);
            this.Name = "Stocksales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocksales";
            this.Load += new System.EventHandler(this.Stocksales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HighRateSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown SalesAmount;
        private NumericUpDown SalesQuantity;
        private NumericUpDown SalesRate;
        private NumericUpDown LowRateSL;
        private NumericUpDown HighRateSL;
        private Label label6;
        private Label label5;
        private Button SaveSalesBtn;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox CompanyBoxSL;
        private Label label1;
        private Label label7;
        private Panel panel1;
        private DateTimePicker SalesDatePicker;
    }
}