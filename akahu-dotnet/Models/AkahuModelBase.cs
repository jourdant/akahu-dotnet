using System.Text.Json.Serialization;

namespace Akahu.Api.Models
{
    public class AkahuModelBase
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("_connection")]
        public string Connection { get; set; }
    }
}
