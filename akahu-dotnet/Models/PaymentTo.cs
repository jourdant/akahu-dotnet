using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class PaymentTo
    {
        public string Name { get; set; }

        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }
    }
}
