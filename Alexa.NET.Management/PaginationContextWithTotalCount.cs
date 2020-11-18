using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management
{
    public class PaginationContextWithTotalCount:PaginationContext
    {
        [JsonProperty("totalCount")]
        public string TotalCount { get; set; }
    }
}