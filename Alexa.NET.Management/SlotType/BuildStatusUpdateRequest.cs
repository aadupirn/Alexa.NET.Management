using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class BuildStatusUpdateRequest
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}