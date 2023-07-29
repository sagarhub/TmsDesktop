using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public  class PurchaseDet
    {
        [DisplayName("Date")]
        public string p_date { get; set; }
        [DisplayName("Company")]
        public string company_name { get; set; }
        [DisplayName("Purchase Rate")]
        public long purchase_rate { get; set; }
        [DisplayName("Quantity")]
        public long quantity { get; set; }
        [DisplayName("Amount")]
        public long amount { get; set; }
    }
}
