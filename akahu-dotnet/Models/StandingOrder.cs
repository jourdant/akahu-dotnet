using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class StandingOrder : AkahuModelBase
    {
        [JsonPropertyName("_from")]
        public string FromId { get; set; }
        [JsonPropertyName("_to")]
        public string ToId { get; set; }

        public string From { get; set; }
        public string To { get; set; }

        [JsonPropertyName("can_cancel")]
        public bool CanCancel { get; set; }
        [JsonPropertyName("next_payment_at")]
        public DateTimeOffset NextPaymentAt { get; set; }
        [JsonPropertyName("start_at")]
        public DateTimeOffset StartAt { get; set; }
        [JsonPropertyName("end_at")]
        public DateTimeOffset EndAt { get; set; }
        public PaymentRequestDetail Metadata { get; set; }

        //need to add period
        public double Amount { get; set; }
    }
}
