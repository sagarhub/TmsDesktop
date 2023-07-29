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
using System.Security.Cryptography.X509Certificates;

namespace trading
{
    public partial class Stocksales : Form
    {
        public Stocksales()
        {
            InitializeComponent();
        }

        private void Stocksales_Load(object sender, EventArgs e)
        {
            eventlistener();
            //Connection 
            using var connection= connectionprovider.GetConnection();
            //define query 

            var combosales = connection.Query<stock>(@"select * from stocks.stock_entry");
            this.CompanyBoxSL.DataSource = combosales;
            CompanyBoxSL.DisplayMember = nameof(stock.company_name);
            CompanyBoxSL.ValueMember = nameof(stock.s_id);
           


        }
        private void  eventlistener()
        {
            SalesQuantity.ValueChanged += SalesQuantity_ValueChanged;
            SalesRate.ValueChanged += SalesRate_ValueChanged;
            CompanyBoxSL.SelectedIndexChanged += Salesbox_SelectedIndexChanged;
            CompanyBoxSL.SelectedIndexChanged += CompanyBoxSL_SelectedIndexChanged;

        }

        private void CompanyBoxSL_SelectedIndexChanged(object? sender, EventArgs e)
        {

            var SLstocks = CompanyBoxSL.SelectedItem as stock;
            HighRateSL.Value = SLstocks.high_rate;
            LowRateSL.Value = SLstocks.low_rate;
            

        }

        private void SalesRate_ValueChanged(object? sender, EventArgs e)
        {
            updateamount();
        }

        private void SalesQuantity_ValueChanged(object? sender, EventArgs e)
        {
            updateamount();
        }
        private void updateamount()
        {
            var salesamount = SalesRate.Value * SalesQuantity.Value;
            SalesAmount.Value = salesamount;
        }
        private void Salesbox_SelectedIndexChanged(object? sender, EventArgs e)
        {
        }

        private void salesbutton_Click(object sender, EventArgs e)
        {
           
            var C_name = CompanyBoxSL.Text;
            var saleRate = SalesRate.Value;
            var salesQuantity = SalesQuantity.Value;
            var totalAmount = SalesAmount.Value;
            var HighRate = HighRateSL.Value;
            var LowRate = LowRateSL.Value;
            var currentuser = Session.CurrentUser.u_id;
            var stockId = CompanyBoxSL.SelectedValue;
            var SalesDate = SalesDatePicker.Value;
            
            if(saleRate > HighRateSL.Value)
            {
                MessageBox.Show("Rate must not be higher than high rate");
                return;
            }
            else if(saleRate < LowRateSL.Value)
            {
                MessageBox.Show("Rate must not be lower than low rate");
                return ;
            }
            else if(salesQuantity<=0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                return;
            }
            var Id=CompanyBoxSL.SelectedValue;
          
            //connection
           using var connection = connectionprovider.GetConnection();
         var RemainingQuantity  = connection.QueryFirstOrDefault<decimal>(@"select 
	
	sp.quantity
	
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
	where se.s_id= @ID", new {ID=Id, });
            if(RemainingQuantity < salesQuantity)
          {
                MessageBox.Show("Not Enough Quantity For Sales!");
                return;
           }
             var query ="insert into stocks.stocksales(sl_name,sales_rate , s_quantity,s_amount,u_id,s_id,s_date) " +
                "values(@slname,@slrate,@slquantity,@slamount,@user,@stockId,@salesDate)";
            //execute
            connection.Execute(query, new
            {
                slname = C_name,
                slrate = saleRate,
                slquantity= salesQuantity,
                slamount = totalAmount,
                user = currentuser,
                stockId = stockId,
                salesDate= SalesDate,
               
            } );

            MessageBox.Show("Sales Successful");
            var SalesDetails = new SalesDetails();this.Hide();this.Close();
            SalesDetails.ShowDialog();
     
        }

        private void SalesAmount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
