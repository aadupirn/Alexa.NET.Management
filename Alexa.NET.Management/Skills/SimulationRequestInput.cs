using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationRequestInput
    {
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}