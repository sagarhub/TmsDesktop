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
using trading.Login;
using trading.models;

namespace trading
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Load += LoginForm_Load;
            Shown += LoginForm_Shown;
        }

        private void LoginForm_Shown(object? sender, EventArgs e)
        {
            UsernameTxt.Focus();
           
            
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void logbtn_Click(object sender, EventArgs e)
        {
            var username = UsernameTxt.Text;
            var password = PassowrdTxt.Text;
           
       
           if(checkuserpass(username,password))
            {
           
            }
           else
            {
                MessageBox.Show("username or password is incorrect");
            }
        }
        private bool checkuserpass(string username , string password)
        {
            //get connection 
            using var connection = connectionprovider.GetConnection();
            //define query ;
            var Query = "select * from auth.userdetails where username = @user_name";

            //execute
            var userDetails = connection.QueryFirstOrDefault<userDetails>(Query, new
            {
                user_name = username,
              
            });
            if (userDetails == null)
            {
                MessageBox.Show("please enter username");
                return true;
               
            }
            
            else
            {
                if(BCrypt.Net.BCrypt.Verify(password,userDetails.pass))
                
                {
                    //recording which user is logged in 
                    Session.CurrentUser = userDetails;
                    var org = connection.QueryFirstOrDefault<Organization>("select * from auth.organization");
                    Session.CurrentOrganization = org;
                   if(Session.CurrentUser.roles == "Admin")
                    {
                        var DASHBOARD = new DASHBOARD();this.Hide();
                        DASHBOARD.ShowDialog();this.Close();
                    }
                    else
                    {
                        var UserDashboad = new UserDashboard();
                        this.Hide();
                        UserDashboad.ShowDialog();this.Close();
                    }
                    return true;
                }
                else return false;
            }
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lgfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void logexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signupbtm_Click(object sender, EventArgs e)
        {
            var userRegister = new Registration();this.Hide();
            userRegister.ShowDialog();this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            var Signup = new SignUp();this.Hide();
            Signup.ShowDialog();this.Show();
        }
    }
}

