using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class CreatedVersion
    {
        [JsonProperty("slotType")]
        public CreatedVersionSlotType SlotType { get; set; }
    }
}