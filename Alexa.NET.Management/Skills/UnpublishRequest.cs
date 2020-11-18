using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class UnpublishRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(StringEnumConverter))]
        public UnpublishType Type { get; set; }

        [JsonProperty("reason"), JsonConverter(typeof(StringEnumConverter))]
        public UnpublishReason Reason { get; set; }
    }
}