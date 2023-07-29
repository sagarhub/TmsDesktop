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
    public partial class PurchaseDetails : Form
    {
        public PurchaseDetails()
        {
            InitializeComponent();
            Load += PurchaseDetails_Load;
        }

        private void PurchaseDetails_Load(object? sender, EventArgs e)
        {
            // connection
            var UserID = Session.CurrentUser.u_id;
            using var connection = connectionprovider.GetConnection();
            var PurchaseView = connection.Query<PurchaseDet>("select *  from stocks.stockpurchase where u_id=@userId",new {userId=UserID});
            PurchaseDetailsView.DataSource = PurchaseView;
        }

        

        private void PurchaseDetailsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
