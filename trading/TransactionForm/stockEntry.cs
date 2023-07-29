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

namespace trading
{
    public partial class stockEntry : Form
    {
        public stockEntry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //save button click operation
        private void stocksave_Click(object sender, EventArgs e)
        {
            var company = CompanyTxt.Text;
            var shortname = ShortNameTxt.Text;
            var highrate = HighRateTxt.Value;
            var lowrate = LowRateTxt.Value;
            //get connection 
           using var connection = connectionprovider.GetConnection();
            //define query 
            var query = "insert into stocks.stock_entry (company_name , short_name,high_rate , low_rate)" +
                "values(@comp,@shortN, @high,@low )";

            //execution 
            connection.Execute(query, new
            {
                comp = company,
                shortN = shortname,
                high = highrate,
                low = lowrate,
            } );
            MessageBox.Show("Saved");
            var Stocklist  = new StockList(); this.Hide(); this.Close();
            Stocklist.ShowDialog();

        }

        private void stockEntry_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
