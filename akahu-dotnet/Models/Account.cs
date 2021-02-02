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

        public string Owner
        {
            get
            {
                var ret = "";
                if (IsBank == true && Type =="CHECKING" && Metadata.ContainsKey("original_holder"))
                {
                    var temp = Metadata["original_holder"]?.ToString().Replace("LTD", "LIMITED").ToLower();
                    if (temp.Contains("templeton")) ret = "Personal";
                    else if (temp.Contains("senere")) ret = "Senere Limited";
                    else if (temp.Contains("aon")) ret = "AON Future Trust";
                    else if (temp.Contains("integra")) ret = "Integra Consulting NZ Limited";
                    else ret = temp;
                }

                return ret;
            }
        }
    }
}
