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

namespace trading
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        //register button click operation 
        private void regbutton_Click(object sender, EventArgs e)
        {
            var username = RegUserNametxt.Text;
            var password = RegPasswordTxt.Text;
            var firstname = FirstNameTxt.Text;
            var lastname = LastNameTxt.Text;
            var Adress = AddressTxt.Text;
            var contactno = ContactTxt.Text;
            var nation = NationalityTxt.Text;
            var role = RoleTxt.Text;
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            
            //get connection
            using var connection = connectionprovider.GetConnection();
            var check = connection.QueryFirstOrDefault<int>("select count(*) from auth.userDetails where username=@NewUser",new { NewUser = username,});
            if(check>0)
            {
                MessageBox.Show("Username Aleready Taken");
                return;
            }
                       
            //define query
            var query = "insert into auth.userdetails(first_name , last_name,   address ,contact , username ,pass,nationality,roles ) " +
                "values(@first,@last,@adds,@cont, @user_name, @user_password,@national,@role)";
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
            MessageBox.Show("User Added Successfully ");
            var AllUserDetail = new AllUserDetail(); this.Hide(); this.Close();
            AllUserDetail.ShowDialog();
        }

        private void userRegister_Load(object sender, EventArgs e)
        {
            var connection = connectionprovider.GetConnection();
            var roles = connection.Query<Role>("select r_name from auth.role");
            this.RoleTxt.DataSource = roles;
            RoleTxt.DisplayMember = nameof(Role.r_name);
            RoleTxt.ValueMember = nameof(Role.rid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegUserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegPasswordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void NationalityTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleTxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

