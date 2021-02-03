using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class User : AkahuModelBase
    {
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt{ get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        
        [JsonPropertyName("access_expires_at")]
        public DateTimeOffset AccessExpiresAt { get; set; }

    }
}
