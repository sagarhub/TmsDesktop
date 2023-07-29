using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public class PurchaseStok
    {
        public long s_id { get; set; } 
        public string company_name { get; set; }
        public long high_rate { get; set; }
        public long low_rate { get; set; }
        

    }
}
