using GoPay.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoPay.Model.Payment
{
    public class EET
    {
        [JsonProperty("dic_poverujiciho")]
        public string DICPoverujiciho { get; set; }

        [JsonProperty("celk_trzba")]
        public long CelkTrzba { get; set; }

        [JsonProperty("zakl_nepodl_dph")]
        public long ZaklNepodlDPH { get; set; }

        [JsonProperty("zakl_dan1")]
        public long ZaklDan1 { get; set; }

        [JsonProperty("dan1")]
        public long Dan1 { get; set; }

        [JsonProperty("zakl_dan2")]
        public long ZaklDan2 { get; set; }

        [JsonProperty("dan2")]
        public long Dan2 { get; set; }

        [JsonProperty("zakl_dan3")]
        public long ZaklDan3 { get; set; }

        [JsonProperty("dan3")]
        public long Dan3 { get; set; }

        [JsonProperty("cest_sluz")]
        public long CestaSluz { get; set; }

        [JsonProperty("pouzit_zboz1")]
        public long PouzitZbozi1 { get; set; }

        [JsonProperty("pouzit_zboz2")]
        public long PouzitZbozi2 { get; set; }

        [JsonProperty("pouzit_zboz3")]
        public long PouzitZbozi3 { get; set; }

        [JsonProperty("urceno_cerp_zuct")]
        public long UrcenoCerpZuct { get; set; }

        [JsonProperty("cerp_zuct")]
        public long CerpZuct { get; set; }

        [JsonProperty("mena")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency Mena { get; set; }
    }
}
