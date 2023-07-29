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

namespace trading.Login
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            Load += SignUp_Load;
        }

        private void SignUp_Load(object? sender, EventArgs e)
        {

            var connection = connectionprovider.GetConnection();
            var roles = connection.Query<Role>("select r_name from auth.role");
            this.SignUpRolebox.DataSource = roles;
            SignUpRolebox.DisplayMember = nameof(Role.r_name);
            SignUpRolebox.ValueMember = nameof(Role.rid);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void SignUpAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var username = SignUpUsername.Text;
            var password = SignUpPass.Text;
            var firstname = SignUpFirstName.Text;
            var lastname = SignUplastname.Text;
            var Adress = SignUpAddress.Text;
            var contactno = SignUpContact.Text;
            var nation = SignUpNation.Text;
            var role = SignUpRolebox.Text;
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            var OrgName = Organizationtxt.Text;
            var OrgAddress = OrganizationAddress.Text;
            var OrgContact = OrganizationContact.Text;
            var OrgEmail = OrganizationEmail.Text;
            var orgBranch = OrganizationBranch.Text;
            //get connection
            using var connection = connectionprovider.GetConnection();


            var usercountQuery = "Select count(*) from auth.userdetails";
            var usercount = connection.QueryFirstOrDefault<int>(usercountQuery);
            if (usercount > 0)
            {
                MessageBox.Show("User Already Registered");
                return;
            }

            //define query
            var query = "insert into auth.userdetails(first_name , last_name,   address ,contact , username ,pass,nationality,roles ) " +
                "values(@first,@last,@adds,@cont, @user_name, @user_password,@national,@role)";
            var insert  = "insert into auth.organization(organization_name,contact_number,branch,organization_address,email)" +
                "values(@organization,@orgcontact,@branch,@orgaddress,@email)";
            //execution
            connection.Execute(query, new
            {
                user_name = username,
                user_password = passwordHash,
                first = firstname,
                last = lastname,
                adds = Adress,
                cont = contactno,
                national = nation,
                role = role,
              


            });
            connection.Execute(insert, new
            {
                organization = OrgName,
                orgcontact = OrgContact,
                branch = orgBranch,
                orgaddress = OrgAddress,
                email = OrgEmail,
            });
            MessageBox.Show("registration complete");
            var loginForm = new LoginForm();this.Close();this.Hide();
            loginForm.ShowDialog(); this.Show();
        }
    }
    }

