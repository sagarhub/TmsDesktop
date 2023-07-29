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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnstockview_Click(object sender, EventArgs e)
        {
            var stocks = new StockList();this.Hide();
            stocks.ShowDialog();this.Show();

        }

        private void userPurchase_Click(object sender, EventArgs e)
        {
            var PurchaseForm = new PurchaeForm();this.Hide();
            PurchaseForm.ShowDialog();this.Show();
        }

        private void userSales_Click(object sender, EventArgs e)
        {
            var Stocksales = new Stocksales();this.Hide();
            Stocksales.ShowDialog();this.Show();
        }

        private void ViewPurchase_Click(object sender, EventArgs e)
        {

            var PurchaseDetail = new PurchaseDetails();this.Hide();
            PurchaseDetail.ShowDialog(); this.Show();
        }

        private void ViewSales_Click(object sender, EventArgs e)
        {
            var SalesDetails = new SalesDetails(); this.Hide();
            SalesDetails.ShowDialog(); this.Show();
        }

        private void MyDetails_Click(object sender, EventArgs e)
        {
            var MyDetails = new MyDetails();this.Hide();
            MyDetails.ShowDialog();this.Show(); 
        }

        private void TotalViewBtn_Click(object sender, EventArgs e)
        {
            var TotalStock = new TotalStock();this.Hide();
            TotalStock.ShowDialog();this.Show();
        }

        private void UserLogoutBtn_Click(object sender, EventArgs e)
        {
            var LogoutConfirm = MessageBox.Show("Are you sure yo want to log out?", "Confirm Logout", MessageBoxButtons.YesNo);

            if (LogoutConfirm == DialogResult.Yes)
            {
                var loginForm = new LoginForm(); this.Hide();
                this.Close();
                loginForm.ShowDialog(); this.Show();

            }
        }
    }
}
