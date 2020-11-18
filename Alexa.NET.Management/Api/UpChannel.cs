using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Api
{
    public class UpChannel
    {
        [JsonProperty("type")]
        public string Type { get; } = "SNS";

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}