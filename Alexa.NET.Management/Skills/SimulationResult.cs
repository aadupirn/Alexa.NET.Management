using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class SimulationResult
    {
        [JsonProperty("alexaExecutionInfo")]
        public AlexaExecutionInfo AlexaExecutionInfo { get; set; }

        [JsonProperty("skillExecutionInfo")]
        public SkillExecutionInfo SkillExecutionInfo { get; set; }

        [JsonProperty("error")]
        public InvocationError Error { get; set; }
    }
}