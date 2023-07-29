namespace trading
{
    partial class stockEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CompanyTxt = new System.Windows.Forms.TextBox();
            this.ShortNameTxt = new System.Windows.Forms.TextBox();
            this.EntrySave = new System.Windows.Forms.Button();
            this.HighRateTxt = new System.Windows.Forms.NumericUpDown();
            this.LowRateTxt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HighRateTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Short name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "High Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Low Rate";
            // 
            // CompanyTxt
            // 
            this.CompanyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyTxt.Location = new System.Drawing.Point(12, 76);
            this.CompanyTxt.Name = "CompanyTxt";
            this.CompanyTxt.Size = new System.Drawing.Size(163, 23);
            this.CompanyTxt.TabIndex = 1;
            // 
            // ShortNameTxt
            // 
            this.ShortNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShortNameTxt.Location = new System.Drawing.Point(209, 75);
            this.ShortNameTxt.Name = "ShortNameTxt";
            this.ShortNameTxt.Size = new System.Drawing.Size(163, 23);
            this.ShortNameTxt.TabIndex = 1;
            // 
            // EntrySave
            // 
            this.EntrySave.Image = global::trading.Properties.Resources.icons8_checkmark_24__1_;
            this.EntrySave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EntrySave.Location = new System.Drawing.Point(159, 205);
            this.EntrySave.Name = "EntrySave";
            this.EntrySave.Size = new System.Drawing.Size(85, 32);
            this.EntrySave.TabIndex = 2;
            this.EntrySave.Text = "Save";
            this.EntrySave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EntrySave.UseVisualStyleBackColor = true;
            this.EntrySave.Click += new System.EventHandler(this.stocksave_Click);
            // 
            // HighRateTxt
            // 
            this.HighRateTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HighRateTxt.DecimalPlaces = 2;
            this.HighRateTxt.Location = new System.Drawing.Point(12, 142);
            this.HighRateTxt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.HighRateTxt.Name = "HighRateTxt";
            this.HighRateTxt.Size = new System.Drawing.Size(163, 23);
            this.HighRateTxt.TabIndex = 3;
            // 
            // LowRateTxt
            // 
            this.LowRateTxt.DecimalPlaces = 2;
            this.LowRateTxt.Location = new System.Drawing.Point(209, 142);
            this.LowRateTxt.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LowRateTxt.Name = "LowRateTxt";
            this.LowRateTxt.Size = new System.Drawing.Size(163, 23);
            this.LowRateTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(92, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add New Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(-2, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 1);
            this.panel1.TabIndex = 6;
            // 
            // stockEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 278);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LowRateTxt);
            this.Controls.Add(this.HighRateTxt);
            this.Controls.Add(this.EntrySave);
            this.Controls.Add(this.ShortNameTxt);
            this.Controls.Add(this.CompanyTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "stockEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stockEntry";
            this.Load += new System.EventHandler(this.stockEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighRateTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CompanyTxt;
        private TextBox ShortNameTxt;
        private Button EntrySave;
        private NumericUpDown HighRateTxt;
        private NumericUpDown LowRateTxt;
        private Label label5;
        private Panel panel1;
    }
}