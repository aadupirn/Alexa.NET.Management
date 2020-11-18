using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.InteractionModel
{
    public class Prompt
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("variations", NullValueHandling = NullValueHandling.Ignore)]
        public Variation[] Variations { get; set; }
    }
}