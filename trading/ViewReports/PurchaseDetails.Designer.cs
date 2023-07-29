namespace trading
{
    partial class PurchaseDetails
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
            this.PurchaseDetailsView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchaseDetailsView
            // 
            this.PurchaseDetailsView.BackgroundColor = System.Drawing.Color.White;
            this.PurchaseDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseDetailsView.Location = new System.Drawing.Point(1, 56);
            this.PurchaseDetailsView.Name = "PurchaseDetailsView";
            this.PurchaseDetailsView.RowTemplate.Height = 25;
            this.PurchaseDetailsView.Size = new System.Drawing.Size(549, 226);
            this.PurchaseDetailsView.TabIndex = 0;
            this.PurchaseDetailsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseDetailsView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(155, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase Details";
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(551, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchaseDetailsView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PurchaseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseDetails";
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView PurchaseDetailsView;
        private Label label1;
    }
}