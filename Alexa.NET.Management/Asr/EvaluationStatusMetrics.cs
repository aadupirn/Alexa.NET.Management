using Newtonsoft.Json;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class EvaluationStatusMetrics
    {
        [JsonProperty("overallErrorRate")]
        public double OverallErrorRate { get; set; }
    }
}