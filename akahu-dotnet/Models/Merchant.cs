using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Merchant : AkahuModelBase
    {
        [JsonPropertyName("_category")]
        public Category Category { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        public string Currency { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }

        //social property needs to be added
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
