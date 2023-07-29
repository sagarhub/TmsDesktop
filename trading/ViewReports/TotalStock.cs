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
    public partial class TotalStock : Form
    {
        public TotalStock()
        {
            InitializeComponent();
            Load += TotalStock_Load;
        }

        private void TotalStock_Load(object? sender, EventArgs e)
        {
            //connection
			
            using var connection = connectionprovider.GetConnection();
			//define query
			var TotalStockList = connection.Query<Total_Stock>(@"select
	se.s_id ,
	se.company_name,
	se.high_rate,
	se.low_rate,
	sp.quantity,
	(quantity * se.high_rate) Amount
from
	(
	select
		s_id,
		sum(quantity) as quantity
	from
		(
		select
			s_id,
			quantity
		from
			stocks.stockpurchase s
	union
		select
			s_id ,
			-1 * s_quantity as quantity
		from
			stocks.stocksales s2 ) as s
	group by
		s_id
                 ) as sp
inner join stocks.stock_entry se on
	sp.s_id = se.s_id
");
            TotalStockView.DataSource = TotalStockList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalStockView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
