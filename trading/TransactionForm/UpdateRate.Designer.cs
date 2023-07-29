namespace trading
{
    partial class UpdateRate
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
            this.ComboCompany = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HighRateUpdate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LowRateUpdate = new System.Windows.Forms.NumericUpDown();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HighRateUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboCompany
            // 
            this.ComboCompany.FormattingEnabled = true;
            this.ComboCompany.Location = new System.Drawing.Point(25, 106);
            this.ComboCompany.Name = "ComboCompany";
            this.ComboCompany.Size = new System.Drawing.Size(167, 23);
            this.ComboCompany.TabIndex = 0;
            this.ComboCompany.Text = "Particulars";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company";
            // 
            // HighRateUpdate
            // 
            this.HighRateUpdate.Location = new System.Drawing.Point(26, 182);
            this.HighRateUpdate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.HighRateUpdate.Name = "HighRateUpdate";
            this.HighRateUpdate.Size = new System.Drawing.Size(166, 23);
            this.HighRateUpdate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "High Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Low Rate";
            // 
            // LowRateUpdate
            // 
            this.LowRateUpdate.Location = new System.Drawing.Point(26, 245);
            this.LowRateUpdate.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.LowRateUpdate.Name = "LowRateUpdate";
            this.LowRateUpdate.Size = new System.Drawing.Size(166, 23);
            this.LowRateUpdate.TabIndex = 2;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.White;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Image = global::trading.Properties.Resources.icons8_checkmark_24;
            this.UpdateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.Location = new System.Drawing.Point(252, 245);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 29);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Save";
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(111, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Update Rate";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(2, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 1);
            this.panel1.TabIndex = 5;
            // 
            // UpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(363, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LowRateUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HighRateUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboCompany);
            this.Name = "UpdateRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRate";
            this.Load += new System.EventHandler(this.UpdateRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HighRateUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowRateUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ComboCompany;
        private Label label1;
        private NumericUpDown HighRateUpdate;
        private Label label2;
        private Label label3;
        private NumericUpDown LowRateUpdate;
        private Button UpdateBtn;
        private Label label4;
        private Panel panel1;
    }
}