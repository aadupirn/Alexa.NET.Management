using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class UpdateRequest
    {
        [JsonProperty("slotType")]
        public SlotDescription SlotType { get; set; }
    }
}