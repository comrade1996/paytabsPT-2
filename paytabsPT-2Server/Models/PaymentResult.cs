using System;

namespace paytabsPT_2Server.Models {
    public class PaymentResult {
        public string response_status { get; set; }
        public string response_code { get; set; }
        public string response_message { get; set; }
        public string? avs_result { get; set; }
        public string? cvv_result { get; set; }
        public DateTime transaction_time { get; set; }
    }
}
