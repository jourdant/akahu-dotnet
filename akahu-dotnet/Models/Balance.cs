using System;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Balance
    {
        public double Available { get; set; }
        public string Currency { get; set; }
        public double Current { get; set; }
        public bool Overdrawn { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt{ get; set; }
    }
}