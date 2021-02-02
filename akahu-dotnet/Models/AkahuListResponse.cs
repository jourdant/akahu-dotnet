using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class AkahuListResponse<T> : AkahuResponseBase
    {
        [JsonPropertyName("items")]
        public List<T> Items { get; set; }
    }
}
