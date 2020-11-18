using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class Invocation
    {
        [JsonProperty("invocationRequest")]
        public InvocationRequestDetail Request { get; set; }

        [JsonProperty("invocationResponse")]
        public InvocationSkillResponse Response { get; set; }

        [JsonProperty("metrics")]
        public InvocationMetrics Metrics { get; set; }
    }
}