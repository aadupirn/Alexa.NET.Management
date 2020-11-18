using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class DialogSlotPrompts
    {
        [JsonProperty("elicitation", NullValueHandling = NullValueHandling.Ignore)]
        public string Elicitation { get; set; }

        [JsonProperty("confirmation", NullValueHandling = NullValueHandling.Ignore)]
        public string Confirmation { get; set; }
    }
}