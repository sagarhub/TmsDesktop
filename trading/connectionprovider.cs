using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading
{
    public static class connectionprovider  
    {
        public static NpgsqlConnection GetConnection()
        {
            //connection string
            return new NpgsqlConnection("Server=localhost; port=5432; Username=postgres; Password=Admin@123; Database=trade;");
        }
        
     }
}
