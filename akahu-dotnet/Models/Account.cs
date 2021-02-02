using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class Account : AkahuModelBase
    {
        [JsonPropertyName("is_bank")]
        public bool IsBank { get; set; }
        public string Name { get; set; }
        public Balance Balance { get; set; }
        public List<string> Attributes { get; set; }
        public string Type { get; set; }

        [JsonPropertyName("formatted_account")]
        private object _formattedAccount { get; set; }
        public string FormattedAccount { get => _formattedAccount?.ToString(); }

        [JsonPropertyName("meta")]
        public Dictionary<string, object> Metadata { get; set; }
        public Branch Branch { get; set; }
    }
}
