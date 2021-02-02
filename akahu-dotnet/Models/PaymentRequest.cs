using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class PaymentRequest
    {
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }

        [JsonPropertyName("meta")]
        public PaymentRequestMetadata Metadata { get; set; }

        [JsonPropertyName("track_arrival")]
        public bool TrackArrival { get; set; }
    }
}
