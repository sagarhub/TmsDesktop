using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public class Organization
    {
        public string organization_name { get; set; }
        public string organization_address { get; set; }
        public string contact_number { get; set; }  
        public string branch { get; set; }
        public string email { get; set; }
    }
}
