using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.SlotType
{
    public class CreateSlotResponseType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}