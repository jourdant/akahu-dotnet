using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class AkahuConfirmationResponse : AkahuResponseBase
    {
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
