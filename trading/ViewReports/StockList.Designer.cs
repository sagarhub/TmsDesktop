namespace trading
{
    partial class StockList
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
            this.components = new System.ComponentModel.Container();
            this.StocksViewGrid = new System.Windows.Forms.DataGridView();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StocksViewGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // StocksViewGrid
            // 
            this.StocksViewGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StocksViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StocksViewGrid.Location = new System.Drawing.Point(1, 55);
            this.StocksViewGrid.Name = "StocksViewGrid";
            this.StocksViewGrid.ReadOnly = true;
            this.StocksViewGrid.RowTemplate.Height = 25;
            this.StocksViewGrid.Size = new System.Drawing.Size(427, 212);
            this.StocksViewGrid.TabIndex = 0;
            this.StocksViewGrid.RowHeadersWidthChanged += new System.EventHandler(this.load);
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataSource = typeof(trading.models.stock);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stocks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StocksViewGrid);
            this.Name = "StockList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "stocks";
            this.Load += new System.EventHandler(this.stocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StocksViewGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView StocksViewGrid;
        private DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private BindingSource stocksBindingSource;
        private Label label1;
    }
}