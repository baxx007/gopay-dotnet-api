using Newtonsoft.Json;

namespace GoPay.Model.Payments
{
    public class OrderItem
    {
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("amount")]
        public long Amount { get; set; }
        
        [JsonProperty("vat_rate")]
        public long VatRate { get; set; }
        
        [JsonProperty("count")]
        public long Count { get; set; }
        
        public override string ToString()
        {
            return string.Format("ROrderItem [name=%s, amount=%s, vat_rate=%s, count=%s]", Name, Amount, VatRate, Count);
        }

    }
}
