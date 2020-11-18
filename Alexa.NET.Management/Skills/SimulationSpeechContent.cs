using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationSpeechContent
    {
        [JsonProperty("caption")]
        public string Caption { get; set; }
    }
}