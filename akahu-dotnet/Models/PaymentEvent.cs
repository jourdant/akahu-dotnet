using System;

namespace Akahu.Api.Models
{
    public class PaymentEvent
    {
        public string Status { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}