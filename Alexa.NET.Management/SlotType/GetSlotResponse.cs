using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class GetSlotResponse
    {
        [JsonProperty("slotType")]
        public SharedSlotType SlotType { get; set; }
    }
}