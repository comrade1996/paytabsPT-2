namespace paytabsPT_2Server.Models {
    public class PaymentInfo {
        public string? card_type { get; set; }
        public string card_scheme { get; set; }
        public string payment_description { get; set; }
        public string? IssuerCountry { get; set; }
        public string? IssuerName { get; set; }
        public int? expiry_month { get; set; }
        public int? expiry_year { get; set; }


        }
    }
