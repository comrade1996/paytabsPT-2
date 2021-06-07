using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace paytabsPT_2Server.Models {
    public class PayTabsIPNListener : QueryTransactionResponse {
        public int? merchant_id { get; set; }
        public int? profile_id { get; set; }
        public string tran_total { get; set; }
        public string? tran_class { get; set; }

        public ShippingDetails shipping_details { get; set; }


    }
}
