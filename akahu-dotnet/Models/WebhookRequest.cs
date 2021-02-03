using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class WebhookRequest
    {
        [JsonPropertyName("webhook_type")]
        public string WebhookType { get; set; }
        public string State { get; set; }
    }
}
