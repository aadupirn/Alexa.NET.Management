using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Skills
{
    public class InvocationMetrics
    {
        [JsonProperty("skillExecutionTimeInMilliseconds")]
        public int ExecutionTime { get; set; }
    }
}