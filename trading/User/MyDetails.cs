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

namespace trading
{
    public partial class MyDetails : Form
    {
        public MyDetails()
        {
            InitializeComponent();
            Load += MyDetails_Load;
        }

        private void MyDetails_Load(object? sender, EventArgs e)
        {
            //connection 
            var UserId = Session.CurrentUser.u_id;
            using var connection = connectionprovider.GetConnection();
            var mylist = connection.Query<ViewUserDetails>("select * from auth.userdetails where u_id=@userId", new { userId = UserId });
            this.MyDetailsGrid.DataSource = mylist;
        }
    }
}
