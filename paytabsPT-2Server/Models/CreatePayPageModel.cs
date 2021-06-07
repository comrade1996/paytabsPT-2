using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paytabsPT_2Server.Models {
    public class CreatePayPageModel {
        public string profile_id { get; set; }
        public string tran_type { get; set; }
        public string tran_class { get; set; }
        public string cart_id { get; set; }
        public string cart_currency { get; set; }
        public double cart_amount { get; set; }
        public string cart_description { get; set; }
        public string paypage_lang { get; set; }
        public int? tokenise { get; set; }
        public CustomerDetails customer_details { get; set; }
        public ShippingDetails shipping_details { get; set; }
        public string callback { get; set; }
        public string @return { get; set; }
    }

}
