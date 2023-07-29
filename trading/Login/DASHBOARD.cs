using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trading.Login;
using trading.models;

namespace trading
{
    public partial class DASHBOARD : Form
    {
        public DASHBOARD()
        {
            InitializeComponent();
            Load += DASHBOARD_Load;
            
        }

        private void DASHBOARD_Load(object? sender, EventArgs e)
        {
         
            LabelForOrg.Text = Session.CurrentOrganization.organization_name;
            labelForAddress.Text = Session.CurrentOrganization.organization_address;
            labelForBranch.Text = Session.CurrentOrganization.branch;
        }

        private void btnstockview_Click(object sender, EventArgs e)
        {
            var stocks = new StockList();this.Hide();
            stocks.ShowDialog();this.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void userdetails_Click(object sender, EventArgs e)
        {
            var details = new AllUserDetail();this.Hide();
            details.ShowDialog();this.Show();
        }

        private void adduser_Click(object sender, EventArgs e)
        {
            var userRegister = new Registration();this.Hide();
            userRegister.ShowDialog();this.Show();
        }

        private void Newstock_Click(object sender, EventArgs e)
        {
            var stockEntry = new stockEntry(); this.Hide();
            stockEntry.ShowDialog();this.Show();
        }

        private void Spurchasebtn_Click(object sender, EventArgs e)
        {
            var PurchaseForm = new PurchaeForm();this.Hide();
            PurchaseForm.ShowDialog();this.Show();
        }

        private void salebutton_Click(object sender, EventArgs e)
        {
            var stocksales = new Stocksales();this.Hide();
            stocksales.ShowDialog();this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PurchaseDetails = new PurchaseDetails();this.Hide();    
            PurchaseDetails.ShowDialog();this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var UserDashboard =  new UserDashboard();this.Hide();
            UserDashboard.ShowDialog();this.Show();
        }

        private void DASHBOARD_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateRate_Click(object sender, EventArgs e)
        {
            var UpdateRate = new UpdateRate();this.Hide();
            UpdateRate.ShowDialog();this.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetPageBtn_Click(object sender, EventArgs e)
        {
            var ResetPassword = new ResetPassword(); this.Hide();
            ResetPassword.ShowDialog();this.Show(); 
        }

        private void AdminLogoutBtn_Click(object sender, EventArgs e)
        {
            var LogoutConfirm = MessageBox.Show("Are you sure yo want to log out?","Confirm Logout",MessageBoxButtons.YesNo) ;
     
            if(LogoutConfirm == DialogResult.Yes)
            {
                var loginForm = new LoginForm();this.Hide();
                this.Close();
                loginForm.ShowDialog();this.Show();
                
            }
        }

        private void LabelForOrg_Click(object sender, EventArgs e)
        {
          
           
        }
    }
}
