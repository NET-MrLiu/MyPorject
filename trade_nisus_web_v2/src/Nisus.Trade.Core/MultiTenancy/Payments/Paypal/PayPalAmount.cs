using Newtonsoft.Json;

namespace Nisus.Trade.MultiTenancy.Payments.Paypal
{
    public class PayPalAmount
    {
        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
