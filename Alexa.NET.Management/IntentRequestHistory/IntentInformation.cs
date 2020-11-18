using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.IntentRequestHistory
{
    public class IntentInformation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}