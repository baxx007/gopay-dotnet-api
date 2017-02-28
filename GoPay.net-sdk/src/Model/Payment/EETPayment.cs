using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoPay.Model.Payment
{
    public class EETPayment : BasePayment
    {
        [JsonProperty("eet")]
        public EET EET { get; set; }
    }
}
