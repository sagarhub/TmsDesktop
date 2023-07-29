using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public class ViewStock
    {
        [DisplayName("Company")]
        public string company_name { get; set; }
        [DisplayName("short Name")]
        public string short_name { get; set; }
        [DisplayName("High Rate")]
        public long high_rate { get; set; }
        [DisplayName("Low Rate")]
        public long low_rate { get; set; }

    }
}
