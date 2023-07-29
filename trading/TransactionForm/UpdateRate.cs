using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trading.models;

namespace trading
{
    public partial class UpdateRate : Form
    {
        public UpdateRate()
        {
            InitializeComponent();
        }

        private void UpdateRate_Load(object sender, EventArgs e)
        {
            //connection 
            using var connection = connectionprovider.GetConnection();
            var ListUpdate = connection.Query<stock>( "select  s_id,company_name,high_rate,low_rate from stocks.stock_entry");
            this.ComboCompany.DataSource = ListUpdate;
            ComboCompany.DisplayMember = nameof(stock.company_name);
            ComboCompany.ValueMember = nameof(stock.s_id);
            ComboCompany.SelectedIndexChanged += ComboCompany_SelectedIndexChanged;
        }

        private void ComboCompany_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var stocks = ComboCompany.SelectedItem as stock;
            HighRateUpdate.Value = stocks.high_rate;
            LowRateUpdate.Value = stocks.low_rate;
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //connection 
            var high = HighRateUpdate.Value;
            var low = LowRateUpdate.Value;
            var id = ComboCompany.SelectedValue;

            using var connection = connectionprovider.GetConnection();
            var Query = "update  stocks.stock_entry set high_rate = @highrate , low_rate= @lowrate where s_id= @id ";
            connection.Execute(Query, new
            {
                highrate=high,
                lowrate=low,
                id=id,
                
            });
            MessageBox.Show("Rate Updated Successfully!");
            var Stocklist = new StockList();this.Hide();this.Close();
            Stocklist.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
