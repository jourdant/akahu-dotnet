using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Transaction : AkahuModelBase
    {
        [JsonPropertyName("_account")]
        public string AccountId { get; set; }
        //[JsonPropertyName("_category")]
        //public string CategoryId { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset Date { get; set; }
        //public bool Pending { get; set; }
        //public Dictionary<string, object> Raw { get; set; }
        //public Dictionary<string, object> Metadata { get; set; }

        //public string Status { get; set; }
        //public string Name { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Hash { get; set; }
        //public string Logo { get; set; }

        //TODO: Add new property 'location'
    }
}
