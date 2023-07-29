using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public  class Sale
    {
        [DisplayName("Date")]
        public string s_date { get; set; }
        // public long Sl_id { get; set; }
        [DisplayName("Company")]
        public string sl_name { get; set; }
        [DisplayName("Sales Rate")]
        public long sales_rate { get; set; }
        [DisplayName("Quantity")]
        public long s_quantity { get; set; }
        [DisplayName("Amount")]
        public long s_amount { get; set; }
       // public long s_id { get; set; }
       // public long u_id { get; set; }
 
    }
}
