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
    public partial class SalesDetails : Form
    {
        public SalesDetails()
        {
            InitializeComponent();
            Load += SalesDetails_Load;
        }

        private void SalesDetails_Load(object? sender, EventArgs e)
        {
            //connection
            var userI = Session.CurrentUser.u_id;
            using var connection = connectionprovider.GetConnection();
            var SalesView = connection.Query<Sale>("select * from stocks.stocksales where u_id = @User",new {User = userI});
            SalesGridView.DataSource = SalesView;
            
        }

        private void SalesDetails_Load_1(object sender, EventArgs e)
        {

        }

        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
