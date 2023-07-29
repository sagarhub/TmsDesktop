using Dapper;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AllUserDetail : Form
    {
        public AllUserDetail()
        {
            InitializeComponent();
        }

        private void details_Load(object sender, EventArgs e)
        {
            //get conection 
            using var connection = connectionprovider.GetConnection();
            //userDetails is class from model  
            var detlist = connection.Query<ViewUserDetails>("select * from auth.userdetails");
            this.UserDetailsView.DataSource = detlist;

        }
    }
}
