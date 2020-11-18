using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class SlotTypeValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public SlotTypeValueName Name { get; set; }
    }
}