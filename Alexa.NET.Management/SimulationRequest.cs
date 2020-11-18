using VoicifyAlexa.NET.Management.Skills;
using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management
{
    public class SimulationRequest
    {
        [JsonProperty("session",NullValueHandling = NullValueHandling.Ignore)]
        public SimulationSession Session { get; set; }

        [JsonProperty("input")]
        public SimulationRequestInput Input { get; set; }

        [JsonProperty("device")]
        public SimulationRequestDevice Device { get; set; }
    }
}