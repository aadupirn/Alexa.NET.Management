using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationRequestDevice
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }
    }
}