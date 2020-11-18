using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class CreateSlotResponse
    {
        [JsonProperty("slotType")]
        public CreateSlotResponseType SlotType { get; set; }
    }
}