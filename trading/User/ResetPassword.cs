using BCrypt.Net;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace trading.Login
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
            Load += ResetPassword_Load;
        }

        private void ResetPassword_Load(object? sender, EventArgs e)
        {
            //connection
            using var connection = connectionprovider.GetConnection();
            var Resetbox = connection.Query<userDetails>("select * from auth.userdetails");
            ResetBox.DataSource = Resetbox;
            ResetBox.DisplayMember = nameof(userDetails.username);
            ResetBox.ValueMember = nameof(userDetails.u_id);
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            var NewPass = NewPasswordTxt.Text;
            var IDs = ResetBox.SelectedValue;
            var hashpassword = BCrypt.Net.BCrypt.HashPassword(NewPass);
            var user = ResetBox.Text;
            var OldPass = OldPasswordtxt.Text;
            if (CheckForReset(OldPass))
            {
                //connection
                using var connection = connectionprovider.GetConnection();
                var query = "update auth.userdetails set pass =@pass where u_id=@ID";
                //execute
                connection.Execute(query, new
                {
                    pass = hashpassword,
                    ID = IDs,
                });
                MessageBox.Show("password reset successful");
                return;
            }
            else
            {
                MessageBox.Show("wrong password");
                return; 
            }
              
            }
        private bool CheckForReset(string OldPass)
        {
            var IDs = ResetBox.SelectedValue;
            //get connection 
            using var connection = connectionprovider.GetConnection();
            //define query ;
            var userDetails = connection.QueryFirstOrDefault<userDetails>("select * from auth.userdetails where u_id = @ID ", new {ID=IDs});


            if (BCrypt.Net.BCrypt.Verify(OldPass,userDetails.pass))
            {

                return true;

            }
            else return false;
                

            }
            

        }
        
    }
