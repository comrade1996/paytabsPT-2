using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using paytabsPT_2Server.Models;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace paytabsPT_2Server.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly string _ServerKey = "S9JNT2KGMD-JBNTZKL9H6-R9Z6MGJTZR";
        private readonly string _payTabsEndpoint = "https://secure-global.paytabs.com/payment/request";


        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync() {
            CreatePayPageModel payPage = new CreatePayPageModel();
            CustomerDetails customerDetail = new CustomerDetails();
            ShippingDetails shippingDetail = new ShippingDetails();

            customerDetail.city = "dubai";
            customerDetail.country = "AE";
            customerDetail.email = "omairsudan@gmail.com";
            customerDetail.name = "omair sudan";
            customerDetail.phone = "0523506338";
            customerDetail.state = "du";
            customerDetail.street1 = "oumdum";
            customerDetail.zip = "12345";

            shippingDetail.city = "dubai";
            shippingDetail.country = "AE";
            shippingDetail.email = "omairsudan1@gmail.com";
            shippingDetail.name = "omair sudan1";
            shippingDetail.phone = "971555555555";
            shippingDetail.state = "dubai";
            shippingDetail.street1 = "oumdum2";
            shippingDetail.zip = "54321";

            payPage.callback = "https://webhook.site/af7bd834-9a82-4316-8b80-542a93d4a83a";
            payPage.cart_amount = 1;
            payPage.cart_currency = "AED";
            payPage.cart_description = "Description of the items/services";
            payPage.cart_id = "cart_11111";
            payPage.customer_details = customerDetail;
            payPage.paypage_lang = "en";
            payPage.profile_id = "70011";
            payPage.@return = "https://localhost";
            payPage.shipping_details = shippingDetail;
            payPage.tran_class = "ecom";
            payPage.tran_type = "sale";


            var client = new HttpClient();

            var jsonInString = JsonConvert.SerializeObject(payPage);
            Debug.WriteLine("jsonInString1", jsonInString);

            var request = new HttpRequestMessage {
                Method = HttpMethod.Post,
                RequestUri = new Uri(_payTabsEndpoint),
                Headers =
                {
                    { "Authorization", _ServerKey },
                },

                Content = new StringContent(jsonInString, Encoding.UTF8, "application/json") {
                    Headers =
        {
         //   ContentType = new MediaTypeHeaderValue("application/json")
        }
                }
            };
            //client.Timeout = TimeSpan.FromMinutes(3);
            using (var response = await client.SendAsync(request)) {
                try {
                    var body = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode) {
                        Debug.WriteLine("body1", body.ToString());
                       var successRes = JsonConvert.DeserializeObject<CreatePayPageResponseModel>(body);

                        
                    } else {
                        Debug.WriteLine("bodyfail", body.ToString());

                        //var failureRes = JsonConvert.DeserializeObject<StcPayErrorResponse>(body);
                    }
                } catch (Exception exception) {
                    Debug.WriteLine("exception", exception.ToString());
                }
            }


            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
