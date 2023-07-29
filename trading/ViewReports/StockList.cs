using System;
using Dapper;
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
    public partial class StockList : Form
    {
        public StockList()
        {
            InitializeComponent();
            Load +=  stocks_Load;
        }

        private void stocks_Load(object sender, EventArgs e)
        {
            //get connection 
            using var connection = connectionprovider.GetConnection();
            // define query and taking class name stock from model 
            var list = connection.Query<ViewStock>("select company_name,short_name,high_rate,low_rate from stocks.stock_entry");
            // to list out the data in datagrid
            this.StocksViewGrid.DataSource = list;
        }

        private void load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
