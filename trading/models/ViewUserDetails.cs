using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trading.models
{
    public class ViewUserDetails
    {
        [DisplayName("First Name")]
        public string first_name { get; set; }
        [DisplayName("Last Name")]
        public string last_name { get; set; }
        [DisplayName("Address ")]
        public string address { get; set; }
        [DisplayName("Contact")]
        public long  contact { get; set; }
        [DisplayName("Username")]
        public string username { get; set; }
        [DisplayName("Role")]
        public string roles { get; set; }
    }
}
