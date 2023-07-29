 using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trading.models;

namespace trading
{
    public partial class PurchaeForm : Form
    {
        public PurchaeForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PurchaeForm_Load(object sender, EventArgs e)
        {
            AttachEventListeners();
           using var connection = connectionprovider.GetConnection();
            //list
            var combolist = connection.Query<stock>("select * from stocks.stock_entry");
            this.CompanyBox.DataSource = combolist;
            CompanyBox.DisplayMember = nameof(stock.company_name);
            CompanyBox.ValueMember = nameof(stock.s_id);

            
        }

        private void AttachEventListeners()
        {
            CompanyBox.SelectedIndexChanged += Companybox_SelectedIndexChanged;
            PurchaseQuantity.ValueChanged += PQty_ValueChanged;
            PurchaseRate.ValueChanged += Prate_ValueChanged;
        }

        private void Prate_ValueChanged(object? sender, EventArgs e)
        {
            UpdateAmount();
        }

        private void PQty_ValueChanged(object? sender, EventArgs e)
        {
            UpdateAmount();
        }

        private void UpdateAmount()
        {
            var amount = PurchaseRate.Value * PurchaseQuantity.Value;
            PurchaseAmount.Value = amount;
        }

        private void Companybox_SelectedIndexChanged(object? sender, EventArgs e)
        {


            var stocks = CompanyBox.SelectedItem as stock;
            HighRatePR.Value = stocks.high_rate;
            LowRatePR.Value = stocks.low_rate;
            
        }

        private void companybox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
            
        }
        private void purchasebutton_Click(object sender, EventArgs e)
        {
            var P_Date = PurchaseDate.Value;
            var company = CompanyBox.Text;
            var rate = PurchaseRate.Value;
            var quantity = PurchaseQuantity.Value;
            var amount = PurchaseAmount.Value;
            var userID = Session.CurrentUser.u_id;
            var Highrate = HighRatePR.Value;
            var Lowrate = LowRatePR.Value;
            var Stockid = CompanyBox.SelectedValue;
            if (rate > HighRatePR.Value)
            {
                MessageBox.Show("Rate cannot be hiher than high rate!");
                return;
            }
            else if(rate < LowRatePR.Value)
            {
                MessageBox.Show("Rate cannot be lower than Low rate!");
                return;
            }
            else if(quantity<=0)
            {
                MessageBox.Show("Quantity must be greater than 0");
                    return;
            }
                //connection
                var connection = connectionprovider.GetConnection();

                //define query 
                var query = "insert into stocks.stockpurchase (company_name , purchase_rate ,quantity,amount,u_id,s_id,p_date )" +
                    " values(@comp , @rate , @quantity , @amount,@userId,@sId,@date )";
                //execute
                connection.Execute(query, new
                {
                    comp = company,
                    rate = rate,
                    quantity = quantity,
                    amount = amount,
                    userId = userID,
                    sId=Stockid,
                    date=P_Date,
                });

                MessageBox.Show("Purchase S!uccessful!");
            var PurchaseDetails = new PurchaseDetails();this.Hide(); this.Close();
            PurchaseDetails.ShowDialog();
        }

        //private void pictureBox4_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    this.Close();
        //    var UserDashBoard = new UserDashboard();
        //    UserDashBoard.ShowDialog();
        //}
    }
}
