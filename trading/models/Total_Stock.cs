using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    
    public class Total_Stock
    {
        [DisplayName("Company")]
        public string company_name { get; set;}
        [DisplayName("Quantity")]
        public long quantity { get; set; }
        [DisplayName("High rate")]
        public long high_rate { get; set; }
        [DisplayName("Low rate")]
        public long low_rate { get; set; }  

        public long Amount { get; set; }
       
    }
}
