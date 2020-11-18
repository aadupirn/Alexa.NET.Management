using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class SlotDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}