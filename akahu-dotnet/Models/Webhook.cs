using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Webhook : AkahuModelBase
    {
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        public string State { get; set; }
        public string Url { get; set; }
        [JsonPropertyName("last_called_at")]
        public DateTimeOffset LastCalledAt { get; set; }
    }
}
